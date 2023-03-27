using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Singleton -> Logger

public sealed class Singleton {
    static Singleton() { }

    private static Singleton? _instance;

    public static Singleton GetInstance() {
        if (_instance == null) {
            _instance = new Singleton();
        } 
        return _instance;
    }
    public static void MyMethod() {
        Console.WriteLine("Hello");
    }
}