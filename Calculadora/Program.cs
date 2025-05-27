// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Console.WriteLine("Hello, World!");

Calculadora miCalculadora = new Calculadora(5);

miCalculadora.sumar(23);
miCalculadora.sumar(2);
//uso de ejemplo
miCalculadora.dividir(0);
miCalculadora.dividir(5);

Console.WriteLine($"El resultado es: {miCalculadora.GetResultado()}");