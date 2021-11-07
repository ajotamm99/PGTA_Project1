using System;
using System.Collections.Generic;
using System.Text;

namespace AsterixDecoder
{
    class CAT21
    {
        String[] Data_block;

        //Variables
        char[] FSPEC_char;//Get_FSPEC

        string RA;//Get_Aircraft_Operational_Status
        string TC;//Get_Aircraft_Operational_Status
        string TS;//Get_Aircraft_Operational_Status
        string ARV;//Get_Aircraft_Operational_Status
        string CDTI_A;//Get_Aircraft_Operational_Status
        string Not_TCAS;//Get_Aircraft_Operational_Status
        string SA;//Get_Aircraft_Operational_Status

        string SAC;
        string SIC;

        string Service_Identification; //Get_Service_Identification

        string RP;//Get_Service_Management

        string ECAT;

        string ATP;
        string ARC;
        string RC;
        string RAB;
        string DCR;
        string GBS;
        string SIM;
        string TST;
        string SAA;
        string CL;
        string IPC;
        string NOGO;
        string CPR;
        string LDPJ;
        string RCF;
        string FX;

        string Mode_3A_octal;

        string TOAP;

        string TOAV;

        string TOMRP;

        string TOMRP_HP;

        string Time_of_Applicability_For_Position_seconds; //Get_Time_Of_Applicability_For_Position
        string Time_of_Applicability_For_Position_HHMMSS; //Get_Time_Of_Applicability_For_Position

        string Time_of_Applicability_For_Velocity_seconds; //Get_Time_Of_Applicability_For_Velocity
        string Time_of_Applicability_For_Velocity_HHMMSS; //Get_Time_Of_Applicability_For_Velocity

        string Time_Of_Message_Reception_For_Position_seconds;//Get_Time_Of_Message_Reception_For_Position
        string Time_Of_Message_Reception_For_Position_HHMMSS;//Get_Time_Of_Message_Reception_For_Position

        string Time_of_Message_Reception_Position_High_Precision;//Get_Time_Of_Message_Reception_Of_Position_High_Precision

        string Time_Of_Message_Reception_For_Velocity_seconds;//Get_Time_Of_Message_Reception_For_Velocity
        string Time_Of_Message_Reception_For_Velocity_HHMMSS;//Get_Time_Of_Message_Reception_For_Velocity

        string Time_of_Message_Reception_Velocity_High_Precision;//Get_Time_Of_Message_Reception_Velocity_High_Precision

        string Time_Of_MASTERIX_Report_Transmission_seconds;//Get_Time_Of_ASTERIX_Report_Transmission
        string Time_Of_MASTERIX_Report_Transmission_HHMMSS;//Get_Time_Of_ASTERIX_Report_Transmission

        string Target_Address; //Get_Target_Adress

        public string NUCr_or_NACv;//Get_Quality_Indicators
        public string NUCp_or_NIC;//Get_Quality_Indicators
        public string NIC_BARO;//Get_Quality_Indicators
        public string SIL;//Get_Quality_Indicators
        public string NAC_P;//Get_Quality_Indicators
        public string SILS;//Get_Quality_Indicators
        public string SDA;//Get_Quality_Indicators
        public string GVA;//Get_Quality_Indicators
        public int PIC;//Get_Quality_Indicators
        public string ICB;//Get_Quality_Indicators
        public string NUC_P;//Get_Quality_Indicators
        public string NIC;//Get_Quality_Indicators


        public CAT21(String[] X)
        {
            this.Data_block = X;
        }


        public string Get_Data_Item(int v)
        {
            return Data_block[v];
        }

        public string[] Get_Data_Block()
        {
            return this.Data_block;
        }

        public char[] Get_FSPEC_char()
        {
            return this.FSPEC_char;
        }

