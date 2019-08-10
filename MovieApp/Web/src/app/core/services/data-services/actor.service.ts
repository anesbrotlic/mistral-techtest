import { Injectable, Injector } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BaseService } from '../../common/base.service';

@Injectable({
  providedIn: 'root'
})
export class ActorService extends BaseService {

  constructor(injector:Injector) { 
    super(injector);
  }

  getAll():Observable<any>{
    let url=environment.actorsURL;
    return this.get(environment.actorsURL);
  }

  getActorDetailsById(actorId:number):Observable<any>{
    let url=`${environment.actorsURL}/${actorId}`;
    return this.get(url);
  }


}
