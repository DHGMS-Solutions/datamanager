﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RunSet.cs" company="DHGMS Solutions">
//   Copyright 2004-2014 DHGMS Solutions.
//      
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//      
//   http://www.apache.org/licenses/LICENSE-2.0
//      
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
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
    /// one of them will match the argument on the command line
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
                return (string)this["Name"];
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