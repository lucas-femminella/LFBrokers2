using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace LFbrokersV2
{
    public class DataUtils
    {
        // TODO: Update connection string
        //public static String connectionString = "Data Source=LFERREIRO;Initial Catalog=LFbrokers;Integrated Security=True";
        public static String connectionString = "Server=lfemminella;Database=LFbrokers;Trusted_Connection=True";
        //public static String connectionString = "Data Source=DESKTOP-0V1H3B5;Initial Catalog=LFbrokers;Integrated Security=True";

        public static void DML(String query)
        {
            SqlConnection conection = new SqlConnection(connectionString);
            conection.Open();
            SqlCommand cmd;

            cmd = new SqlCommand(query, conection);
            cmd.ExecuteNonQuery();

            conection.Close();
        }

        public static List<SelectListItem> getSelectListItems(String model, String value, String text)
        {
            List<SelectListItem> selectedList = new List<SelectListItem>();
            SqlConnection conection = new SqlConnection(connectionString);
            conection.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            
            cmd = new SqlCommand("SELECT " + value + ", " + text + " FROM " + model, conection);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    selectedList.Add(new SelectListItem { Value = dr[value].ToString(), Text = dr[text].ToString() });
                }
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conection.Close();
            }
            return selectedList;
        }


        public static Dictionary<string, string> querySingleRecord(String model, String[] fields, String condition)
        {
            var map = new Dictionary<string, string>();

            SqlConnection conection = new SqlConnection(connectionString);
            conection.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            String qr = "SELECT " + String.Join(",", fields) + " FROM " + model + " WHERE " + condition + " LIMIT 1";
            cmd = new SqlCommand("SELECT " + String.Join(",", fields) + " FROM " + model + " WHERE " + condition, conection);
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < fields.Length; i++)
                    {
                        String field = fields[i];
                        String value = dr.GetValue(dr.GetOrdinal(field)).ToString();

                        map.Add(field, value);
                    }
                }
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conection.Close();
            }
            return map;
        }

        public static int getId(String model)
        {
            SqlConnection conection = new SqlConnection(connectionString);
            conection.Open();
            SqlCommand cmd = new SqlCommand("select max(ID) as maxId from " + model, conection);
            SqlDataReader dr = cmd.ExecuteReader();
            String maxId = "1";
            if (dr.HasRows)
            {
                dr.Read();
                
                if (dr["maxId"] != DBNull.Value)
                {
                    maxId = (Convert.ToInt32(dr["maxId"]) + 1).ToString();
                }
    
            }
            conection.Close();

            return Convert.ToInt32(maxId);
        }
    }
}
