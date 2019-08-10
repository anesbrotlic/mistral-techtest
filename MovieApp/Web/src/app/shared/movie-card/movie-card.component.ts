import { Component, OnInit, Input, Injector } from '@angular/core';
import { MovieModel } from 'src/app/core/models/data-models';
import { UnsubscribeOnDestroy } from 'src/app/core/common/unsubscribe.on.destroy';
import { BaseComponent } from 'src/app/core/common/base.component';
import { MovieService } from 'src/app/core/services/data-services/movie.service';
import { takeUntil } from 'rxjs/operators';
import { AppConstants } from 'src/app/core/common/app.constants';
import { ToastClassType } from 'src/app/core/enums/toast-class-name';

@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.scss']
})
export class MovieCardComponent extends BaseComponent implements OnInit {

  @Input() movie:MovieModel;
  rating:number=2;
  ratingTitles:Array<string>=['Terrible','Bad','Medicore','Good','Awesome']

  constructor(injector:Injector,private movieService:MovieService) { super(injector);}

  ngOnInit() {
  }

  onRateChange(newRating:number){
    this.movieService.rateMovie(this.movie.id,newRating)
    .pipe(takeUntil(this.d$))
    .subscribe(
      (res)=>{
        this.movie=res;
        console.log('movie updated  '+JSON.stringify(res));
        this.showToast(AppConstants.movie_rated_success,ToastClassType.Success);
      },
      (err)=>{

      },
      ()=>{}
    );
  }
}
