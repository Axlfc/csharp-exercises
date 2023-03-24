using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ConcretoFactory2 : IAbstractFactory {
    public IAbstractProductA CreateProductA() {
        return new ConcretoProductA2();
    }
    public IAbstractProductB CreateProductB() {
        return new ConcretoProductB2();
    }
}