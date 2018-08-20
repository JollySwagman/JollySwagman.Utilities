using JollySwagman.Utilities.Exceptions;
using System;
using System.Configuration;

namespace JollySwagman.Utilities
{
    public class Settings
    {
        public enum GetSettingBehaviour
        {
            ThrowIfNotFound,
            IgnoreIfNotFound
        }

        public static T ConfigSetting<T>(string settingName)
        {
            return ConfigSetting<T>(settingName, GetSettingBehaviour.ThrowIfNotFound);
        }

        public static T ConfigSetting<T>(string settingName, GetSettingBehaviour behaviour)
        {
            var value = ConfigurationManager.AppSettings[settingName];

            if (behaviour == GetSettingBehaviour.ThrowIfNotFound && value == null)
            {
                throw new SettingKeyNotFoundException(settingName);
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public static string GetConnectionString(string key)
        {
            var conn = ConfigurationManager.ConnectionStrings[key];
            if (conn == null)
            {
                throw new ConnectionStringNotFoundException(key);
            }
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}