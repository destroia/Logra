import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { LoginComponent } from './login/login.component';
import { HashLocationStrategy, LocationStrategy } from '@angular/common';
import { Navbar1Component } from './navbar1/navbar1.component';
import { HomeComponent } from './home/home.component';
import { BarVideoComponent } from './bar-video/bar-video.component';
import { BloqueVideoComponent } from './bloque-video/bloque-video.component';
import { BloqueDocComponent } from './bloque-doc/bloque-doc.component';
import { HttpClientModule } from '@angular/common/http';
@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    Navbar1Component,
    HomeComponent,
    BarVideoComponent,
    BloqueVideoComponent,
    BloqueDocComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule
   
  ],
  providers: [{ provide: LocationStrategy, useClass: HashLocationStrategy }],
  bootstrap: [AppComponent]
})
export class AppModule { }
