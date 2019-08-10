import { Component, OnInit, Injector } from '@angular/core';
import { BaseComponent } from 'src/app/core/common/base.component';
import { ActorDetailModel } from 'src/app/core/models/data-models';
import { ActorService } from 'src/app/core/services/data-services/actor.service';
import { ActivatedRoute } from '@angular/router';
import { takeUntil } from 'rxjs/operators';

@Component({
  selector: 'app-actor-detail',
  templateUrl: './actor-detail.component.html',
  styleUrls: ['./actor-detail.component.scss']
})
export class ActorDetailComponent extends BaseComponent implements OnInit {

  actor:ActorDetailModel;

  constructor(injector:Injector,
              private actorService:ActorService,
              private route:ActivatedRoute) { super(injector); }

  ngOnInit() {

    let actorId=this.route.snapshot.params['id'];

    this.actorService.getActorDetailsById(actorId)
        .pipe(takeUntil(this.d$))
        .subscribe(
          (res)=>{
            this.actor=res;
          },
          (err)=>{},
          ()=>{}
        );

  }

}
