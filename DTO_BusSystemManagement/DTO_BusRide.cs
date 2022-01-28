﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BusSystemManagement
{
    class DTO_BusRide
    {
        private int _BUSRIDE_BUSLINEID;
        private int _BUSRIDE_BUSID;
        private int _BUSRIDE_MDRIVERID;
        private int _BUSRIDE_ASDRIVERID;
        private int _BUSRIDE_ID;
        private DateTime _BUSRIDE_STARTTIME;

        public DTO_BusRide()
        {

        }
        public DTO_BusRide(int bUSRIDE_BUSLINEID, int bUSRIDE_BUSID, int bUSRIDE_MDRIVERID,
            int bUSRIDE_ASDRIVERID, int bUSRIDE_ID, DateTime bUSRIDE_STARTTIME)
        {
            _BUSRIDE_BUSLINEID = bUSRIDE_BUSLINEID;
            _BUSRIDE_BUSID = bUSRIDE_BUSID;
            _BUSRIDE_MDRIVERID = bUSRIDE_MDRIVERID;
            _BUSRIDE_ASDRIVERID = bUSRIDE_ASDRIVERID;
            _BUSRIDE_ID = bUSRIDE_ID;
            _BUSRIDE_STARTTIME = bUSRIDE_STARTTIME;
        }

        public int BUSRIDE_BUSLINEID { get => _BUSRIDE_BUSLINEID; set => _BUSRIDE_BUSLINEID = value; }
        public int BUSRIDE_BUSID { get => _BUSRIDE_BUSID; set => _BUSRIDE_BUSID = value; }
        public int BUSRIDE_MDRIVERID { get => _BUSRIDE_MDRIVERID; set => _BUSRIDE_MDRIVERID = value; }
        public int BUSRIDE_ASDRIVERID { get => _BUSRIDE_ASDRIVERID; set => _BUSRIDE_ASDRIVERID = value; }
        public int BUSRIDE_ID { get => _BUSRIDE_ID; set => _BUSRIDE_ID = value; }
        public DateTime BUSRIDE_STARTTIME { get => _BUSRIDE_STARTTIME; set => _BUSRIDE_STARTTIME = value; }
    }
}
