import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { AuthGuardService } from './core/guards/auth-guard.service';
import { LoginRouteGuardService } from './core/guards/login-route-guard.service';


const routes: Routes = [
  {
    path: 'movie',
    loadChildren: () => import('./movie/movie.module').then(mod => mod.MovieModule),
    canActivate:[AuthGuardService]
  },
  {
    path: 'actor',
    loadChildren: () => import('./actor/actor.module').then(mod => mod.ActorModule),
    canActivate:[AuthGuardService]
  },
  {
    path:'login',
    component:LoginComponent,
    canActivate:[LoginRouteGuardService]
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
