using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLabII_CS
{
    class Insecto
    {
        protected eElemento _elementoparaExterminar;
        protected eElemento _elementoQueMeExtermina;

        public Insecto()
        { 
        }

        public override string ToString()
        {
            return "\nElemento para exterminar: " + _elementoparaExterminar + "\nElemento que me extermina: "+_elementoQueMeExtermina;
        }
    }
}