        public void CAT21_Decoding(string[] data_block_hexa)//, Decoding_Library decoding_library)
        {
            string[] data_block_binary = Convert_HexadecimalDataBLock_To_BinaryDataBlock(data_block_hexa);

            int i = 2;

            i = Get_FSPEC(data_block_binary, i); //ERROR????? creo que no le gusta el nombre del argumento i


            if (FSPEC_char[0] == '1') { i = Get_Data_Source_Identification(data_block_binary, i); }

            if (FSPEC_char[1] == '1') { i = Get_Target_Report_Descriptor(data_block_binary, i); }

            if (FSPEC_char[2] == '1') { i = Get_Track_Number(data_block_binary, i); }

            if (FSPEC_char[3] == '1') { i = Get_Service_Identification(data_block_binary, i); }

            if (FSPEC_char[4] == '1') { i = Get_Time_Applicability_Position(data_block_binary, i); }

            if (FSPEC_char[5] == '1') { i = Get_Position_Wgs84(data_block_binary, i); }

            if (FSPEC_char[6] == '1') { i = Get_Position_Wgs84_High(data_block_binary, i); }

            if (FSPEC_char[7] == '1') //bit FX1
            {
                if (FSPEC_char[8] == '1') { i = Get_Time_Applicability_Velocity(data_block_binary, i); }

                if (FSPEC_char[9] == '1') { i = Get_Air_Speed(data_block_binary, i); }

                if (FSPEC_char[10] == '1') { i = Get_True_Air_Speed(data_block_binary, i); }

                if (FSPEC_char[11] == '1') { i = Get_Target_Address(data_block_binary, i); }

                if (FSPEC_char[12] == '1') { i = Get_Time_Message_Reception_Position(data_block_binary, i); }

                if (FSPEC_char[13] == '1') { i = Get_Time_Message_Reception_Position_High(data_block_binary, i); }

                if (FSPEC_char[14] == '1') { i = Get_Message_Reception_Velocity(data_block_binary, i); }

                if (FSPEC_char[15] == '1')
                {
                    if (FSPEC_char[16] == '1') { i = Get_Message_Reception_Velocity_High(data_block_binary, i); }

                    if (FSPEC_char[17] == '1') { i = Get_Geometric_Height(data_block_binary, i); }

                    if (FSPEC_char[18] == '1') { i = Get_Quality_Indicators(data_block_binary, i); }

                    if (FSPEC_char[19] == '1') { i = Get_MOPS_Version(data_block_binary, i); }

                    if (FSPEC_char[20] == '1') { i = Get_Mode_3A_Code(data_block_binary, i); }

                    if (FSPEC_char[21] == '1') { i = Get_Roll_Angle(data_block_binary, i); }

                    if (FSPEC_char[22] == '1') { i = Get_Flight_Level(data_block_binary, i); }

                    if (FSPEC_char[23] == '1')
                    {
                        if (FSPEC_char[24] == '1') { i = Get_Magnetic_Heading(data_block_binary, i); }

                        if (FSPEC_char[25] == '1') { i = Get_Targe_Status(data_block_binary, i); }

                        if (FSPEC_char[26] == '1') { i = Get_Barometric_Vertical_Rate(data_block_binary, i); }

                        if (FSPEC_char[27] == '1') { i = Get_Geometric_Vertical_Rate(data_block_binary, i); }

                        if (FSPEC_char[28] == '1') { i = Get_Airborne_Ground_Vector(data_block_binary, i); }

                        if (FSPEC_char[29] == '1') { i = Get_Track_Angle_Rate(data_block_binary, i); }

                        if (FSPEC_char[30] == '1') { i = Get_Time_Report_Transmission(data_block_binary, i); }

                        if (FSPEC_char[31] == '1')
                        {
                            if (FSPEC_char[32] == '1') { i = Get_Target_Identification(data_block_binary, i); }

                            if (FSPEC_char[33] == '1') { i = Get_Emitter_Category(data_block_binary, i); }

                            if (FSPEC_char[34] == '1') { i = Get_Met_Information(data_block_binary, i); }

                            if (FSPEC_char[35] == '1') { i = Get_Selected_Altitude(data_block_binary, i); }

                            if (FSPEC_char[36] == '1') { i = Get_Final_State_Selected_Altitude(data_block_binary, i); }

                            if (FSPEC_char[37] == '1') { i = Get_Trajectory_Intent(data_block_binary, i); }

                            if (FSPEC_char[38] == '1') { i = Get_Service_Management(data_block_binary, i); }

                            if (FSPEC_char[39] == '1')
                            {
                                if (FSPEC_char[40] == '1') { i = Get_Aircraft_Operational_Status(data_block_binary, i); }

                                if (FSPEC_char[41] == '1') { i = Get_Surface_Capabilities_Characteristics(data_block_binary, i); }

                                if (FSPEC_char[42] == '1') { i = Get_Message_Amplitude(data_block_binary, i); }

                                if (FSPEC_char[43] == '1') { i = Get_Mode_S_MB_Data(data_block_binary, i); }

                                if (FSPEC_char[44] == '1') { i = Get_ACAS_Resolution_Advisory_Report(data_block_binary, i); }

                                if (FSPEC_char[45] == '1') { i = Get_Receiver_Id(data_block_binary, i); }

                                if (FSPEC_char[46] == '1') { i = Get_Data_Ages(data_block_binary, i); }

                            }

                        }

                    }

                }
            }
        }

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
        public static string Convert_HexadecimalString_To_BinaryString(string hex)
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

