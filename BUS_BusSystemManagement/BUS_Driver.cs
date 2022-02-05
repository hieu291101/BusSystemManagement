using DAL_BusSystemManagement;
using DTO_BusSystemManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_BusSystemManagement
{
    public class BUS_Driver
    {
        DAL_Driver dalDriver = new DAL_Driver();
        public DataTable GetDriver()
        {
            return dalDriver.GetDriver();
        }

        public string GetDriverById(int id)
        {
            return dalDriver.GetDriverById(id);
        }

        public List<string> GetListDriverId()
        {
            return dalDriver.GetListDriverId();
        }

        public bool AddDriver(DTO_AsDriver ad, DTO_Driver d)
        {
            return dalDriver.AddDriver(ad, d);
        }

        public bool UpdateDriver(DTO_AsDriver ad, DTO_Driver d)
        {
            return dalDriver.UpdateDriver(ad, d);
        }

        public bool DeleteDriver(int DRIVER_ID)
        {
            return dalDriver.DeleteDriver(DRIVER_ID);
        }

        public DataTable FindDriverByName(string kw)
        {
            return dalDriver.FindDriverByName(kw);
        }

        public DataTable FindDriverByGender(string kw)
        {
            return dalDriver.FindDriverByGender(kw);
        }

        public DataTable FindDriverByAddress(string kw)
        {
            return dalDriver.FindDriverByAddress(kw);
        }

        public DataTable FindDriverByPhoneNumber(string kw)
        {
            return dalDriver.FindDriverByPhoneNumber(kw);
        }

        public DataTable FindDriverByIdCard(string kw)
        {
            return dalDriver.FindDriverByIdCard(kw);
        }

        public DataTable FindDriverByExperienceYear(string kw)
        {
            return dalDriver.FindDriverByExperienceYear(kw);
        }

        public DataTable FindDriverByDriverLicense(string kw)
        {
            return dalDriver.FindDriverByDriverLicense(kw);
        }
    }
}
