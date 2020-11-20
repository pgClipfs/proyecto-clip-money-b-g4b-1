import { Barrio } from './barrio';

export class Usuario{
    usuario: string;
    nombre_titular: string;
    apellido_titular: string;
    contrasenia: string
    telefono:string;
    mail:string;
    fecha_nacimiento:Date;
    DNI:number;
    calle_direccion:string;
    numero_direccion:number;
    barrio:Barrio;
    id_barrio: number;
} 