import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Usuario } from './models/usuario';

@Injectable({
  providedIn: 'root'
})
export class CuentaService {

  endPoint='https://localhost:44343/Api/';

  constructor(private http: HttpClient) { }

  getCuentaUsuario(usuario: Usuario){
    let params = new HttpParams();
    params = params.set('usuario', usuario.usuario);
    return this.http.get(this.endPoint+'Cuenta/ObtenerCuenta', {params});
  }

  getCuentasAmigas(id_usuario: number){
    let params = new HttpParams();
    params = params.set('id_usuario', id_usuario.toString());
    return this.http.get(this.endPoint+'CuentaAmiga/ObtenerListadoCuentasAmigas', {params});
  }
}