        public string[] Convert_HexadecimalDataBLock_To_BinaryDataBlock(string[] HexadecimalDataBLock)
        {
            string[] BinaryDataBlock = new string[HexadecimalDataBLock.Length];
            int c = 0;
            while (c < HexadecimalDataBLock.Length)
            {
                BinaryDataBlock[c] = Convert_HexadecimalString_To_BinaryString(HexadecimalDataBLock[c]);
                c = c + 1;
            }
            return BinaryDataBlock;
        }

        public double A2_Complement_To_Decimal(string binari_number)
        {

            char[] binari_number_char = binari_number.ToCharArray();

            if (binari_number_char[0] == '0')
            {
                int decimal_number = Convert.ToInt32(binari_number, 2);
                return Convert.ToSingle(decimal_number);
            }

            else
            {
                string a2_number = "";
                int i = 1;

                while (i < binari_number.Length)
                {
                    if (binari_number_char[i] == '1') { a2_number += "0"; }

                    if (binari_number_char[i] == '0') { a2_number += "1"; }

                    i++;
                }

                double decimal_number = Convert.ToInt32(a2_number, 2);
                decimal_number = -decimal_number + 1;
                return decimal_number;
            }

        }

        public string Character_Decoding_Target_Identification(string character_coded)
        {
            string character_decoded = "";
            Char[] character_coded_char = character_coded.ToCharArray(0, 6);
            string code_b4_b3_b2_b1 = string.Concat(character_coded_char[3], character_coded_char[2], character_coded_char[1], character_coded_char[0]);
            string code_b6_b5 = string.Concat(character_coded_char[5], character_coded_char[4]);

            if (code_b4_b3_b2_b1 == "0000")
            {
                if (code_b6_b5 == "01") { character_decoded = "P"; }
                if (code_b6_b5 == "10") { character_decoded = "SP"; }
                if (code_b6_b5 == "11") { character_decoded = "0"; }
            }
            if (code_b4_b3_b2_b1 == "0001")
            {
                if (code_b6_b5 == "00") { character_decoded = "A"; }
                if (code_b6_b5 == "01") { character_decoded = "Q"; }
                if (code_b6_b5 == "11") { character_decoded = "1"; }
            }
            if (code_b4_b3_b2_b1 == "0010")
            {
                if (code_b6_b5 == "00") { character_decoded = "B"; }
                if (code_b6_b5 == "01") { character_decoded = "R"; }
                if (code_b6_b5 == "11") { character_decoded = "2"; }
            }
            if (code_b4_b3_b2_b1 == "0011")
            {
                if (code_b6_b5 == "00") { character_decoded = "C"; }
                if (code_b6_b5 == "01") { character_decoded = "S"; }
                if (code_b6_b5 == "11") { character_decoded = "3"; }
            }
            if (code_b4_b3_b2_b1 == "0100")
            {
                if (code_b6_b5 == "00") { character_decoded = "D"; }
                if (code_b6_b5 == "01") { character_decoded = "T"; }
                if (code_b6_b5 == "11") { character_decoded = "4"; }
            }
            if (code_b4_b3_b2_b1 == "0101")
            {
                if (code_b6_b5 == "00") { character_decoded = "E"; }
                if (code_b6_b5 == "01") { character_decoded = "U"; }
                if (code_b6_b5 == "11") { character_decoded = "5"; }
            }
            if (code_b4_b3_b2_b1 == "0110")
            {
                if (code_b6_b5 == "00") { character_decoded = "F"; }
                if (code_b6_b5 == "01") { character_decoded = "V"; }
                if (code_b6_b5 == "11") { character_decoded = "6"; }
            }
            if (code_b4_b3_b2_b1 == "0111")
            {
                if (code_b6_b5 == "00") { character_decoded = "G"; }
                if (code_b6_b5 == "01") { character_decoded = "W"; }
                if (code_b6_b5 == "11") { character_decoded = "7"; }
            }
            if (code_b4_b3_b2_b1 == "1000")
            {
                if (code_b6_b5 == "00") { character_decoded = "H"; }
                if (code_b6_b5 == "01") { character_decoded = "X"; }
                if (code_b6_b5 == "11") { character_decoded = "8"; }
            }
            if (code_b4_b3_b2_b1 == "1001")
            {
                if (code_b6_b5 == "00") { character_decoded = "I"; }
                if (code_b6_b5 == "01") { character_decoded = "Y"; }
                if (code_b6_b5 == "11") { character_decoded = "9"; }
            }
            if (code_b4_b3_b2_b1 == "1010")
            {
                if (code_b6_b5 == "00") { character_decoded = "J"; }
                if (code_b6_b5 == "01") { character_decoded = "Z"; }
            }
            if (code_b4_b3_b2_b1 == "1011")
            {
                if (code_b6_b5 == "00") { character_decoded = "K"; }
            }
            if (code_b4_b3_b2_b1 == "1100")
            {
                if (code_b6_b5 == "00") { character_decoded = "L"; }
            }
            if (code_b4_b3_b2_b1 == "1101")
            {
                if (code_b6_b5 == "00") { character_decoded = "M"; }
            }
            if (code_b4_b3_b2_b1 == "1110")
            {
                if (code_b6_b5 == "00") { character_decoded = "N"; }
            }
            if (code_b4_b3_b2_b1 == "1111")
            {
                if (code_b6_b5 == "00") { character_decoded = "O"; }
            }

            return character_decoded;
        }

