import { Component, OnInit } from '@angular/core';
import { BaseComponent } from 'src/app/core/common/base.component';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent extends BaseComponent implements OnInit {

  constructor() { super();}

  ngOnInit() {
  }

}
