import { Component, OnInit, Inject } from '@angular/core';
import { AbstractControl, FormControl, ValidationErrors, ValidatorFn, Validators } from '@angular/forms';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { CuentaService } from 'src/app/cuenta.service';
import { Cuenta } from 'src/app/models/cuenta';
import { CuentaAmiga } from 'src/app/models/cuentaAmiga';
import { OperacionesService } from 'src/app/operaciones.service';
import { runInThisContext } from 'vm';

@Component({
  selector: 'app-realizar-transferencia',
  templateUrl: './realizar-transferencia.component.html',
  styleUrls: ['./realizar-transferencia.component.css']
})
export class RealizarTransferenciaComponent implements OnInit {

  cuentaLogueada: Cuenta;
  cuentaDestino: any;
  montoTranferenciaControl:FormControl;
  constructor(
    public dialogRef: MatDialogRef<RealizarTransferenciaComponent>,
    private operacionesService: OperacionesService,
    private _snackBar: MatSnackBar,
    @Inject(MAT_DIALOG_DATA) public data: any) {
    this.cuentaLogueada = data.cuentaLogueada;
    this.cuentaDestino = data.cuentaDestino;
    this.montoTranferenciaControl = new FormControl('', [Validators.required, this.verificarMontoTransferencia(this.cuentaLogueada.balance)]);
  }

  ngOnInit(): void {
  }

  verificarMontoTransferencia(balance:number): ValidatorFn{
    return( control: AbstractControl): ValidationErrors => {
      return control.value <= 0 ? { 'errorNulo': true } : control.value > balance ? { 'montoMayor': true } : null;
    };
  }

  getErrorMessage() {
    if (this.montoTranferenciaControl.hasError('errorNulo')) {
      return 'El valor ingresado debe ser mayor a 0';
    }

    return this.montoTranferenciaControl.hasError('montoMayor') ? 'El monto a tranferir no puede superar al balance de la cuenta' : '';
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  realizarTransferencia(){
    if(this.montoTranferenciaControl.valid){
      let transferencia = {
        cuentaOrigen: this.cuentaLogueada.CVU,
        balanceOrigen:this.cuentaLogueada.balance,
        cuentaDestino: this.cuentaDestino.cvu,
        montoTransferencia: this.montoTranferenciaControl.value
      }
      this.operacionesService.realizarTransferencia(transferencia).subscribe(data =>
        {
          if(data){
            this.cuentaLogueada.balance -= this.montoTranferenciaControl.value;
            localStorage.setItem('usuario', JSON.stringify(this.cuentaLogueada));
            this.openSnackBar("Transferencia realizada con exito");
            this.onNoClick();

          }else{
            this.openSnackBar("No se pudo realizar la transferencia");
          }
        }, error => this.openSnackBar("Error al contactar con el servidor"));
    }
    
  }
  openSnackBar(message: string) {
    this._snackBar.open(message, "OK", {
      duration: 6000,
    });
  }

}
