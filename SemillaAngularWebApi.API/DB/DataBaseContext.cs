using MySql.Data.MySqlClient;
using SemillaAngularWebApi.API.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SemillaAngularWebApi.API.DB
{
    public class DataBaseContext
    {
        public static string conexion = ConfigurationManager.ConnectionStrings["AuthContext"].ConnectionString;
        
        public string componerWhere(List<ConditionsSelect> listaOp) {
            string where_clause = "";
            int count = 0;
            foreach (var op in listaOp)
            {
                where_clause += "( ";
                if (op.isMultiple)
                {
                    var valSelect = (List<ConditionsSelect>)op.value;
                    where_clause += componerWhere(valSelect);                    
                }
                else
                {
                    if (op.op == null) op.op = "=";
                    where_clause += op.campo + op.op + op.value.ToString();
                }
                where_clause += ") ";
                if (count < listaOp.Count) where_clause += " AND ";
                count++;
            }
            return where_clause;
        }

        public List<Dictionary<string, object>> select(string table,Dictionary<string,object> parametros)
        {
            List<Dictionary<string, object>> datos = new List<Dictionary<string, object>>();            
            MySqlConnection conn = new MySqlConnection(conexion);
            conn.Open();
            string query = "SELECT ";
            //Si fields no es null obtenemos los campos a buscar, si no obtenemos todo
            if (parametros!=null && parametros["fields"] != null)
            {
                query += parametros["fields"].ToString() + " FROM " + table;
            }
            else {
                query += "* FROM " + table;
            }

            if (parametros != null && parametros["where"] != null)
            {
                List<ConditionsSelect> listaOp = (List<ConditionsSelect>)parametros["where"];
                string where_clause = componerWhere(listaOp);
                query += " WHERE " + where_clause;
            }            
            MySqlCommand mycomand = new MySqlCommand(query, conn);
            /*mycomand.Parameters.AddWithValue("?pId", pId);
            mycomand.Parameters.AddWithValue("?Nci", Nci);
            */
            MySqlDataReader reader = mycomand.ExecuteReader();
            while (reader.Read())
            {
                Dictionary<string, object> fila = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    fila.Add(reader.GetName(i),reader.GetValue(i));
                }
                datos.Add(fila);
            }      
            return datos;
        }

    }
}