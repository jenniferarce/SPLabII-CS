using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SPLabII_CS
{
    [XmlInclude(typeof(Cucaracha))]
    [Serializable]
    public class Insecto
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
