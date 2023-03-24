// Delegados

Console.WriteLine("Escribe un mensaje para el delegado:");
string msg = Console.ReadLine();
/* Usando el delegado que hemos declarado con "delegade void"
ImprimirDelegadoClase obj = new ImprimirDelegadoClase();
obj.EjemploDelegate(msg);
*/

// Usando Action<string>
/*
ImprimirConActionClase obj = new ImprimirConActionClase();
obj.EjemploAction(msg);
*/

// Usando Delegado anónimo

ImprimirConDelegadoAnonimo obj = new ImprimirConDelegadoAnonimo();
obj.EjemploConDelegadoAnonimo(msg);

// Definiciones
public delegate void ImprimirDelegado(string value);


public class ImprimirDelegadoClase {
    private void Imprimir(string value) {
        Console.WriteLine($"He recibido este valor: {value}");
    }
    public void EjemploDelegate(string str) {
        // Declaracion
        ImprimirDelegado imprimirDelegado = new ImprimirDelegado(Imprimir);
        // Invocación - Call
        imprimirDelegado(str);

    }
}

public class ImprimirConActionClase {
    private void Imprimir(string msg) {
        Console.WriteLine(msg);
    }
    public void EjemploAction(string msg) {
        Action<string> imprimirDelegadoAction = Imprimir;
        imprimirDelegadoAction(msg);
    }
}

public class ImprimirConDelegadoAnonimo {
    public void EjemploConDelegadoAnonimo(string msg) {
        /* Definición regular 
        Action<string> imprimirConAction = delegate (string msg) {
            Console.WriteLine($"Desde delegado anónimo: {msg}");
        };
        imprimirConAction($"{msg}");
        */

        Action<string> imprimirConActionLambda = x => Console.WriteLine(x);
        imprimirConActionLambda(msg);

        Func<int, string> res = v => $"El resultado es: {v}";
        Console.WriteLine(res(5));

        Func<int, int, int> mult = (v1, v2) => v1 * v2;
        int resultado = mult(3, 2);
        Console.WriteLine(resultado);

        // Predicate
        Predicate<int> esMayordeEdad = e => e >= 18;
        bool mayordeEdad = esMayordeEdad(27); // true
    }
}