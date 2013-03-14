// -----------------------------------------------------------------------
// <copyright file="Configuration.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Dhgms.DataManager.Model.Exception;

    /// <summary>
    /// Helper methods for dealing with the XML Config File
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Retrieves a runset from the config file, based upon the command line argument
        /// </summary>
        /// <param name="commandLine">
        /// the command line arguments containing the name of the required runset
        /// </param>
        /// <param name="xmlConfigurationSection">
        /// the xml config file containing the runset collection
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
        /// <returns>The required runset</returns>
        /// <exception cref="ArgumentNullException">
        /// One of the arguments passed in is null
        /// </exception>
        /// <exception cref="NullRunSetNameException">
        /// No run set name is specified in the command line arguments
        /// </exception>
        public static ConfigurationElement.RunSet<TRunSet> GetRunSet<TCommandLine, TRunSet, TConfigurationClass>(
            TCommandLine commandLine,
            TConfigurationClass xmlConfigurationSection)
            where TCommandLine : Info.CommandLineSettings.Base, Info.CommandLineSettings.Interface.IRunSet
            where TRunSet : ConfigurationElement.RunSet<TRunSet>, new()
            where TConfigurationClass : System.Configuration.ConfigurationSection, ConfigurationElementCollection.Interface.IRunSetCollection<TRunSet>
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
                throw new NullRunSetNameException(runSetName);
            }

            var runSets = xmlConfigurationSection.RunSets;
            foreach (ConfigurationElement.RunSet<TRunSet> run in runSets)
            {
                if (run.Name.Equals(runSetName, StringComparison.OrdinalIgnoreCase))
                {
                    return run;
                }
            }

            throw new RunSetNotFoundException(runSetName);
        }
    }
}
