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
        //Esto lo podremos meter en otro sitio pero lo dejo aqui para ver los cambios
        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
                { '0', "0000" },
                { '1', "0001" },
                { '2', "0010" },
                { '3', "0011" },
                { '4', "0100" },
                { '5', "0101" },
                { '6', "0110" },
                { '7', "0111" },
                { '8', "1000" },
                { '9', "1001" },
                { 'a', "1010" },
                { 'b', "1011" },
                { 'c', "1100" },
                { 'd', "1101" },
                { 'e', "1110" },
                { 'f', "1111" }
            };

        public static string HexStringToBinary(string hex)
        {
            StringBuilder result = new StringBuilder();
            if (hex.Length == 1)
                hex = "0" + hex;  //para que todos sean octetos
            foreach (char c in hex)
            {
                // Esto petará si no le entramos algo hexadecimal asik tenemos que meter un try catch aqui
                result.Append(hexCharacterToBinary[char.ToLower(c)]);
            }
            return result.ToString();
        }


        //Funciones

        //public string SAC;
        //public string SIC;
        //private static int Compute_Data_Source_Identification(string msgHex1, string msgHex2, int i)
        //{

        //    SAC = Convert.ToString(Convert.ToInt32(msgHex1, 2));
        //    SIC = Convert.ToString(Convert.ToInt32(msgHex2, 2)); 
        //    i += 2; //2 octetos
        //    return i;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String path = @"..\Ficheros_asterix\201002-lebl-080001_adsb.ast";
            AsterixFile asterixFile = new AsterixFile(path);
            asterixFile.leer();
            List<CAT21> listaCAT21 = new List<CAT21>();
            listaCAT21 = asterixFile.getListCAT21();

            //listaCAT21 es una lista de paquetes (enteros) ASTERIX. Cada paquete ASTERIX, tiene una lista de octetos
            //PRUEBA 1 RUBEN

            Console.WriteLine(listaCAT21[0].getCat(0)); // 15 = cat21
            Console.WriteLine(listaCAT21[0].getCat(1)); // 0 = len (en hexa)
            Console.WriteLine(listaCAT21[0].getCat(2)); // 63 = len (en hexa)
            Console.WriteLine(listaCAT21[0].getCat(3)); // F7 = comienzo FSPEC

            //Prueba del Hex to Binary (Funciona)
            string resultado = "";
            resultado = HexStringToBinary(listaCAT21[0].getCat(3));
            Console.WriteLine(resultado);

            //Prueba de sacar el FSPEC (Funciona)
            StringBuilder FSPEC = new StringBuilder();
            int end = 0;
            int i = 3;
            while(end==0)
            {
                FSPEC.Append(HexStringToBinary(listaCAT21[0].getCat(i)));
                if(HexStringToBinary(listaCAT21[0].getCat(i)).EndsWith("0"))
                {
                    end = 1;
                }
                Console.WriteLine(listaCAT21[0].getCat(i));
                Console.WriteLine("FSPEC: " + FSPEC);
                i++;
            }
            Console.WriteLine("FSPEC: "+FSPEC);

            Console.WriteLine(listaCAT21[0].getCat(i)); //primer octeto tras el FSPEC

            #region CAT21

            
           
            //Comprovamos cada campo para realizar las funciones
            if (FSPEC[0] == '1') 
            {
                //Compute_Data_Source_Identification(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i+1), i);
            }
            if (FSPEC[1] == '1')
            { 

            }
            if (FSPEC[2] == '1')
            {

            }
            if (FSPEC[3] == '1')
            {

            }
            if (FSPEC[4] == '1')
            {

            }
            if (FSPEC[5] == '1')
            {

            }
            if (FSPEC[6] == '1')
            {

            }
            if (FSPEC.Length > 8)
            {
                if (FSPEC[8] == '1')
                {

                }
                if (FSPEC[9] == '1')
                {

                }
                if (FSPEC[10] == '1')
                {

                }
                if (FSPEC[11] == '1')
                {

                }
                if (FSPEC[12] == '1')
                {

                }
                if (FSPEC[13] == '1')
                {

                }
                if (FSPEC[14] == '1')
                {

                }
                if (FSPEC.Length > 16)
                {
                    if (FSPEC[16] == '1')
                    {

                    }
                    if (FSPEC[17] == '1')
                    {

                    }
                    if (FSPEC[18] == '1')
                    {

                    }
                    if (FSPEC[19] == '1')
                    {

                    }
                    if (FSPEC[20] == '1')
                    {

                    }
                    if (FSPEC[21] == '1')
                    {

                    }
                    if (FSPEC[22] == '1')
                    {

                    }
                    if (FSPEC.Length > 24)
                    {
                        if (FSPEC[24] == '1')
                        {

                        }
                        if (FSPEC[25] == '1')
                        {

                        }
                        if (FSPEC[26] == '1')
                        {

                        }
                        if (FSPEC[27] == '1')
                        {

                        }
                        if (FSPEC[28] == '1')
                        {

                        }
                        if (FSPEC[29] == '1')
                        {

                        }
                        if (FSPEC[30] == '1')
                        {

                        }
                        if (FSPEC.Length > 32)
                        {
                            if (FSPEC[32] == '1')
                            {

                            }
                            if (FSPEC[33] == '1')
                            {

                            }
                            if (FSPEC[34] == '1')
                            {

                            }
                            if (FSPEC[35] == '1')
                            {

                            }
                            if (FSPEC[36] == '1')
                            {

                            }
                            if (FSPEC[37] == '1')
                            {

                            }
                            if (FSPEC[38] == '1')
                            {

                            }
                            if (FSPEC.Length > 40)
                            {
                                if (FSPEC[40] == '1')
                                {

                                }
                                if (FSPEC[41] == '1')
                                {

                                }
                                if (FSPEC[42] == '1')
                                {

                                }
                                if (FSPEC[43] == '1')
                                {

                                }
                                if (FSPEC[44] == '1')
                                {

                                }
                                if (FSPEC[45] == '1')
                                {

                                }
                                if (FSPEC[46] == '1')
                                {

                                }
                                //NO SE SI HAY 47
                            }
                        }
                    }
                }
            }
            #endregion


            #region CAT10
            //Comprovamos cada campo para realizar las funciones
            if (FSPEC[0] == '1')
            {
                Get_Message_Type()
            }
            if (FSPEC[1] == '1')
            {

            }
            if (FSPEC[2] == '1')
            {

            }
            if (FSPEC[3] == '1')
            {

            }
            if (FSPEC[4] == '1')
            {

            }
            if (FSPEC[5] == '1')
            {

            }
            if (FSPEC[6] == '1')
            {

            }
            if (FSPEC.Length > 8)
            {
                if (FSPEC[8] == '1')
                {

                }
                if (FSPEC[9] == '1')
                {

                }
                if (FSPEC[10] == '1')
                {

                }
                if (FSPEC[11] == '1')
                {

                }
                if (FSPEC[12] == '1')
                {

                }
                if (FSPEC[13] == '1')
                {

                }
                if (FSPEC[14] == '1')
                {

                }
                if (FSPEC.Length > 16)
                {
                    if (FSPEC[16] == '1')
                    {

                    }
                    if (FSPEC[17] == '1')
                    {

                    }
                    if (FSPEC[18] == '1')
                    {

                    }
                    if (FSPEC[19] == '1')
                    {

                    }
                    if (FSPEC[20] == '1')
                    {

                    }
                    if (FSPEC[21] == '1')
                    {

                    }
                    if (FSPEC[22] == '1')
                    {

                    }
                    if (FSPEC.Length > 24)
                    {
                        if (FSPEC[24] == '1')
                        {

                        }
                        if (FSPEC[25] == '1')
                        {

                        }
                        if (FSPEC[26] == '1')
                        {

                        }
                        if (FSPEC[27] == '1')
                        {

                        }
                    }
                        #endregion










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
