import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { CuentaService } from '../cuenta.service';
import { Cuenta } from '../models/cuenta';
import { Usuario } from '../models/usuario';
import { UsuarioService } from '../usuario.service';

@Component({
  selector: 'app-iniciarses',
  templateUrl: './iniciarses.component.html',
  styleUrls: ['./iniciarses.component.css']
})
export class IniciarsesComponent implements OnInit {
  //to do encriptación constraseña token profe Martín
  user: Usuario = new Usuario();

  constructor(private usuarioService: UsuarioService,
              private cuentaService: CuentaService,
              private router: Router,
              private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  loginUser() {
    if (this.user.usuario != '') {
      this.usuarioService.getUsuarioLogueado(this.user).subscribe((data: Usuario) => {
        if (data != null) {
          this.cuentaService.getCuentaUsuario(data).subscribe((dataC: Cuenta) => {
            if(dataC != null){
              localStorage.setItem('usuario', JSON.stringify(dataC));
              //var obtenerMemoria = JSON.parse(localStorage.getItem('usuario'));
            }
          })
          this.router.navigateByUrl('/Inicio/SaldoUsuario');
        } else { 
          this.openSnackBar('Usuario inexistente, compruebe usuario y/o contraseña'); 
        }
      });
    }
  }

  openSnackBar(message: string) {
    this._snackBar.open(message, "OK", {
      duration: 2000,
    });
  }


}
