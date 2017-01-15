using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPLabII_CS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<iExterminar> QueQuieroExterminar = new List<iExterminar>();
            List<Insecto> exterminadas = new List<Insecto>();

            Exterminador unExterminador = new Exterminador(eElemento.AerosolParaCucarachas, eElemento.RifleFrancotirador, "Persona con un aerosol");

            //insectos que se van a agregar a la colección QueQuieroExterminar
            Mosquito mosquito1 = new Mosquito(1);
            mosquito1.ElementoQueMeExtermina = eElemento.Ojota;
            Cucaracha cuca1 = new Cucaracha(eColor.Rubia);
            cuca1.ElementoQueMeExtermina = eElemento.AerosolParaCucarachas;
            Mosquito mosquito2 = new Mosquito(3);
            mosquito2.ElementoQueMeExtermina = eElemento.Granada;

            Cucaracha cuca2 = new Cucaracha(eColor.Morocha);
            cuca2.ElementoQueMeExtermina = eElemento.Kriptonita;

            QueQuieroExterminar.Add(mosquito1);
            QueQuieroExterminar.Add(mosquito2);
            QueQuieroExterminar.Add(cuca1);
            QueQuieroExterminar.Add(cuca2);
            //tener en cuenta que se podrían agregar otros elementos además de los utilizados

            //d) (Completar)
            //e) (Completar)
            //f) (Completar)


        }
    }
}
