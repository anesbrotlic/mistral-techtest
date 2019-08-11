import { Component, OnInit, Injector, ChangeDetectorRef } from '@angular/core';
import { BaseComponent } from './core/common/base.component';
import { UserIndicatorsService } from './core/services/shared-services/user-indicators.service';
import { takeUntil } from 'rxjs/operators';
import { ToastModel } from './core/models/toast-model';
import { ToastClassType } from './core/enums/toast-class-name';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent extends BaseComponent implements OnInit {

  title = 'Movie App';
  isShowLoading: boolean = false;
  toastModel: ToastModel;

  constructor(injector: Injector,
    private userIndicatorService: UserIndicatorsService,
    private cdRef: ChangeDetectorRef) {
    super(injector);
  }

  ngAfterViewChecked() {
    this.userIndicatorService.showLoading$
      .pipe(takeUntil(this.d$))
      .subscribe(
        (res) => {
          this.isShowLoading = res
          // console.log('loading: ' + res);
        });

    this.cdRef.detectChanges();

  }

  ngOnInit(): void {

    this.userIndicatorService.showToast$
      .pipe(takeUntil(this.d$))
      .subscribe(
        (res) => {
          if (res == null)
            return;

          this.toastModel = res;
        }
      );

  }

}
