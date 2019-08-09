import { Component, OnInit, Input } from '@angular/core';
import { MovieModel } from 'src/app/core/models/models';
import { UnsubscribeOnDestroy } from 'src/app/core/common/unsubscribe.on.destroy';
import { MovieService } from 'src/app/core/services/movie.service';
import { takeUntil } from 'rxjs/operators';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.scss']
})
export class MovieListComponent extends BaseComponent implements OnInit {

  searchString:string='';
  pageNumber:number=1;
  movies:Array<MovieModel>=undefined;

  @Input() showOnlyMovies:string;

  constructor(private movieService:MovieService) { super();}

  ngOnInit() {

    this.loadMovies();
  }

  loadMovies() {

    this.movieService.getAllMovies(this.pageNumber,!this.showOnlyMovies,this.searchString).pipe(
      takeUntil(this.d$))
      .subscribe(
        (res)=>{
          this.movies=res;
          console.log(`gets success ${this.showOnlyMovies?'movies':'tv shows'}`);
        },
        (err)=>{},
        ()=>{}
      );

  }

  loadMore(){
    this.pageNumber++;

    this.movieService.getAllMovies(this.pageNumber,!this.showOnlyMovies,this.searchString).pipe(
      takeUntil(this.d$))
      .subscribe(
        (res)=>{
          this.movies.push(...res);
          console.log(`gets success ${this.showOnlyMovies?'movies':'tv shows'} count:${res.length}`);
        },
        (err)=>{},
        ()=>{}
      );

  }

}
