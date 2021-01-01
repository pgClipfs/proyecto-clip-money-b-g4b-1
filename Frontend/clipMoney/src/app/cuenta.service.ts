import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Cuenta } from './models/cuenta';
import { CuentaAmiga } from './models/cuentaAmiga';
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

  obtenerCuentaFiltro( filtro: string){
    let params = new HttpParams;
    params = params.set('filtro', filtro);
    return this.http.get<Cuenta>(this.endPoint+"/Cuenta/ObtenerCuentaFiltro",{params});
  }

  agregarCuentaAmiga(cuentaAmiga: CuentaAmiga){
    return this.http.post<boolean>(this.endPoint+"CuentaAmiga/AgregarCuentaAmiga",cuentaAmiga)
  }

}
