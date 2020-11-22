import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { BarrioService } from '../barrio.service';
import { Barrio } from '../models/barrio';

import { Usuario } from '../models/usuario';
import { UsuarioService } from '../usuario.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-registro-usuario',
  templateUrl: './registro-usuario.component.html',
  styleUrls: ['./registro-usuario.component.css']
})
export class RegistroUsuarioComponent implements OnInit {



    numberOnly(event): boolean {
      const charCode = (event.which) ? event.which : event.keyCode;
      if (charCode > 31 && (charCode < 48 || charCode > 57)) {
        return false;
      }
      return true;
  
    }
  

  registroUsuario: Usuario = new Usuario();

  barrios: Barrio[] = [];


  constructor(private usuarioService: UsuarioService,
    private router: Router,
    private barrioService: BarrioService,
    private _snackBar: MatSnackBar) { }


  ngOnInit(): void {
    this.obtenerBarrio();
  }

  registerUser() {
    this.usuarioService.guardarUsuario(this.registroUsuario).subscribe((resultado: Boolean) => {
      if (resultado == false) {
        this.openSnackBar('Revise los datos ingresados');
      }
      else {
        this.registroUsuario = new Usuario();
        this.openSnackBar('Usuario creado con éxito, iniciar sesion');
      }
    });

  }

  obtenerBarrio() {
    this.barrioService.obtenerBarrios().subscribe((data: Barrio[]) => {
      this.barrios = data;
    });
  }

  openSnackBar(message: string) {
    this._snackBar.open(message, "OK", {
      duration: 2000,
    });
  }

}




