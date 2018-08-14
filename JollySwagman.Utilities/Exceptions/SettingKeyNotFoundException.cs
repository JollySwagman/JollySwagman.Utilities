using System;

namespace JollySwagman.Utilities.Exceptions
{
    public class SettingKeyNotFoundException : ApplicationException
    {
        public SettingKeyNotFoundException(string settingKey) : base(string.Format("Key '{0}' not found in config file.", settingKey))
        {
        }
    }
}