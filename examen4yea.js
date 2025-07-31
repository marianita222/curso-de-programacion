const colorSemaforo =  prompt ("de que color esta el semaforo?");
let valorSemaforo = "verde";
let valorSemaforo2 = "amarillo";
let valorSemaforo3 = "rojo";

if (colorSemaforo === valorSemaforo){
    console.log ("puede avanzar");
}
else if (colorSemaforo === valorSemaforo2){
    console.log("reduzca la velocidad");
}
else if (colorSemaforo === valorSemaforo3){
    console.log("debe deternese");
}
else
    console.log("color no valido");
