using System;
using System.Collections.Generic;
using System.Text;

namespace AsterixDecoder
{
    class CAT10
    {
        String[] Data_block;
        char[] FSPEC_char;//Get_FSPEC

        string Message_Type; // Get_Message_Type;

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

        string Latitude_WGS84;//Get_Position_in_WGS_84_Coordinates
        string Longitude_WGS84;//Get_Position_in_WGS_84_Coordinates

        string X; //Get_Position_in_Cartesian_Coordinates
        string Y; //Get_Position_in_Cartesian_Coordinates

        string V_Mode3A; //Get_Mode_3A_Code_in_Octal_Representation
        string G_Mode3A; //Get_Mode_3A_Code_in_Octal_Representation
        string L_Mode3A; //Get_Mode_3A_Code_in_Octal_Representation
        string Mode_3A_octal; //Get_Mode_3A_Code_in_Octal_Representation

        string V_Flight_Level; //Get_Flight_Level_in_Binary_Representation
        string G_Flight_Level; //Get_Flight_Level_in_Binary_Representation
        string Flight_Level; //Get_Flight_Level_in_Binary_Representation

        string Measured_Height; //Get_Measured_Height

        string PAM; //Get_Amplitude_of_Primary_Plot

        string Time_of_Day_seconds; //Compute_Time_of_Day
        string Time_of_Day_HHMMSS; //Compute_Time_of_Day

        string Track_Number; //Get_Track_Number

        string CNF; //Get_Track_Status
        string TRE; //Get_Track_Status
        string CST; //Get_Track_Status
        string MAH; //Get_Track_Status
        string TCC; //Get_Track_Status
        string STH; //Get_Track_Status
        string TOM; //Get_Track_Status
        string DOU; //Get_Track_Status
        string MRS; //Get_Track_Status
        string GHO; //Get_Track_Status

        string Ground_Speed; //Get_Calculated_Track_Velocity_in_Polar_Coordinates
        string Track_Angle; //Get_Calculated_Track_Velocity_in_Polar_Coordinates

        string Vx; //Get_Calculated_Track_Velocity_in_Cartesian_Coordinates
        string Vy; //Get_Calculated_Track_Velocity_in_Cartesian_Coordinates

        string Ax; //Get_Calculated_Acceleration
        string Ay; //Get_Calculated_Acceleration

        string Target_Address; //Get_Target_Address

        string STI; //Get_Target_Identification
        string Target_Identification; //Get_Target_Identification

        string[] MB_Data; //Get_Mode_S_MB_Data
        string[] BDS1; //Get_Mode_S_MB_Data
        string[] BDS2; //Get_Mode_S_MB_Data
        string modeS_rep; //Get_Mode_S_MB_Data

        string Lenght; //Get_Target_Size_and_Orientation
        string Orientation; //Get_Target_Size_and_Orientation
        string Width; //Get_Target_Size_and_Orientation

        string[] DRHO; //Get_Presence
        string[] DTHETA; //Get_Presence

        string VFI; //Get_Vehicle_Fleet_Identificatior

        string TRB; //Get_Pre_programmed_Message
        string MSG; //Get_Pre_programmed_Message

        string Standard_Deviation_X; //Get_Standard_Deviation_Of_Position
        string Standard_Deviation_Y; //Get_Standard_Deviation_Of_Position
        string Covariance_XY_2C; //Get_Standard_Deviation_Of_Position

        string NOGO; //Get_System_Status
        string OVL; //Get_System_Status
        string TSV; //Get_System_Status
        string DIV; //Get_System_Status
        string TTF; //Get_System_Status


        //CONSTRUCTORS
        public CAT10(String[] X)
        {
            this.Data_block = X;
        }

        //GETS
        public string[] Get_Data_Block() 
        {
            return this.Data_block;
        }
        public string Get_Data_Item(int v)
        {
            return this.Data_block[v];
        }
        public char[] Get_FSPEC_char()
        {
            return this.FSPEC_char;
        }


