using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Data;
using AsterixDecoder;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String path = @"..\Ficheros_asterix\201002-lebl-080001_adsb.ast";
            AsterixFile asterixFile = new AsterixFile(path);
            asterixFile.leer();
            List<CAT21> listaCAT21 = new List<CAT21>();
            listaCAT21 = asterixFile.getListCAT21();







            //int cont = 0;
            //int pack = 0;
            //while (pack < listaCAT21.Count  && pack<20)
            //{
            //    cont = 0;
            //    Console.WriteLine("Paquete "+pack+":");
            //    while (cont < Convert.ToInt32(listaCAT21[pack].getCat(2), 16))
            //    {
            //        Console.WriteLine(listaCAT21[pack].getCat(cont));
            //        cont++;


            //    }
            //    Console.WriteLine("Longitud " + Convert.ToString(cont));
            //    pack++;
            //}
            //int cont = 0;
            //int pack = 0;
            //string mensaje = "";
            //while (pack < listaCAT21.Count)
            //{
            //    cont = 0;

            //    while (cont < Convert.ToInt32(listaCAT21[pack].getCat(2), 16))
            //    {
            //        mensaje+=listaCAT21[pack].getCat(cont);
            //        cont++;
            //    }
            //    pack++;
            //}
            //Console.WriteLine(mensaje);


            //Console.WriteLine("Paquete 2:");
            //cont = 0;
            //while (cont < Convert.ToInt32(listaCAT21[3].getCat(2), 16))
            //{
            //    Console.WriteLine(listaCAT21[3].getCat(cont));
            //    cont++;
            //}
            //Console.WriteLine("Longitud " + Convert.ToString(cont));
        }
    }
}
