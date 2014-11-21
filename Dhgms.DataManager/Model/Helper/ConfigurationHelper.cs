// -----------------------------------------------------------------------
// <copyright file="ConfigurationHelper.cs" company="DHGMS Solutions">
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
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Linq;

    using Dhgms.DataManager.Model.ConfigurationElement;
    using Dhgms.DataManager.Model.ConfigurationElementCollection;
    using Dhgms.DataManager.Model.Exception;
    using Dhgms.DataManager.Model.Info.CommandLineSettings;

    /// <summary>
    /// Helper methods for dealing with the XML Config File
    /// </summary>
    public static class ConfigurationHelper
    {
        /// <summary>
        /// Retrieves a run set from the config file, based upon the command line argument
        /// </summary>
        /// <param name="commandLine">
        /// the command line arguments containing the name of the required run set
        /// </param>
        /// <param name="xmlConfigurationSection">
        /// the xml config file containing the run set collection
        /// </param>
        /// <typeparam name="TCommandLine">
        /// The type for the command line object
        /// </typeparam>
        /// <typeparam name="TRunSet">
        /// The type for the run set class
        /// </typeparam>
        /// <typeparam name="TConfigurationClass">
        /// The type for the xml configuration class
        /// </typeparam>
        /// <returns>The required run set</returns>
        /// <exception cref="ArgumentNullException">
        /// One of the arguments passed in is null
        /// </exception>
        /// <exception cref="NullRunSetNameException">
        /// No run set name is specified in the command line arguments
        /// </exception>
        public static RunSet<TRunSet> GetRunSet<TCommandLine, TRunSet, TConfigurationClass>(
            TCommandLine commandLine,
            TConfigurationClass xmlConfigurationSection)
            where TCommandLine : CommandLineSettingsBase, IRunSet
            where TRunSet : RunSet<TRunSet>, new()
            where TConfigurationClass : System.Configuration.ConfigurationSection, IRunSetCollection<TRunSet>
        {
            if (commandLine == null)
            {
                throw new ArgumentNullException("commandLine");
            }

            if (xmlConfigurationSection == null)
            {
                throw new ArgumentNullException("xmlConfigurationSection");
            }

            var runSetName = commandLine.RunSet;
            if (string.IsNullOrWhiteSpace(runSetName))
            {
                throw new NullRunSetNameException();
            }

            var runSets = xmlConfigurationSection.RunSets;
            foreach (var run in runSets.Cast<RunSet<TRunSet>>().Where(run => run.Name.Equals(runSetName, StringComparison.OrdinalIgnoreCase)))
            {
                return run;
            }

            throw new RunSetNotFoundException(runSetName);
        }
    }
}
