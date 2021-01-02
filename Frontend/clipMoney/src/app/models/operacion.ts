import { Cuenta } from "./cuenta";
import { Moneda } from "./moneda";
import { OperacionTipo } from "./operacionTipo";

export class Operacion {
    id_operacion: number;
    cuenta: Cuenta;
    CVU_cuenta: number;
    cuentaDestino: Cuenta;
    CVU_cuenta_destino: number;
    cuentaOrigen: number;
    CVU_cuenta_Origen: number;
    verificacion_banco: boolean;
    descripcion: string;
    fecha_ocurrencia: Date;
    monto_original: number;
    monto: number;
    operacionTipo: OperacionTipo;
    id_tipo_operacion: number;
    verificacion_origen_destino: number;
    moneda: Moneda;
    id_moneda: number;

}

















