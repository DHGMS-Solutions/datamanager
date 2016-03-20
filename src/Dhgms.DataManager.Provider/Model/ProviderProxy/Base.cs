//////////////////////////////////////////////////////////////////////////
// Licensed under GNU General Public License version 2 (GPLv2)
//
// DHGMS Data Manager by DHGMS Solutions
// http://datamanager.codeplex.com
//////////////////////////////////////////////////////////////////////////

namespace Dhgms.DataManager.Model.ProviderProxy
{
    using System;
    using System.Configuration;
    using System.Configuration.Provider;

    /// <summary>
    /// Generic Class for the Base Provider Proxy
    /// </summary>
    /// <remarks>
    /// This is based on code from the article "Wicked Code: The SQL Site Map Provider You've Been Waiting For"
    /// http://msdn.microsoft.com/en-us/magazine/cc163657.aspx
    /// </remarks>
    /// <typeparam name="TInheritingType">The class that is inheriting this base class</typeparam>
    /// <typeparam name="TProviderClass">The class for the actual provider</typeparam>
    /// <typeparam name="TProviderCollection">The Provider collection class</typeparam>
    /// <typeparam name="TProviderSection">The class for the provider section of the config file</typeparam>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1005:AvoidExcessiveParametersOnGenericTypes", Justification = "Needed")]
    public class Base<TInheritingType, TProviderClass, TProviderCollection, TProviderSection>
        where TInheritingType : Base<TInheritingType, TProviderClass, TProviderCollection, TProviderSection>, new()
        where TProviderCollection : Model.ProviderCollection.BaseCollection<TProviderClass>, new()
        where TProviderClass : ProviderBase
        where TProviderSection : Model.ConfigurationSection.ProviderSection
    {
        #region fields

        /// <summary>
        /// The default provider
        /// </summary>
        private static TProviderClass defaultProvider;

        /// <summary>
        /// Collection of providers
        /// </summary>
        private static TProviderCollection providers;

        /// <summary>
        /// objectLock object
        /// </summary>
        private readonly object objectLock = new object();

        /// <summary>
        /// The name of the section
        /// </summary>
        private readonly string sectionName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Base{TInheritingType,TProviderClass,TProviderCollection,TProviderSection}"/> class.
        /// </summary>
        /// <param name="sectionName">
        /// The section name.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Section name is null
        /// </exception>
        protected Base(string sectionName)
        {
            if (string.IsNullOrEmpty(sectionName))
            {
                throw new ArgumentNullException("sectionName");
            }

            this.sectionName = sectionName;

            this.LoadProviders();
        }

        /// <summary>
        /// Gets the Default Provider
        /// </summary>
        public TProviderClass Default
        {
            get
            {
                return defaultProvider;
            }

            private set
            {
                defaultProvider = value;
            }
        }

        /// <summary>
        /// Gets the Collection Of Providers
        /// </summary>
        public TProviderCollection Providers
        {
            get
            {
                return providers;
            }

            private set
            {
                providers = value;
            }
        }

        #endregion

        #region our methods

        /// <summary>
        /// Load the providers from the web.config.
        /// </summary>
        protected void LoadProviders()
        {
            // Avoid claiming lock if providers are already loaded
            if (this.Default != null)
            {
                return;
            }

            lock (this.objectLock)
            {
                // Do this again to make sure _provider is still null
                if (this.Default != null)
                {
                    return;
                }

                // Get a reference to the Provider section
                var section = (TProviderSection)ConfigurationManager.GetSection(this.sectionName);
                if (section == null)
                {
                    // missing configuration section
                    throw new ConfigurationErrorsException("Missing config section " + this.sectionName);
                }

                // Load registered providers and point _provider
                // to the default provider
                this.Providers = new TProviderCollection();
                System.Web.Configuration.ProvidersHelper.InstantiateProviders(
                    section.Providers,
                    this.Providers,
                    typeof(TProviderClass));

                this.Default = this.Providers[section.DefaultProvider];

                if (this.Default == null)
                {
                    throw new ProviderException("Unable to load default provider");
                }
            }
        }

        #endregion
    }
}
