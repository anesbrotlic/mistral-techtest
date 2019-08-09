import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ActorDetailModel } from '../models/models';
import { environment } from 'src/environments/environment';
import { BaseService } from './base.service';

@Injectable({
  providedIn: 'root'
})
export class ActorService extends BaseService {

  constructor(private httpClient:HttpClient) { 
    super(httpClient);
  }

  getActorDetailsById(actorId:number):Observable<any>{
    let url=`${environment.actorByIdURL}/${actorId}`;
    return this.get(url);
  }


}
