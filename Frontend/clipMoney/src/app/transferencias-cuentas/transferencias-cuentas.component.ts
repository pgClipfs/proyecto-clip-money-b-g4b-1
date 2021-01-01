import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CuentaService } from '../cuenta.service';
import { Usuario } from '../models/usuario';
import { DTOCuentaAmiga } from '../modelsDTO/DTOCuentaAmiga';
import { AgregarCuentaAmigaComponent } from './modales/agregar-cuenta-amiga/agregar-cuenta-amiga.component';

@Component({
  selector: 'app-transferencias-cuentas',
  templateUrl: './transferencias-cuentas.component.html',
  styleUrls: ['./transferencias-cuentas.component.css']
})
export class TransferenciasCuentasComponent implements OnInit {

  listadoCuentasAmigas: DTOCuentaAmiga[] = [];
  usuarioLogueado: any;

  constructor(private cuentaService: CuentaService,public dialog: MatDialog) { }

  ngOnInit(): void {
     this.usuarioLogueado = JSON.parse(localStorage.getItem('usuario'));
      this.obtenerCuentasAmigas();
  }
  obtenerCuentasAmigas(){
    this.cuentaService.getCuentasAmigas(this.usuarioLogueado.user.id_usuario).subscribe((data: DTOCuentaAmiga[]) => {

      if(data != null){
        this.listadoCuentasAmigas = data;
      }
    });
  }

  openDialogAgregarCuenta(): void {
    const dialogRef = this.dialog.open(AgregarCuentaAmigaComponent, {
      width: '600px',
      data: {idUsuario: this.usuarioLogueado.user.id_usuario}
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log(result);
      this.obtenerCuentasAmigas();
    });
  }

}
