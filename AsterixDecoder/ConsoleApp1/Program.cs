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
            //String[] Data_block;

            char[] FSPEC_char = new char[2000];//Get_FSPEC




            Console.WriteLine("Hello World!");

            String path = @"..\Ficheros_asterix\201002-lebl-080001_smr.ast";
            AsterixFile asterixFile = new AsterixFile(path);
            asterixFile.leer();
            List<CAT10> listaCAT10 = new List<CAT10>();
            List<CAT21> listaCAT21 = new List<CAT21>();
            listaCAT21 = asterixFile.getListCAT21();
            listaCAT10 = asterixFile.getListCAT10();

            //listaCAT21 es una lista de paquetes (enteros) ASTERIX. Cada paquete ASTERIX, tiene una lista de octetos
            //PRUEBA 1 RUBEN
            //Console.WriteLine("punto1");
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(0)); // 15 = cat21
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(1)); // 0 = len (en hexa)
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(2)); // 63 = len (en hexa)
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(3)); // F7 = comienzo FSPEC
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(4)); // F1
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(5)); // 9 
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(6)); // 10 
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(7));//  0 = fin FSPEC
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(8)); // message type
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(9)); // 
            //Console.WriteLine(listaCAT10[0].Get_Data_Item(10));


            int paq = 4;
            listaCAT10[paq].CAT10_Decoding(listaCAT10[paq].Get_Data_Block());
            //string[] data_block_binary = listaCAT21[paq].Convert_HexadecimalDataBLock_To_BinaryDataBlock(listaCAT21[paq].Get_Data_Block());

            //int e = 3;
            //e = listaCAT21[paq].Get_FSPEC(data_block_binary, e);

            //for (int i = 0; i < 52659; i++)
            //{
            //    e = 3;
            //    e = listaCAT10[i].Get_FSPEC(data_block_binary, e);
            //    if (listaCAT10[i].Get_FSPEC_char()[4] == '1') { Console.WriteLine("La i es ="+i); }
            //}

            //Console.WriteLine("DECIMAL TO OCTAL");
            //string dec = "10102";
            //string a = listaCAT21[paq].Convert_Decimal_To_Octal(dec);
            //Console.WriteLine("a="+a);

            //Console.WriteLine("decimal to octal");
            //int dec1 = 10102;
            //int a1 = listaCAT21[paq].ConvertDecimalToOctal(dec1);
            //Console.WriteLine("a1=" + a1);

            //Console.WriteLine("222decimal to octal2");
            //string dec2= "10102";
            //string a2 = listaCAT21[paq].ConvertDecimalToOctal2(dec2);
            //Console.WriteLine("a2=" + a2);


            //for (int a = e; a < 30; a++)
            //{
            //    Console.WriteLine(data_block_binary[a]);
            //}
            //Console.WriteLine("DATA_BLOCK_end");
            // Console.WriteLine("FSPEC=" + listaCAT21[paq].Get_FSPEC_char()[0] + listaCAT21[paq].Get_FSPEC_char()[1] + listaCAT21[paq].Get_FSPEC_char()[2] + listaCAT21[paq].Get_FSPEC_char()[3] + listaCAT21[paq].Get_FSPEC_char()[4] + listaCAT21[paq].Get_FSPEC_char()[5] + listaCAT21[paq].Get_FSPEC_char()[6]);

            // listaCAT21[paq].CAT21_Decoding(listaCAT21[paq].Get_Data_Block());



                        //        }

                        //    }






                        //#region CAT21



                        ////Comprovamos cada campo para realizar las funciones
                        //if (FSPEC[0] == '1')
                        //{
                        //    i = DataSourceIdentification(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), i);
                        //}
                        //if (FSPEC[1] == '1')
                        //{
                        //    int result = 0;
                        //    while (result == 0)
                        //    {
                        //        result = TargetReportDescriptor(listaCAT21[0].getCat(i), i);
                        //        i = i + 1;
                        //    }

                        //}
                        //if (FSPEC[2] == '1')
                        //{
                        //    i = TrackNumber(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), i);
                        //}
                        //if (FSPEC[3] == '1')
                        //{
                        //    i = ServiceIdentification(listaCAT21[0].getCat(i), i);
                        //}
                        //if (FSPEC[4] == '1')
                        //{
                        //    i = Toap(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), listaCAT21[0].getCat(i + 2), i);
                        //}
                        //if (FSPEC[5] == '1')
                        //{
                        //    i = PosWGS(listaCAT21[0], i);
                        //}
                        //if (FSPEC[6] == '1')
                        //{
                        //    i = PosWGSH(listaCAT21[0], i);
                        //}
                        //if (FSPEC.Length > 8)
                        //{
                        //    if (FSPEC[8] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[9] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[10] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[11] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[12] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[13] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[14] == '1')
                        //    {

                        //    }
                        //    if (FSPEC.Length > 16)
                        //    {
                        //        if (FSPEC[16] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[17] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[18] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[19] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[20] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[21] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[22] == '1')
                        //        {

                        //        }
                        //        if (FSPEC.Length > 24)
                        //        {
                        //            if (FSPEC[24] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[25] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[26] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[27] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[28] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[29] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[30] == '1')
                        //            {

                        //            }
                        //            if (FSPEC.Length > 32)
                        //            {
                        //                if (FSPEC[32] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[33] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[34] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[35] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[36] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[37] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[38] == '1')
                        //                {

                        //                }
                        //                if (FSPEC.Length > 40)
                        //                {
                        //                    if (FSPEC[40] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[41] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[42] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[43] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[44] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[45] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[46] == '1')
                        //                    {

                        //                    }
                        //                    //NO SE SI HAY 47
                        //                }
                        //            }
                        //        }
                        //    }
                        //}


                        //string SAC;
                        //string SIC1;
                        //string airport_code;


                        //int DataSourceIdentification(string oct1, string oct2, int i)
                        //{
                        //    SAC = Convert.ToString(Convert.ToInt32(oct1, 2));
                        //    int SIC = Convert.ToInt32(oct2, 2);
                        //    SIC1 = Convert.ToString(SIC);

                        //    //Decode
                        //    int airportcode = 0;
                        //    if (SIC == 107 || SIC == 7 || SIC == 219) { airportcode = 0; } //BARCELONA
                        //    else if (SIC == 5 || SIC == 105 || SIC == 209) { airportcode = 1; } //ASTURIAS
                        //    else if (SIC == 2 || SIC == 102) { airportcode = 2; } //PALMA
                        //    else if (SIC == 6 || SIC == 106 || SIC == 227 || SIC == 228) { airportcode = 3; } //SANTIAGO
                        //    else if (SIC == 3 || SIC == 4 || SIC == 104) { airportcode = 4; } //BARAJAS
                        //    else if (SIC == 1 || SIC == 101) { airportcode = 5; } //TENERIFE
                        //    else if (SIC == 108) { airportcode = 6; } //Malaga
                        //    else if (SIC == 203) { airportcode = 7; } //Bilbao
                        //    else if (SIC == 206) { airportcode = 8; } //ALICANTE
                        //    else if (SIC == 207) { airportcode = 9; } //GRANADA
                        //    else if (SIC == 210) { airportcode = 10; } //LANZAROTE
                        //    else if (SIC == 211) { airportcode = 11; } //TURRILLAS
                        //    else if (SIC == 212) { airportcode = 12; } //Menorca
                        //    else if (SIC == 213 || SIC == 229) { airportcode = 13; } //IBIZA
                        //    else if (SIC == 214) { airportcode = 14; } //VALDESPINA
                        //    else if (SIC == 215 || SIC == 221) { airportcode = 15; } //PARACUELLOS
                        //    else if (SIC == 216) { airportcode = 16; } //RANDA
                        //    else if (SIC == 218) { airportcode = 17; } //GERONA
                        //    else if (SIC == 220 || SIC == 222) { airportcode = 18; } //ESPIÑEIRAS
                        //    else if (SIC == 223) { airportcode = 19; } //VEJER
                        //    else if (SIC == 224) { airportcode = 20; } //YESTE
                        //    else if (SIC == 225 || SIC == 226) { airportcode = 21; } //VIGO
                        //    else if (SIC == 230) { airportcode = 22; } //VALENCIA
                        //    else if (SIC == 231) { airportcode = 23; } //SEVILLA
                        //    airport_code = Convert.ToString(airportcode);

                        //    i = i + 2;
                        //    return i;
                        //}



                        //string ATP;
                        //string ARC;
                        //string RC;
                        //string RAB;

                        //int TargetReportDescriptor(string oct1, int i)
                        //{
                        //    char[] Oct = oct1.ToCharArray();
                        //    int atp = Convert.ToInt32(string.Concat(Oct[0], Oct[1], Oct[2]), 2);
                        //    int arc = Convert.ToInt32(string.Concat(Oct[3], Oct[4]), 2);

                        //    ATP = atp switch
                        //    {
                        //        0 => "24-Bit ICAO address",
                        //        1 => ATP = "Duplicate address",
                        //        2 => "Surface vehicle address",
                        //        3 => "Anonymous address",
                        //        _ => "Reserved for future use",
                        //    };
                        //    ARC = arc switch
                        //    {
                        //        0 => "25 ft ",
                        //        1 => "100 ft",
                        //        2 => "Unknown",
                        //        _ => "Invalid",
                        //    };
                        //    string rc = "";
                        //    if (Oct[5] == '0') { RC = "Default"; }
                        //    else { rc = "Range Check passed, CPR Validation pending"; }
                        //    RC = rc;
                        //    string rab = "";
                        //    if (Oct[6] == '0') { RAB = "Report from target transponder"; }
                        //    else { RAB = "Report from field monitor (fixed transponder)"; }
                        //    RAB = rab;
                        //    if (Oct[7] == '1')
                        //    {
                        //        return 0;
                        //    }
                        //    else
                        //    {
                        //        return 1;
                        //    }
                        //}

                        //int PosWGS(CAT21 cat, int i)
                        //{
                        //    char[] Oct1 = cat.getCat(i).ToCharArray();
                        //    char[] Oct2 = cat.getCat(i + 1).ToCharArray();
                        //    char[] Oct3 = cat.getCat(i + 2).ToCharArray();
                        //    char[] Oct4 = cat.getCat(i + 3).ToCharArray();
                        //    char[] Oct5 = cat.getCat(i + 4).ToCharArray();
                        //    char[] Oct6 = cat.getCat(i + 5).ToCharArray();





                        //    i = i + 6;
                        //    return i;
                        //}




                        //#endregion


                        //#region CAT10
                        //atributos del objeto CAT10



                        //Prueba del Hex to Binary (Funciona)

                        //string resultado = "";
                        //resultado = HexStringToBinary(listaCAT21[0].getCat(3));
                        //Console.WriteLine(resultado);

                        ////Prueba de sacar el FSPEC (Funciona)
                        //StringBuilder FSPEC = new StringBuilder();
                        //int end = 0;
                        //int i = 3;
                        //while(end==0)
                        //{
                        //    FSPEC.Append(HexStringToBinary(listaCAT21[0].getCat(i)));
                        //    if(HexStringToBinary(listaCAT21[0].getCat(i)).EndsWith("0"))
                        //    {
                        //        end = 1;
                        //    }
                        //    Console.WriteLine(listaCAT21[0].getCat(i));
                        //    Console.WriteLine("FSPEC: " + FSPEC);
                        //    i++;
                        //}
                        //Console.WriteLine("FSPEC: "+FSPEC);

                        //Console.WriteLine(listaCAT21[0].getCat(i)); //primer octeto tras el FSPEC

                        #region CAT21



                        ////Comprovamos cada campo para realizar las funciones
                        //if (FSPEC[0] == '1') 
                        //{
                        //    i= DataSourceIdentification(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i+1), i);
                        //}
                        //if (FSPEC[1] == '1')
                        //{
                        //    int result = 0;
                        //    while (result == 0) {
                        //        result = TargetReportDescriptor(listaCAT21[0].getCat(i), i);
                        //        i = i + 1;
                        //    }

                        //}
                        //if (FSPEC[2] == '1')
                        //{
                        //    i = TrackNumber(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), i);
                        //}
                        //if (FSPEC[3] == '1')
                        //{
                        //   i = ServiceIdentification(listaCAT21[0].getCat(i),  i);
                        //}
                        //if (FSPEC[4] == '1')
                        //{
                        //    i = Toap(listaCAT21[0].getCat(i), listaCAT21[0].getCat(i + 1), listaCAT21[0].getCat(i + 2), i);
                        //}
                        //if (FSPEC[5] == '1')
                        //{
                        //    i = PosWGS(listaCAT21[0], i);
                        //}
                        //if (FSPEC[6] == '1')
                        //{
                        //    i = PosWGSH(listaCAT21[0], i);
                        //}
                        //if (FSPEC.Length > 8)
                        //{
                        //    if (FSPEC[8] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[9] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[10] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[11] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[12] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[13] == '1')
                        //    {

                        //    }
                        //    if (FSPEC[14] == '1')
                        //    {

                        //    }
                        //    if (FSPEC.Length > 16)
                        //    {
                        //        if (FSPEC[16] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[17] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[18] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[19] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[20] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[21] == '1')
                        //        {

                        //        }
                        //        if (FSPEC[22] == '1')
                        //        {

                        //        }
                        //        if (FSPEC.Length > 24)
                        //        {
                        //            if (FSPEC[24] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[25] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[26] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[27] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[28] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[29] == '1')
                        //            {

                        //            }
                        //            if (FSPEC[30] == '1')
                        //            {

                        //            }
                        //            if (FSPEC.Length > 32)
                        //            {
                        //                if (FSPEC[32] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[33] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[34] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[35] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[36] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[37] == '1')
                        //                {

                        //                }
                        //                if (FSPEC[38] == '1')
                        //                {

                        //                }
                        //                if (FSPEC.Length > 40)
                        //                {
                        //                    if (FSPEC[40] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[41] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[42] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[43] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[44] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[45] == '1')
                        //                    {

                        //                    }
                        //                    if (FSPEC[46] == '1')
                        //                    {

                        //                    }
                        //                    //NO SE SI HAY 47
                        //                }
                        //            }
                        //        }
                        //    }
                        //}


                        //string SAC;
                        //string SIC1;
                        //string airport_code;


                        //int DataSourceIdentification(string oct1, string oct2, int i) {
                        //    SAC = Convert.ToString(Convert.ToInt32(oct1, 2));
                        //    int SIC = Convert.ToInt32(oct2, 2);
                        //    SIC1 = Convert.ToString(SIC);

                        //    //Decode
                        //    int airportcode = 0;
                        //    if (SIC == 107 || SIC == 7 || SIC == 219) { airportcode = 0; } //BARCELONA
                        //    else if (SIC == 5 || SIC == 105 || SIC == 209) { airportcode = 1; } //ASTURIAS
                        //    else if (SIC == 2 || SIC == 102) { airportcode = 2; } //PALMA
                        //    else if (SIC == 6 || SIC == 106 || SIC == 227 || SIC == 228) { airportcode = 3; } //SANTIAGO
                        //    else if (SIC == 3 || SIC == 4 || SIC == 104) { airportcode = 4; } //BARAJAS
                        //    else if (SIC == 1 || SIC == 101) { airportcode = 5; } //TENERIFE
                        //    else if (SIC == 108) { airportcode = 6; } //Malaga
                        //    else if (SIC == 203) { airportcode = 7; } //Bilbao
                        //    else if (SIC == 206) { airportcode = 8; } //ALICANTE
                        //    else if (SIC == 207) { airportcode = 9; } //GRANADA
                        //    else if (SIC == 210) { airportcode = 10; } //LANZAROTE
                        //    else if (SIC == 211) { airportcode = 11; } //TURRILLAS
                        //    else if (SIC == 212) { airportcode = 12; } //Menorca
                        //    else if (SIC == 213 || SIC == 229) { airportcode = 13; } //IBIZA
                        //    else if (SIC == 214) { airportcode = 14; } //VALDESPINA
                        //    else if (SIC == 215 || SIC == 221) { airportcode = 15; } //PARACUELLOS
                        //    else if (SIC == 216) { airportcode = 16; } //RANDA
                        //    else if (SIC == 218) { airportcode = 17; } //GERONA
                        //    else if (SIC == 220 || SIC == 222) { airportcode = 18; } //ESPIÑEIRAS
                        //    else if (SIC == 223) { airportcode = 19; } //VEJER
                        //    else if (SIC == 224) { airportcode = 20; } //YESTE
                        //    else if (SIC == 225 || SIC == 226) { airportcode = 21; } //VIGO
                        //    else if (SIC == 230) { airportcode = 22; } //VALENCIA
                        //    else if (SIC == 231) { airportcode = 23; } //SEVILLA
                        //    airport_code = Convert.ToString(airportcode);

                        //    i = i + 2;
                        //    return i;
                        //}

                        //string ATP;
                        //string ARC;
                        //string RC;
                        //string RAB;

                        //int TargetReportDescriptor(string oct1, int i)
                        //{
                        //    char[] Oct = oct1.ToCharArray();
                        //    int atp = Convert.ToInt32(string.Concat(Oct[0], Oct[1], Oct[2]), 2);
                        //    int arc = Convert.ToInt32(string.Concat(Oct[3], Oct[4]), 2);

                        //    ATP = atp switch
                        //    {
                        //        0 => "24-Bit ICAO address",
                        //        1 => ATP = "Duplicate address",
                        //        2 => "Surface vehicle address",
                        //        3 => "Anonymous address",
                        //        _ => "Reserved for future use",
                        //    };
                        //    ARC = arc switch
                        //    {
                        //        0 => "25 ft ",
                        //        1 => "100 ft",
                        //        2 => "Unknown",
                        //        _ => "Invalid",
                        //    };
                        //    string rc="";
                        //    if (Oct[5] == '0') { RC = "Default"; }
                        //    else { rc = "Range Check passed, CPR Validation pending"; }
                        //    RC = rc;
                        //    string rab = "";
                        //    if (Oct[6] == '0') { RAB = "Report from target transponder"; }
                        //    else { RAB = "Report from field monitor (fixed transponder)"; }
                        //    RAB = rab;
                        //    if (Oct[7] == '1')
                        //    {
                        //        return 0;
                        //    }
                        //    else {
                        //        return 1;
                        //    }
                        //}

                        //int PosWGS(CAT21 cat, int i) {
                        //    char[] Oct1 = cat.getCat(i).ToCharArray();
                        //    char[] Oct2 = cat.getCat(i+1).ToCharArray();
                        //    char[] Oct3 = cat.getCat(i + 2).ToCharArray();
                        //    char[] Oct4 = cat.getCat(i + 3).ToCharArray();
                        //    char[] Oct5 = cat.getCat(i + 4).ToCharArray();
                        //    char[] Oct6 = cat.getCat(i + 5).ToCharArray();

                        //    i = i + 6;
                        //    return i;
                        //}




                        #endregion


                        #region CAT10
                        //atributos del objeto CAT10



                        //public void CAT10_Decoding(string[] data_block_hexa)//, Decoding_Library decoding_library)
                        //{
                        //    string[] data_block_binary = Convert_HexadecimalDataBLock_To_BinaryDataBlock(data_block_hexa);

                        //    int i = 2;

                        //    i = Get_FSPEC(data_block_binary, i); //ERROR????? creo que no le gusta el nombre del argumento i


                        //    if (FSPEC_char[0] == '1') { i = Get_Message_Type(data_block_binary, i); }

                        //    if (FSPEC_char[1] == '1') { i = Get_Data_Source_Identifier(data_block_binary, i); }

                        //    if (FSPEC_char[2] == '1') { i = Get_Target_Report_Descriptor(data_block_binary, i); }

                        //    if (FSPEC_char[3] == '1') { i = Get_Measured_Position_in_Polar_Coordinates(data_block_binary, i); }

                        //    if (FSPEC_char[4] == '1') { i = Get_Position_in_WGS_84_Coordinates(data_block_binary, i); }

                        //    if (FSPEC_char[5] == '1') { i = Get_Position_in_Cartesian_Coordinates(data_block_binary, i); }

                        //    if (FSPEC_char[6] == '1') { i = Get_Mode_3A_Code_in_Octal_Representation(data_block_binary, i); }

                        //    if (FSPEC_char[7] == '1') //bit FX1
                        //    {
                        //        if (FSPEC_char[8] == '1') { i = Get_Flight_Level_in_Binary_Representation(data_block_binary, i); }

                        //        if (FSPEC_char[9] == '1') { i = Get_Measured_Height(data_block_binary, i); }

                        //        if (FSPEC_char[10] == '1') { i = Get_Amplitude_of_Primary_Plot(data_block_binary, i); }

                        //        if (FSPEC_char[11] == '1') { i = Get_Time_of_Day(data_block_binary, i); }

                        //        if (FSPEC_char[12] == '1') { i = Get_Track_Number(data_block_binary, i); }

                        //        if (FSPEC_char[13] == '1') { i = Get_Track_Status(data_block_binary, i); }

                        //        if (FSPEC_char[14] == '1') { i = Get_Calculated_Track_Velocity_in_Polar_Coordinates(data_block_binary, i); }

                        //        if (FSPEC_char[15] == '1')
                        //        {
                        //            if (FSPEC_char[16] == '1') { i = Get_Calculated_Track_Velocity_in_Cartesian_Coordinates(data_block_binary, i); }

                        //            if (FSPEC_char[17] == '1') { i = Get_Calculated_Acceleration(data_block_binary, i); }

                        //            if (FSPEC_char[18] == '1') { i = Get_Target_Address(data_block_binary, i); }

                        //            if (FSPEC_char[19] == '1') { i = Get_Target_Identification(data_block_binary, i); }

                        //            if (FSPEC_char[20] == '1') { i = Get_Mode_S_MB_Data(data_block_binary, i); }

                        //            if (FSPEC_char[21] == '1') { i = Get_Target_Size_and_Orientation(data_block_binary, i); }

                        //            if (FSPEC_char[22] == '1') { i = Get_Presence(data_block_binary, i); }

                        //            if (FSPEC_char[23] == '1')
                        //            {
                        //                if (FSPEC_char[24] == '1') { i = Get_Vehicle_Fleet_Identificatior(data_block_binary, i); }

                        //                if (FSPEC_char[25] == '1') { i = Get_Pre_Programmed_Message(data_block_binary, i); }

                        //                if (FSPEC_char[26] == '1') { i = Get_Standard_Deviation_Of_Position(data_block_binary, i); }

                        //                if (FSPEC_char[27] == '1') { i = Get_System_Status(data_block_binary, i); }

                        //            }

                        //        }

                        //    }
                        //}










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
//#endregion