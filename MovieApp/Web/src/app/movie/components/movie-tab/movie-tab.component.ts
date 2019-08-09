import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-movie-tvshow-tab',
  templateUrl: './movie-tab.component.html',
  styleUrls: ['./movie-tab.component.scss']
})
export class MovieTabComponent extends BaseComponent implements OnInit {

  showMovies:boolean=true;

  constructor() { super();}

  ngOnInit() {
  }


  toggleShowMovie(show:boolean){
    this.showMovies=show;
  }

}
