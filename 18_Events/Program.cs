// Eventos -> Editor -> Suscriptor


SuscriptorCalc calculadora = new SuscriptorCalc(1, 2);
calculadora.ResultadoSuma();
calculadora.ResultadoResta();


// Editor
public class Editor{
    public delegate void EjemploEvento();
    public event EjemploEvento ejemploEvento;
}


public class EditorCalc {
    public delegate void EjemploDelegado();
    public event EjemploDelegado ejemploEvento;

    public void Sumar(int a, int b) {
        if (ejemploEvento != null) {
            ejemploEvento();
            Console.WriteLine($"La suma es: {a + b}");
        } else {
            Console.WriteLine("No tienes una suscripción al evento.");
        }
    }

    public void Restar(int a, int b) {
        if (ejemploEvento != null) {
            ejemploEvento();
            Console.WriteLine($"La resta es: {a - b}");
        } else {
            Console.WriteLine("No tienes una suscripción al evento.");
        }
    }

    public void Saludar() {
        if (ejemploEvento != null) {
            ejemploEvento();
            Console.WriteLine("Hola, soy una calculadora.");
        } else {
            Console.WriteLine("No tienes una suscripción al evento.");
        }
        
    }
}


// Suscriptor
public class SuscriptorCalc {
    EditorCalc editor;
    private readonly int A;
    private readonly int B;

    public void EventHandler() {
        Console.WriteLine("Se imprime el resultado de la operación");
    }
    public SuscriptorCalc(int a, int b) {
        editor = new EditorCalc();
        A = a;
        B = b;
        editor.ejemploEvento += EventHandler;
    }
    public void ResultadoSuma() {
        editor.Sumar(A, B);
    }
    public void ResultadoResta() {
        editor.Restar(A, B);
        // methods
        editor.Saludar();
    }
}