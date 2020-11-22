import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class BarrioService {

  endPoint='https://localhost:44343/Api/Barrio/';

  constructor(private http: HttpClient) { }

  obtenerBarrios(){
    return this.http.get(this.endPoint+'ObtenerBarrios');
  }
  
}
