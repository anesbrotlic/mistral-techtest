import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MovieHomeComponent } from './components/movie-home/movie-home.component';
import { MovieDetailComponent } from './components/movie-detail/movie-detail.component';
import { MovieTabComponent } from './components/movie-tab/movie-tab.component';


const routes: Routes = [
  {
    path:'',
    component:MovieHomeComponent,
    children:[
      {path:'',component:MovieTabComponent},
      {path:'detail/:id',component:MovieDetailComponent},
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MovieRoutingModule { }
