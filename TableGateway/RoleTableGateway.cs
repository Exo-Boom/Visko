﻿using System.Collections.Generic;
using System.Data.SqlClient;

namespace vis.TableGateway
{
    public class RoleTableGateway
    {
        public List<Role> SelectAll()
        {
            SqlConnection conn = new SqlConnection(Database.connectionString);
            conn.Open();

            var dotaz = "SELECT * FROM Role";
            SqlCommand com = new SqlCommand(dotaz, conn);

            SqlDataReader data = com.ExecuteReader();

            List<Role> list = new List<Role>();


            while (data.Read())
            {
                Role a = new Role(data.GetInt32(0), data.GetString(1), data.GetString(2));
                list.Add(a);

            }

            conn.Close();

            return list;
        }
    }
}