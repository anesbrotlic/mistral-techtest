import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { MovieCardComponent } from './movie-card/movie-card.component';

import { BarRatingModule } from "ngx-bar-rating";
import { ActorCardComponent } from './actor-card/actor-card.component';
import { GlobalLoaderComponent } from './global-loader/global-loader.component';
import { ToastComponent } from './toast/toast.component';
import { CoreModule } from '../core/core.module';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [NavbarComponent, MovieCardComponent, ActorCardComponent, GlobalLoaderComponent, ToastComponent],
  imports: [
    CoreModule,
    BarRatingModule,
  ],
  exports:[
    CoreModule,
    NavbarComponent,
    MovieCardComponent,
    BarRatingModule,
    ActorCardComponent,
    GlobalLoaderComponent,
    ToastComponent,
  ]
})
export class SharedModule { }
