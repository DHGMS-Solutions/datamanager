// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="CommandLineBase.cs">
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
//   Base class for parsing command line arguements
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Base class for parsing command line arguments
    /// </summary>
    /// <typeparam name="TCommandLineSettings">
    /// The settings class that represents the command line arguments
    /// </typeparam>
    public abstract class CommandLineBase<TCommandLineSettings>
        where TCommandLineSettings : Model.Info.CommandLineSettings.CommandLineSettingsBase
    {
        #region Public Properties

        /// <summary>
        /// Gets a value indicating whether /? has been specified on the command line
        /// </summary>
        /// <returns>whether /? has been specified</returns>
        public bool WantsHelp
        {
            get
            {
                return this.CommandLineSettings.WantsHelp;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Command Line Settings
        /// </summary>
        protected TCommandLineSettings CommandLineSettings { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Entry point for parsing the command line arguments
        /// </summary>
        /// <param name="args">
        /// Collection of command line arguments
        /// </param>
        /// <returns>
        /// A POCO representing the command line settings.
        /// </returns>
        public abstract TCommandLineSettings Parse(string[] args);

        #endregion

        #region Methods

        /// <summary>
        /// The get are pair arguments specified.
        /// </summary>
        /// <param name="argCollection">
        /// The argument Collection.
        /// </param>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        /// <returns>
        /// whether the switch has been specified
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        protected static string GetArePairArgumentsSpecified(List<string> argCollection, string parameter)
        {
            if (argCollection == null)
            {
                throw new ArgumentNullException("argCollection");
            }

            if (argCollection.Count < 1)
            {
                throw new ArgumentException("argCollection should contain at least 1 item", "argCollection");
            }

            if (string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentNullException("parameter");
            }

            var endPosition = argCollection.Count - 1;
            var positionCounter = 0;
            while (positionCounter < endPosition)
            {
                if (argCollection[positionCounter].Equals(parameter, StringComparison.OrdinalIgnoreCase))
                {
                    return OnPairArgumentSpecified(positionCounter, endPosition, argCollection);
                }

                positionCounter++;
            }

            return null;
        }

// ReSharper disable UnusedParameter.Local
        private static string OnPairArgumentSpecified(int positionCounter, int endPosition, List<string> argCollection)
// ReSharper restore UnusedParameter.Local
        {
            // check to make sure there is an argument after
            if (positionCounter < 1 || positionCounter == endPosition)
            {
                throw new ArgumentOutOfRangeException("positionCounter");
            }

            // check the argument after isn't a switch
            if (argCollection == null)
            {
                throw new ArgumentNullException("argCollection");
            }

            if (argCollection[positionCounter + 1][0].Equals('/'))
            {
                throw new ArgumentException("No value for parameter specified.", "argCollection");
            }

            var result = argCollection[positionCounter + 1];

            argCollection.RemoveRange(positionCounter, 2);
            return result;
        }

        /// <summary>
        /// Checks if a switch has been specified on the command line
        /// </summary>
        /// <param name="argCollection">
        /// command line arguments
        /// </param>
        /// <param name="parameter">
        /// The switch to check for
        /// </param>
        /// <returns>
        /// whether the switch has been specified
        /// </returns>
        protected static bool GetIsSingleArgumentSpecified(IList<string> argCollection, string parameter)
        {
            if (argCollection == null)
            {
                throw new ArgumentNullException("argCollection");
            }

            if (argCollection.Count < 1)
            {
                throw new ArgumentException("argCollection should contain at least 1 item", "argCollection");
            }

            if (string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentNullException("parameter");
            }

            var endPosition = argCollection.Count;
            var positionCounter = 0;
            while (positionCounter < endPosition)
            {
                if (argCollection[positionCounter].Equals(parameter, StringComparison.OrdinalIgnoreCase))
                {
                    argCollection.RemoveAt(positionCounter);
                    return true;
                }

                positionCounter++;
            }

            return false;
        }

        #endregion
    }
}