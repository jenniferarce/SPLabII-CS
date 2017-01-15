using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLabII_CS
{
    public interface iExterminar
    {
        eElemento ElementoParaExterminar
        {
            get;
            set;
        }
        eElemento ElementoQueMeExtermina
        {
            get;
            set;
        }
        bool Exterminar(iExterminar algo);

    }
}
