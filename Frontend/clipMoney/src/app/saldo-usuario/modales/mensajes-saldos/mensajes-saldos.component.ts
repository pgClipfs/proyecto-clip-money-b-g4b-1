import { Component, Inject, OnInit } from '@angular/core';
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

@Component({
  selector: 'app-mensajes-saldos',
  templateUrl: './mensajes-saldos.component.html',
  styleUrls: ['./mensajes-saldos.component.css']
})
export class MensajesSaldosComponent implements OnInit {

  mensaje: string;
  constructor(
    public dialogRef: MatDialogRef<MensajesSaldosComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any) {
      this.mensaje = data.mensaje;
     }

  ngOnInit(): void {
  }
  onNoClick(): void {
    this.dialogRef.close();
  }


}
