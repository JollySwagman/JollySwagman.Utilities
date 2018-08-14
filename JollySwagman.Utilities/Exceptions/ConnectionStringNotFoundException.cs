using System;

namespace JollySwagman.Utilities.Exceptions
{
    public class ConnectionStringNotFoundException : ApplicationException
    {
        public ConnectionStringNotFoundException(string settingKey) : base(string.Format("Connection string '{0}' not found in config file.", settingKey))
        {
        }
    }
}