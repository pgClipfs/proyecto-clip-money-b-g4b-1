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
import { RegistroUsuarioComponent } from './registro-usuario/registro-usuario.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTabsModule } from '@angular/material/tabs';
import {MatFormFieldModule} from '@angular/material/form-field'; 
import {MatSelectModule} from '@angular/material/select'; 
import {MatSnackBarModule} from '@angular/material/snack-bar'; 
import {MatDatepickerModule} from '@angular/material/datepicker'; 
import { MatNativeDateModule } from '@angular/material/core';
import { MatInputModule } from '@angular/material/input';
import { MicuentaComponent } from './micuenta/micuenta.component';


@NgModule({
  declarations: [
    AppComponent,
    IniciarsesComponent,
    EstructuraloginComponent,
    SaldoUsuarioComponent,
    RegistroUsuarioComponent,
    MicuentaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatTabsModule,
    MatFormFieldModule,
    MatSelectModule,
    MatSnackBarModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