        public string Convert_Decimal_To_Octal(string decimal_number)
        {
            string octal_number = "";
            int decValue, counter, i = 1, j;
            int[] octalValue = new int[80];
            decValue = 111;
            counter = decValue;
            while (counter != 0)
            {
                octalValue[i++] = counter % 8;
                counter /= 8;
            }
            for (j = i - 1; j > 0; j--)
                octal_number = octal_number + octalValue[j];
            return octal_number;
        }

        //Decoding_Library

        public int Get_FSPEC(string[] data_block_binary, int i)
        {
            string code_FX = "1";
            string FSPEC_string = "";
            while (code_FX == "1")
            {
                string octet = data_block_binary[i].PadLeft(8, '0');

                FSPEC_string = FSPEC_string + octet.Substring(0, 8); //el bit fx también lo añadimos

                code_FX = octet.Substring(7, 1);

                i = i + 1;
            }
            FSPEC_char = FSPEC_string.ToCharArray(0, FSPEC_string.Length);
            return i;
        }

        public int Get_Data_Source_Identification(string[] data_block, int i)
        {
            SAC = Convert.ToString(Convert.ToInt32(data_block[i], 2));
            SIC = Convert.ToString(Convert.ToInt32(data_block[i + 1], 2));
            i += 2;
            return i;
        }

