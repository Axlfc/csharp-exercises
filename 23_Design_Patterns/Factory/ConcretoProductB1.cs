using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ConcretoProductB1 : IAbstractProductB {
    public string MetodoB() {
        return "Desde MetodoA en ConcretoProductB1";
    }
    public string OtroMetodoB(IAbstractProductA colaborador) {
        var res = colaborador.MetodoA();
        return $"El resultado de la colab con A es: {res}";
    }
}
