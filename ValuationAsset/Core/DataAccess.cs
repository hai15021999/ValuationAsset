using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ValuationAsset.Core
{
    public class DataAccess
    {
        private static string sConnectionString = ConfigurationManager.ConnectionStrings["Entities"].ConnectionString;

        public DataAccess()
        {

        }

        public DataSet execSqlReturn(string cmdText, List<SqlParameter> parameters)
        {
            return execSqlReturnInternal(cmdText, parameters);
        }

        private DataSet execSqlReturnInternal(string cmdText, List<SqlParameter> parameters)
        {
            DataSet ds = null;
            using (SqlConnection connection = new SqlConnection(sConnectionString))
            {
                connection.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = cmdText;
                        command.Parameters.AddRange(parameters);

                        da.SelectCommand = command;

                        // If we have a DataSet from a previos attempt, dispose of it.
                        if (ds != null)
                        {
                            ds.Dispose();
                            ds = null;
                        }

                        ds = new DataSet();
                        da.Fill(ds);
                    }
                }
                connection.Close();
            }
            return ds;
        }
    }

    public static class SqlExtensions
    {
        public static void AddRange(this SqlParameterCollection collection, List<SqlParameter> parameters)
        {
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    collection.Add(parameter);
                }
            }
        }
    }
}
