import { Component, OnInit, Input, Injector } from '@angular/core';
import { ActorModel } from 'src/app/core/models/data-models';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-actor-card',
  templateUrl: './actor-card.component.html',
  styleUrls: ['./actor-card.component.scss']
})
export class ActorCardComponent extends BaseComponent implements OnInit {

  @Input() actor:ActorModel;

  constructor(injector:Injector) { super(injector); }

  ngOnInit() {
  }

}
