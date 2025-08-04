<?php

$estudiantes = [
    [
        'nombre' => 'Juan Pérez',
        'notas' => [
            'Matemáticas' => 85,
            'Historia' => 90,
            'Ciencias' => 78
        ]
    ],
    [
        'nombre' => 'María García',
        'notas' => [
            'Matemáticas' => 92,
            'Historia' => 88,
            'Ciencias' => 95,
            'Literatura' => 85
        ]
    ],
    [
        'nombre' => 'Carlos López',
        'notas' => [
            'Matemáticas' => 75,
            'Historia' => 82,
            'Inglés' => 90
        ]
    ]
];


foreach ($estudiantes as $estudiante) {
    echo "Estudiante: " . $estudiante['nombre'] . "\n";
    echo "Notas:\n";
    
    foreach ($estudiante['notas'] as $materia => $calificacion) {
        echo "  - $materia: $calificacion\n";
    }
    
    echo "\n"; 
}
?>