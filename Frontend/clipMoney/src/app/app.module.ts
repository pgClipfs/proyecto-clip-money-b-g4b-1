import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IniciarsesComponent } from './iniciarses/iniciarses.component';
import { EstructuraloginComponent } from './estructuralogin/estructuralogin.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { SaldoUsuarioComponent } from './saldo-usuario/saldo-usuario.component';


@NgModule({
  declarations: [
    AppComponent,
    IniciarsesComponent,
    EstructuraloginComponent,
    SaldoUsuarioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
