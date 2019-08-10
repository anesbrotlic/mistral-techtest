import { Injectable, OnInit } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { AppConstants } from '../../common/app.constants';
import { BehaviorSubject } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class LoginHelperService {

  isUserLogged$:BehaviorSubject<boolean>=new BehaviorSubject<boolean>(true);

  constructor(public jwtHelper: JwtHelperService) {
    this.isUserLogged$.next(this.isUserLogged());
   }


  login(token: string) {
      localStorage.setItem(AppConstants.jwt_local_storage_key, token);
      this.isUserLogged$.next(true);
  }

  logout() {
      localStorage.removeItem(AppConstants.jwt_local_storage_key);
      this.isUserLogged$.next(false);
  }

  isUserLogged(): boolean {
      var token = this.getToken;

      if (token && !this.jwtHelper.isTokenExpired()) {
          return true;
      }
      return false;
  }

  getToken():string{
    return localStorage.getItem(AppConstants.jwt_local_storage_key);
  }


}
