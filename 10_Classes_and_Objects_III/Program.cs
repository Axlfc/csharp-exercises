﻿// Generics
Generic<string> str = new Generic<string>();
str.Dato = "dato";

Console.WriteLine($"Generic Dato: {str.Dato}");
Console.WriteLine($"Tipo de Generic Dato: {str.Dato.GetType()}");
Console.WriteLine($"Tipo de  Generic Dato: {str.GetType()}");


public class Generic<T> {
    public T Dato { get; set; }
}