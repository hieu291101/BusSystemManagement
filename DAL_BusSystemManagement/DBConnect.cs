﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BusSystemManagement
{
    public class DBConnect
    {
        protected MySqlConnection _conn = new MySqlConnection("Server=localhost:3306; Database=bussystemmanagement; Uid=root; Pwd=Dieuphuong0723");
    }
}
