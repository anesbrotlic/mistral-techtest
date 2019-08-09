import { environment } from 'src/environments/environment';
import { UnsubscribeOnDestroy } from './unsubscribe.on.destroy';

export abstract class BaseComponent extends UnsubscribeOnDestroy{
    IsError:boolean=false;
    IsLoading:boolean=false;

    public createImgPath = (serverPath: string) => {

      if(!serverPath)
        return environment.noPhotoPath;

        return `${environment.webAPIBaseURL}/${serverPath}`;
      }
    }