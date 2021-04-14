﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Projekt_Felulet
{
    class DB
    {
        private SQLiteConnection con = new SQLiteConnection("data source=NetpincerDB.db");

        public SQLiteConnection GetConnection()
        {
            return con;
        }

        public void openconnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void closeconnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
