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

        string Track_Number;//Get_Track_Number

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

        string NUCr_or_NACv;//Get_Quality_Indicators
        string NUCp_or_NIC;//Get_Quality_Indicators
        string NIC_BARO;//Get_Quality_Indicators
        string SIL;//Get_Quality_Indicators
        string NAC_P;//Get_Quality_Indicators
        string SILS;//Get_Quality_Indicators
        string SDA;//Get_Quality_Indicators
        string GVA;//Get_Quality_Indicators
        string PIC;//Get_Quality_Indicators
        string ICB;//Get_Quality_Indicators
        string NUC_P;//Get_Quality_Indicators
        string NIC;//Get_Quality_Indicators

        string TIS;//Get_Trajectory_Intent
        string TID;//Get_Trajectory_Intent
        string NAV;//Get_Trajectory_Intent
        string NVB;//Get_Trajectory_Intent
        string REP;//Get_Trajectory_Intent
        string[] TCA;//Get_Trajectory_Intent
        string[] NC;//Get_Trajectory_Intent
        string[] TCP;//Get_Trajectory_Intent
        string[] Altitude;//Get_Trajectory_Intent
        string[] Latitude;//Get_Trajectory_Intent
        string[] Longitude;//Get_Trajectory_Intent
        string[] Point_Type;//Get_Trajectory_Intent
        string[] TD;//Get_Trajectory_Intent
        string[] TRA;//Get_Trajectory_Intent
        string[] TOA;//Get_Trajectory_Intent
        string[] TOV;//Get_Trajectory_Intent
        string[] TTR;//Get_Trajectory_Intent

        string Latitude_WGS84_Coordinates;//Get_Position_In_WGS84_Coordinates
        string Longitude_WGS84_Coordinates;//Get_Position_In_WGS84_Coordinates

        string Latitude_WGS84_Coordinates_High_Precision;//Get_Position_In_WGS84_Coordinates_High_Precision
        string Longitude_WGS84_Coordinates_High_Precision;//Get_Position_In_WGS84_Coordinates_High_Precision

        string MAM;//Get_Message_Amplitude

        string Geometric_Height;//Get_Geometric_Height

        string SAS;//Get_Selected_Altitude
        string Source;//Get_Selected_Altitude
        string Selected_Altitude;//Get_Selected_Altitude

        string MV;//Get_Final_State_Selected_Altitude
        string AH;//Get_Final_State_Selected_Altitude
        string AM;//Get_Final_State_Selected_Altitude
        string Final_State_Selected_Altitude;//Get_Final_State_Selected_Altitude

        string Flight_Level;//Get_Flight_Level

        string IM;//Get_Air_Speed
        string Air_Speed;//Get_Air_Speed

        string RE_True_AirSpeed;//Get_True_AirSpeed
        string True_AirSpeed;//Get_True_AirSpeed

        string RE_Barometric_Vertical_Rate;//Get_Barometric_Vertical_Rate
        string Barometric_Vertical_Rate;//Get_Barometric_Vertical_Rate

        string RE_Geometric_Vertical_Rate;//Get_Geometric_Vertical_Rate
        string Geometric_Vertical_Rate;//Get_Geometric_Vertical_Rate

        string RE_Airborne_Ground_Vector;//Get_Airborne_Ground_Vector
        string Ground_Speed;//Get_Airborne_Ground_Vector
        string Track_Angle;//Get_Airborne_Ground_Vector

        string Target_Identification;//Get_Target_Identification

        string ICF;//Get_Target_Status
        string LNAV;//Get_Target_Status
        string PS;//Get_Target_Status
        string SS;//Get_Target_Status

        string VNS;//Get_MOPS_Version
        string VN;//Get_MOPS_Version
        string LTT;//Get_MOPS_Version

        string WS;//Get_Met_Information
        string WD;//Get_Met_Information
        string TMP;//Get_Met_Information
        string TRB;//Get_Met_Information
        string Wind_Speed;//Get_Met_Information
        string Wind_Direction;//Get_Met_Information
        string Temperature;//Get_Met_Information
        string Turbulence;//Get_Met_Information

        string Roll_Angle;//Get_Roll_Angle

        string TAR;//Get_Track_Angle_Rate

        string Magnetic_Heading;//Get_Magnetic_Heading

        string ModeS_Rep;//Get_Mode_S_MB_Data
        string[] MB_Data;//Get_Mode_S_MB_Data
        string[] BDS1;//Get_Mode_S_MB_Data
        string[] BDS2;//Get_Mode_S_MB_Data

        string TYP;//Get_ACAS_Resolution_Advisory_Report
        string STYP;//Get_ACAS_Resolution_Advisory_Report
        string ARA;//Get_ACAS_Resolution_Advisory_Report
        string RAC;//Get_ACAS_Resolution_Advisory_Report
        string RAT;//Get_ACAS_Resolution_Advisory_Report
        string MTE;//Get_ACAS_Resolution_Advisory_Report
        string TTI;//Get_ACAS_Resolution_Advisory_Report
        string TID_ACAS;//Get_ACAS_Resolution_Advisory_Report

        string POA;//Get_Surface_Capabilities_Characteristics
        string CDTI_S;//Get_Surface_Capabilities_Characteristics
        string B2_low;//Get_Surface_Capabilities_Characteristics
        string RAS;//Get_Surface_Capabilities_Characteristics
        string IDENT;//Get_Surface_Capabilities_Characteristics
        string Length_And_Width;//Get_Surface_Capabilities_Characteristics

        string AOS_Data_Age;//Get_Data_Ages
        string TRD_Data_Age;//Get_Data_Ages
        string M3A_Data_Age;//Get_Data_Ages
        string QI_Data_Age;//Get_Data_Ages
        string Trajectory_Intent_Data_Age;//Get_Data_Ages
        string MAM_Data_Age;//Get_Data_Ages
        string GH_Data_Age;//Get_Data_Ages
        string FL_Data_Age;//Get_Data_Ages
        string ISA_Data_Age;//Get_Data_Ages
        string FSA_Data_Age;//Get_Data_Ages
        string AS_Data_Age;//Get_Data_Ages
        string TAS_Data_Age;//Get_Data_Ages
        string MH_Data_Age;//Get_Data_Ages
        string BVR_Data_Age;//Get_Data_Ages
        string GVR_Data_Age;//Get_Data_Ages
        string GV_Data_Age;//Get_Data_Ages
        string TAR_Data_Age;//Get_Data_Ages
        string Target_Identification_Data_Age;//Get_Data_Ages
        string TS_Data_Age;//Get_Data_Ages
        string MET_Data_Age;//Get_Data_Ages
        string ROA_Data_Age;//Get_Data_Ages
        string ARA_Data_Age;//Get_Data_Ages
        string SCC_Data_Age;//Get_Data_Ages

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

            if (FSPEC_char[4] == '1') { i = Get_Time_Of_Applicability_For_Position(data_block_binary, i); }

            if (FSPEC_char[5] == '1') { i = Get_Position_In_WGS84_Coordinates(data_block_binary, i); }

            if (FSPEC_char[6] == '1') { i = Get_Position_In_WGS84_Coordinates_High_Precision(data_block_binary, i); }

            if (FSPEC_char[7] == '1') //bit FX1
            {
                if (FSPEC_char[8] == '1') { i = Get_Time_Applicability_Velocity(data_block_binary, i); }

                if (FSPEC_char[9] == '1') { i = Get_Air_Speed(data_block_binary, i); }

                if (FSPEC_char[10] == '1') { i = Get_True_AirSpeed(data_block_binary, i); }

                if (FSPEC_char[11] == '1') { i = Get_Target_Address(data_block_binary, i); }

                if (FSPEC_char[12] == '1') { i = Get_Time_Of_Message_Reception_For_Position(data_block_binary, i); }

                if (FSPEC_char[13] == '1') { i = Get_Time_Of_Message_Reception_Of_Position_High_Precision(data_block_binary, i); }

                if (FSPEC_char[14] == '1') { i = Get_Time_Of_Message_Reception_For_Velocity(data_block_binary, i); }

                if (FSPEC_char[15] == '1')
                {
                    if (FSPEC_char[16] == '1') { i = Get_Time_Of_Message_Reception_Velocity_High_Precision(data_block_binary, i); }

                    if (FSPEC_char[17] == '1') { i = Get_Geometric_Height(data_block_binary, i); }

                    if (FSPEC_char[18] == '1') { i = Get_Quality_Indicators(data_block_binary, i); }

                    if (FSPEC_char[19] == '1') { i = Get_MOPS_Version(data_block_binary, i); }

                    if (FSPEC_char[20] == '1') { i = Get_Mode_3A_Code_In_Octal_Representation(data_block_binary, i); }

                    if (FSPEC_char[21] == '1') { i = Get_Roll_Angle(data_block_binary, i); }

                    if (FSPEC_char[22] == '1') { i = Get_Flight_Level(data_block_binary, i); }

                    if (FSPEC_char[23] == '1')
                    {
                        if (FSPEC_char[24] == '1') { i = Get_Magnetic_Heading(data_block_binary, i); }

                        if (FSPEC_char[25] == '1') { i = Get_Target_Status(data_block_binary, i); }

                        if (FSPEC_char[26] == '1') { i = Get_Barometric_Vertical_Rate(data_block_binary, i); }

                        if (FSPEC_char[27] == '1') { i = Get_Geometric_Vertical_Rate(data_block_binary, i); }

                        if (FSPEC_char[28] == '1') { i = Get_Airborne_Ground_Vector(data_block_binary, i); }

                        if (FSPEC_char[29] == '1') { i = Get_Track_Angle_Rate(data_block_binary, i); }

                        if (FSPEC_char[30] == '1') { i = Get_Time_Of_ASTERIX_Report_Transmission(data_block_binary, i); }

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
            this.SAC = Convert.ToString(Convert.ToInt32(data_block[i], 2));
            this.SIC = Convert.ToString(Convert.ToInt32(data_block[i + 1], 2));
            i = i + 2;
            Console.WriteLine("SIC=" + this.SIC);
            Console.WriteLine("SAC=" + this.SAC);
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

        
        //2 octets
        public int Get_Track_Number(string[] data_block, int i)
        {
            this.Track_Number = Convert.ToString(Convert.ToInt32(String.Concat(data_block[i].Substring(4, 4), data_block[i + 1]),2));
            Console.WriteLine("Track_Number=" + Track_Number);
            i = i + 2;
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
            //Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("Get_Time_Of_Applicability_For_Position(segundos totales)" + segundos_totales);
            this.Time_of_Applicability_For_Position_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            this.Time_of_Applicability_For_Position_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            Console.WriteLine(Time_of_Applicability_For_Position_HHMMSS);
            Console.WriteLine("Get_Time_Of_Applicability_For_Position=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;
        }

       
        //6 octets
        public int Get_Position_In_WGS84_Coordinates(string[] data_block, int i)
        {
            this.Latitude_WGS84_Coordinates = Convert.ToString(Convert.ToDouble(A2_Complement_To_Decimal(String.Concat(data_block[i], data_block[i + 1], data_block[i + 2])))* (180 / (Math.Pow(2, 23))));
            this.Longitude_WGS84_Coordinates = Convert.ToString(Convert.ToDouble(A2_Complement_To_Decimal(String.Concat(data_block[i+3], data_block[i + 4], data_block[i + 5]))) * (180 / (Math.Pow(2, 23))));
            Console.WriteLine("Latitude_WGS84_Coordinates" + this.Latitude_WGS84_Coordinates);
            Console.WriteLine("Longitude_WGS84_Coordinates" + this.Longitude_WGS84_Coordinates);
            i = i + 6;
            return i;
        }
        
        //8 octets
        public int Get_Position_In_WGS84_Coordinates_High_Precision(string[] data_block, int i)
        {
            this.Latitude_WGS84_Coordinates_High_Precision = Convert.ToString(Convert.ToDouble(A2_Complement_To_Decimal(String.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3]))) * (180 / (Math.Pow(2, 30))));
            this.Longitude_WGS84_Coordinates_High_Precision = Convert.ToString(Convert.ToDouble(A2_Complement_To_Decimal(String.Concat(data_block[i + 4], data_block[i + 5], data_block[i + 6], data_block[i + 7]))) * (180 / (Math.Pow(2, 30))));
            
            Console.WriteLine("Latitude_WGS84_Coordinates_High_Precision" + this.Latitude_WGS84_Coordinates_High_Precision);
            Console.WriteLine("Latitude_WGS84_Coordinates_High_Precision" + this.Latitude_WGS84_Coordinates_High_Precision);
            i = i + 8;
            return i;
        }
        //3 octets
        public int Get_Time_Applicability_Velocity(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            //Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            //Console.WriteLine("segundos totales" + segundos_totales);
            this.Time_of_Applicability_For_Velocity_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            this.Time_of_Applicability_For_Velocity_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            //Console.WriteLine(this.Time_of_Applicability_For_Position_HHMMSS);
            Console.WriteLine("Get_Time_Applicability_Velocity=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;
        }

        
        //2 octets
        public int Get_Air_Speed(string[] data_block, int i)
        {
            string code_IM = data_block[i].Substring(0, 1);
            if (code_IM == "0") { this.IM = "IAS"; }
            else { this.IM = "Mach"; }

            if (this.Air_Speed == "IAS") { this.Air_Speed = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i].Substring(1, 7), data_block[i + 1]), 2)) * Math.Pow(2, -14)); }

            else { this.Air_Speed = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i].Substring(1, 7), data_block[i + 1]), 2)) * 0.001); }

            Console.WriteLine("IM=" + this.IM);
            Console.WriteLine("Air_Speed=" + this.Air_Speed);
            return i;
        }

        
        //2 octets
        public int Get_True_AirSpeed(string[] data_block, int i)
        {
            string code_RE = data_block[i].Substring(0, 1);
            if (code_RE == "0") { this.RE_True_AirSpeed = "Value in defined range"; }
            else { this.RE_True_AirSpeed = "Value exceeds defined range"; }

            this.True_AirSpeed = Convert.ToString(Convert.ToInt32(String.Concat(data_block[i].Substring(1, 7), data_block[i + 1]), 2)) + " ft";

            Console.WriteLine("RE=" + this.RE_True_AirSpeed);
            Console.WriteLine("True_AirSpeed=" + this.True_AirSpeed);
            i = i + 2;
            return i;
        }

        // 3 octets
        public int Get_Target_Address(string[] data_block, int i)
        {
            this.Target_Address = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]);
            Console.WriteLine("Target_Address: " + this.Target_Address);
            i = i + 3;
            return i;
        }

        public int Get_Time_Of_Message_Reception_For_Position(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            Console.WriteLine("segundos totales" + segundos_totales);
            this.Time_Of_Message_Reception_For_Position_seconds = Convert.ToString(segundos_totales);//this.Time_of_Day_seconds

            //double segundos = segundos_totales % 60;
            //double aux = segundos_totales / 60;
            //double minutos = aux % 60;
            //double horas = aux / 60;

            int horas = Convert.ToInt32(segundos_totales / 3600);
            float rest = segundos_totales % 3600;
            int minutos = Convert.ToInt32(rest / 60);
            float segundos = rest % 60;

            this.Time_Of_Message_Reception_For_Position_HHMMSS = Convert.ToString(horas) + ":" + Convert.ToString(minutos) + ":" + Convert.ToString(segundos);
            //Console.WriteLine(Time_Of_Message_Reception_For_Position_HHMMSS);
            Console.WriteLine("Time_Of_Message_Reception_For_Position_seconds=" + Convert.ToString(segundos_totales));
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

            Console.Write("Time_of_Message_Reception_Position_High_Precision=" + this.Time_of_Message_Reception_Position_High_Precision);
            i = i + 4;
            return i;
        }

        //3 octets
        public int Get_Time_Of_Message_Reception_For_Velocity(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            //Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            //Console.WriteLine("segundos totales" + segundos_totales);
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
            //Console.WriteLine(Time_Of_Message_Reception_For_Velocity_HHMMSS);
            Console.WriteLine("Time_Of_Message_Reception_For_Velocity_HHMMSS=" + Convert.ToString(segundos_totales));
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
            Console.WriteLine("Time_of_Message_Reception_Velocity_High_Precision=" + Time_of_Message_Reception_Velocity_High_Precision);
            i = i + 4;
            return i;
        }

        
        //2 octets
        public int Get_Geometric_Height(string[] data_block, int i)
        {
            this.Geometric_Height = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2)) * 6.25 + " ft");
            Console.Write("Geometric_Height=" + this.Geometric_Height);
            i = i + 2;
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
                    int code_PIC = Convert.ToInt32(data_block[i+number_of_octets].Substring(0, 4), 2);
                    this.PIC = Convert.ToString(code_PIC);
                    if (code_PIC == 0) { this.ICB = "No integrity(or > 20.0 NM)"; this.NUC_P = "0"; this.NIC = "0"; }
                    if (code_PIC == 1) { this.ICB = "< 20.0 NM"; this.NUC_P = "1"; this.NIC = "1"; }
                    if (code_PIC == 2) { this.ICB = "< 10.0 NM"; this.NUC_P = "2"; this.NIC = "-"; }
                    if (code_PIC == 3) { this.ICB = "< 8.0 NM"; this.NUC_P = "-"; this.NIC = "2"; }
                    if (code_PIC == 4) { this.ICB = "< 4.0 NM"; this.NUC_P = "-"; this.NIC = "3"; }
                    if (code_PIC == 5) { this.ICB = "< 2.0 NM"; this.NUC_P = "3"; this.NIC = "4"; }
                    if (code_PIC == 6) { this.ICB = "< 1.0 NM"; this.NUC_P = "4"; this.NIC = "5"; }
                    if (code_PIC == 7) { this.ICB = "< 0.6 NM"; this.NUC_P = "-"; this.NIC = "6 (+ 1/1)"; }
                    if (code_PIC == 8) { this.ICB = "< 0.5 NM"; this.NUC_P = "5"; this.NIC = "6 (+ 0/0)"; }
                    if (code_PIC == 9) { this.ICB = "< 0.3 NM"; this.NUC_P = "-"; this.NIC = "6 (+ 0/1)"; }
                    if (code_PIC == 10) { this.ICB = "< 0.2 NM"; this.NUC_P = "6"; this.NIC = "7"; }
                    if (code_PIC == 11) { this.ICB = "< 0.1 NM"; this.NUC_P = "7"; this.NIC = "8"; }
                    if (code_PIC == 12) { this.ICB = "< 0.04 NM"; this.NUC_P = ""; this.NIC = "9"; }
                    if (code_PIC == 13) { this.ICB = "< 0.013 NM"; this.NUC_P = "8"; this.NIC = "10"; }
                    if (code_PIC == 14) { this.ICB = "< 0.004 NM"; this.NUC_P = "9"; this.NIC = "11"; }
                    if (code_PIC == 15) { this.ICB = "not defined"; this.NUC_P = "not defined"; this.NIC = "not defined"; }

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

        //1 octet
        public int Get_MOPS_Version(string[] data_block, int i)
        {
            string code_VNS = data_block[i].Substring(1, 1);
            if (code_VNS == "0") { this.VNS = "The MOPS Version is supported by the GS"; }
            else { this.VNS = "The MOPS Version is not supported by the GS"; }

            string code_VN = data_block[i].Substring(2, 2);
            if (code_VN == "00") { this.VN = "ED102/DO-260 [Ref. 8]"; }
            if (code_VN == "01") { this.VN = "DO-260A [Ref. 9] "; }
            else { this.VN = "ED102A/DO-260B [Ref. 11]"; }

            int code_LTT = Convert.ToInt32(data_block[i].Substring(5, 3), 2);
            if (code_LTT == 0) { this.LTT = "Other"; }
            if (code_LTT == 1) { this.LTT = "UAT"; }
            if (code_LTT == 2) { this.LTT = "1090 ES "; }
            if (code_LTT == 3) { this.LTT = "VDL 4"; }
            else { this.LTT = "Not assigned"; }

            Console.WriteLine("VNS=" + this.VNS);
            Console.WriteLine("VN=" + this.VN);
            Console.WriteLine("LTT=" + this.LTT);
            i = i + 1;
            return i;
        }

        //2 octets
        public int Get_Mode_3A_Code_In_Octal_Representation(string[] data_block, int i)
        {
 
            this.Mode_3A_octal = Convert_Decimal_To_Octal(Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]).Substring(4, 12), 2))).PadLeft(4, '0'); //this.Mode_3A_octal
            Console.WriteLine("Mode_3A_octal=" + Mode_3A_octal);

            return i;
        }
        
        //2 octets
        public int Get_Roll_Angle(string[] data_block, int i)
        {
            this.Roll_Angle = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2)) * 0.01)+"º";
            Console.WriteLine("Roll_Angle=" + this.Roll_Angle);
            i = i + 2;
            return i;
        }
        
        //2 octets
        public int Get_Flight_Level(string[] data_block, int i)
        {
            this.Flight_Level = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2)) * 0.25);
            Console.Write("Flight_Level=" + this.Flight_Level);
            i = i + 2;
            return i;
        }
        
        //2 octets  
        public int Get_Magnetic_Heading(string[] data_block, int i)
        {
            this.Magnetic_Heading = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]),2))*(360/Math.Pow(2,16)));
            Console.WriteLine("Magnetic_Heading" + this.Magnetic_Heading);
            i = i + 2;
            return i;
        }
        
        //1 octet
        public int Get_Target_Status(string[] data_block, int i)
        {
            string code_ICF = data_block[i].Substring(0, 1);
            if (code_ICF == "0") { this.ICF = "No intent change active"; }
            else { this.ICF = "Intent change flag raised"; }

            string code_LNAV = data_block[i].Substring(1, 1);
            if (code_ICF == "0") { this.LNAV = "LNAV Mode engaged"; }
            else { this.LNAV = "LNAV Mode not engaged"; }

            int code_PS = Convert.ToInt32(data_block[i].Substring(3, 3), 2);
            if (code_PS == 0) { this.PS = "No emergency / not reported"; }
            if (code_PS == 1) { this.PS = "General emergency"; }
            if (code_PS == 2) { this.PS = "Lifeguard / medical emergency"; }
            if (code_PS == 3) { this.PS = "Minimum fuel"; }
            if (code_PS == 4) { this.PS = "No communications"; }
            if (code_PS == 5) { this.PS = "Unlawful interference"; }
            else { PS = "'Downed' Aircraft"; }

            string code_SS = data_block[i].Substring(6, 2);
            if (code_SS == "00") { this.SS = "No condition reported"; }
            if (code_SS == "01") { this.SS = "Permanent Alert (Emergency condition)"; }
            if (code_SS == "10") { this.SS = "Temporary Alert (change in Mode 3/A Code other than emergency)"; }
            else { SS = "SPI set"; }

            i = i + 1;

            Console.WriteLine("ICF=" + this.ICF);
            Console.WriteLine("LNAV=" + this.LNAV);
            Console.WriteLine("PS=" + this.PS);
            Console.WriteLine("SS=" + this.SS);

            return i;
        }
        //2 octets
        public int Get_Barometric_Vertical_Rate(string[] data_block, int i)
        {
            string code_RE = data_block[i].Substring(0, 1);
            if (code_RE == "0") { this.RE_Barometric_Vertical_Rate = "Value in defined range"; }
            else { this.RE_Barometric_Vertical_Rate = "Value exceeds defined range"; }

            this.Barometric_Vertical_Rate = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i].Substring(1, 7), data_block[i + 1]), 2)) * 6.25)+" ft/min";
            
            Console.WriteLine("RE_Barometric_Vertical_Rate=" + this.RE_Barometric_Vertical_Rate);
            Console.WriteLine("Barometric_Vertical_Rate="+this.Barometric_Vertical_Rate);
            i=i+2;
            return i;
        }
        
        //2 octets
        public int Get_Geometric_Vertical_Rate(string[] data_block, int i)
        {
            string code_RE = data_block[i].Substring(0, 1);
            if (code_RE == "0") { this.RE_Geometric_Vertical_Rate = "Value in defined range"; }
            else { this.RE_Geometric_Vertical_Rate = "Value exceeds defined range"; }

            this.Geometric_Vertical_Rate  = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i].Substring(1, 7), data_block[i + 1]), 2)) * 6.25) + " ft/min";

            Console.WriteLine("RE_Geometric_Vertical_Rate=" + this.RE_Geometric_Vertical_Rate);
            Console.WriteLine("Geometric_Vertical_Rate=" + this.Geometric_Vertical_Rate);

            i = i + 2;
            return i;
        }

        //4 octets
        public int Get_Airborne_Ground_Vector(string[] data_block, int i)
        {
            string code_RE = data_block[i].Substring(0, 1);
            if (code_RE == "0") { this.RE_Airborne_Ground_Vector = "Value in defined range"; }
            else { this.RE_Airborne_Ground_Vector = "Value exceeds defined range"; }
            Console.WriteLine("RE_Airborne_Ground_Vector" + this.RE_Airborne_Ground_Vector);

            this.Ground_Speed = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i].Substring(1, 7), data_block[i + 1]), 2)) * 0.22) + " kts";
            Console.WriteLine("Ground_Speed" + this.Ground_Speed);

            this.Track_Angle = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i+2], data_block[i + 3]), 2)) * (360/Math.Pow(2,16))) + " º";
            Console.WriteLine("Track_Angle" + this.Track_Angle);

            i = i + 4;
            return i;
        }
        
        //2 octets
        public int Get_Track_Angle_Rate(string[] data_block, int i)
        {
            this.TAR = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i].Substring(6, 2), data_block[i + 1]),2))*(1/32))+" º/s";
            Console.WriteLine("TAR="+this.TAR);
            i = i + 2;
            return i;
        }
        //3 octets
        public int Get_Time_Of_ASTERIX_Report_Transmission(string[] data_block, int i)
        {
            int data_decimal = Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2);
            //Console.WriteLine("data-decimal" + data_decimal);
            float segundos_totales = Convert.ToSingle((data_decimal) * (1 / 128.0));
            //Console.WriteLine("segundos totales" + segundos_totales);
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
            //Console.WriteLine(Time_Of_MASTERIX_Report_Transmission_HHMMSS);
            Console.WriteLine("Time_Of_MASTERIX_Report_Transmission_HHMMSS=" + Convert.ToString(segundos_totales));
            i = i + 3;
            return i;

        }
        
        //6 octets
        public int Get_Target_Identification(string[] data_block, int i)
        {
            string data = string.Concat(data_block[i], data_block[i + 1], data_block[i + 2], data_block[i + 3], data_block[i + 4], data_block[i + 5]);

            string character1 = Character_Decoding_Target_Identification(data.Substring(0, 6));
            string character2 = Character_Decoding_Target_Identification(data.Substring(6, 6));
            string character3 = Character_Decoding_Target_Identification(data.Substring(12, 6));
            string character4 = Character_Decoding_Target_Identification(data.Substring(18, 6));
            string character5 = Character_Decoding_Target_Identification(data.Substring(24, 6));
            string character6 = Character_Decoding_Target_Identification(data.Substring(30, 6));
            string character7 = Character_Decoding_Target_Identification(data.Substring(36, 6));
            string character8 = Character_Decoding_Target_Identification(data.Substring(42, 6));

            this.Target_Identification = string.Concat(character1, character2, character3, character4, character5, character6, character7, character8);
            Console.WriteLine("Target Idnetification: " + Target_Identification);

            i = i + 6;
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

            Console.WriteLine("ECAT="+this.ECAT);
            i=i+1;
            return i;
        }
        

        //Varible
        public int Get_Met_Information(string[] data_block, int i)
        {
            this.WS = data_block[i].Substring(0, 1);
            this.WD = data_block[i].Substring(1, 1);
            this.TMP = data_block[i].Substring(2, 1);
            this.TRB = data_block[i].Substring(3, 1);
            i = i + 1;
            if (this.WS == "1") //SUBFIELD 1
            {
                this.Wind_Speed = Convert.ToString(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2))+" kt";
                i = i + 1;
            }
            if (this.WD == "1") //SUBFIELD 2
            {
                this.Wind_Direction = Convert.ToString(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2))+ "º";
                i = i + 1;
            }
            if (this.TMP == "1") //SUBFIELD 3
            {
                this.Temperature = Convert.ToString(Convert.ToDouble(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2))*0.25)+" ºC";
                i = i + 1;
            }
            if (this.TRB == "1") //SUBFIELD 4
            {
                this.Turbulence = Convert.ToString(Convert.ToInt32(String.Concat(data_block[i], data_block[i + 1]), 2));
                i = i + 1;
            }
            return i;
        }
        
        //2 octets
        public int Get_Selected_Altitude(string[] data_block, int i)
        {
            string code_SAS = data_block[i].Substring(0, 1);
            if (code_SAS == "0") { this.SAS = "No source information provided"; }
            else { this.SAS = "Source Information provided"; }
            Console.WriteLine("SAS=" + this.SAS);

            string code_Source = data_block[i].Substring(1, 2);
            if (code_Source == "00") { this.Source = "Unknown"; }
            if (code_Source == "01") { this.Source = "Aircraft Altitude (Holding Altitude)"; }
            if (code_Source == "10") { this.Source = "MCP/FCU Selected Altitude"; }
            else { this.Source = "FMS Selected Altitude "; }
            Console.WriteLine("Source=" + this.Source);

            this.Selected_Altitude= Convert.ToString(A2_Complement_To_Decimal(String.Concat(data_block[i].Substring(3, 5),data_block[i+1]))*25)+" ft";
            Console.WriteLine("Selected_Altitude=" + this.Selected_Altitude);
            i = i + 2;

            return i;
        }

        
        //2 octets
        public int Get_Final_State_Selected_Altitude(string[] data_block, int i)
        {
            string code_MV = data_block[i].Substring(0, 1);
            if (code_MV == "0") { this.MV = "Not active or unknown"; }
            else { this.MV = "Active"; }
            Console.WriteLine("MV=" + this.MV);

            string code_AH = data_block[i].Substring(1, 1);
            if (code_AH == "0") { this.AH = "Not active or unknown"; }
            else { this.AH = "Active"; }
            Console.WriteLine("AH=" + this.AH);

            string code_AM = data_block[i].Substring(2, 1);
            if (code_AM == "0") { this.AM = "Not active or unknown"; }
            else { this.AM = "Active"; }
            Console.WriteLine("AM=" + this.AM);

            this.Final_State_Selected_Altitude = Convert.ToString(A2_Complement_To_Decimal(String.Concat(data_block[i].Substring(3, 5), data_block[i + 1])) * 25) + " ft";

            i = i + 2;

            return i;
        }

        
        public int Get_Trajectory_Intent(string[] data_block, int i)
        {

            this.TIS = data_block[i].Substring(0, 1);
            Console.WriteLine("TIS=" + this.TIS);
            this.TID = data_block[i].Substring(1, 1);
            Console.WriteLine("TIS=" + this.TIS);


            if (this.TIS=="1")//PRESENCE OF SUBFIELD 1
            {
                i = i + 1;
                string code_NAV = data_block[i].Substring(0, 1);
                if (code_NAV == "0") { this.NAV = "Trajectory Intent Data is available for this aircraft"; }
                else { this.NAV = "Trajectory Intent Data is not available for this aircraft "; }
                Console.WriteLine("NAV=" + this.NAV);

                string code_NVB = data_block[i].Substring(0, 1);
                if (code_NVB == "0") { this.NVB = "Trajectory Intent Data is valid"; }
                else { this.NVB = "Trajectory Intent Data is not valid"; }
                Console.WriteLine("NVB=" + this.NVB);

            }
            if (this.TID == "1")//PRESENCE OF SUBFIELD 2
            {
                i=i+1;
                this.REP = Convert.ToString(Convert.ToInt32(data_block[i], 2));
                Console.WriteLine("REP=" + this.REP);
                i = i + 1;
                int c = 0;
                while (c < Convert.ToInt32(this.REP))
                {
                    string code_TCA = data_block[i].Substring(0, 1);
                    if (code_TCA == "0") { this.TCA[c] = "TCP number available"; }
                    else { this.TCA[c] = "TCP number not available"; }

                    string code_NC = data_block[i].Substring(1, 1);
                    if (code_NC == "0") { this.NC[c] = "TCP compliance"; }
                    else { this.NC[c] = "TCP non-compliance"; }

                    this.TCP[c] = Convert.ToString(Convert.ToInt32(data_block[i].Substring(2, 6),2));
                    i = i + 1;

                    this.Altitude[c] = Convert.ToString(A2_Complement_To_Decimal(String.Concat(data_block[i], data_block[i + 1]))*10+"ft");
                    i = i + 2;

                    this.Latitude[c]= Convert.ToString(A2_Complement_To_Decimal(String.Concat(data_block[i], data_block[i + 1], data_block[i + 2])) * (180 / (Math.Pow(2, 23)))) + "º";
                    i = i + 3;

                    this.Longitude[c] = Convert.ToString(A2_Complement_To_Decimal(String.Concat(data_block[i], data_block[i + 1], data_block[i + 2])) * (180 / (Math.Pow(2, 23)))) + "º";
                    i = i + 3;

                    int code_Point_Type = Convert.ToInt32(data_block[i].Substring(0, 4), 2);
                    if (code_Point_Type == 0) { this.Point_Type[c] = "Unknown"; }
                    if (code_Point_Type == 1) { this.Point_Type[c] = "Fly by waypoint (LT) "; }
                    if (code_Point_Type == 2) { this.Point_Type[c] = "Fly over waypoint (LT)"; }
                    if (code_Point_Type == 3) { this.Point_Type[c] = "Hold pattern (LT)"; }
                    if (code_Point_Type == 4) { this.Point_Type[c] = "Procedure hold (LT)"; }
                    if (code_Point_Type == 5) { this.Point_Type[c] = "Procedure turn (LT)"; }
                    if (code_Point_Type == 6) { this.Point_Type[c] = "RF leg (LT)"; }
                    if (code_Point_Type == 7) { this.Point_Type[c] = "Top of climb (VT)"; }
                    if (code_Point_Type == 8) { this.Point_Type[c] = "Top of descent (VT)"; }
                    if (code_Point_Type == 9) { this.Point_Type[c] = "Start of level (VT)"; }
                    if (code_Point_Type == 10) { this.Point_Type[c] = "Cross-over altitude (VT)"; }
                    else { this.Point_Type[c] = "Transition altitude (VT)"; }


                    string code_TD = data_block[i].Substring(4, 2);
                    if (code_TD == "00") { this.TD[c] = "N/A"; }
                    if (code_TD == "01") { this.TD[c] = "Turn right"; }
                    if (code_TD == "10") { this.TD[c] = "Turn left"; }
                    else { this.TD[c] = "No turn"; }

                    string code_TRA = data_block[i].Substring(6, 1);
                    if (code_TRA == "0") { this.TRA[c] = "TTR not available"; }
                    else { this.TRA[c] = "TTR available"; }

                    string code_TOA = data_block[c].Substring(7, 1);
                    if (code_TOA == "0") { this.TOA[c] = "TOV available"; }
                    else { this.TOA[c] = "TOV not available"; }

                    i = i + 1;

                    this.TOV[i] = Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1], data_block[i + 2]), 2)) + " s";
                    i = i + 3;

                    this.TTR[i] = Convert.ToString(Convert.ToInt32(string.Concat(data_block[i], data_block[i + 1]), 2) * 0.01) + " Nm";
                    i = i + 2;

                    c = c + 1;
                }
                Console.WriteLine("TCA=" + this.TCA);
                Console.WriteLine("NC=" + this.NC);
                Console.WriteLine("TCP=" + this.TCP);
                Console.WriteLine("Altitude=" + this.Altitude);
                Console.WriteLine("Longitude=" + this.Longitude);
                Console.WriteLine("Point_Type=" + this.Point_Type);
                Console.WriteLine("TD=" + this.TD);
                Console.WriteLine("TRA=" + this.TRA);
                Console.WriteLine("TOA=" + this.TOA);
                Console.WriteLine("TOV=" + this.TOV);
                Console.WriteLine("TTR=" + this.TTR);



            }
            return i;
        }

        //1 octet
        public int Get_Service_Management(string[] data_block, int i)
        {
            this.RP = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.5) + " s";
            Console.WriteLine("RP=" + this.RP);
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
 
        //Variable (1 compulsory + 1 optional)
        public int Get_Surface_Capabilities_Characteristics(string[] data_block, int i)
        {
            string code_POA = data_block[i].Substring(2, 1);
            if (code_POA == "0") { this.POA = "Position transmitted is not ADS-B position reference point"; }
            else { this.POA = "Position transmitted is the ADS-B position reference point"; }
            Console.WriteLine("POA=" + this.POA);

            string code_CDTI_S = data_block[i].Substring(3, 1);
            if (code_CDTI_S == "0") { this.CDTI_S = "CDTI not operational"; }
            else { this.CDTI_S = "CDTI operational"; }
            Console.WriteLine("CDTI_S=" + this.CDTI_S);

            string code_B2_low = data_block[i].Substring(4, 1);
            if (code_B2_low == "0") { this.B2_low = "≥ 70 Watts"; }
            else { this.B2_low = "< 70 Watts"; }
            Console.WriteLine("B2_low=" + this.B2_low);

            string code_RAS = data_block[i].Substring(5, 1);
            if (code_RAS == "0") { this.RAS = "Aircraft not receiving ATC-services "; }
            else { this.RAS = "Aircraft receiving ATC services"; }
            Console.WriteLine("RAS=" + this.RAS);

            string code_IDENT = data_block[i].Substring(6, 1);
            if (code_IDENT == "0") { this.IDENT = "IDENT switch not active"; }
            else { this.IDENT = "IDENT switch active "; }
            Console.WriteLine("IDENT=" + this.IDENT);

            string code_FX = data_block[i].Substring(7, 1);
            i = i + 1;

            if (code_FX == "1")
            { 
                int code_Length_and_Width = Convert.ToInt32(data_block[i].Substring(4, 4), 2);
                if (code_Length_and_Width == 0) { this.Length_And_Width = "Lenght < 15m ; Width < 11.5m"; }
                if (code_Length_and_Width == 1) { this.Length_And_Width = "Lenght < 15m ; Width < 23m"; }
                if (code_Length_and_Width == 2) { this.Length_And_Width = "Lenght < 25m ; Width < 28.5m"; }
                if (code_Length_and_Width == 3) { this.Length_And_Width = "Lenght < 25m ; Width < 34m"; }
                if (code_Length_and_Width == 4) { this.Length_And_Width = "Lenght < 35m ; Width < 33m"; }
                if (code_Length_and_Width == 5) { this.Length_And_Width = "Lenght < 35m ; Width < 38m"; }
                if (code_Length_and_Width == 6) { this.Length_And_Width = "Lenght < 45m ; Width < 39.5m"; }
                if (code_Length_and_Width == 7) { this.Length_And_Width = "Lenght < 45m ; Width < 45m"; }
                if (code_Length_and_Width == 8) { this.Length_And_Width = "Lenght < 55m ; Width < 45m"; }
                if (code_Length_and_Width == 9) { this.Length_And_Width = "Lenght < 55m ; Width < 52m"; }
                if (code_Length_and_Width == 10) { this.Length_And_Width = "Lenght < 65m ; Width < 59.5m"; }
                if (code_Length_and_Width == 11) { this.Length_And_Width = "Lenght < 65m ; Width < 67m"; }
                if (code_Length_and_Width == 12) { this.Length_And_Width = "Lenght < 75m ; Width < 72.5m"; }
                if (code_Length_and_Width == 13) { this.Length_And_Width = "Lenght < 75m ; Width < 80m"; }
                if (code_Length_and_Width == 14) { this.Length_And_Width = "Lenght < 85m ; Width < 80m"; }
                else { this.Length_And_Width = "Lenght > 85m ; Width > 80m"; }

                Console.WriteLine("Length_And_Width=" + this.Length_And_Width);
                i = i + 1;
            }
            return i;
        }
        
        //1 octet
        public int Get_Message_Amplitude(string[] data_block, int i)
        {
            this.MAM = Convert.ToString((Convert.ToInt32(data_block[i], 2))) + "dBm";

            Console.WriteLine("MAM=" + this.MAM);
            i = i + 1;
            return i;
        }
        

        //9 octets
        public int Get_Mode_S_MB_Data(string[] data_block, int i)
        {
            int code_modeS_rep = Convert.ToInt32(data_block[i], 2);
            this.ModeS_Rep = Convert.ToString(code_modeS_rep);
            Console.WriteLine("ModeS_Rep: " + ModeS_Rep);

            int c = 0;
            while (c < code_modeS_rep)
            {
                this.MB_Data[c] = String.Concat(data_block[i + 1], data_block[i + 2], data_block[i + 3], data_block[i + 4], data_block[i + 5], data_block[i + 6], data_block[i + 7]);
                this.BDS1[c] = data_block[i + 8].Substring(0, 4);
                this.BDS2[c] = data_block[i + 8].Substring(4, 4);
                i = i + 9;
                c++;
            }
            Console.WriteLine("MB_Data: " + MB_Data);
            Console.WriteLine("BDS1: " + BDS1);
            Console.WriteLine("BDS2: " + BDS2);
            return i;
        }

        //7 octets
        public int Get_ACAS_Resolution_Advisory_Report(string[] data_block, int i)
        {
            this.TYP = data_block[i].Substring(0, 5);
            Console.WriteLine("TYP=" + this.TYP);
            this.STYP = data_block[i].Substring(5, 3);
            Console.WriteLine("STYP=" + this.STYP);
            this.ARA = String.Concat(data_block[i + 1], data_block[i + 2].Substring(0, 6));
            Console.WriteLine("ARA=" + this.ARA);
            this.RAC= String.Concat(data_block[i + 2].Substring(6,2), data_block[i + 3].Substring(0, 2));
            Console.WriteLine("RAC=" + this.RAC);
            this.RAT= data_block[i+3].Substring(2,1);
            Console.WriteLine("RAT=" + this.RAT);
            this.MTE = data_block[i + 3].Substring(3, 1);
            Console.WriteLine("MTE=" + this.MTE);
            this.TTI = data_block[i + 3].Substring(4, 2);
            Console.WriteLine("TTI=" + this.TTI);
            this.TID_ACAS = String.Concat(data_block[i + 3].Substring(6, 2),data_block[i+4],data_block[i+5],data_block[i+6]);
            Console.WriteLine("TID_ACAS=" + this.TID_ACAS);

            i = i + 7;
            return i;
        }

        string RID;//Get_Reciever_ID
        //1 octet
        public int Get_Receiver_ID(string[] data_block, int i)
        {
            this.RID=Convert.ToString(Convert.ToInt32(data_block[i],2));
            Console.WriteLine("RID=" + this.RID);
            i = i + 1;
            return i;
        }
        
        //Variable
        public int Get_Data_Ages(string[] data_block, int i)
        {
            int octets = 1;//octets que te el Primary subfield
            string code_AOS_Data_Age = data_block[i].Substring(0, 1);
            Console.WriteLine("code_AOS_Data_Age=" + code_AOS_Data_Age);
            string code_TRD_Data_Age = data_block[i].Substring(1, 1);
            Console.WriteLine("code_TRD_Data_Age=" + code_TRD_Data_Age);
            string code_M3A_Data_Age = data_block[i].Substring(2, 1);
            Console.WriteLine("codeM3A_Data_Age=" + code_M3A_Data_Age);
            string code_QI_Data_Age = data_block[i].Substring(3, 1);
            Console.WriteLine("codeQI_Data_Age=" + code_QI_Data_Age);
            string code_Target_Intent_Data_Age = data_block[i].Substring(4, 1);
            Console.WriteLine("codeTarget_Intent_Data_Age=" + code_Target_Intent_Data_Age);
            string code_MAM_Data_Age = data_block[i].Substring(5, 1);
            Console.WriteLine("codeMAM_Data_Age=" + code_MAM_Data_Age);
            string code_GH_Data_Age = data_block[i].Substring(6, 1);
            Console.WriteLine("codeGH_Data_Age=" + code_GH_Data_Age);
            string code_FX1 = data_block[i].Substring(7, 1);

            string code_FL_Data_Age = "-";
            string code_ISA_Data_Age = "-";
            string code_FSA_Data_Age = "-";
            string code_AS_Data_Age = "-";
            string code_TAS_Data_Age = "-";
            string code_MH_Data_Age = "-";
            string code_BVR_Data_Age = "-";
            string code_FX2 = "-";

            string code_GVR_Data_Age = "-";
            string code_GV_Data_Age = "-";
            string code_TAR_Data_Age = "-";
            string code_Target_Identification_Data_Age = "-";
            string code_TS_Data_Age = "-";
            string code_MET_Data_Age = "-";
            string code_ROA_Data_Age = "-";
            string code_FX3 = "-";

            string code_ARA_Data_Age = "-";
            string code_SCC_Data_Age = "-";

            i = i + 1;
            if (code_FX1 == "1")
            {
                octets = octets + 1;
                code_FL_Data_Age = data_block[i].Substring(0, 1);
                code_ISA_Data_Age = data_block[i].Substring(1, 1);
                code_FSA_Data_Age = data_block[i].Substring(2, 1);
                code_AS_Data_Age = data_block[i].Substring(3, 1);
                code_TAS_Data_Age = data_block[i].Substring(4, 1);
                code_MH_Data_Age = data_block[i].Substring(5, 1);
                code_BVR_Data_Age = data_block[i].Substring(6, 1);
                code_FX2 = data_block[i].Substring(7, 1);
                i = i + 1;
                if (code_FX2 == "1")
                {
                    octets = octets + 1;
                    code_GVR_Data_Age = data_block[i].Substring(0, 1);
                    code_GV_Data_Age = data_block[i].Substring(1, 1);
                    code_TAR_Data_Age = data_block[i].Substring(2, 1);
                    code_Target_Identification_Data_Age = data_block[i].Substring(3, 1);
                    code_TS_Data_Age = data_block[i].Substring(4, 1);
                    code_MET_Data_Age = data_block[i].Substring(5, 1);
                    code_ROA_Data_Age = data_block[i].Substring(6, 1);
                    code_FX3 = data_block[i].Substring(7, 1);

                    i = i + 1;

                    if (code_FX3 == "1")
                    {
                        octets = octets + 1;
                        code_ARA_Data_Age = data_block[i].Substring(0, 1);
                        code_SCC_Data_Age = data_block[i].Substring(1, 1);
                        i = i + 1;

                    }
                }
            }
            if (octets >= 1) 
            {
                if (code_AOS_Data_Age == "1")
                {
                    this.AOS_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("AOS_Data_Age=" + this.AOS_Data_Age);
                    i = i + 1;
                }
                if (code_TRD_Data_Age == "1")
                {
                    this.TRD_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("TRD_Data_Age=" + this.TRD_Data_Age);
                    i = i + 1;
                }
                if (code_M3A_Data_Age == "1")
                {
                    this.M3A_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("M3A_Data_Age=" + this.M3A_Data_Age);
                    i = i + 1;
                }
                if (code_QI_Data_Age == "1")
                {
                    this.QI_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("QI_Data_Age=" + this.QI_Data_Age);
                    i = i + 1;
                }
                if (code_Target_Intent_Data_Age == "1")
                {
                    this.Trajectory_Intent_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("Trajectory_Intent_Data_Age=" + this.Trajectory_Intent_Data_Age);
                    i = i + 1;
                }
                if (code_MAM_Data_Age == "1")
                {
                    this.MAM_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("MAM_Data_Age=" + this.MAM_Data_Age);
                    i = i + 1;
                }

                if (code_GH_Data_Age == "1")
                {
                    this.GH_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                    Console.WriteLine("GH_Data_Age=" + this.GH_Data_Age);
                    i = i + 1;
                }
                
                if (octets >= 2)
                {
                    if (code_FL_Data_Age == "1")
                    {
                        this.FL_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("FL_Data_Age=" + this.FL_Data_Age);
                        i = i + 1;
                    }
                    if (code_ISA_Data_Age == "1")
                    {
                        this.ISA_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("ISA_Data_Age=" + this.ISA_Data_Age);
                        i = i + 1;
                    }
                    if (code_FSA_Data_Age == "1")
                    {
                        this.FSA_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("FSA_Data_Age=" + this.FSA_Data_Age);
                        i = i + 1;
                    }
                    if (code_AS_Data_Age == "1")
                    {
                        this.AS_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("AS_Data_Age=" + this.AS_Data_Age);
                        i = i + 1;
                    }
                    if (code_TAS_Data_Age == "1")
                    {
                        this.TAS_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("TAS_Data_Age=" + this.TAS_Data_Age);
                        i = i + 1;
                    }
                    if (code_MH_Data_Age == "1")
                    {
                        this.MH_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("MH_Data_Age=" + this.MH_Data_Age);
                        i = i + 1;
                    }
                    if (code_BVR_Data_Age == "1")
                    {
                        this.BVR_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                        Console.WriteLine("BVR_Data_Age=" + this.BVR_Data_Age);
                        i = i + 1;
                    }
                    
                    if (octets >= 3)
                    {
                        if (code_GVR_Data_Age == "1")
                        {

                            this.GVR_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("GVR_Data_Age=" + this.GVR_Data_Age);
                            i = i + 1;
                        }
                        if (code_GV_Data_Age == "1")
                        {
                            this.GV_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("GV_Data_Age=" + this.GV_Data_Age);
                            i = i + 1;
                        }
                        if (code_TAR_Data_Age == "1")
                        {
                            this.TAR_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("TAR_Data_Age=" + this.TAR_Data_Age);
                            i = i + 1;
                        }
                        if (code_Target_Identification_Data_Age == "1")
                        {
                            this.Target_Identification_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("Target_Identification_Data_Age=" + this.Target_Identification_Data_Age);
                            i = i + 1;
                        }
                        if (code_TS_Data_Age == "1")
                        {
                            this.TS_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("TS_Data_Age=" + this.TS_Data_Age);
                            i = i + 1;
                        }
                        if (code_MET_Data_Age == "1")
                        {
                            this.MET_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("MET_Data_Age=" + this.MET_Data_Age);
                            i = i + 1;
                        }

                        if (code_ROA_Data_Age == "1")
                        {
                            this.ROA_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                            Console.WriteLine("ROA_Data_Age=" + this.ROA_Data_Age);
                            i = i + 1;
                        }

                        if (octets >= 4)
                        {
                            if (code_ARA_Data_Age == "1")
                            {
                                this.ARA_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                                Console.WriteLine("ARA_Data_Age=" + this.ARA_Data_Age);
                                i = i + 1;
                            }
                            if (code_SCC_Data_Age == "1")
                            {
                                this.SCC_Data_Age = Convert.ToString(Convert.ToDouble(Convert.ToInt32(data_block[i], 2)) * 0.1) + " s";
                                Console.WriteLine("SCC_Data_Age=" + this.SCC_Data_Age);
                                i = i + 1;
                            }
                            
                        }
                    }
                }
            }
            

            return i;
        }

        

    }
}