        //Varible length 1/3 octets
        public int Get_Target_Report_Descriptor(string[] data_block, int i)
        {
            int code_ATP = Convert.ToInt32(data_block[i].Substring(0, 3), 2);
            if (code_ATP == 0){ this.ATP = "24-Bit ICAO address ";  }
            if (code_ATP == 1) { this.ATP = "Duplicate address "; }
            if (code_ATP == 2) { this.ATP = "Surface vehicle address"; }
            if (code_ATP == 3) { this.ATP = "Anonymous address"; }
            if (code_ATP >= 4 || code_ATP<= 7) { this.ATP = "Reserved for future use "; }
            Console.WriteLine("ATP="+this.ATP);

            int code_ARC= Convert.ToInt32(data_block[i].Substring(4, 2), 2);
            if (code_ARC == 0) { this.ARC = "25 ft"; }
            if (code_ARC == 1) { this.ARC = "100 ft "; }
            if (code_ARC == 2) { this.ARC = "Unknown"; }
            if (code_ARC == 3) { this.ARC = "Invalid"; }
            Console.WriteLine("ARC=" + this.ARC);

            string code_RC = data_block[i].Substring(5, 1);
            if (code_RC == "0") { this.RC = "Default"; }
            else { this.RC = "Range Check passed, CPR Validation pending"; }
            Console.WriteLine("RC=" + this.RC);

            string code_RAB = data_block[i].Substring(6, 1);
            if (code_RAB == "0") { this.RAB = "Report from target transponder"; }
            else { this.RAB = "Report from field monitor(fixed transponder) "; }
            Console.WriteLine("RAB=" + this.RAB);

            string code_FX = data_block[i].Substring(7, 1);
            int number_of_octets = 1;
            while (code_FX == "1")
            {
                if (number_of_octets == 1)
                { //FIRST EXTENT
                    string code_DCR = data_block[i+number_of_octets].Substring(0, 1);
                    if (code_DCR == "0") { this.DCR = "No differential correction (ADS-B)"; }
                    else { this.DCR = "Differential correction (ADS-B)"; }
                    Console.WriteLine("DCR=" + this.DCR);

                    string code_GBS = data_block[i].Substring(1, 1);
                    if (code_GBS == "0") { this.GBS = "Ground Bit not set "; }
                    else { this.GBS = "Ground Bit set "; }
                    Console.WriteLine("DCR=" + this.DCR);

                    string code_SIM = data_block[i].Substring(2, 1);
                    if (code_SIM == "0") { this.SIM = "Actual target report"; }
                    else { this.SIM = "Simulated target report"; }
                    Console.WriteLine("SIM=" + this.SIM);

                    string code_TST = data_block[i].Substring(3, 1);
                    if (code_TST == "0") { this.TST = "Default"; }
                    else { this.TST = "Test Target"; }
                    Console.WriteLine("TST=" + this.TST);

                    string code_SAA = data_block[i].Substring(4, 1);
                    if (code_SAA == "0") { this.SAA = "Equipment capable to provide Selected Altitude"; }
                    else { this.SAA = "Equipment not capable to provide Selected Altitude"; }
                    Console.WriteLine("SAA=" + this.SAA);

                    string code_CL = data_block[i].Substring(5, 2);
                    if (code_CL == "00") { this.CL = "Report valid "; }
                    if (code_CL == "01") { this.CL = "Report suspect"; }
                    if (code_CL == "10") { this.CL = "No information"; }
                    else { this.CL = "Reserved for future use"; }
                    Console.WriteLine("CL=" + this.CL);

                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }
                else
                { //SECOND EXTENT
                    
                    string code_IPC = data_block[i].Substring(2, 1);
                    if (code_IPC == "0") { this.IPC = "Independent Position Check default"; }
                    else { this.IPC = "Independent Position Check failed"; }
                    Console.WriteLine("IPC=" + this.IPC);

                    string code_NOGO = data_block[i].Substring(3, 1);
                    if (code_NOGO == "0") { this.NOGO = "NOGO-bit not set"; }
                    else { this.NOGO = "NOGO-bit set"; }
                    Console.WriteLine("NOGO=" + this.NOGO);

                    string code_CPR = data_block[i].Substring(4, 1);
                    if (code_CPR == "0") { this.CPR = "CPR Validation correct"; }
                    else { this.CPR = "CPR Validation failed"; }
                    Console.WriteLine("CPR=" + this.CPR);

                    string code_LDPJ = data_block[i].Substring(3, 1);
                    if (code_LDPJ == "0") { this.LDPJ = "LDPJ not detected "; }
                    else { this.LDPJ = "LDPJ detected"; }
                    Console.WriteLine("LDPJ=" + this.LDPJ);

                    string code_RCF = data_block[i].Substring(4, 1);
                    if (code_RCF == "0") { this.RCF = "Range Check default"; }
                    else { this.RCF = "Range Check failed"; }
                    Console.WriteLine("RCF=" + this.RCF);

                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }
                number_of_octets = number_of_octets + 1;

            }
            i = i + number_of_octets;
            return i;
        }





        public int Get_Track_Number(string[] data_block, int i)
        {

            return i;
        }

        //1 octet
        public int Get_Service_Identification(string[] data_block, int i)
        {
            this.Service_Identification = Convert.ToString(Convert.ToInt32(data_block[i], 2));
            Console.WriteLine("Service_Identification=" + this.Service_Identification);
            i = i + 1;
            return i;
        }

        public int Get_Time_Of_Applicability_For_Position(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("segundos totales" + segundos_totales);
            Time_of_Applicability_For_Position_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            Time_of_Applicability_For_Position_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            Console.WriteLine(Time_of_Applicability_For_Position_HHMMSS);
            Console.WriteLine("TIME OF THE DAY=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;
        }

        public int Get_Position_Wgs84(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Position_Wgs84_High(string[] data_block, int i)
        {

            return i;
        }
        //3 octets
        public int Get_Time_Applicability_Velocity(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("segundos totales" + segundos_totales);
            Time_of_Applicability_For_Velocity_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            Time_of_Applicability_For_Velocity_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            Console.WriteLine(Time_of_Applicability_For_Position_HHMMSS);
            Console.WriteLine("TIME OF THE DAY=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;
        }

        public int Get_Air_Speed(string[] data_block, int i)
        {

            return i;
        }

        public int Get_True_Air_Speed(string[] data_block, int i)
        {

            return i;
        }

        // 3 octets
        public int Get_Target_Address(string[] data_block, int i)
        {
            this.Target_Address = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]);
            Console.WriteLine("Target_Address: " + Target_Address);
            i = i + 3;
            return i;
        }

        public int Get_Time_Of_Message_Reception_For_Position(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("segundos totales" + segundos_totales);
            Time_Of_Message_Reception_For_Position_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            Time_Of_Message_Reception_For_Position_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            Console.WriteLine(Time_Of_Message_Reception_For_Position_HHMMSS);
            Console.WriteLine("TIME OF THE DAY=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;
        }

        //4 octets
        public int Get_Time_Of_Message_Reception_Of_Position_High_Precision(string[] data_block, int i)
        {
            string FSI = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3]).Substring(0, 2);
            string Time_binary = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3]).Substring(2, 30);

