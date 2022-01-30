using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_getEnum
    {
        public static DTO_Gender_Enum GetGenderEnum(string stringEnum)
        {
            DTO_Gender_Enum gender = DTO_Gender_Enum.KHAC;
            switch (stringEnum)
            {
                case "Nam":
                    gender = DTO_Gender_Enum.NAM;
                    break;
                case "Nu":
                    gender = DTO_Gender_Enum.NU;
                    break;
            }
            return gender;
        }

        public static DTO_License_Enum GetLicenseEnum(string stringEnum)
        {
            DTO_License_Enum license = DTO_License_Enum.B2;
            switch (stringEnum)
            {
                case "C":
                    license = DTO_License_Enum.C;
                    break;
                case "D":
                    license = DTO_License_Enum.D;
                    break;
                case "E":
                    license = DTO_License_Enum.E;
                    break;
                case "F":
                    license = DTO_License_Enum.F;
                    break;
            }
            return license;
        }
    }
}
