using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.Tests.Model.ConfigurationLoader
{
    using Dhgms.DataManager.Model.Info.CommandLineSettings;

    using Xunit;

    public class CodeConfigurationLoaderTest : BaseConfigurationLoaderTest<Dhgms.DataManager.Model.ConfigurationLoader.CodeConfigurationLoader<Mocking.Model.ConfigurationLoader.MockCodeBasedConfiguration>, Mocking.Model.ConfigurationLoader.MockCodeBasedConfiguration>
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
