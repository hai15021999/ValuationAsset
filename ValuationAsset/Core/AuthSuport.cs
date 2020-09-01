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
            string strSql = "Select ID from tbUser Where UserName = '" + userName + "'";
            DataAccess da = new DataAccess();
            var checkUser = da.execSqlQuery2(strSql);
            if(checkUser != null) {
                if (checkUser.Rows.Count == 0)
                {
                    return "true";
                }
                else
                {
                    return "UserName has aready existed";
                }
            } else
            {
                return "Error when check user exists";
            }
        }

        public static string Register(string userName, string password)
        {
            DataAccess da = new DataAccess();
            var hashedPwd = GetMD5(password);
            List<SqlParameter> para = new List<SqlParameter>()
            {
                new SqlParameter() { ParameterName = "@userName", SqlDbType = SqlDbType.VarChar, Value = userName },
                new SqlParameter() { ParameterName = "@password", SqlDbType = SqlDbType.VarChar, Value = hashedPwd }
            };
            string queryStr = "Insert Into tbUser(UserName, Password) values(@userName, @password)";
            return da.CreateUser(queryStr, para);
        }

    }
}
