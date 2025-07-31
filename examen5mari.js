let diaSemana = "3";
let plato_del_dia;

switch (diaSemana) { 
 case "1":
    plato_del_dia = "Lentejas"
    break;

case "2":
    plato_del_dia ="Pollo al horno"
    break;


case "3":
     plato_del_dia = "Pescado a la plancha"
    break;


case "4":
     plato_del_dia = "Pasta"
    break;



case "5":
     plato_del_dia = "Paella"
    break;
default:
    plato_del_dia = "Dia no valido. Elige un numero del 1 al 5.";
}
console.log (`El plato para el dia ${diaSemana} es: ${plato_del_dia}`)