            double total_seconds = Convert.ToDouble(Convert.ToInt32(Time_binary, 2))* Math.Pow(2, -30);
            
            if (FSI == "10") { total_seconds= total_seconds-1; }
            if (FSI == "01") { total_seconds= total_seconds+1; }

            this.Time_of_Message_Reception_Position_High_Precision = Convert.ToString(total_seconds) + " s";
            i = i + 4;
            return i;
        }

        //3 octets
        public int Get_Time_Of_Message_Reception_For_Velocity(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("segundos totales" + segundos_totales);
            this.Time_Of_Message_Reception_For_Velocity_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            this.Time_Of_Message_Reception_For_Velocity_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            Console.WriteLine(Time_Of_Message_Reception_For_Velocity_HHMMSS);
            Console.WriteLine("TIME OF THE DAY=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;
        }

        //4 octets
        public int Get_Time_Of_Message_Reception_Velocity_High_Precision(string[] data_block, int i)
        {
            string FSI = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3]).Substring(0, 2);
            string Time_binary = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3]).Substring(2, 30);

            double total_seconds = Convert.ToDouble(Convert.ToInt32(Time_binary, 2)) * Math.Pow(2, -30);

            if (FSI == "10") { total_seconds = total_seconds - 1; }
            if (FSI == "01") { total_seconds = total_seconds + 1; }

            this.Time_of_Message_Reception_Velocity_High_Precision = Convert.ToString(total_seconds) + " s";
            i = i + 4;
            return i;
        }

        public int Get_Geometric_Height(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Quality_Indicators(string[] data_block, int i)
        {
            this.NUCr_or_NACv = Convert.ToString(Convert.ToInt32(data_block[i].Substring(0, 3), 2));
            this.NUCp_or_NIC= Convert.ToString(Convert.ToInt32(data_block[i].Substring(3, 4), 2));
            string code_FX= data_block[i].Substring(7, 1);

            int number_of_octets = 1;
            while (code_FX == "1")
            {
                if (number_of_octets == 1)
                { //FIRST EXTENT
                    this.NIC_BARO = Convert.ToString(Convert.ToInt32(data_block[i+number_of_octets].Substring(0, 1), 2));
                    Console.WriteLine("NIC_BARO=" + this.NIC_BARO);
                    this.SIL = Convert.ToString(Convert.ToInt32(data_block[i+number_of_octets].Substring(1, 2), 2));
                    Console.WriteLine("SIL=" + this.SIL);
                    this.NAC_P = Convert.ToString(Convert.ToInt32(data_block[i+number_of_octets].Substring(3, 4), 2));
                    Console.WriteLine("NAC_P=" + this.NAC_P);

                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }
                if (number_of_octets == 2)
                { //SECOND EXTENT
                    string code_SIL = data_block[i+number_of_octets].Substring(2, 1);
                    if (code_SIL == "0") { this.SIL = "measured per flight-hour"; }
                    else { this.SIL = "measured per sample"; }
                    Console.WriteLine("SIL=" + this.SIL);

                    this.SDA = Convert.ToString(Convert.ToInt32(data_block[i + number_of_octets].Substring(3, 2), 2));
                    Console.WriteLine("SDA=" + this.SDA);

                    this.GVA = Convert.ToString(Convert.ToInt32(data_block[i + number_of_octets].Substring(5, 2), 2));
                    Console.WriteLine("GVA=" + this.GVA);

                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }

                else
                { //THIRD EXTENT
                    this.PIC = Convert.ToInt32(data_block[i+number_of_octets].Substring(0, 4), 2);
                    if (PIC == 0) { this.ICB = "No integrity(or > 20.0 NM)"; this.NUC_P = "0"; this.NIC = "0"; }
                    if (PIC == 1) { this.ICB = "< 20.0 NM"; this.NUC_P = "1"; this.NIC = "1"; }
                    if (PIC == 2) { this.ICB = "< 10.0 NM"; this.NUC_P = "2"; this.NIC = "-"; }
                    if (PIC == 3) { this.ICB = "< 8.0 NM"; this.NUC_P = "-"; this.NIC = "2"; }
                    if (PIC == 4) { this.ICB = "< 4.0 NM"; this.NUC_P = "-"; this.NIC = "3"; }
                    if (PIC == 5) { this.ICB = "< 2.0 NM"; this.NUC_P = "3"; this.NIC = "4"; }
                    if (PIC == 6) { this.ICB = "< 1.0 NM"; this.NUC_P = "4"; this.NIC = "5"; }
                    if (PIC == 7) { this.ICB = "< 0.6 NM"; this.NUC_P = "-"; this.NIC = "6 (+ 1/1)"; }
                    if (PIC == 8) { this.ICB = "< 0.5 NM"; this.NUC_P = "5"; this.NIC = "6 (+ 0/0)"; }
                    if (PIC == 9) { this.ICB = "< 0.3 NM"; this.NUC_P = "-"; this.NIC = "6 (+ 0/1)"; }
                    if (PIC == 10) { this.ICB = "< 0.2 NM"; this.NUC_P = "6"; this.NIC = "7"; }
                    if (PIC == 11) { this.ICB = "< 0.1 NM"; this.NUC_P = "7"; this.NIC = "8"; }
                    if (PIC == 12) { this.ICB = "< 0.04 NM"; this.NUC_P = ""; this.NIC = "9"; }
                    if (PIC == 13) { this.ICB = "< 0.013 NM"; this.NUC_P = "8"; this.NIC = "10"; }
                    if (PIC == 14) { this.ICB = "< 0.004 NM"; this.NUC_P = "9"; this.NIC = "11"; }
                    if (PIC == 15) { this.ICB = "not defined"; this.NUC_P = "not defined"; this.NIC = "not defined"; }

                    Console.WriteLine("PIC=" + this.PIC);
                    Console.WriteLine("ICB=" + this.ICB);
                    Console.WriteLine("NUC_P=" + this.NUC_P);
                    Console.WriteLine("NIC=" + this.NIC);
                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }
                number_of_octets = number_of_octets + 1;

            }
            i = i + number_of_octets;
            return i;
        }
    }

        public int Get_MOPS_Version(string[] data_block, int i)
        {

            return i;
        }

        //2 octets
        public int Get_Mode_3A_Code_In_Octal_Representation(string[] data_block, int i)
        {
 
            this.Mode_3A_octal = Convert_Decimal_To_Octal(Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]).Substring(4, 12), 2))).PadLeft(4, '0'); //this.Mode_3A_octal
            Console.WriteLine("Mode_3A_octal=" + Mode_3A_octal);

            return i;
        }

        public int Get_Roll_Angle(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Flight_Level(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Magnetic_Heading(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Targe_Status(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Barometric_Vertical_Rate(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Geometric_Vertical_Rate(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Airborne_Ground_Vector(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Track_Angle_Rate(string[] data_block, int i)
        {

            return i;
        }
        //3 octets
        public int Get_Time_Of_ASTERIX_Report_Transmission(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("segundos totales" + segundos_totales);
            this.Time_Of_MASTERIX_Report_Transmission_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            this.Time_Of_MASTERIX_Report_Transmission_HHMMSS= Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            Console.WriteLine(Time_Of_MASTERIX_Report_Transmission_HHMMSS);
            Console.WriteLine("TIME OF THE DAY=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;

        }

        public int Get_Target_Identification(string[] data_block, int i)
        {

            return i;
        }

        //1 octet
        public int Get_Emitter_Category(string[] data_block, int i)
        {
            int code_ECAT = Convert.ToInt32(data_block[i], 2);

            if (code_ECAT == 0) { this.ECAT = "No ADS-B Emitter Category Information"; }
            if (code_ECAT == 1) { this.ECAT = "light aircraft <= 15500 lbs"; }
            if (code_ECAT == 2) { this.ECAT = "15500 lbs < small aircraft <75000 lbs"; }
            if (code_ECAT == 3) { this.ECAT = "75000 lbs < medium a/c < 300000 lbs"; }
            if (code_ECAT == 4) { this.ECAT = "High Vortex Large"; }
            if (code_ECAT == 5) { this.ECAT = "300000 lbs <= heavy aircraft "; }
            if (code_ECAT == 6) { this.ECAT = "highly manoeuvrable (5g acceleration capability) and high speed(> 400 knots cruise)";}
            if (code_ECAT >= 7 || code_ECAT <= 9) { this.ECAT = "reserved"; }
            if (code_ECAT == 10) { this.ECAT = "rotocraft"; }
            if (code_ECAT == 11) { this.ECAT = "glider / sailplane"; }
            if (code_ECAT == 12) { this.ECAT = "lighter-than-air"; }
            if (code_ECAT == 13) { this.ECAT = "unmanned aerial vehicle"; }
            if (code_ECAT == 14) { this.ECAT = "space / transatmospheric vehicle"; }
            if (code_ECAT == 15) { this.ECAT = "ultralight / handglider / paraglider "; }
            if (code_ECAT == 16) { this.ECAT = "parachutist / skydiver"; }
            if (code_ECAT >= 17 || code_ECAT <= 19) { ECAT = "reserved"; }
            if (code_ECAT == 20) { this.ECAT = "surface emergency vehicle "; }
            if (code_ECAT == 21) { this.ECAT = "surface service vehicle "; }
            if (code_ECAT == 22) { this.ECAT = "fixed ground or tethered obstruction "; }
            if (code_ECAT == 23) { this.ECAT = "cluster obstacle "; }
            if (code_ECAT == 24) { this.ECAT = "line obstacle"; }
            
            i=i+1;
            return i;
        }

        public int Get_Met_Information(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Selected_Altitude(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Final_State_Selected_Altitude(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Trajectory_Intent(string[] data_block, int i)
        {

            return i;
        }

        //1 octet
        public int Get_Service_Management(string[] data_block, int i)
        {
            this.RP = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.5) + " s";
            i = i + 1;
            return i;
        }

        //1 octet
        public int Get_Aircraft_Operational_Status(string[] data_block, int i)
        {
            string code_RA = data_block[i].Substring(0, 1);
            if (code_RA == "0") { this.RA= "TCAS II or ACAS RA not active"; Console.WriteLine("RA= TCAS II or ACAS RA not active"); }
            else { this.RA = "TCAS RA active"; Console.WriteLine("RA=TCAS RA active"); }

            string code_TC = data_block[i].Substring(1, 2);
            if (code_TC == "00") { this.TC = "no capability for trajectory Change Reports"; Console.WriteLine("TC = No capability for trajectory Change Reports"); }
            if (code_TC == "01") { this.TC = "support fot TC+0 reports only"; Console.WriteLine("TC = Support fot TC+0 reports only"); }
            if (code_TC == "10") { this.TC = "support for multiple TC reports"; Console.WriteLine("TC = Support for multiple TC reports"); }
            if (code_TC == "11") { this.TC = "reserved"; Console.WriteLine("TC = reserved"); }

            string code_TS = data_block[i].Substring(3, 1);
            if (code_TS == "0") { this.TS = "no capability to support Target State Reports "; Console.WriteLine("TS=no capability to support Target State Reports "); }
            else { this.TS = "TCAS RA active"; Console.WriteLine("TS=capable of supporting target State Reports "); }

            string code_ARV = data_block[i].Substring(4, 1);
            if (code_ARV == "0") { this.ARV = "no capability to generate ARV-reports"; Console.WriteLine("ARV=no capability to generate ARV-reports"); }
            else { this.ARV = "capable of generate ARV-reports"; Console.WriteLine("ARV=capable of generate ARV-reports"); }

            string code_CDTI_A = data_block[i].Substring(5, 1);
            if (code_CDTI_A == "0") { this.CDTI_A = "CDTI not operational"; Console.WriteLine("CDTI=CDTI not operational"); }//this.TYP
            else { this.CDTI_A = "CDTI operational"; Console.WriteLine("CDTI=CDTI operational"); }

            string code_Not_TCAS = data_block[i].Substring(6, 1);
            if (code_Not_TCAS == "0") { this.Not_TCAS = "TCAS operational"; Console.WriteLine("TCAS=TCAS operational "); }//this.TYP
            else { this.Not_TCAS = "TCAS not operational"; Console.WriteLine("TCAS=TCAS not operational "); }

            string code_SA = data_block[i].Substring(6, 1);
            if (code_SA == "0") { this.SA = "Antenna Diversity"; Console.WriteLine("SA=Antenna Diversity"); }//this.TYP
            else { this.SA = "Single Antenna only "; Console.WriteLine("RA=Single Antenna only "); }

            i = i + 1;

            return i;
        }

        public int Get_Surface_Capabilities_Characteristics(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Message_Amplitude(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Mode_S_MB_Data(string[] data_block, int i)
        {

            return i;
        }

        public int Get_ACAS_Resolution_Advisory_Report(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Receiver_Id(string[] data_block, int i)
        {

            return i;
        }

        public int Get_Data_Ages(string[] data_block, int i)
        {

            return i;
        }

    }
}
