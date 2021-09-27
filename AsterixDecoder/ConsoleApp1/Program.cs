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
            int cont = 0;
            

            while (cont < Convert.ToInt32(listaCAT21[2].getCat(2),16)) {
                Console.WriteLine(listaCAT21[2].getCat(cont));
                cont++;

            }
            Console.WriteLine(Convert.ToString(cont));
        }
    }
}
