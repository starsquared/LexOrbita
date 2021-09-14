import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { LawyerListComponent } from './lawyers/lawyer-list/lawyer-list.component';
import { LawyerDetailComponent } from './lawyers/lawyer-detail/lawyer-detail.component';
import { ClientDashboardComponent } from './clients/client-dashboard/client-dashboard.component';
import { ToastrModule } from 'ngx-toastr';
import { LawyerDashboardComponent } from './lawyers/lawyer-dashboard/lawyer-dashboard.component';
import { SharedModule } from './_modules/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    LawyerListComponent,
    LawyerDetailComponent,
    ClientDashboardComponent,
    LawyerDashboardComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
