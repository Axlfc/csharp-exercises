using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory {
    public class ConcretoProductA2 : IAbstractProductA {
        public string MetodoA() {
            return "Desde MetodoA en ConcretoProductA2";
        }
    }
}