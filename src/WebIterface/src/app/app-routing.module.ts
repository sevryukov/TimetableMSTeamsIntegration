import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { TeamsPageComponent } from '../app/teams-page/teams-page.component';
import { MeetingsPageComponent } from './meetings-page/meetings-page.component';

const routes: Routes = [
  {path:'', component: TeamsPageComponent},
  {path:':meeting', component: MeetingsPageComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
