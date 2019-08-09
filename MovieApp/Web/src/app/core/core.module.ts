import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MovieModel, MovieModel2, ActorModel, ActorDetailModel, MovieDetailsModel, LoginModel } from './models/models';
import { MovieService } from './services/movie.service';
import { ActorService } from './services/actor.service';
import { AuthService } from './services/auth.service';



@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  exports:[
    MovieModel,MovieModel2,MovieDetailsModel, ActorModel, ActorDetailModel, LoginModel,
    MovieService,AuthService,ActorService
  ]
})
export class CoreModule { }
