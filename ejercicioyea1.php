<?php
$frutas = ["pera", "manzana", "banana", "mango","durazno"];
foreach ($frutas as $frutas){
    echo $frutas . "\n";
}
$producto = [
    "nombre"   => "pera", 
    "precio" => "0.90",
    "stock"     => 20
];

echo 'nombre:' . $producto["nombre"] . "\n";
echo 'precio:'. $producto ["precio"] . "\n";
echo  'stock:' . $producto ["stock"] . "unidades \n";


?>