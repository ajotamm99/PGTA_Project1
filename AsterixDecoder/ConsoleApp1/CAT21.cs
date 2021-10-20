using System;
using System.Collections.Generic;
using System.Text;

namespace AsterixDecoder
{
    class CAT21
    {
        String[] Data_block;
        char[] FSPEC_char;//Get_FSPEC
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

                            if (FSPEC_char[34] == '1') { i = Get_Met Information(data_block_binary, i); }

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

    }
}
