using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    public class DTO_BusRide
    {
        private int _BUSRIDE_BUSLINEID;
        private int _BUSRIDE_BUSID;
        private int _BUSRIDE_DRIVERID;
        private int _BUSRIDE_ID;
        private DateTime _BUSRIDE_STARTTIME;
        private string _BUSRIDE_TYPE;

        public DTO_BusRide()
        {

        }

        public DTO_BusRide(int bUSRIDE_BUSLINEID, int bUSRIDE_BUSID, int bUSRIDE_DRIVERID, int bUSRIDE_ID, DateTime bUSRIDE_STARTTIME, string bUSRIDE_TYPE)
        {
            _BUSRIDE_BUSLINEID = bUSRIDE_BUSLINEID;
            _BUSRIDE_BUSID = bUSRIDE_BUSID;
            _BUSRIDE_DRIVERID = bUSRIDE_DRIVERID;
            _BUSRIDE_ID = bUSRIDE_ID;
            _BUSRIDE_STARTTIME = bUSRIDE_STARTTIME;
            _BUSRIDE_TYPE = bUSRIDE_TYPE;
        }

        public int BUSRIDE_BUSLINEID { get => _BUSRIDE_BUSLINEID; set => _BUSRIDE_BUSLINEID = value; }
        public int BUSRIDE_BUSID { get => _BUSRIDE_BUSID; set => _BUSRIDE_BUSID = value; }
        public int BUSRIDE_DRIVERID { get => _BUSRIDE_DRIVERID; set => _BUSRIDE_DRIVERID = value; }
        public int BUSRIDE_ID { get => _BUSRIDE_ID; set => _BUSRIDE_ID = value; }
        public DateTime BUSRIDE_STARTTIME { get => _BUSRIDE_STARTTIME; set => _BUSRIDE_STARTTIME = value; }
        public string BUSRIDE_TYPE { get => _BUSRIDE_TYPE; set => _BUSRIDE_TYPE = value; }
    }
}
