import { OnDestroy } from '@angular/core';
import { Subject } from 'rxjs';

export abstract class UnsubscribeOnDestroy implements OnDestroy {
    protected d$: Subject<Object>;

    constructor() {
        this.d$ = new Subject<VoidFunction>();

        const f = this.ngOnDestroy;
        this.ngOnDestroy = () => {
            f();
            this.d$.next();
            this.d$.complete();
            this.d$.unsubscribe();
        };
    }
    public ngOnDestroy() { 

        console.log('ngOnDestroy:: cleaning resources');

    }
}