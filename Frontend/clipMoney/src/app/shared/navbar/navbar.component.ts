import { Component, OnInit } from '@angular/core';
import { Cuenta } from 'src/app/models/cuenta';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  cuentaLogueada: Cuenta;
  constructor() { }

  ngOnInit(): void {
    this.cuentaLogueada = JSON.parse(localStorage.getItem('usuario'));
  }

}
