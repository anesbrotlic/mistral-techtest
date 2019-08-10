import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from 'src/app/core/common/base.component';
import { LoginHelperService } from 'src/app/core/services/shared-services/login-helper.service';
import { Router } from '@angular/router';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent extends BaseComponent implements OnInit {

  isUserLogged:boolean=false;

  constructor(injector:Injector,
              private loginHelperService:LoginHelperService,
              private router:Router) { super(injector);}

  ngOnInit() {
    this.loginHelperService.isUserLogged$
        .pipe(takeUntil(this.d$))
        .subscribe((res)=>this.isUserLogged=res);
  }

  logout(){
    this.loginHelperService.logout();
    this.router.navigate(['/login']);
  }

}
