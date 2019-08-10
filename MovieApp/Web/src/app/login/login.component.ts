import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from '../core/common/base.component';
import { AuthService } from '../core/services/data-services/auth.service';
import { takeUntil } from 'rxjs/operators';
import { LoginModel } from '../core/models/data-models';
import { LoginHelperService } from '../core/services/shared-services/login-helper.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent extends BaseComponent implements OnInit {

  loginModel:LoginModel={username:'user4',password:'user4'};
  incorrectDataErrorMsg = '';

  constructor(injector: Injector,
    private authService: AuthService,
    private loginHelperService:LoginHelperService,
    private router:Router) { super(injector); }

  ngOnInit() {
  }

  signIn() {

    this.incorrectDataErrorMsg='';
    this.showLoading();

    this.authService.login(this.loginModel)
      .pipe(takeUntil(this.d$))
      .subscribe(
        (token) => {
          this.loginHelperService.login(token);
          this.router.navigate(["/movie"]);
        },
        (err) => {
          this.hideLoading();
          this.incorrectDataErrorMsg = "Cannot log in! Try again!"
        },
        () => this.hideLoading());

  }


}
