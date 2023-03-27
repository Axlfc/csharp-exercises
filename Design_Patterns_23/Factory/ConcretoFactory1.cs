using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    class ConcretoFactory1 : IAbstractFactory {
        public IAbstractProductA CreateProductA() {
            return new ConcretoProductA1();
        }
        public IAbstractProductB CreateProductB() {
            return new ConcretoProductB1();
        }
    }
}