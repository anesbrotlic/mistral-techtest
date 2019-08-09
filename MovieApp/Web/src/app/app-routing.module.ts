import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: 'movie',
    loadChildren: () => import('./movie/movie.module').then(mod => mod.MovieModule)
  },
  {
    path: 'actor',
    loadChildren: () => import('./actor/actor.module').then(mod => mod.ActorModule)
  },
{
  path:'**',
  redirectTo:'/movie',
  pathMatch:'full'
},
  {
    path:'',
    redirectTo:'/movie',
    pathMatch:'full'
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
