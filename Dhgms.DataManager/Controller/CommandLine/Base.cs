// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="Base.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
// </copyright>
// <summary>
//   Base class for parsing command line arguements
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Controller.CommandLine
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
    public abstract class Base<TCommandLineSettings>
        where TCommandLineSettings : Model.Info.CommandLineSettings.Base
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
        /// Command Line Settings Information
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
        public abstract void Parse(string[] args);

        #endregion

        #region Methods

        /// <summary>
        /// The get are pair arguments specified.
        /// </summary>
        /// <param name="argCollection">
        /// The arg Collection.
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
                throw new ArgumentException("should containt at least 1 item", "argCollection");
            }

            // gets around lack of IsNullOrWhiteSpace in pre .NET 4
            if (parameter == null || parameter.Trim().Length < 1)
            {
                throw new ArgumentNullException("parameter");
            }

            int endPosition = argCollection.Count - 1;
            int positionCounter = 0;
            while (positionCounter < endPosition)
            {
                if (argCollection[positionCounter].Equals(parameter, StringComparison.OrdinalIgnoreCase))
                {
                    // check to make sure there is an argument after
                    if (positionCounter == endPosition)
                    {
                        throw new ArgumentException("No value for " + parameter + " specified.");
                    }

                    // check the argument after isn't a switch
                    string runSet = argCollection[positionCounter + 1];
                    if (runSet[0].Equals('/'))
                    {
                        throw new ArgumentException("No value for " + parameter + " specified.");
                    }

                    argCollection.RemoveRange(positionCounter, 2);
                    return runSet;
                }

                positionCounter++;
            }

            return null;
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
                throw new ArgumentException("should containt at least 1 item", "argCollection");
            }

            // gets around lack of IsNullOrWhiteSpace in pre .NET 4
            if (parameter == null || parameter.Trim().Length < 1)
            {
                throw new ArgumentNullException("parameter");
            }

            int endPosition = argCollection.Count;
            int positionCounter = 0;
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