import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ActorRoutingModule } from './actor-routing.module';
import { ActorDetailComponent } from './components/actor-detail/actor-detail.component';
import { ActorHomeComponent } from './components/actor-home/actor-home.component';


@NgModule({
  declarations: [ActorDetailComponent, ActorHomeComponent],
  imports: [
    CommonModule,
    ActorRoutingModule
  ]
})
export class ActorModule { }
