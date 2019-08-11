import { Component, OnInit, Input, Injector } from '@angular/core';
import { MovieModel } from 'src/app/core/models/data-models';
import { MovieService } from 'src/app/core/services/data-services/movie.service';
import { takeUntil } from 'rxjs/operators';
import { BaseComponent } from 'src/app/core/common/base.component';
import { SearchHelper } from 'src/app/core/helpers/search-helper';
import { SearchModel } from 'src/app/core/models/search-models';
import { SearchTypeEnum, KeywordTypeEnum } from 'src/app/core/enums/search-enums';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.scss']
})
export class MovieListComponent extends BaseComponent implements OnInit {

  searchString: string = '';
  pageNumber: number = 1;
  searchObject: SearchModel = undefined;
  movies: Array<MovieModel> = undefined;

  @Input() showOnlyMovies: string;

  constructor(injector: Injector,
    private movieService: MovieService) { super(injector); }

  ngOnInit() {
    this.loadMovies();
  }

  loadMovies() {

    this.showLoading();

    this.movieService.getAllMovies(this.pageNumber, !this.showOnlyMovies, this.searchObject).pipe(
      takeUntil(this.d$))
      .subscribe(
        (res) => {
          this.movies = res;
          console.log(`gets success ${this.showOnlyMovies ? 'movies' : 'tv shows'}`);
        },
        (err) => { },
        () => this.hideLoading()
      );

  }

  loadMore() {
    this.pageNumber++;

    this.showLoading();

    this.movieService.getAllMovies(this.pageNumber, !this.showOnlyMovies, this.searchObject).pipe(
      takeUntil(this.d$))
      .subscribe(
        (res) => {
          this.movies.push(...res);
          console.log(`gets success ${this.showOnlyMovies ? 'movies' : 'tv shows'} count:${res.length}`);
        },
        (err) => { },
        () => this.hideLoading()
      );

  }

  onSearchStringChanges(value: string) {

    //  IF USER ENTERS MORE THAN 2 CHARACTERS THEN SEARCH
    if (value.length >= 2)
      this.search();
  }

  search() {

    if (SearchHelper.isContainingNumber(this.searchString)) {

      // RATING SEARCH
      if (+SearchHelper.getNumberFromString(this.searchString) < 6 &&
        SearchHelper.getSearchTypeWordIfExists(this.searchString.toLowerCase(),SearchTypeEnum.Rating) != null) {

        // VALID NUMBER EXISTS HERE
        // VALID RATING KEYWORD EXISTS HERE
        // CHECK FOR KeywordType NEEDED

        this.searchObject = SearchHelper.tryGetSearchModel_rating(this.searchString.toLowerCase());

        if (this.searchObject != null) {
          this.loadMovies();
          // this.writeToConsole();
          return;
        }

      }
      // RELEASE SEARCH
      else if(SearchHelper.getSearchTypeWordIfExists(this.searchString.toLowerCase(),SearchTypeEnum.ReleaseDate)!=null){

        // VALID NUMBER EXISTS HERE
        // VALID RATING KEYWORD EXISTS HERE
        // CHECK FOR KeywordType NEEDED

        this.searchObject = SearchHelper.tryGetSearchModel_release(this.searchString.toLowerCase());

        if (this.searchObject != null) {
          this.loadMovies();
          // this.writeToConsole();
          return;
        }

      }

    }

    this.searchObject={regularSearch:true,value:this.searchString,keywordSearchObject:null};
    this.loadMovies();

    // this.writeToConsole();

  }

  writeToConsole() {
    
    console.log(`${this.searchObject.regularSearch?'Regular':'Keyword'} search\n
                value: ${this.searchObject.value}\n
                \n
                type: ${this.searchObject.keywordSearchObject?SearchTypeEnum[this.searchObject.keywordSearchObject.searchType]:''}\n
                equaity: ${this.searchObject.keywordSearchObject?KeywordTypeEnum[this.searchObject.keywordSearchObject.keyWordType]:''}`)


  }










}

//   search() {

//     if (this.searchContainsNumber()) {

//       if (this.isSearchType(SearchTypeEnum.Rating)) {

//         this.setSearchObject(false,SearchTypeEnum.Rating);
//         return;
//       }
//       else if (this.isSearchType(SearchTypeEnum.ReleaseDate)) {


//         this.setSearchObject(false,SearchTypeEnum.ReleaseDate);
//         return;
//       }

//     }

//     this.setSearchObject(true);

//   }


//   setSearchObject(regularSearch:boolean,keywordSearchType: SearchTypeEnum=null) {

//     if(regularSearch){
//       this.searchObject={
//         regularSearch:true,
//         keywordSearchObject:null,
//         value:this.searchString
//       };
//     }
//     else{
//       this.searchObject={
//         regularSearch:false,
//         value:this.searchString.match(/\d+/)[0],
//         keywordSearchObject:{
//           searchType:keywordSearchType,
//           keyWordType:this.getKeywordTypeEnum()
//         }
//       }
//     }

//   }


//   searchContainsNumber(): boolean {
//     return /\d/.test(this.searchString);
//   }
//   isSearchType(keywordSearchType: SearchTypeEnum): boolean {

//     let isRecievedSearchType = false;
//     let trimmedSearchString = this.searchString.toLowerCase().replace(/\s/g, "");
//     let listOfKeywords = (keywordSearchType == SearchTypeEnum.Rating) ?
//       AppConstants.rating_search_keywords :
//       (keywordSearchType == SearchTypeEnum.ReleaseDate) ?
//         AppConstants.release_date_search_keywords :
//         new Array<string>();

//     if (listOfKeywords.length == 0)
//       return;

//     listOfKeywords.forEach(keyword => {
//       if (trimmedSearchString.includes(keyword))
//         isRecievedSearchType = true;
//     });

//     return isRecievedSearchType;

//   }
//   getKeywordTypeEnum(): KeywordTypeEnum{

//   let trimmedSearchString = this.searchString.toLowerCase().replace(/\s/g, "");
//   let keywordsArray = new Array<string>();

//   keywordsArray = AppConstants.more_than_keywords;
//   for (let i = 0; i < keywordsArray.length; i++)
//     if (trimmedSearchString.includes(keywordsArray[i]))
//       return KeywordTypeEnum.More;

//   keywordsArray = AppConstants.less_than_keywords;
//   for (let i = 0; i < keywordsArray.length; i++)
//     if (trimmedSearchString.includes(keywordsArray[i]))
//       return KeywordTypeEnum.Less;

//   keywordsArray = AppConstants.at_least_keywords;
//   for (let i = 0; i < keywordsArray.length; i++)
//     if (trimmedSearchString.includes(keywordsArray[i]))
//       return KeywordTypeEnum.AtLeast;

//   keywordsArray = AppConstants.at_most_keywords;
//   for (let i = 0; i < keywordsArray.length; i++)
//     if (trimmedSearchString.includes(keywordsArray[i]))
//       return KeywordTypeEnum.AtMost;

//   keywordsArray = AppConstants.older_keywords;
//   for (let i = 0; i < keywordsArray.length; i++)
//     if (trimmedSearchString.includes(keywordsArray[i]))
//       return KeywordTypeEnum.Older;

//   return KeywordTypeEnum.Exact;

// }



