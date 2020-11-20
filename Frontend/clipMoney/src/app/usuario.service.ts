import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from './models/usuario';

@Injectable({
  providedIn: 'root'
})
export class UsuarioService {

  constructor(private http: HttpClient) { }
  getUsuarioLogueado(usuario:Usuario){
    return this.http.get('https://localhost:44343/Api/Usuario/UsuarioLogueado?usuario='+usuario.usuario+'&contrasenia='+usuario.contrasenia);
  
  }
}
