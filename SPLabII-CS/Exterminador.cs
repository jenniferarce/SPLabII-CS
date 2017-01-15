using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLabII_CS
{
    public class Exterminador:iExterminar 
    {
        private string _descripcion;
        private eElemento _elementoParaExterminar;
        private eElemento _elementoquemata;

        public Exterminador(eElemento elementoparaexterminar, eElemento elementoquememata, string descripcion)
        {
            _elementoParaExterminar = elementoparaexterminar;
            _elementoquemata = elementoquememata;
            _descripcion = descripcion;
        }

        #region iExterminar Members

        public eElemento ElementoParaExterminar
        {
            get
            {
                return _elementoParaExterminar;
            }
            set
            {
                _elementoParaExterminar = value;
            }
        }

        public eElemento ElementoQueMeExtermina
        {
            get
            {
                return _elementoquemata;
            }
            set
            {
                _elementoquemata = value;
            }
        }

        public bool Exterminar(iExterminar algo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
