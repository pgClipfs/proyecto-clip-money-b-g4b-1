import { Component, OnInit } from '@angular/core';
import { CuentaService } from '../cuenta.service';
import { UsuarioService } from '../usuario.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-micuenta',
  templateUrl: './micuenta.component.html',
  styleUrls: ['./micuenta.component.css']
})
export class MicuentaComponent implements OnInit {

  cuenta = JSON.parse(localStorage.getItem('usuario'));

  constructor(private usuarioService: UsuarioService,
    private cuentaService: CuentaService,
    private modalService: NgbModal,
    private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  open(content) {
    this.modalService.open(content, { ariaLabelledBy: 'modal-basic-title' });
  }

  modificarMail() {
    this.cuenta.usuario.mail = (<HTMLInputElement>document.getElementById("modificarMail")).value;
    localStorage.setItem('usuario', JSON.stringify(this.cuenta));
  }

  modificarTelefono() {
    this.cuenta.usuario.telefono = (<HTMLInputElement>document.getElementById("modificarTelefono")).value;
    localStorage.setItem('usuario', JSON.stringify(this.cuenta));
  }

  modificarDomicilio() {
    this.cuenta.usuario.calle_direccion = (<HTMLInputElement>document.getElementById("modificarCalle")).value;
    this.cuenta.usuario.numero_direccion = (<HTMLInputElement>document.getElementById("modificarNumeroCalle")).value;
    localStorage.setItem('usuario', JSON.stringify(this.cuenta));
  }

  modificarUsuario() {
    this.usuarioService.modificarUsuario(this.cuenta.usuario).subscribe((resultado: Boolean) => {
      if (resultado == false) {
        this.openSnackBar('Ha ocurrido un error, intente nuevamente.');
      }
      else {
        this.openSnackBar('Los datos se han modificado exitosamente.');
      }
    });
  }

  openSnackBar(message: string) {
    this._snackBar.open(message, "OK", {
      duration: 2000,
    });
  }
}