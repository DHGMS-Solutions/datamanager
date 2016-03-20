using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.Tests.Model.ConfigurationLoader
{
    public class XmlAppConfigConfigurationLoaderTest : BaseConfigurationLoaderTest<Dhgms.DataManager.Model.ConfigurationLoader.XmlAppConfigConfigurationLoader<Mocking.Model.ConfigurationLoader.MockXmlAppConfigBasedConfiguration>, Mocking.Model.ConfigurationLoader.MockXmlAppConfigBasedConfiguration>
    {
        public class ConstructorMethod : BaseConstructorMethod
        {
        }

        public class GetSettingsMethod : BaseGetSettingsMethod
        {
            
        }

        public class OneProperty : BaseOneProperty
        {
        }

        public class TwoProperty : BaseTwoProperty
        {
        }
    }
}
