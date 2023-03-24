using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ConcretoProductA1 : IAbstractProductA {
    public string MetodoA() {
        return "Desde MetodoA en ConcretoProductA1";
    }
}
