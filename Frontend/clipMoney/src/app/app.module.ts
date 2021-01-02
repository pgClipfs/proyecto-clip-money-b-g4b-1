import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { IniciarsesComponent } from './iniciarses/iniciarses.component';
import { EstructuraloginComponent } from './estructuralogin/estructuralogin.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
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
import { NavbarComponent } from './shared/navbar/navbar.component';
import { TransferenciasCuentasComponent } from './transferencias-cuentas/transferencias-cuentas.component';
import { AgregarCuentaAmigaComponent } from './transferencias-cuentas/modales/agregar-cuenta-amiga/agregar-cuenta-amiga.component';
import { MatDialogModule } from '@angular/material/dialog';
import {MatIconModule} from '@angular/material/icon';
import { MicuentaComponent } from './micuenta/micuenta.component';
import { RealizarTransferenciaComponent } from './transferencias-cuentas/modales/realizar-transferencia/realizar-transferencia.component';
import { RouterModule } from '@angular/router';
import { RouterTestingModule } from '@angular/router/testing';


@NgModule({
  declarations: [
    AppComponent,
    IniciarsesComponent,
    EstructuraloginComponent,
    SaldoUsuarioComponent,
    RegistroUsuarioComponent,
    NavbarComponent,
    TransferenciasCuentasComponent,
    AgregarCuentaAmigaComponent,
    MicuentaComponent,
    RealizarTransferenciaComponent
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
    MatInputModule,
    MatDialogModule,
    MatIconModule,
    ReactiveFormsModule,
    RouterModule,
    RouterTestingModule 
  ],
  entryComponents: [
    AgregarCuentaAmigaComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
