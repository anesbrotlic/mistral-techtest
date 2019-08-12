import { Injectable, Injector, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { UnsubscribeOnDestroy } from './unsubscribe.on.destroy';
import { catchError } from 'rxjs/operators';
import { LoginHelperService } from '../services/shared-services/login-helper.service';
import { UserIndicatorsService } from '../services/shared-services/user-indicators.service';
import { AppConstants } from './app.constants';
import { ToastClassType } from '../enums/toast-class-name';


@Injectable({
  providedIn: 'root'
})
export class BaseService extends UnsubscribeOnDestroy {

  protected _url: string;
  protected _headers: HttpHeaders;
  protected _http:HttpClient;
  protected loginHelperService:LoginHelperService;
  protected userIndicatorService:UserIndicatorsService;
  
  constructor(injector:Injector) {
      super();

      this._http=injector.get(HttpClient);
      this.loginHelperService=injector.get(LoginHelperService);
      this.userIndicatorService=injector.get(UserIndicatorsService);

      this._url = environment.webAPIBaseURL;
      this._headers = new HttpHeaders({ 'Content-Type': 'application/json' , 'Authorization':`Bearer ${this.loginHelperService.getToken()}`});
  }

  protected getAll(url: string): Observable<any> {
      return this._http.get(url, { headers: this._headers }).pipe(catchError(error => this.handleError(error)));
    //   .pipe(catchError(this.handleError));
  }

  protected get(url: string): Observable<any> {
      return this._http.get(url, { headers: this._headers }).pipe(catchError(error => this.handleError(error)));
    //   .pipe(catchError(this.handleError));
  }

  protected post(url: string, data: any): Observable<any> {
      return this._http.post(url, data, { headers: this._headers }).pipe(catchError(error => this.handleError(error)));
    //   .pipe(catchError(this.handleError));
  }

  protected post_login(url: string, data: any){
    return this._http.post(url, data, { headers: this._headers, responseType: 'text' as 'json'}).pipe(catchError(error => this.handleError(error)));
  }

  protected update(url: string, data: any): Observable<any> {
      return this._http.put(url, data, { headers: this._headers }).pipe(catchError(error => this.handleError(error)));
  }

  protected delete(url: string): Observable<any> {
      return this._http.delete(url, { headers: this._headers }).pipe(catchError(error => this.handleError(error)));
  }

  protected handleError(error: any) {


      this.userIndicatorService.showToast({message:AppConstants.error_user_message,classType:ToastClassType.Error});

          return Observable.throw(error);
  }
}
