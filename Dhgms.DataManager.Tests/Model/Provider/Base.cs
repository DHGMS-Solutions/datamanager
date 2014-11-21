namespace Dhgms.DataManager.Tests.Model.Provider
{
    using Xunit;

    /// <summary>
    /// Mocking class for a provider
    /// </summary>
    public class ProviderClassMocking
        : System.Configuration.Provider.ProviderBase
    {
    }

    /// <summary>
    /// Mocking class for a provider section
    /// </summary>
    public class ProviderSectionMocking
        : Dhgms.DataManager.Model.ConfigurationSection.ProviderSection
    {
    }

    /// <summary>
    /// Unit tests for Provider Proxy
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Test units for the constructor
        /// </summary>
        public class ConstructorMethod
        {
            /// <summary>
            /// Test to ensure the constructor succeeds
            /// </summary>
            [Fact]
            public void ShouldSucceed()
            {
                new ProviderProxyBaseMocking();
            }
        }

        /// <summary>
        /// Mocking class for Provider Collection
        /// </summary>
        internal class ProviderCollectionMocking
            : Dhgms.DataManager.Model.ProviderCollection.BaseCollection<ProviderClassMocking>
        {
        }

        /// <summary>
        /// Mocking class for Provider Proxy
        /// </summary>
        internal class ProviderProxyBaseMocking
            : Dhgms.DataManager.Model.ProviderProxy.Base<ProviderProxyBaseMocking, ProviderClassMocking, ProviderCollectionMocking, ProviderSectionMocking>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ProviderProxyBaseMocking"/> class.
            /// </summary>
            public ProviderProxyBaseMocking()
                : base("providerProxyBaseMocking")
            {
            }
        }
    }
}
