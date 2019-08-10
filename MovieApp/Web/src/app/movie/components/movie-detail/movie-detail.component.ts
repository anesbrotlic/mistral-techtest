import { Component, OnInit, Injector } from '@angular/core';
import { UnsubscribeOnDestroy } from 'src/app/core/common/unsubscribe.on.destroy';
import { MovieService } from 'src/app/core/services/data-services/movie.service';
import { ActorService } from 'src/app/core/services/data-services/actor.service';
import { AuthService } from 'src/app/core/services/data-services/auth.service';
import { forkJoin } from 'rxjs';
import { BaseComponent } from 'src/app/core/common/base.component';
import { MovieDetailsModel } from 'src/app/core/models/data-models';
import { ActivatedRoute } from '@angular/router';
import { takeUntil } from 'rxjs/operators';

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

    this.movieService.getMovieById(movieId)
        .pipe(takeUntil(this.d$))
        .subscribe(
          (res)=>{
            this.movie=res;
          },
          (err)=>{},
          ()=>{});

    // forkJoin([this.authService.login({username:'user4',password:'user4'}),
    //           this.actorService.getActorDetailsById(2),
    //           this.movieService.getAllMovies(1,false,""),
    //           this.movieService.getMovieById(3),
    //           this.movieService.rateMovie(3,4)])
    // .subscribe(data=>{
    //   console.log(`login res: ${data[0]}`);
    //   console.log(`actor res: ${data[1]}`);
    //   console.log(`all movies res: ${data[2]}`);
    //   console.log(`movie by id res: ${data[3]}`);
    //   console.log(`rate mov res: ${data[4]}`);
    //           });


  }

}
