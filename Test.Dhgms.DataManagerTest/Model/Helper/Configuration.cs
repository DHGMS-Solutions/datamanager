// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Configuration.cs" company="">
//   
// </copyright>
// <summary>
//   Tests of helper methods for dealing with the XML Config File
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestDhgms.DataManagerTest.Model.Helper
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TestDhgms.DataManagerMocking.Model.ConfigurationElement;
    using TestDhgms.DataManagerMocking.Model.Info;

    /// <summary>
    /// Tests of helper methods for dealing with the XML Config File
    /// </summary>
    [TestClass]
    public class Configuration
    {
        /// <summary>
        /// Test of the GetRunSet method
        /// </summary>
        [TestClass]
        public class GetRunSetMethod
        {
            #region Public Methods and Operators

            /// <summary>
            /// Test to ensure the call fails if the command line object is null
            /// </summary>
            [TestMethod]
            public void CommandLineNull()
            {
                var element = new RunSet { Name = "Normal" };

                var xmlConfigurationSection = new DataManagerMocking.Model.ConfigurationSection.RunSet();
                xmlConfigurationSection.RunSets.Add(element);

                Xunit.Assert.Throws<System.ArgumentNullException>(
                    () =>
                    Dhgms.DataManager.Model.Helper.Configuration.GetRunSet<CommandLineSettings, RunSet, DataManagerMocking.Model.ConfigurationSection.RunSet>(null, xmlConfigurationSection));
            }

            /// <summary>
            /// Test to ensure the call fails if there is no runset name in the command line object
            /// </summary>
            [TestMethod]
            public void NoRunSetNameInCommandLine()
            {
                var element = new RunSet { Name = "Normal" };

                var xmlConfigurationSection = new DataManagerMocking.Model.ConfigurationSection.RunSet();
                xmlConfigurationSection.RunSets.Add(element);

                var commandLine = new CommandLineSettings();

                Xunit.Assert.Throws<Dhgms.DataManager.Model.Exception.NullRunSetNameException>(
                    () =>
                    Dhgms.DataManager.Model.Helper.Configuration.GetRunSet<CommandLineSettings, RunSet, DataManagerMocking.Model.ConfigurationSection.RunSet>(commandLine, xmlConfigurationSection));
            }

            /// <summary>
            /// Test to ensure the call fails if the specified run set can't be found
            /// </summary>
            [TestMethod]
            public void RunSetNotFound()
            {
                var element = new RunSet { Name = "Normal" };

                var xmlConfigurationSection = new DataManagerMocking.Model.ConfigurationSection.RunSet();
                xmlConfigurationSection.RunSets.Add(element);

                var commandLine = new CommandLineSettings { RunSet = "Missing" };

                Xunit.Assert.Throws<Dhgms.DataManager.Model.Exception.RunSetNotFoundException>(() => 
                    Dhgms.DataManager.Model.Helper.Configuration.GetRunSet<CommandLineSettings, RunSet, DataManagerMocking.Model.ConfigurationSection.RunSet>(commandLine, xmlConfigurationSection));
            }

            /// <summary>
            /// Test to ensure the call suceeds
            /// </summary>
            [TestMethod]
            public void ShouldSucceed()
            {
                var element = new RunSet { Name = "Normal" };

                var xmlConfigurationSection = new DataManagerMocking.Model.ConfigurationSection.RunSet();
                xmlConfigurationSection.RunSets.Add(element);

                var commandLine = new CommandLineSettings { RunSet = "Normal" };

                Dhgms.DataManager.Model.Helper.Configuration.GetRunSet<CommandLineSettings, RunSet, DataManagerMocking.Model.ConfigurationSection.RunSet>(
                        commandLine, xmlConfigurationSection);
            }

            /// <summary>
            /// Test to ensure the call fails if the xml config object is null
            /// </summary>
            [TestMethod]
            public void XmlConfigNull()
            {
                var commandLine = new CommandLineSettings { RunSet = "Normal" };

                Xunit.Assert.Throws<System.ArgumentNullException>(() =>
                    Dhgms.DataManager.Model.Helper.Configuration.GetRunSet<CommandLineSettings, RunSet, DataManagerMocking.Model.ConfigurationSection.RunSet>(
                        commandLine, null));
            }

            #endregion
        }
    }
}