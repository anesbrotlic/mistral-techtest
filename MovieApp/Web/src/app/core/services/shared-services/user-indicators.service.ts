import { Injectable } from '@angular/core';
import { Subject, BehaviorSubject, Observable } from 'rxjs';
import { ToastModel } from '../../models/toast-model';
import { ToastClassType } from '../../enums/toast-class-name';

@Injectable({
  providedIn: 'root'
})
export class UserIndicatorsService {

  public showLoading$:BehaviorSubject<boolean>=new BehaviorSubject<boolean>(false);
  public showToast$:BehaviorSubject<ToastModel>=new BehaviorSubject<ToastModel>(null);

  constructor() { }

  showLoading(show:boolean){
    this.showLoading$.next(show);
  }

  showToast(toastModel:ToastModel){

    this.showToast$.next(toastModel);
  }

}
