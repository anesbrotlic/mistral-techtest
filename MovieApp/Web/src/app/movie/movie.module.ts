import { NgModule } from '@angular/core';

import { MovieRoutingModule } from './movie-routing.module';
import { MovieHomeComponent } from './components/movie-home/movie-home.component';
import { MovieDetailComponent } from './components/movie-detail/movie-detail.component';
import { MovieTabComponent } from './components/movie-tab/movie-tab.component';
import { MovieListComponent } from './components/movie-list/movie-list.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [MovieHomeComponent, MovieDetailComponent, MovieTabComponent, MovieListComponent],
  imports: [
    SharedModule,
    MovieRoutingModule,
  ]
})
export class MovieModule { }
