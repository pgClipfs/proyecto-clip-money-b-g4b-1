import { Usuario } from "./usuario";

export class Cuenta{
        CVU:number;
        balance:number;
        descripcion:string;
        cuentaTipo:string;
        id_tipo_cuenta:number;
        estado:boolean;
        fecha_creacion:Date;
        fecha_baja:Date;
        user:string;
        usuario:Usuario;
        alias:string;
        total_giro_descubierto:number;
}