        public void CAT10_Decoding(string[] data_block_hexa)//, Decoding_Library decoding_library)
        {
            string[] data_block_binary = Convert_HexadecimalDataBLock_To_BinaryDataBlock(data_block_hexa);

            int i = 2;

            i = Get_FSPEC(data_block_binary, i); //ERROR????? creo que no le gusta el nombre del argumento i


            if (FSPEC_char[0] == '1') { i = Get_Message_Type(data_block_binary, i); }

            if (FSPEC_char[1] == '1') { i = Get_Data_Source_Identifier(data_block_binary, i); }

            if (FSPEC_char[2] == '1') { i = Get_Target_Report_Descriptor(data_block_binary, i); }

            if (FSPEC_char[3] == '1') { i = Get_Measured_Position_in_Polar_Coordinates(data_block_binary, i); }

            if (FSPEC_char[4] == '1') { i = Get_Position_in_WGS_84_Coordinates(data_block_binary, i); }

            if (FSPEC_char[5] == '1') { i = Get_Position_in_Cartesian_Coordinates(data_block_binary, i); }

            if (FSPEC_char[6] == '1') { i = Get_Mode_3A_Code_in_Octal_Representation(data_block_binary, i); }

            if (FSPEC_char[7] == '1') //bit FX1
            {
                if (FSPEC_char[8] == '1') { i = Get_Flight_Level_in_Binary_Representation(data_block_binary, i); }

                if (FSPEC_char[9] == '1') { i = Get_Measured_Height(data_block_binary, i); }

                if (FSPEC_char[10] == '1') { i = Get_Amplitude_of_Primary_Plot(data_block_binary, i); }

                if (FSPEC_char[11] == '1') { i = Get_Time_of_Day(data_block_binary, i); }

                if (FSPEC_char[12] == '1') { i = Get_Track_Number(data_block_binary, i); }

                if (FSPEC_char[13] == '1') { i = Get_Track_Status(data_block_binary, i); }

                if (FSPEC_char[14] == '1') { i = Get_Calculated_Track_Velocity_in_Polar_Coordinates(data_block_binary, i); }

                if (FSPEC_char[15] == '1')
                {
                    if (FSPEC_char[16] == '1') { i = Get_Calculated_Track_Velocity_in_Cartesian_Coordinates(data_block_binary, i); }

                    if (FSPEC_char[17] == '1') { i = Get_Calculated_Acceleration(data_block_binary, i); }

                    if (FSPEC_char[18] == '1') { i = Get_Target_Address(data_block_binary, i); }

                    if (FSPEC_char[19] == '1') { i = Get_Target_Identification(data_block_binary, i); }

                    if (FSPEC_char[20] == '1') { i = Get_Mode_S_MB_Data(data_block_binary, i); }

                    if (FSPEC_char[21] == '1') { i = Get_Target_Size_and_Orientation(data_block_binary, i); }

                    if (FSPEC_char[22] == '1') { i = Get_Presence(data_block_binary, i); }

                    if (FSPEC_char[23] == '1')
                    {
                        if (FSPEC_char[24] == '1') { i = Get_Vehicle_Fleet_Identificatior(data_block_binary, i); }

                        if (FSPEC_char[25] == '1') { i = Get_Pre_Programmed_Message(data_block_binary, i); }

                        if (FSPEC_char[26] == '1') { i = Get_Standard_Deviation_Of_Position(data_block_binary, i); }

                        if (FSPEC_char[27] == '1') { i = Get_System_Status(data_block_binary, i); }

                    }

                }

            }
        }
        ////Estas tambien iran a Decoding_Library, pero por ahora las dejo separadas porque son de tipología distinta
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

        //1 octet
        public int Get_Message_Type(string[] data_block, int i)
        {
            int data = Convert.ToInt32(data_block[i], 2);
            Console.WriteLine("data_MessageType=" + data);
            if (data == 1) { Console.WriteLine("Target Report"); } //this.Message_Type = 
            if (data == 2) { Console.WriteLine("Start of Update Cycle"); }
            if (data == 3) { Console.WriteLine("Periodic Status Message"); }
            if (data == 4) { Console.WriteLine("Event-triggered Status Message"); }
            i = i + 1;
            return i;
        }

