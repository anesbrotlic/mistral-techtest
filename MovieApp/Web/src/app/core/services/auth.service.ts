import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginModel } from '../models/models';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService extends BaseService {

  constructor(private httpClient:HttpClient) { 
    super(httpClient);
  }

  login(loginModel:LoginModel):Observable<any>{
    return this.httpClient.post(environment.loginURL,loginModel,{responseType: 'text' as 'json'});
  }

}
