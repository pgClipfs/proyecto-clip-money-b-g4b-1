import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Operacion } from './models/operacion';

@Injectable({
  providedIn: 'root'
})
export class OperacionesService {

  endPoint='https://localhost:44343/Api/';
  constructor(private http: HttpClient) { }

  realizarTransferencia(transferencia: any){
    let params = new HttpParams();
    params = params.set('cuentaOrigen',transferencia.cuentaOrigen );
    params = params.set('cuentaDestino',transferencia.cuentaDestino );
    params = params.set('montoTransferencia',transferencia.montoTransferencia );
    params = params.set('balanceOrigen',transferencia.balanceOrigen );
    params = params.set('totalGiro',transferencia.totalGiro );
    return this.http.get<boolean>(this.endPoint+"Operacion/RealizarTransferencia",{params});
  }

  obtenerOperaciones(cuentaCVU: number){
    let params = new HttpParams();
    params = params.set('CVU_cuenta',cuentaCVU.toString());
    return this.http.get<Operacion[]>(this.endPoint+"Operacion/ObtenerOperaciones",{params});
  }
}
