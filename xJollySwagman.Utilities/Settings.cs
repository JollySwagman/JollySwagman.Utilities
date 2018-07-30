using System;
using System.Collections.ObjectModel;

namespace JollySwagman.Utilities
{
    public class Settings
    {
        public static T ConfigSetting<T>(string settingName) where T : struct
        {
            var value = ConfigurationManager.AppSettings[settingName];

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}