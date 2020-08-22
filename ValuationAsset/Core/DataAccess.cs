using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;

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

        private DataSet execSqlQuery(string queryStr)
        {
            DataSet ds = null;
            using (SqlConnection connection = new SqlConnection(sConnectionString))
            {
                connection.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(queryStr, connection))
                {
                    if (ds != null)
                    {
                        ds.Dispose();
                        ds = null;
                    }

                    ds = new DataSet();
                    da.Fill(ds);
                }
                connection.Close();
            }
            return ds;
        }

        public void execSqlNoReturn(string query)
        {
            string output = "";
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = sConnectionString;
                    using (SqlCommand command = BuildCommand(cn, query, ref output))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            command.CommandTimeout = 5 * 60;
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        internal SqlCommand BuildCommand(SqlConnection cn, string query, ref string output)
        {
            cn.Open();
            string inQuery = query.Trim();
            output += ("original: " + inQuery + "\n");

            string proc = null;
            SqlCommand command = null;
            if (inQuery.Contains(" "))
            {
                proc = inQuery.Substring(0, inQuery.IndexOf(" "));
                inQuery = inQuery.Substring(inQuery.IndexOf(" ")).Trim();

                string[] elements = Regex.Split(inQuery, ",(?=(?:[^']*'[^']*')*[^']*$)");

                command = new SqlCommand(proc, cn);
                command.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(command);
                output += ("SqlCommand: " + proc + " " + elements.Length + "\n");
                for (int t = 0; t < elements.Length; t++)
                {

                    try
                    {
                        string value = elements[t].Trim();
                        if (value.Equals(""))
                        {
                            command.Parameters[t + 1].Value = value;
                        }
                        else if (value.StartsWith("'") || value.StartsWith("N'"))
                        {
                            if (value.StartsWith("N'"))
                            {
                                value = value.Substring(1);
                            }
                            value = Regex.Replace(value, "^\'|\'$", "").Replace("''", "'");
                            if (command.Parameters[t + 1].SqlDbType == SqlDbType.UniqueIdentifier)
                            {
                                command.Parameters[t + 1].Value = new Guid(value);
                            }
                            else
                            {
                                command.Parameters[t + 1].Value = value;
                            }

                        }
                        else if (value.Equals("null"))
                        {
                            command.Parameters[t + 1].Value = DBNull.Value;
                            command.Parameters[t + 1].IsNullable = true;  ///27604f05-86ad-47ef-9e05-950bb762570c
                        }
                        else
                        {
                            command.Parameters[t + 1].Value = value;
                        }

                        output += ("Parameters[" + t + "]: " + value + "\n");
                    }
                    catch (Exception we)
                    {
                        throw new Exception(we.Message);
                    }
                }

            }
            else
            {
                command = new SqlCommand(inQuery, cn);
                command.CommandType = CommandType.StoredProcedure;
            }
            return command;
        }
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

