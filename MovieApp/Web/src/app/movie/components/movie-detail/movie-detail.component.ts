import { Component, OnInit } from '@angular/core';
import { UnsubscribeOnDestroy } from 'src/app/core/common/unsubscribe.on.destroy';
import { MovieService } from 'src/app/core/services/movie.service';
import { ActorService } from 'src/app/core/services/actor.service';
import { AuthService } from 'src/app/core/services/auth.service';
import { forkJoin } from 'rxjs';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-movie-detail',
  templateUrl: './movie-detail.component.html',
  styleUrls: ['./movie-detail.component.scss']
})
export class MovieDetailComponent extends BaseComponent implements OnInit {

  constructor(private movieService:MovieService) {super();}


  ngOnInit() {

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
