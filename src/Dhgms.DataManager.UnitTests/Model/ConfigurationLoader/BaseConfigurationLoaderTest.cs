using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.Tests.Model.ConfigurationLoader
{
    using Dhgms.DataManager.Model;

    using Xunit;

    public abstract class BaseConfigurationLoaderTest<TConfigurationLoaderClass, TApplicationConfiguration>
        where TConfigurationLoaderClass : Dhgms.DataManager.Model.ConfigurationLoader.BaseConfigurationLoader<TApplicationConfiguration>, new()
        where TApplicationConfiguration : class, Dhgms.DataManager.Mocking.Model.ConfigurationLoader.IMockConfiguration
    {
        public abstract class BaseConstructorMethod
        {
            [Fact]
            public void ShouldSucceed()
            {
                var instance = new TConfigurationLoaderClass();
                Assert.NotNull(instance);
            }
        }

        public abstract class BaseGetSettingsMethod
        {
            [Fact]
            public void ShouldSucceed()
            {
                var instance = new TConfigurationLoaderClass();
                var config = instance.GetSettings();

                var configCastToInterface = config as IApplicationConfiguration;
                Assert.NotNull(configCastToInterface);
            }
        }

        public abstract class BaseOneProperty
        {
            [Fact]
            public void InspectorShouldSucceed()
            {
                var instance = new TConfigurationLoaderClass();
                var config = instance.GetSettings();

                var result = config.One;
                Assert.Equal(1, result);
            }
        }

        public abstract class BaseTwoProperty
        {
            [Fact]
            public void InspectorShouldSucceed()
            {
                var instance = new TConfigurationLoaderClass();
                var config = instance.GetSettings();

                var result = config.Two;
                Assert.Equal(2, result);
            }
        }
    }
}
