import { Component, OnInit } from '@angular/core';
import { Cuenta } from '../models/cuenta';
import { Operacion } from '../models/operacion';
import { OperacionesService } from '../operaciones.service';

@Component({
  selector: 'app-saldo-usuario',
  templateUrl: './saldo-usuario.component.html',
  styleUrls: ['./saldo-usuario.component.css']
})
export class SaldoUsuarioComponent implements OnInit {

  usuarioLogueado: Cuenta;
  operaciones: Operacion[] = [];
  constructor( private operacionesService: OperacionesService) { 
    this.usuarioLogueado = JSON.parse(localStorage.getItem('usuario'));
  }

  ngOnInit(): void {
    this.operacionesService.obtenerOperaciones(this.usuarioLogueado.CVU).subscribe(data =>{
      if(data != null){
        this.operaciones = data;
      }
    });
  }

}
