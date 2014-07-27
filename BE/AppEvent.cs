using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BE {
    public class AppEvent {


        public static void AddEvent(String appName, String Context, String eventType, string eventDescription, string query, string status) {
            //var ctx = 

            var ctx = new DE.GCSEntities();
            var item = new DE.AppEvent() { };
            item.AppName = appName;
            item.EventType = eventType;
            item.EventDescription = eventDescription;
            item.Query = query;
            item.Status = status;
            item.rct = DateTime.Now;

            try {
                ctx.AppEvents.Add(item);
                ctx.SaveChanges();
            }
            catch (System.Exception ex) {
                throw new System.Exception(ex.Message, ex.InnerException);
            }

            /*
            String connStr = System.Configuration.ConfigurationManager.ConnectionStrings["connstr"].ToString();
            
            String str = "INSERT INTO AppEvent(AppName, EventType, EventDescription, Query, Status) Values(@appName, @eventType, @eventDescription, @query, @status)";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@appName", DbType = DbType.String, Value = appName });
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@eventType", DbType = DbType.String, Value = eventType });
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@eventDescription", DbType = DbType.String, Value = eventDescription });
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@query", DbType = DbType.String, Value = query });
            cmd.Parameters.Add(new SqlParameter() { ParameterName = "@status", DbType = DbType.String, Value = status });
            cmd.ExecuteNonQuery();
            conn.Dispose();
             * */
        }
    }
}