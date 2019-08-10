import { environment } from 'src/environments/environment';
import { UnsubscribeOnDestroy } from './unsubscribe.on.destroy';
import { UserIndicatorsService } from '../services/shared-services/user-indicators.service';
import { Injector } from '@angular/core';
import { ToastModel } from '../models/toast-model';
import { ToastClassType } from '../enums/toast-class-name';

export abstract class BaseComponent extends UnsubscribeOnDestroy {

  private loadingIndicatorService:UserIndicatorsService;

  constructor(private injector: Injector) {
    super();
    this.loadingIndicatorService=injector.get(UserIndicatorsService);
  }

  // IMG PATH RESOLVER
  protected createImgPath = (serverPath: string) => {

    if (!serverPath)
      return environment.noPhotoPath;

    return `${environment.webAPIBaseURL}/${serverPath}`;
  }


  // LOADING USER INDICATOR 
  protected showLoading() {
    this.loadingIndicatorService.showLoading(true);
  }
  protected hideLoading() {
    this.loadingIndicatorService.showLoading(false);
  }

  // TOAST USER INDICATOR
  protected showToast(message:string, toastClassName:ToastClassType){
    this.loadingIndicatorService.showToast({message:message,classType:toastClassName});
  }


}