using System;
using NUnit.Framework;

namespace JollySwagman.Utilities.Test
{
    [TestFixture]
    public class SettingsTests
    {
        [Test]
        public void Get_Setting()
        {
            var resultInt = Settings.ConfigSetting<int>("IntValue");
            var resultStr = Settings.ConfigSetting<string>("StringValue");
        }

        [Test]
        public void Throw_If_Key_Not_Found()
        {
            Assert.That(() => Settings.ConfigSetting<string>("UnknownKey"),
                                Throws.Exception
                                .TypeOf<Exceptions.SettingKeyNotFoundException>()
                                .With.Property("Message")
                                .EqualTo("Key 'UnknownKey' not found in config file."));
        }
    }
}