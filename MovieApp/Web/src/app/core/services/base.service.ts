import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { Observable } from 'rxjs';
import { UnsubscribeOnDestroy } from '../common/unsubscribe.on.destroy';
import { catchError } from 'rxjs/operators';


@Injectable({
  providedIn: 'root'
})
export class BaseService extends UnsubscribeOnDestroy {

  protected _url: string;
  protected _headers: HttpHeaders;
  protected _http: HttpClient;
  constructor(http: HttpClient) {
      super();
      this._url = environment.webAPIBaseURL;
      this._headers = new HttpHeaders({ 'Content-Type': 'application/json' });
      this._http = http;
  }

  protected getAll(url: string): Observable<any> {
      return this._http.get(url, { headers: this._headers });
    //   .pipe(catchError(this.handleError));
  }

  protected get(url: string): Observable<any> {
      return this._http.get(url, { headers: this._headers });
    //   .pipe(catchError(this.handleError));
  }

  protected post(url: string, data: any): Observable<any> {
      return this._http.post(url, data, { headers: this._headers });
    //   .pipe(catchError(this.handleError));
  }

  protected update(url: string, data: any): Observable<any> {
      return this._http.put(url, data, { headers: this._headers }).pipe(catchError(this.handleError));
  }

  protected delete(url: string): Observable<any> {
      return this._http.delete(url, { headers: this._headers }).pipe(catchError(this.handleError));
  }

  protected handleError(error: any) {
          return Observable.throw(error);
  }
}
