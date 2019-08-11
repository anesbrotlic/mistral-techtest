import { Injectable, Injector } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { extend } from 'webdriver-js-extender';
import { BaseService } from '../../common/base.service';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { SearchModel } from '../../models/search-models';
import { MovieRequestModel } from '../../models/data-models';

@Injectable({
  providedIn: 'root'
})
export class MovieService extends BaseService {

  constructor(injector:Injector) { 
    super(injector);
  }

  getAllMovies(page:number,tvShow:boolean,searchObject:SearchModel):Observable<any>{
    let url=`${environment.moviesURL}`;
    let moviesRequestModel:MovieRequestModel={page:page,tvShow:tvShow,searchObject:searchObject};
    return this.post(url,moviesRequestModel);
  }

  getMovieById(movieId:number):Observable<any>{
    let url=`${environment.moviesURL}/${movieId}`;
    return this.get(url);
  }

  rateMovie(movieId:number, rating:number):Observable<any>{
    let url=`${environment.rateMovieByIdURL}/${movieId}`;
    return this.post(url,rating);
  }

}
