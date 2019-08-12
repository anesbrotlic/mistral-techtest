import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WhitespacePipe } from './pipes/whitespace';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { UserIndicatorsService } from './services/shared-services/user-indicators.service';


@NgModule({
  declarations: [WhitespacePipe],
  imports: [
    CommonModule,
    FormsModule,
    RouterModule,
    HttpClientModule

  ],
  exports:[
    CommonModule,
    WhitespacePipe,
    FormsModule,
    RouterModule,
    HttpClientModule
  ],

})
export class CoreModule {
 }
