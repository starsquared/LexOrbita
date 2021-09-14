import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClientDashboardComponent } from './clients/client-dashboard/client-dashboard.component';
import { HomeComponent } from './home/home.component';
import { LawyerDashboardComponent } from './lawyers/lawyer-dashboard/lawyer-dashboard.component';
import { LawyerDetailComponent } from './lawyers/lawyer-detail/lawyer-detail.component';
import { LawyerListComponent } from './lawyers/lawyer-list/lawyer-list.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'clients', component: ClientDashboardComponent },
      { path: 'lawyers/lawyer-dashboard', component: LawyerDashboardComponent },
      { path: 'lawyers/:id', component: LawyerDetailComponent },
    ],
  },
  { path: 'lawyers', component: LawyerListComponent },
  { path: '**', component: HomeComponent, pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
