using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using ValuationAsset.Core;

namespace ValuationAsset.Core
{
    public static class AuthSuport
    {
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        public static string Login(string userName, string password)
        {
            var hashedPwd = GetMD5(password);

            DataAccess da = new DataAccess();
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter() { ParameterName = "@userName", SqlDbType = SqlDbType.VarChar, Value = userName },
                new SqlParameter() { ParameterName = "@password", SqlDbType = SqlDbType.VarChar, Value = hashedPwd }
            };
            string queryExc = "sp_Login";
            var login = da.execSqlReturn(queryExc, para).Tables[0].Rows[0][0].ToString();
            if (login == "0")
                return "Invalid UserName or Password.";

            AuthSession.Set(AuthSession.key_UserName, userName);

            return "true";
        }

        public static string CheckUserExisted(string userName)
        {
            string strSql = "Select top 1 1 from tbUser Where UserName = '" + userName + "'";
            DataAccess da = new DataAccess();
            var checkUser = da.execSqlQuery(strSql);
            try
            {
                if (checkUser.Tables.Count > 0 && checkUser.Tables[0] != null && checkUser.Tables[0].Rows.Count > 0)
                {
                    return "UserName has aready existed";
                }
                return "true";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public static void Register(int? userId, string userName, string password, int roleId, int deactive, int isCreate)
        {
            DataAccess da = new DataAccess();
            var hashedPwd = GetMD5(password);
            
            string queryStr = string.Format("sp_CreateUser {0}, '{1}', '{2}', {3}, {4}, {5}", userId, userName, hashedPwd, roleId, deactive, isCreate);
            da.execSqlNoReturn(queryStr);
        }

    }
}
