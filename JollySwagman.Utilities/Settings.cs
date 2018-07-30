using JollySwagman.Utilities.Exceptions;
using System;
using System.Collections.ObjectModel;
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

        public static T ConfigSetting<T>(string settingName) //where T : struct
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
    }
}