import { Component, OnInit } from '@angular/core';
import { CuentaService } from '../cuenta.service';
import { UsuarioService } from '../usuario.service';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MatSnackBar } from '@angular/material/snack-bar';
import { AbstractControl, FormControl, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';

@Component({
  selector: 'app-micuenta',
  templateUrl: './micuenta.component.html',
  styleUrls: ['./micuenta.component.css']
})
export class MicuentaComponent implements OnInit {

  cuenta = JSON.parse(localStorage.getItem('usuario'));
  controlMail: FormControl;

  constructor(private usuarioService: UsuarioService,
    private cuentaService: CuentaService,
    private modalService: NgbModal,
    private _snackBar: MatSnackBar) {
    var mailUsuario:string =  this.cuenta.usuario.mail;
    this.controlMail = new FormControl('', [Validators.required, this.verificarMail(mailUsuario.trim())]);
  }

  verificarMail(mailUsuario: string): ValidatorFn {
    return (control: AbstractControl): ValidationErrors => {
      return control.value == mailUsuario ? { 'mailRepetido': true } : null;
    };
  }
  getErrorMessage() {
    if (this.controlMail.hasError('mailRepetido')) {
      return 'El mail ingresado es el mismo que ya se encuentra registrado';
    }
  }

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
