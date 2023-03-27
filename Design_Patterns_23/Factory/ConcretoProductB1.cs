using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    public class ConcretoProductB1 : IAbstractProductB {
        public string MetodoB() {
            return "Desde MetodoB en ConcretoProductB1";
        }
        public string OtroMetodoB(IAbstractProductA colaborador) {
            var resultado = colaborador.MetodoA();
            return $"El resultado de la colaboración con A es: {resultado} desde ConcretoProductB1";
        }
    }
}