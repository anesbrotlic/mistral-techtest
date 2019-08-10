import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ActorRoutingModule } from './actor-routing.module';
import { ActorDetailComponent } from './components/actor-detail/actor-detail.component';
import { ActorHomeComponent } from './components/actor-home/actor-home.component';
import { ActorListComponent } from './components/actor-list/actor-list.component';
import { SharedModule } from '../shared/shared.module';


@NgModule({
  declarations: [ActorDetailComponent, ActorHomeComponent, ActorListComponent],
  imports: [
    ActorRoutingModule,
    SharedModule
  ]
})
export class ActorModule { }
