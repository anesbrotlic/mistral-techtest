import { Component, OnInit, Input } from '@angular/core';
import { MovieModel } from 'src/app/core/models/models';
import { UnsubscribeOnDestroy } from 'src/app/core/common/unsubscribe.on.destroy';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.scss']
})
export class MovieCardComponent extends BaseComponent implements OnInit {

  @Input() movie:MovieModel;

  constructor() { super();}

  ngOnInit() {
  }

}
