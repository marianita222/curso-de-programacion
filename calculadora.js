let operacion = prompt(`
    calculadora basica
    Ingrese una operación:
    1. Suma (+)
    2. Resta (-)
    3. Multiplicación (*)
    4. División (/)
    5. Potencia (^)
    6. Raíz cuadrada (√)
    7. Porcentaje (%)
    8. Factorial (!)
    0. Salir`);

let numero = Number(prompt("cual es el primer numero: "));
let numero1 = Number(prompt("cual es el segundo numero:"));

switch (operacion) {
    case "suma":
    let suma = numero + numero1;
    console.log(suma)
    case "resta":
}

