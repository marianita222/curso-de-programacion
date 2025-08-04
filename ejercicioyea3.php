<?php

$tareas = [
    [
        'tarea' => 'Hacer la compra',
        'completada' => false,
        'prioridad' => 'media'
    ],
    [
        'tarea' => 'Estudiar para el examen',
        'completada' => false,
        'prioridad' => 'alta'
    ],
    [
        'tarea' => 'Llamar al médico',
        'completada' => true,
        'prioridad' => 'baja'
    ],
    [
        'tarea' => 'Enviar informe',
        'completada' => false,
        'prioridad' => 'alta'
    ]
];


function mostrarTareas($listaTareas, $soloPendientes = false) {
    echo "--------------------------------\n";
    echo $soloPendientes ? "TAREAS PENDIENTES:\n" : "TODAS LAS TAREAS:\n";
    echo "--------------------------------\n";
    
    foreach ($listaTareas as $index => $tarea) {
        if ($soloPendientes && $tarea['completada']) {
            continue; 
        }
        
        $estado = $tarea['completada'] ? '✓' : '✗';
        echo "Tarea #" . ($index + 1) . ": " . $tarea['tarea'] . "\n";
        echo "Prioridad: " . $tarea['prioridad'] . "\n";
        echo "Estado: " . $estado . "\n";
        echo "--------------------------------\n";
    }
}

// 1. Mostrar todas las tareas iniciales
mostrarTareas($tareas);

// 2. Marcar una tarea como completada (por ejemplo, "Hacer la compra")
foreach ($tareas as &$tarea) {
    if ($tarea['tarea'] == 'Hacer la compra') {
        $tarea['completada'] = true;
        break;
    }
}

// 3. Mostrar solo las tareas pendientes
mostrarTareas($tareas, true);
?>