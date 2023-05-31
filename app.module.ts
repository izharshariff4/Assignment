import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { AddItemComponent } from './Components/add-item/add-item.component';
import { UpdateItemComponent } from './Components/update-item/update-item.component';
import { ViewItemsComponent } from './Components/view-items/view-items.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    AddItemComponent,
    UpdateItemComponent,
    ViewItemsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
