using System;

var moto = new Motos();
moto.ArrancarMoto();

Motos.Arrancar();

// Extension
Methods_I.ExtensionMoto.Acelerar();

// Retornos de métodos
int gasolina = moto.CantidadGasolina();
Console.WriteLine($"Nos quedan {gasolina} litros de combustible.");

// Sobrecargas
dynamic deposito = moto.EcharGasolina(10);
Console.WriteLine($"Ahora tenemos {deposito} litros de combustible.");

class Motos {
    public static void Arrancar() {
        Console.WriteLine("Arrancando Moto");
    }

    public void ArrancarMoto() {
        Console.WriteLine("Arranco esta moto");
    }

    public int CantidadGasolina() {
        int gasolina = 20;
        return gasolina;
    }

    public int EcharGasolina(int litros) {
        int nivelDeposito = litros + 20;
        return nivelDeposito;
    }

    public float EcharGasolina(float litros) {
        float nivelDeposito = 20 + litros;
        return nivelDeposito;
    }

    public double EcharGasolina(double litros) {
        double nivelDeposito = 20 + litros;
        return nivelDeposito;
    }
}

