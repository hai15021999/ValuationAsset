using System;
using System.Collections.Generic;
using System.Text;

namespace ValuationAsset.Core
{
    public static class AuthSession
    {
        public static Dictionary<string, string> _session = new Dictionary<string, string>();
        public static void Set(string key, string value)
        {
            if (!_session.ContainsKey(key))
                _session.Add(key, value);
        }

        public static string Get(string key)
        {
            var value = _session[key];

            return value;
        }

        public static void Clear()
        {
            _session.Clear();
        }

        public static string key_UserId = "UserId";
        public static string key_UserName = "UserName";
        public static string key_Role = "Role";
    }
}
