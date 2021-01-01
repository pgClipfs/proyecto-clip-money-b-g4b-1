import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { CuentaService } from 'src/app/cuenta.service';
import { Cuenta } from 'src/app/models/cuenta';
import { CuentaAmiga } from 'src/app/models/cuentaAmiga';

@Component({
  selector: 'app-agregar-cuenta-amiga',
  templateUrl: './agregar-cuenta-amiga.component.html',
  styleUrls: ['./agregar-cuenta-amiga.component.css']
})
export class AgregarCuentaAmigaComponent implements OnInit {

  filtroCuenta: "";
  usuarioEncontrado = false;
  cuentaAmigaNueva: Cuenta = new Cuenta();
  cuentaInsert: CuentaAmiga = new CuentaAmiga();

  constructor(
    public dialogRef: MatDialogRef<AgregarCuentaAmigaComponent>,
    private cuentaService: CuentaService,
    private _snackBar: MatSnackBar,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

  buscarCuenta(){
    this.cuentaService.obtenerCuentaFiltro(this.filtroCuenta).subscribe(data =>{
      if(data != null){
        this.usuarioEncontrado = true;
        this.cuentaAmigaNueva = data;
        this.openSnackBar("Usuario encontrado");
      }
      else{
        this.openSnackBar("No se encontro el usuario ingresado");
      }
    }, error => {
      this.openSnackBar("Error al intentar realizar la busqueda en el servidor");
    });
  }
  openSnackBar(message: string) {
    this._snackBar.open(message, "OK", {
      duration: 6000,
    });
  }

  guardarCuentaAmiga(){
    if(!this.usuarioEncontrado){
      this.openSnackBar("Debe filtrar el resultado antes de poder guardar la cuenta");
    }else{

      this.cuentaInsert.CVU = this.cuentaAmigaNueva.CVU;
      this.cuentaInsert.id_usuario = this.data.idUsuario;
      this.cuentaInsert.fecha_ultima_transaccion = new Date();

      this.cuentaService.agregarCuentaAmiga(this.cuentaInsert).subscribe(data=>{
        if(data){
          this.openSnackBar("Nueva cuenta amiga agregada correctamente")
        }else{
          this.openSnackBar("No se pudo agregar la cuenta");
        }
        this.dialogRef.close();
      },error => this.openSnackBar("Hubo un error al intentar guardar la nueva cuenta"));
    }
  }

  ngOnInit(): void {
  }

}
