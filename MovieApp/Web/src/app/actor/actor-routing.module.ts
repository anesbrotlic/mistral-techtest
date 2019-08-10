import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ActorHomeComponent } from './components/actor-home/actor-home.component';
import { ActorDetailComponent } from './components/actor-detail/actor-detail.component';
import { ActorListComponent } from './components/actor-list/actor-list.component';


const routes: Routes = [
  {
    path:'',
    component:ActorHomeComponent,
    children:[
      {path:'',component:ActorListComponent},
      {path:'detail/:id',component:ActorDetailComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ActorRoutingModule { }
