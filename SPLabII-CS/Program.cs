using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

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

            Console.WriteLine("*****-----LISTA ¡ANTES! DE ELIMINAR-----*****");
            foreach (Insecto ins in QueQuieroExterminar)
            {
                Console.WriteLine(ins.ToString());
            }

            #region ELIMINAR/SERIALIZAR CUCARACHA

            using (XmlTextWriter escritor = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "EjemploXML.xml", Encoding.UTF8))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Insecto>));
                //XmlSerializer ser = new XmlSerializer(typeof(Cucaracha));
                if (QueQuieroExterminar.Contains(cuca1))  //if (cuca1 == QueQuieroExterminar)
                {
                    if (unExterminador.Exterminar(cuca1) == true)
                    {
                        exterminadas.Add(cuca1);
                        //ser.Serialize(escritor, c1);
                        QueQuieroExterminar.Remove(cuca1);
                    }
                    else
                    {
                        Console.WriteLine("No se pudo eliminar Cucaracha1.");
                    }
                }//CUCA1
                if (QueQuieroExterminar.Contains(cuca2))//if (cuca2 == QueQuieroExterminar)
                {
                    if (unExterminador.Exterminar(cuca2) == true)
                    {
                        exterminadas.Add(cuca2);
                        //ser.Serialize(escritor, c2);
                        QueQuieroExterminar.Remove(cuca2);
                    }
                    else
                    {
                        Console.WriteLine("No se pudo eliminar Cucaracha2");
                    }
                }//CUCA2
                ser.Serialize(escritor, exterminadas);
            }//XMLTEXTWRITER
            #endregion

            #region ELIMINAR/GUARDAR MOSQUITOS

            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "EjemploTXT.txt");

            if (QueQuieroExterminar.Contains(mosquito1))
            {
                if (unExterminador.Exterminar(mosquito1) == true)
                {
                    QueQuieroExterminar.Remove(mosquito1);
                    Console.WriteLine("Se elimino Mosquito1");
                }
                else
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(mosquito1.ToString());
                }
            }//MOSQUITO-1
            if (QueQuieroExterminar.Contains(mosquito2))
            {
                if (unExterminador.Exterminar(mosquito2) == true)
                {
                    QueQuieroExterminar.Remove(mosquito2);
                    Console.WriteLine("Se elimino Mosquito2");
                }
                else
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine(mosquito2.ToString());
                }
            }//MOSQUITO-2
            sw.Close();

            #endregion
            //--------------------------------------------------
            Console.WriteLine("*****-----LISTA DESPUES DE ELIMINAR-----*****");
            foreach (Insecto ins in QueQuieroExterminar)
            {
                Console.WriteLine(ins.ToString());
            }

            Console.ReadKey();


        }
    }
}
