using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JollySwagman.Utilities.Exceptions
{
    public class SettingKeyNotFoundException : ApplicationException
    {
        public SettingKeyNotFoundException(string settingKey) : base(string.Format("Key '{0}' not found in config file.", settingKey))
        {
        }
    }
}