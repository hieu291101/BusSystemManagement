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
    }
}
