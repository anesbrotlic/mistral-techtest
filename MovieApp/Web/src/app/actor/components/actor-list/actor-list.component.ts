import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from 'src/app/core/common/base.component';
import { ActorService } from 'src/app/core/services/data-services/actor.service';
import { ActorModel } from 'src/app/core/models/data-models';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-actor-list',
  templateUrl: './actor-list.component.html',
  styleUrls: ['./actor-list.component.scss']
})
export class ActorListComponent extends BaseComponent implements OnInit {

  actors:Array<ActorModel>;

  constructor(injector:Injector,private actorService:ActorService) { super(injector); }

  ngOnInit() {

    this.showLoading();

    this.actorService.getAll()
        .pipe(takeUntil(this.d$))
        .subscribe(
          (res)=>{
            this.actors=res;
            console.log('sucess actor list count==> '+res.lenght);
          },
          (err)=>{
            console.log('error  '+ JSON.stringify(err.error));
          },
          ()=>this.hideLoading()
        );

  }

}
