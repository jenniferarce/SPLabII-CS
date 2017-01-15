using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLabII_CS
{
    public class Mosquito:Insecto,iExterminar
    {
        private int _nivelZumbido;

        public Mosquito()
            : base()
        { }
        public Mosquito(int nivelZumbido)
        {
            _nivelZumbido = nivelZumbido;
        }

        public int NivelZumbido
        {
            get
            {
                return _nivelZumbido;
            }
            set
            {
                _nivelZumbido = value;
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
        
        public override string ToString()
        {
            return base.ToString() + "\nNivel zumbido: "+_nivelZumbido;
        }
    }
}
