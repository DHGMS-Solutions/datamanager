// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunSet.cs" company="DHGMS Solutions">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Represents a run set inside the app config
//   one of them will match the arguement on the command line
//   A run set is a set of rules specific to an invidiual run of the program
//   i.e. a runset of "monday" for a mondays scheduled run
//   or "england" for english machines
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElement
{
    using System;
    using System.Configuration;

    /// <summary>
    /// Represents a run set inside the app config
    /// one of them will match the arguement on the command line
    /// A run set is a set of rules specific to an invidiual run of the program
    /// i.e. a runset of "monday" for a mondays scheduled run
    /// or "england" for english machines
    /// </summary>
    /// <typeparam name="TRunSetClass">
    /// </typeparam>
    public abstract class RunSet<TRunSetClass> : ConfigurationElement
        where TRunSetClass : RunSet<TRunSetClass>
    {
        #region Public Properties

        /// <summary>
        /// The name of the run set
        /// </summary>
        // public System.String name;
        [ConfigurationProperty("Name", IsRequired = true)]
        public string Name
        {
            get
            {
                return (String)this["Name"];
            }

            set
            {
                this["Name"] = value;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Dictates whether the config is read only
        /// </summary>
        /// <returns>
        /// true or false
        /// </returns>
        public override bool IsReadOnly()
        {
            return false;
        }

        #endregion
    }
}