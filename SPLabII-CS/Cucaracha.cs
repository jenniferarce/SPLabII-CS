using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLabII_CS
{
    public class Cucaracha:Insecto, iExterminar
    {
        private eColor _color;

        public Cucaracha()
            : base()
        { }
        public Cucaracha(eColor color)
        {
            _color = color;
        }

        public eColor Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        #region iExterminar Members

        public eElemento ElementoParaExterminar
        {
            get
            {
                return _elementoparaExterminar;
            }
            set
            {
                _elementoparaExterminar = value;
            }
        }

        public eElemento ElementoQueMeExtermina
        {
            get
            {
                return _elementoQueMeExtermina;
            }
            set
            {
                _elementoQueMeExtermina = value;
            }
        }

        public bool Exterminar(iExterminar algo)
        {
            return false;
        }

        #endregion

    }
}
