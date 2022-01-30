using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_BusLine
    {
        private int _BUSLINE_ID;
        private string _BUSLINE_NAME;
        private int _BUSLINE_STARTTIME;
        private int _BUSLINE_ENDTIME;
        private string _BUSLINE_STARTLOCATION;
        private string _BUSLINE_ENDLOCATION;
        private string _BUSLINE_BUSSTOPDETAIL;
        private int _BUSLINE_FREQUENCY;

        public DTO_BusLine()
        {

        }
        public DTO_BusLine(int bUSLINE_ID, string bUSLINE_NAME, int bUSLINE_STARTTIME,
            int bUSLINE_ENDTIME, string bUSLINE_STARTLOCATION,
            string bUSLINE_ENDLOCATION, string bUSLINE_BUSSTOPDETAIL, int bUSLINE_FREQUENCY)
        {
            _BUSLINE_ID = bUSLINE_ID;
            _BUSLINE_NAME = bUSLINE_NAME;
            _BUSLINE_STARTTIME = bUSLINE_STARTTIME;
            _BUSLINE_ENDTIME = bUSLINE_ENDTIME;
            _BUSLINE_STARTLOCATION = bUSLINE_STARTLOCATION;
            _BUSLINE_ENDLOCATION = bUSLINE_ENDLOCATION;
            _BUSLINE_BUSSTOPDETAIL = bUSLINE_BUSSTOPDETAIL;
            _BUSLINE_FREQUENCY = bUSLINE_FREQUENCY;
        }

        public int BUSLINE_ID { get => _BUSLINE_ID; set => _BUSLINE_ID = value; }
        public string BUSLINE_NAME { get => _BUSLINE_NAME; set => _BUSLINE_NAME = value; }
        public int BUSLINE_STARTTIME { get => _BUSLINE_STARTTIME; set => _BUSLINE_STARTTIME = value; }
        public int BUSLINE_ENDTIME { get => _BUSLINE_ENDTIME; set => _BUSLINE_ENDTIME = value; }
        public string BUSLINE_STARTLOCATION { get => _BUSLINE_STARTLOCATION; set => _BUSLINE_STARTLOCATION = value; }
        public string BUSLINE_ENDLOCATION { get => _BUSLINE_ENDLOCATION; set => _BUSLINE_ENDLOCATION = value; }
        public string BUSLINE_BUSSTOPDETAIL { get => _BUSLINE_BUSSTOPDETAIL; set => _BUSLINE_BUSSTOPDETAIL = value; }
        public int BUSLINE_FREQUENCY { get => _BUSLINE_FREQUENCY; set => _BUSLINE_FREQUENCY = value; }
    }
}
