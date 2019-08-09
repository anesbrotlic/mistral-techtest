import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { extend } from 'webdriver-js-extender';
import { BaseService } from './base.service';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MovieService extends BaseService {

  constructor(public httpClient:HttpClient) { 
    super(httpClient);
  }

  getAllMovies(page:number,tvShow:boolean,search:string):Observable<any>{
    let url=`${environment.allMoviesURL}?page=${page}&tvShow=${tvShow}&search=${search}`;
    return this.getAll(url);
  }

  getMovieById(movieId:number):Observable<any>{
    let url=`${environment.movieByIdURL}/${movieId}`;
    return this.get(url);
  }

  rateMovie(movieId:number, rating:number):Observable<any>{
    let url=`${environment.rateMovieByIdURL}/${movieId}`;
    return this.post(url,rating);
  }

}
