using System;
using System.Diagnostics;
using System.Threading;

// Sin multithreading
Stopwatch crono = new Stopwatch();
crono.Start();

// tarea 1
Thread.Sleep(1000); 

// tarea 2
for (int i = 0; i<400000000; i++) {
    i *= 1;
}

// tarea 3
Thread.Sleep(1000); 

crono.Stop();
Console.WriteLine($"Este programa ha tardado: {crono.Elapsed}");

// Main Thread o Hilo Principal
Thread hiloPrincipal = Thread.CurrentThread;
hiloPrincipal.Name = "Hilo Principal";
Console.WriteLine($"Estamos en el hilo: {hiloPrincipal.Name}");


Stopwatch crono2 = Stopwatch.StartNew();


// Task 1 Task(lambda);
var task1 = new Task(() => {
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000);  // parar el hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"1. Este hilo ha tardado: {crono.Elapsed}");
});


// Task 2 Task(lambda);
var task2 = new Task(() => {
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000);  // parar el hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"2. Este hilo ha tardado: {crono.Elapsed}");
});

// Task 3 Task(lambda);
var task3 = new Task(() => {
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000);  // parar el hilo 1 segundo
    crono.Stop();
    Console.WriteLine($"3. Este hilo ha tardado: {crono.Elapsed}");
});

// Iniciamos las tareas

task1.Start();
task2.Start();
task3.Start();


// Recibir los tasks completados
/*
await task1;
await task2;
await task3;
*/

// Colectivamente
await Task.WhenAll(task1, task2, task3); // Recibimos totas las tareas iniciadas cuando se completan
crono2.Stop();
Console.WriteLine($"Todo el programa ha durado: {crono2.Elapsed}");

// Finalizamos el programa

