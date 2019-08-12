import { Component, OnInit, Injector } from '@angular/core';
import { UnsubscribeOnDestroy } from 'src/app/core/common/unsubscribe.on.destroy';
import { MovieService } from 'src/app/core/services/data-services/movie.service';
import { ActorService } from 'src/app/core/services/data-services/actor.service';
import { AuthService } from 'src/app/core/services/data-services/auth.service';
import { forkJoin } from 'rxjs';
import { BaseComponent } from 'src/app/core/common/base.component';
import { MovieDetailsModel } from 'src/app/core/models/data-models';
import { ActivatedRoute } from '@angular/router';
import { takeUntil, finalize } from 'rxjs/operators';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.scss']
})
export class MovieDetailComponent extends BaseComponent implements OnInit {

  movie:MovieDetailsModel;

  constructor(injector:Injector,private movieService:MovieService,
              private route:ActivatedRoute) {super(injector);}


  ngOnInit() {

    let movieId=this.route.snapshot.params['id'];

    this.showLoading();

    this.movieService.getMovieById(movieId)
    .pipe(takeUntil(this.d$),
          finalize(()=>this.hideLoading()))
        .subscribe(
          (res)=>{
            this.movie=res;
          },
          (err)=>{},
          ()=>{});

  }

}
