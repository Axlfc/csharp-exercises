// Patrones de Diseño

using Factory;

class Program {
    static void Main(string[] args) {
        // Testing Singleton
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();

        if (s1 == s2) {
            Console.WriteLine("Singleton works!");
        } else {
            Console.WriteLine("Singleton failed!!");
        }

        // Testing Factory
        Console.WriteLine("Testing Factory");

        Cliente cliente = new Cliente();
        cliente.Main();
    }
}

class Cliente {
    public void Main() {
        Console.WriteLine();

        Console.WriteLine("Creating ProductA and ProductB using ConcretoFactory1");
        ClienteMetodo(new ConcretoFactory1());

        Console.WriteLine();

        Console.WriteLine("Creating ProductA and ProductB using ConcretoFactory2");
        ClienteMetodo(new ConcretoFactory2());
    }

    void ClienteMetodo(IAbstractFactory factory) {
        var ProductA = factory.CreateProductA();
        Console.WriteLine();
        Console.WriteLine("ProductA: " + ProductA.MetodoA());

        var ProductB = factory.CreateProductB();
        Console.WriteLine();
        Console.WriteLine("ProductB: " + ProductB.MetodoB());
    }
}