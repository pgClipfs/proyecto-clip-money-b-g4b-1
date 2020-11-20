import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EstructuraloginComponent } from './estructuralogin/estructuralogin.component';
import { IniciarsesComponent } from './iniciarses/iniciarses.component';
import { SaldoUsuarioComponent } from './saldo-usuario/saldo-usuario.component';


const routes: Routes = [
  {path:'',component:EstructuraloginComponent},
  {path:'Inicio',component:SaldoUsuarioComponent},
  {path:'**',component:SaldoUsuarioComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
