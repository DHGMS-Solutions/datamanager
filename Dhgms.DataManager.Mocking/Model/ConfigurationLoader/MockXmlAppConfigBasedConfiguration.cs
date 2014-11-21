namespace Dhgms.DataManager.Mocking.Model.ConfigurationLoader
{
    using System.Configuration;

    public class MockXmlAppConfigBasedConfiguration : ConfigurationSection, IMockConfiguration
    {
        [ConfigurationProperty("One", IsRequired = false)]
        public int One
        {
            get
            {
                return (int)this["One"];
            }
        }

        [ConfigurationProperty("Two", IsRequired = false)]
        public int Two
        {
            get
            {
                return (int)this["Two"];
            }
        }
    }
}
