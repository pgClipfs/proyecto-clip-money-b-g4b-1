import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { CanActivate } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class LoginGuardService implements CanActivate {

  constructor(private router: Router) { }

  canActivate() {
    var usuarioLogueado = JSON.parse(localStorage.getItem('usuario'));

    if (usuarioLogueado == null) {
      this.router.navigate(['/']);
      return false;
    }
    return true;
  }
}
