import { Injectable, Injector } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginModel } from '../../models/data-models';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BaseService } from '../../common/base.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService extends BaseService {

  constructor(private httpClient:HttpClient,
    injector:Injector) { 
    super(injector);
  }

  login(loginModel:LoginModel):Observable<any>{
    return this.httpClient.post(environment.loginURL,loginModel,{responseType: 'text' as 'json'});
  }

}
