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
                i= DataSourceIdentification(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i+1), i);
            }
            if (FSPEC[1] == '1')
            {
                int result = 0;
                while (result == 0) {
                    result = TargetReportDescriptor(listaCAT21[0].getCat(i), i);
                    i = i + 1;
                }

            }
            if (FSPEC[2] == '1')
            {
                i = TrackNumber(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), i);
            }
            if (FSPEC[3] == '1')
            {
               i = ServiceIdentification(listaCAT21[0].getCat(i),  i);
            }
            if (FSPEC[4] == '1')
            {
                i = Toap(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), listaCAT21[0].getCat(i + 2), i);
            }
            if (FSPEC[5] == '1')
            {
                i = PosWGS(listaCAT21[0], i);
            }
            if (FSPEC[6] == '1')
            {
                i = PosWGSH(listaCAT21[0], i);
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


            string SAC;
            string SIC1;
            string airport_code;


            int DataSourceIdentification(string oct1, string oct2, int i) {
                SAC = Convert.ToString(Convert.ToInt32(oct1, 2));
                int SIC = Convert.ToInt32(oct2, 2);
                SIC1 = Convert.ToString(SIC);

                //Decode
                int airportcode = 0;
                if (SIC == 107 || SIC == 7 || SIC == 219) { airportcode = 0; } //BARCELONA
                else if (SIC == 5 || SIC == 105 || SIC == 209) { airportcode = 1; } //ASTURIAS
                else if (SIC == 2 || SIC == 102) { airportcode = 2; } //PALMA
                else if (SIC == 6 || SIC == 106 || SIC == 227 || SIC == 228) { airportcode = 3; } //SANTIAGO
                else if (SIC == 3 || SIC == 4 || SIC == 104) { airportcode = 4; } //BARAJAS
                else if (SIC == 1 || SIC == 101) { airportcode = 5; } //TENERIFE
                else if (SIC == 108) { airportcode = 6; } //Malaga
                else if (SIC == 203) { airportcode = 7; } //Bilbao
                else if (SIC == 206) { airportcode = 8; } //ALICANTE
                else if (SIC == 207) { airportcode = 9; } //GRANADA
                else if (SIC == 210) { airportcode = 10; } //LANZAROTE
                else if (SIC == 211) { airportcode = 11; } //TURRILLAS
                else if (SIC == 212) { airportcode = 12; } //Menorca
                else if (SIC == 213 || SIC == 229) { airportcode = 13; } //IBIZA
                else if (SIC == 214) { airportcode = 14; } //VALDESPINA
                else if (SIC == 215 || SIC == 221) { airportcode = 15; } //PARACUELLOS
                else if (SIC == 216) { airportcode = 16; } //RANDA
                else if (SIC == 218) { airportcode = 17; } //GERONA
                else if (SIC == 220 || SIC == 222) { airportcode = 18; } //ESPIÑEIRAS
                else if (SIC == 223) { airportcode = 19; } //VEJER
                else if (SIC == 224) { airportcode = 20; } //YESTE
                else if (SIC == 225 || SIC == 226) { airportcode = 21; } //VIGO
                else if (SIC == 230) { airportcode = 22; } //VALENCIA
                else if (SIC == 231) { airportcode = 23; } //SEVILLA
                airport_code = Convert.ToString(airportcode);

                i = i + 2;
                return i;
            }



            string ATP;
            string ARC;
            string RC;
            string RAB;

            int TargetReportDescriptor(string oct1, int i)
            {
                char[] Oct = oct1.ToCharArray();
                int atp = Convert.ToInt32(string.Concat(Oct[0], Oct[1], Oct[2]), 2);
                int arc = Convert.ToInt32(string.Concat(Oct[3], Oct[4]), 2);

                ATP = atp switch
                {
                    0 => "24-Bit ICAO address",
                    1 => ATP = "Duplicate address",
                    2 => "Surface vehicle address",
                    3 => "Anonymous address",
                    _ => "Reserved for future use",
                };
                ARC = arc switch
                {
                    0 => "25 ft ",
                    1 => "100 ft",
                    2 => "Unknown",
                    _ => "Invalid",
                };
                string rc="";
                if (Oct[5] == '0') { RC = "Default"; }
                else { rc = "Range Check passed, CPR Validation pending"; }
                RC = rc;
                string rab = "";
                if (Oct[6] == '0') { RAB = "Report from target transponder"; }
                else { RAB = "Report from field monitor (fixed transponder)"; }
                RAB = rab;
                if (Oct[7] == '1')
                {
                    return 0;
                }
                else {
                    return 1;
                }
            }

            int PosWGS(CAT21 cat, int i) {
                char[] Oct1 = cat.getCat(i).ToCharArray();
                char[] Oct2 = cat.getCat(i+1).ToCharArray();
                char[] Oct3 = cat.getCat(i + 2).ToCharArray();
                char[] Oct4 = cat.getCat(i + 3).ToCharArray();
                char[] Oct5 = cat.getCat(i + 4).ToCharArray();
                char[] Oct6 = cat.getCat(i + 5).ToCharArray();





                i = i + 6;
                return i;
            }




            #endregion


            #region CAT10
            //atributos del objeto CAT10
            string Message_Type; //Get_Message_Type

            string SAC; //Get_Data_Source_Identifier
            string SIC; //Get_Data_Source_Identifier

            string TYP; //Get_Target_Report_Descriptor
            string DCR; //Get_Target_Report_Descriptor
            string CHN; //Get_Target_Report_Descriptor
            string GBS; //Get_Target_Report_Descriptor
            string CRT; //Get_Target_Report_Descriptor
            string SIM; //Get_Target_Report_Descriptor
            string TST; //Get_Target_Report_Descriptor
            string RAB; //Get_Target_Report_Descriptor
            string LOP; //Get_Target_Report_Descriptor
            string TOT; //Get_Target_Report_Descriptor
            string SPI; //Get_Target_Report_Descriptor

            string RHO; //Get_Measured_Position_in_Polar_Coordinates
            string Theta; //Get_Measured_Position_in_Polar_Coordinates

            //Comprovamos cada campo para realizar las funciones
            if (FSPEC[0] == '1')
            {
                //Get_Message_Type()
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


             //1 octet
            public int Get_Message_Type(string[] data_block, int i)
            {
                int data = Convert.ToInt32(data_block[i], 2);
                if (data == 1) { this.Message_Type = "Target Report"; }
                if (data == 2) { this.Message_Type = "Start of Update Cycle"; }
                if (data == 3) { this.Message_Type = "Periodic Status Message"; }
                if (data == 4) { this.Message_Type = "Event-triggered Status Message"; }
                i=i+1;
                return i;
            }

            //2 octets
            public int Get_Data_Source_Identifier(string[] data_block, int i)
            {
                this.SAC = Convert.ToString(Convert.ToInt32(data_block[i], 2));
                this.SIC = Convert.ToString(Convert.ToInt32(data_block[i + 1], 2));
                i =i+2;
                return i;
            }
                    
            //minimum of 1 octet, there is no maximum
            public int Get_Target_Report_Descriptor(string[] data_block, int i)
            {
                int number_of_octets = 1;
                string octet1 = data_block[i];

                string code_TYP = octet1.Substring(0, 3);
                if (code_TYP == "000") { this.TYP = "SSR multilateration"; }
                if (code_TYP == "001") { this.TYP = "Mode S multilateration"; }
                if (code_TYP == "010") { this.TYP = "ADS-B"; }
                if (code_TYP == "011") { this.TYP = "PSR"; }
                if (code_TYP == "100") { this.TYP = "Magnetic Loop System"; }
                if (code_TYP == "101") { this.TYP = "HF multilateration"; }
                if (code_TYP == "110") { this.TYP = "Not defined"; }
                if (code_TYP == "111") { this.TYP = "Other types"; }


                string code_DCR = octet1.Substring(3, 1);
                if (code_DCR == "0") { this.DCR = "No differential correction (ADS-B)"; }
                if (code_DCR == "1") { this.DCR = "Differential correction (ADS-B)"; }

                string code_CHN = octet1.Substring(4, 1);
                if (code_CHN == "0") { this.CHN = "Chain 1"; }
                if (code_CHN == "1") { this.CHN = "Chain 2"; }

                string code_GBS = octet1.Substring(5, 1);
                if (code_GBS == "0") { this.GBS = "Transponder Ground bit not set"; }
                if (code_GBS == "1") { this.GBS = "Transponder Ground bit set"; }

                string code_CRT = octet1.Substring(6, 1);
                if (code_CRT == "0") { this.CRT = "No Corrupted reply in multilateration"; }
                if (code_CRT == "1") { this.CRT = "Corrupted replies in multilateration"; }

                string code_FX = Convert.ToString(octet1[7]);

                while (code_FX == "1")
                {
                    string octet = data_block[i + number_of_octets];

                    if (number_of_octets == 1) //first extend
                    {
                        string code_SIM = octet.Substring(0, 1);
                        if (code_SIM == "0")
                            this.SIM = "Actual target report";
                        if (code_SIM == "1")
                            this.SIM = "Simulated target report";

                        string code_TST = octet.Substring(1, 1);
                        if (code_TST == "0")
                            this.TST = "TST: Default";
                        if (code_TST == "1")
                            this.TST = "Test Target";

                        string code_RAB = octet.Substring(2, 1);
                        if (code_RAB == "0")
                            this.RAB = "Report from target transponder";
                        if (code_RAB == "1")
                            this.RAB = "Report from field monitor (fixed transponder)";

                        string code_LOP = octet.Substring(3, 2);
                        if (code_LOP == "00")
                            this.LOP = "Loop status: Undetermined";
                        if (code_LOP == "01")
                            this.LOP = "Loop start";
                        if (code_LOP == "10")
                            this.LOP = "Loop finish";

                        string code_TOT = octet.Substring(5, 2);
                        if (code_TOT == "00")
                            this.TOT = "Type of vehicle: Undetermined";
                        if (code_TOT == "01")
                            this.TOT = "Aircraft";
                        if (code_TOT == "10")
                            this.TOT = "Ground vehicle";
                        if (code_TOT == "11")
                            this.TOT = "Helicopter";


                    }

                    else //second extend
                    {
                        string code_SPI = octet.Substring(0, 1);
                        if (code_SPI == "0") { this.SPI = "Absence of SPI (Special Position Identification)"; }
                        if (code_SPI == "1") { this.SPI = "SPI (Special Position Identification)"; }

                    }
                    code_FX = octet.Substring(7, 1);
                    number_of_octets = number_of_octets + 1;
                }
                i = i + number_of_octets;
                return i;
            }
              
             //4 octets
            public int Get_Measured_Position_in_Polar_Coordinates(string[] data_block, int i)
            {
                this.RHO = Convert.ToInt32(string.Concat(message[i], message[i + 1]), 2);
                this.Theta = Convert.ToInt32(string.Concat(message[i+2], message[i + 3]), 2);
                
                i = i + 4;
                return i;
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
