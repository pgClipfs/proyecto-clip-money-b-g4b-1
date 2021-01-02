import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

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
    return this.http.get<boolean>(this.endPoint+"Operacion/RealizarTransferencia",{params});
  }
}
