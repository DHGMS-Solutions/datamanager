// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Base class for providers
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Provider
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration.Provider;

    /// <summary>
    /// Base class for providers
    /// </summary>
    public abstract class Base : ProviderBase
    {
        #region Public Methods and Operators

        /// <summary>
        /// The initialize.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="config">
        /// </param>
        public override void Initialize(string name, NameValueCollection config)
        {
            // Verify that config isn't null
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            base.Initialize(name, config);

            this.OnInitialize(name, config);

            // Throw an exception if unrecognized attributes remain
            if (config.Count <= 0)
            {
                return;
            }

            string attr = config.GetKey(0);
            if (!string.IsNullOrEmpty(attr))
            {
                throw new ProviderException("Unrecognized attribute: " + attr);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The on initialize.
        /// </summary>
        /// <param name="name">
        /// </param>
        /// <param name="config">
        /// </param>
        protected abstract void OnInitialize(string name, NameValueCollection config);

        #endregion
    }
}