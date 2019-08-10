import { Component, OnInit, Input, Injector, OnChanges, SimpleChanges, SimpleChange } from '@angular/core';
import { ToastModel } from 'src/app/core/models/toast-model';
import { BaseComponent } from 'src/app/core/common/base.component';
import { ToastClassType } from 'src/app/core/enums/toast-class-name';

@Component({
  selector: 'app-toast',
  templateUrl: './toast.component.html',
  styleUrls: ['./toast.component.scss']
})
export class ToastComponent extends BaseComponent implements OnChanges {

  @Input() toastModel: ToastModel;

  message: string='';
  className: string='';
  isShowToast: boolean = false;

  constructor(injector: Injector) { super(injector); }

  ngOnInit() {
  }

  ngOnChanges(changes: SimpleChanges): void {

    let change = changes['toastModel'];

    // on initial when data is undefined -return 
    if (change.currentValue == null)
      return;

    // gets data
    this.toastModel = change.currentValue;

    this.message = this.toastModel.message;
    this.className = this.getClassName(this.toastModel.classType);
    this.isShowToast = true;

    //wait 3 Seconds and hide
    setTimeout(function () {
      this.isShowToast = false;
    }.bind(this), 3000);

  }


  getClassName(classType: ToastClassType): string {
    let className = 'alert alert-dismissible ';

    switch (classType) {
      case ToastClassType.Error: { return className += 'alert-danger'; }
      case ToastClassType.Success: { return className += 'alert-success'; }
    }
  }

}

