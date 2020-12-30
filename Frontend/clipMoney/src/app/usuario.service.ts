import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from './models/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  endPoint='https://localhost:44343/Api/Usuario/';

  constructor(private http: HttpClient) { }

  getUsuarioLogueado(usuario: Usuario){
    let params = new HttpParams();
    params = params.set('usuario', usuario.usuario);
    params = params.set('contrasenia', usuario.contrasenia);
    return this.http.get(this.endPoint+'UsuarioLogueado', {params});
  }

  guardarUsuario(usuarioG: Usuario){
    return this.http.post(this.endPoint+'GuardarUsuario',usuarioG);
  }

  modificarUsuario(usuarioM: Usuario){
    return this.http.post(this.endPoint+'ModificarUsuario',usuarioM);
  }
}
