import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Cuenta } from '../models/cuenta';
import { Operacion } from '../models/operacion';
import { OperacionesService } from '../operaciones.service';
import { MensajesSaldosComponent } from './modales/mensajes-saldos/mensajes-saldos.component';

@Component({
  selector: 'app-saldo-usuario',
  templateUrl: './saldo-usuario.component.html',
  styleUrls: ['./saldo-usuario.component.css']
})
export class SaldoUsuarioComponent implements OnInit {

  usuarioLogueado: Cuenta;
  operaciones: Operacion[] = [];
  mensajeRecargar = "Si desea recargar saldo en su cuenta, puede realizar una transferencia bancaria directamente desde su Home Banking o desde un Cajero Automático, obien acercarse a un RapiPago o Pagofácil cercano con su número de DNI y el monto en efectivo que desea agregar a su cuenta virtual.";
  mensajeRetirar = "Si desea retirar saldo en su cuenta, puede crear desde su App CLipMoney una clave de 4 (cuatro) dígitos. A continuación, podrá dirigirse a cualquier cajero habilitado (Red Link o Banelco), ingresar la clave recientemente creada, ¡y listo! Podrá disponer del saldo de su cuenta.";

  constructor( private operacionesService: OperacionesService,public dialog: MatDialog) { 
    this.usuarioLogueado = JSON.parse(localStorage.getItem('usuario'));
  }

  ngOnInit(): void {
    this.operacionesService.obtenerOperaciones(this.usuarioLogueado.CVU).subscribe(data =>{
      if(data != null){
        this.operaciones = data;
      }
    });
  }
  openDialogMostrarMsg(mensajeNro: number): void {
    var mensaje  = mensajeNro == 0 ? this.mensajeRecargar: this.mensajeRetirar;
    const dialogRef = this.dialog.open(MensajesSaldosComponent, {
      width: '600px',
      data: {mensaje: mensaje}
    });

    dialogRef.afterClosed().subscribe(result => {
    });
  }

}
