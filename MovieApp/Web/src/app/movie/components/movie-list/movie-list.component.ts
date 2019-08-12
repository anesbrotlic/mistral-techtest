import { Component, OnInit, Input, Injector } from '@angular/core';
import { MovieModel } from 'src/app/core/models/data-models';
import { MovieService } from 'src/app/core/services/data-services/movie.service';
import { takeUntil, finalize, debounceTime, switchMap } from 'rxjs/operators';
import { BaseComponent } from 'src/app/core/common/base.component';
import { SearchHelper } from 'src/app/core/helpers/search-helper';
import { SearchModel } from 'src/app/core/models/search-models';
import { SearchTypeEnum, KeywordTypeEnum } from 'src/app/core/enums/search-enums';
import { BehaviorSubject, Observable } from 'rxjs';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.scss']
})
export class MovieListComponent extends BaseComponent implements OnInit {

  searchString$: BehaviorSubject<string> = new BehaviorSubject<string>('');
  searchString: string = '';
  pageNumber: number = 1;
  searchObject: SearchModel = undefined;
  movies: Array<MovieModel> = undefined;
  canLoadMore: boolean = true;

  @Input() showOnlyMovies: string;

  constructor(injector: Injector,
    private movieService: MovieService) { super(injector); }

  ngOnInit() {

    this.searchString$.pipe(takeUntil(this.d$),
                           debounceTime(300),
                           switchMap(searchString=>{

                             
                             this.showLoading();
                             
                             this.searchString=searchString;
                             this.pageNumber=1;
                             this.prepareSearchObject();

                             return this.movieService.getAllMovies(this.pageNumber,!this.showOnlyMovies,this.searchObject)
                                                     .pipe(takeUntil(this.d$),
                                                           finalize(()=>this.hideLoading()));}))
      .subscribe(
        (res) => {
          this.handleLoadedMovies(res);
        }
      );


  }

  handleLoadedMovies(movies:Array<MovieModel>){
    if (movies != null) {
      this.movies = movies;
      this.canLoadMore = this.movies.length % 10 == 0;
    }
    else
      this.movies = new Array<MovieModel>();
  }

  loadMore() {
    this.pageNumber++;

    this.showLoading();

    this.movieService.getAllMovies(this.pageNumber, !this.showOnlyMovies, this.searchObject)
      .pipe(takeUntil(this.d$),
        finalize(() => this.hideLoading()))
      .subscribe(
        (res: Array<MovieModel>) => {
          if (res != null) {
            this.movies.push(...res);
            this.canLoadMore = this.movies.length % 10 == 0;
          }
          else {
            this.canLoadMore = false;
          }
        },
        (err) => { },
        () => { }
      );

  }

  onSearchKeyUp(value: string) {
      this.searchString$.next(value);
  }


  prepareSearchObject() {

    if (SearchHelper.isContainingNumber(this.searchString)) {

      // RATING SEARCH
      if (+SearchHelper.getNumberFromString(this.searchString) < 6 &&
        SearchHelper.getSearchTypeWordIfExists(this.searchString.toLowerCase(), SearchTypeEnum.Rating) != null) {

        // VALID NUMBER EXISTS HERE
        // VALID RATING KEYWORD EXISTS HERE
        // CHECK FOR KeywordType NEEDED

        this.searchObject = SearchHelper.tryGetSearchModel_rating(this.searchString.toLowerCase());

        if (this.searchObject != null) {
          // this.loadMovies();
          // this.writeToConsole();
          return;
        }

      }
      // RELEASE SEARCH
      else if (SearchHelper.getSearchTypeWordIfExists(this.searchString.toLowerCase(), SearchTypeEnum.ReleaseDate) != null) {

        // VALID NUMBER EXISTS HERE
        // VALID RATING KEYWORD EXISTS HERE
        // CHECK FOR KeywordType NEEDED

        this.searchObject = SearchHelper.tryGetSearchModel_release(this.searchString.toLowerCase());

        if (this.searchObject != null) {
          // this.loadMovies();
          // this.writeToConsole();
          return;
        }

      }

    }

    this.searchObject = { regularSearch: true, value: this.searchString, keywordSearchObject: null };
    // this.loadMovies();

    // this.writeToConsole();

  }

  writeSearchObjToConsole() {

    console.log(`${this.searchObject.regularSearch ? 'Regular' : 'Keyword'} search\n
                value: ${this.searchObject.value}\n
                \n
                type: ${this.searchObject.keywordSearchObject ? SearchTypeEnum[this.searchObject.keywordSearchObject.searchType] : ''}\n
                equaity: ${this.searchObject.keywordSearchObject ? KeywordTypeEnum[this.searchObject.keywordSearchObject.keyWordType] : ''}`)


  }


}

