import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TeamsPageComponent } from './teams-page/teams-page.component';
import { MeetingsPageComponent } from './meetings-page/meetings-page.component';

@NgModule({
  declarations: [
    AppComponent,
    TeamsPageComponent,
    MeetingsPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
