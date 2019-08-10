import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-actor-home',
  templateUrl: './actor-home.component.html',
  styleUrls: ['./actor-home.component.scss']
})
export class ActorHomeComponent extends BaseComponent implements OnInit {

  constructor(injector:Injector) {super(injector); }

  ngOnInit() {
  }

}