        //2 octets
        public int Get_Data_Source_Identifier(string[] data_block, int i)
        {
            SAC = Convert.ToString(Convert.ToInt32(data_block[i], 2));
            SIC = Convert.ToString(Convert.ToInt32(data_block[i + 1], 2));
            i = i + 2;
            Console.WriteLine("SAC=" + SAC);

            Console.WriteLine("SIC=" + SIC);
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

            string code_FX = octet1.Substring(7, 1);

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
            this.RHO = Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]), 2));
            this.Theta = Convert.ToString(Convert.ToInt32(string.Concat(data_block[i + 2], data_block[i + 3]), 2) * (360 / (Math.Pow(2, 16))));

            i = i + 4;
            return i;
        } //incomplete
        //8 octets
        public int Get_Position_in_WGS_84_Coordinates(string[] data_block, int i)
        {
            this.Latitude_WGS84 = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3])) * (180 / (Math.Pow(2, 31))));
            this.Longitude_WGS84 = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i + 4], data_block[i + 5], data_block[i + 6], data_block[i + 3])) * (180 / (Math.Pow(2, 31))));
            i = i + 8;
           
            return i;
        } //incomplete

        public int Get_Position_in_Cartesian_Coordinates(string[] data_block, int i)
        {
            this.X = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i], data_block[i + 1])));
            this.Y = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i + 2], data_block[i + 3])));

            return i + 1;
        }

        //2 octets
        public int Get_Mode_3A_Code_in_Octal_Representation(string[] data_block, int i) //incomplete
        {
            string octets = string.Concat(data_block[i], data_block[i + 1]);

            string code_V = octets.Substring(0, 1);
            if (code_V == "0") { this.V_Mode3A = "Code validated"; }
            else { this.V_Mode3A = "Code not validated"; }

            string code_G = octets.Substring(1, 1);
            if (code_G == "0") { this.G_Mode3A = "Default"; }
            else { this.G_Mode3A = "Garbled code"; }

            string code_L = octets.Substring(0, 1);
            if (code_L == "0") { this.L_Mode3A = "Mode-3/A code derived from the reply of the transponder"; }
            else { this.L_Mode3A = "Mode-3/A code not extracted during the last scan"; }

            string code_Mode3A = octets.Substring(4, 12);
            this.Mode_3A_octal = Convert.ToString(Convert_Decimal_To_Octal(Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]).Substring(4, 12), 2)))).PadLeft(4, '0');

            i = i + 2;
            return i;
        }

        //2 octets
        public int Get_Flight_Level_in_Binary_Representation(string[] data_block, int i)
        {
            string octets = string.Concat(data_block[i], data_block[i + 1]);
            i = i + 2;

            string code_V = octets.Substring(0, 1);
            if (code_V == "0") { this.V_Flight_Level = "Code validated"; }
            else { this.V_Flight_Level = "Code not validated"; }

            string code_G = octets.Substring(1, 1);
            if (code_G == "0") { this.G_Flight_Level = "Default"; }
            else { this.G_Flight_Level = "Garbled code"; }

            string code_Flight_Level = octets.Substring(2, 14);

            Flight_Level = Convert.ToString(A2_Complement_To_Decimal(code_Flight_Level) * (0.25));

            return i;
        }

        //2 octets
        public int Get_Measured_Height(string[] data_block, int i)
        {
            this.Measured_Height = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i], data_block[i + 1])) * 6.25) + " ft";
            i = i + 2;
            return i;
        }

        //1 octet
        public int Get_Amplitude_of_Primary_Plot(string[] data_block, int i)
        {
            this.PAM = Convert.ToString(Convert.ToInt32(data_block[i], 2));
            i = i + 1;
            return i;
        }

        //3 octets
        public int Get_Time_of_Day(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            double segundos_totales = (Convert.ToDouble(data_decimal) * (1 / 128));
            this.Time_of_Day_seconds = Convert.ToString(segundos_totales);

            double segundos = segundos_totales % 60;
            double aux = segundos_totales / 60;
            double minutos = aux % 60;
            double horas = aux / 60;

            this.Time_of_Day_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);

            i = i + 3;
            return i;
        }

        //2 octets 
        public int Get_Track_Number(string[] data_block, int i)
        {
            this.Track_Number = Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]).Substring(4, 12), 2));
            i = i + 2;
            return i;
        }

        //VARIABLE (1octet + 2 opcionals)
        public int Get_Track_Status(string[] data_block, int i)
        {
            //STRUCTURE OF FIRST PART
            int number_of_octets = 1;
            string octet1 = data_block[i];

            string code_CNF = octet1.Substring(0, 1);
            if (code_CNF == "0") { this.CNF = "Confirmed track"; }
            else { this.CNF = "Track in initialisation phase"; }

            string code_TRE = octet1.Substring(1, 1);
            if (code_TRE == "0") { this.CNF = "Default"; }
            else { this.TRE = "Last report for a track"; }

            string code_CST = octet1.Substring(2, 2);
            if (code_CST == "00") { this.CST = "No extrapolation"; }
            if (code_CST == "01") { this.CST = "Predictable extrapolation due to sensor refresh period"; }
            if (code_CST == "10") { this.CST = "Predictable extrapolation in masked area"; }
            if (code_CST == "11") { this.CST = "Extrapolation due to unpredictable absence of detection"; }

            string code_MAH = octet1.Substring(4, 1);
            if (code_MAH == "0") { this.MAH = "Default"; }
            else { this.MAH = "Horizontal manoeuvre"; }

            string code_TCC = octet1.Substring(5, 1);
            if (code_TCC == "0") { this.TCC = "Tracking performed in 'Sensor Plane', i.e. neither slant range correction nor projection was applied"; }
            else { this.TCC = "Slant range correction and a suitable projection technique are used to track in a 2D.reference plane, tangential to the earth model at the Sensor Site co-ordinates"; }

            string code_STH = octet1.Substring(4, 1);
            if (code_STH == "0") { this.STH = "Measured position"; }
            else { this.STH = "Smoothed position"; }

            string code_FX = octet1.Substring(7, 1);


            while (code_FX == "1")
            {
                string octet = data_block[i + number_of_octets];

                if (number_of_octets == 1) //STRUCTURE OF FIRST EXTENT
                {
                    string code_TOM = octet.Substring(0, 2);
                    if (code_TOM == "00") { this.TOM = "Unknown type of movement "; }
                    if (code_TOM == "01") { this.TOM = "Taking-off"; }
                    if (code_TOM == "10") { this.TOM = "Landing"; }
                    if (code_TOM == "11") { this.TOM = "Other types of movement"; }

                    string code_DOU = octet.Substring(2, 3);
                    if (code_DOU == "000") { this.DOU = "No doubt"; }
                    if (code_DOU == "001") { this.DOU = "Doubtful correlation (undetermined reason)"; }
                    if (code_DOU == "010") { this.DOU = "Doubtful correlation in clutter"; }
                    if (code_DOU == "011") { this.DOU = "Loss of accuracy"; }
                    if (code_DOU == "100") { this.DOU = "Loss of accuracy in clutter"; }
                    if (code_DOU == "101") { this.DOU = "Unstable track"; }
                    if (code_DOU == "110") { this.DOU = "Previously coasted"; }

                    string code_MRS = octet.Substring(5, 2);
                    if (code_MRS == "00") { this.MRS = "Merge or split indication undetermined"; }
                    if (code_MRS == "01") { this.MRS = "Track merged by association to plot"; }
                    if (code_MRS == "10") { this.MRS = "Track merged by non-association to plot"; }
                    if (code_MRS == "11") { this.MRS = "Split track"; }

                }

                else //STRUCTURE OF SECOND EXTENT
                {
                    string code_GHO = octet.Substring(0, 1);
                    if (code_GHO == "0") { this.GHO = "Default"; }
                    else { this.GHO = "Ghost track"; }

                }
                code_FX = octet.Substring(7, 1);
                number_of_octets = number_of_octets + 1;
            }
            i = i + number_of_octets;
            return i;
        }

        //4 octets
        public int Get_Calculated_Track_Velocity_in_Polar_Coordinates(string[] data_block, int i)
        {
            double gs = Convert.ToDouble(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]), 2)) * Math.Pow(2, -14); // in NM
            if (gs > 2) { gs = 2; } //OR ERROR???
            this.Ground_Speed = Convert.ToString(gs);

            this.Track_Angle = Convert.ToString(Convert.ToInt32(string.Concat(data_block[i + 2], data_block[i + 3]), 2) * (360 / (Math.Pow(2, 16))));

            i = i + 4;
            return i;
        }

        //4 octets
        public int Get_Calculated_Track_Velocity_in_Cartesian_Coordinates(string[] data_block, int i)
        {
            this.Vx = Convert.ToString((A2_Complement_To_Decimal(string.Concat(data_block[i], data_block[i + 1])) * 0.25));

            this.Vy = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i + 2], data_block[i + 3])) * 0.25);

            i = i + 4;
            return i;
        }

        //2 octets
        public int Get_Calculated_Acceleration(string[] data_block, int i)
        {
            this.Ax = Convert.ToString(A2_Complement_To_Decimal(data_block[i]) * 0.25);
            this.Ay = Convert.ToString(A2_Complement_To_Decimal(data_block[i + 1]) * 0.25);
            i = i + 2;
            return i;
        }

        //3 octets
        public int Get_Target_Address(string[] data_block, int i)
        {
            this.Target_Address = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]);
            i = i + 3;
            return i;
        }

        //7 octets
        public int Get_Target_Identification(string[] data_block, int i) //incomplete, mirar atenea
        {
            string data = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3], data_block[i + 4], data_block[i + 5], data_block[i + 6]);
            string code_STI = data.Substring(0, 2);
            if (code_STI == "00") { this.STI = "Callsign or registration downlinked from transponder"; }
            if (code_STI == "01") { this.STI = "Callsign not downlinked from transponder"; }
            if (code_STI == "10") { this.STI = "Registration not downlinked from transponder"; }

            string character1 = Character_Decoding_Target_Identification(data.Substring(8, 6));
            string character2 = Character_Decoding_Target_Identification(data.Substring(14, 6));
            string character3 = Character_Decoding_Target_Identification(data.Substring(20, 2));
            string character4 = Character_Decoding_Target_Identification(data.Substring(26, 2));
            string character5 = Character_Decoding_Target_Identification(data.Substring(32, 2));
            string character6 = Character_Decoding_Target_Identification(data.Substring(38, 2));
            string character7 = Character_Decoding_Target_Identification(data.Substring(44, 2));
            string character8 = Character_Decoding_Target_Identification(data.Substring(50, 2));

            this.Target_Identification = string.Concat(character1, character2, character3, character4, character5, character6, character7, character8);

            i = i + 7;
            return i;
        }

        public int Get_Mode_S_MB_Data(string[] data_block, int i)
        {
            int code_modeS_rep = Convert.ToInt32(data_block[i], 2);
            this.ModeS_Rep = Convert.ToString(code_modeS_rep);

            for (int c = 0; i < code_modeS_rep; i++)
            {
                this.MB_Data[c] = String.Concat(data_block[i + 1], data_block[i + 2], data_block[i + 3], data_block[i + 4], data_block[i + 5], data_block[i + 6], data_block[i + 7]);
                this.BDS1[c] = data_block[i + 8].Substring(0, 4);
                this.BDS2[c] = data_block[i + 8].Substring(4, 4);
                i = i + 9;
            }
            return i;
        }

        public int Get_Target_Size_and_Orientation(string[] data_block, int i)
        {
            this.Lenght = Convert.ToString(Convert.ToInt32(data_block[i].Substring(0, 7), 2));
            string code_FX = data_block[i].Substring(7, 1);
            int number_of_octets = 1;
            while (code_FX == "1")
            {
                if (number_of_octets == 1)
                { //FIRST EXTENT
                    this.Orientation = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i + number_of_octets].Substring(0, 7), 2)) * (360 / 128));
                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }
                else
                { //SECOND EXTENT
                    this.Width = Convert.ToString(Convert.ToInt32(data_block[i + number_of_octets].Substring(0, 7), 2));
                    code_FX = data_block[i + number_of_octets].Substring(7, 1);
                }
                number_of_octets = number_of_octets + 1;

            }
            i = i + number_of_octets;
            return i;
        }

        public int Get_Presence(string[] data_block, int i)
        {
            int code_REP = Convert.ToInt32(data_block[i], 2);
            i = i + 1;

            int c = 0;
            while (c < code_REP)
            {
                this.DRHO[c] = Convert.ToString(Convert.ToInt32(data_block[i], 2));
                this.DTHETA[c] = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i + 1], 2)) * 0.15);
                i = i + 2;
                c = c + 1;
            }
            return i;
        }

        //1 octet
        public int Get_Vehicle_Fleet_Identificatior(string[] data_block, int i)
        {
            int code_vfi = Convert.ToInt32(data_block[i], 2);
            if (code_vfi == 0) { this.VFI = "Unknown"; }
            if (code_vfi == 1) { this.VFI = "ATC equipment maintenance"; }
            if (code_vfi == 2) { this.VFI = "Airport maintenance"; }
            if (code_vfi == 3) { this.VFI = "Fire"; }
            if (code_vfi == 4) { this.VFI = "Bird scarer"; }
            if (code_vfi == 5) { this.VFI = "Snow plough"; }
            if (code_vfi == 6) { this.VFI = "Runway sweeper"; }
            if (code_vfi == 7) { this.VFI = "Emergency"; }
            if (code_vfi == 8) { this.VFI = "Police"; }
            if (code_vfi == 9) { this.VFI = "Bus"; }
            if (code_vfi == 10) { this.VFI = "Tug (push/tow)"; }
            if (code_vfi == 11) { this.VFI = "Grass cutter"; }
            if (code_vfi == 12) { this.VFI = "Fuel"; }
            if (code_vfi == 13) { this.VFI = "Baggage"; }
            if (code_vfi == 14) { this.VFI = "Catering"; }
            if (code_vfi == 15) { this.VFI = "Aircraft maintenance"; }
            if (code_vfi == 16) { this.VFI = "Flyco (follow me)"; }
            i = i + 1;
            return i;
        }

        //1 octet
        public int Get_Pre_Programmed_Message(string[] data_block, int i)
        {
            string code_TRB = data_block[i].Substring(0, 1);
            if (code_TRB == "0") { this.TRB = "Trouble: Default"; }
            else { this.TRB = "Trouble: In Trouble"; }

            int code_MSG = Convert.ToInt32(data_block[i].Substring(1, 7), 2);
            if (code_MSG == 1) { this.MSG = "Towing aircraft"; }
            if (code_MSG == 2) { this.MSG = "Follow me” operation"; }
            if (code_MSG == 3) { this.MSG = "Runway check"; }
            if (code_MSG == 4) { this.MSG = "Emergency operation (fire, medical…)"; }
            if (code_MSG == 5) { this.MSG = "Work in progress (maintenance, birds scarer, sweepers…)"; }
            i = i + 1;
            return i;
        }

        //4 octets
        public int Get_Standard_Deviation_Of_Position(string[] data_block, int i)
        {
            this.Standard_Deviation_X = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.25);
            this.Standard_Deviation_Y = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i + 1], 2)) * 0.25);
            this.Covariance_XY_2C = Convert.ToString(A2_Complement_To_Decimal(string.Concat(data_block[i + 2], data_block[i + 3])) * 0.25);
            i = i + 4;
            return i;
        }

        //1 octet
        public int Get_System_Status(string[] data_block, int i)
        {
            string code_NOGO = data_block[i].Substring(0, 2);
            if (code_NOGO == "00") { this.NOGO = "Operational"; }
            if (code_NOGO == "01") { this.NOGO = "Degraded"; }
            if (code_NOGO == "10") { this.NOGO = "NOGO"; }

            string code_OVL = data_block[i].Substring(2, 1);
            if (code_OVL == "0") { this.OVL = "No overload"; }
            else { this.OVL = "Overload"; }

            string code_TSV = data_block[i].Substring(3, 1);
            if (code_TSV == "0") { this.TSV = "valid"; }
            else { this.TSV = "invalid"; }

            string code_DIV = data_block[i].Substring(4, 1);
            if (code_DIV == "0") { this.DIV = "Normal operation"; }
            else { this.DIV = "Diversity degraded"; }

            string code_TTF = data_block[i].Substring(5, 1);
            if (code_TTF == "0") { this.TTF = "Test Target Operative"; }
            else { this.TTF = "Test Target Failure"; }


            i = i + 1;
            return i;
        }
    }

}
