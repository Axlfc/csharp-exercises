using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ConcretoProductB2 : IAbstractProductB {
    public string MetodoB() {
        return "Desde MetodoA en ConcretoProductB2";
    }
}
