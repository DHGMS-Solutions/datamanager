// -----------------------------------------------------------------------
// <copyright file="RunSet.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestDhgms.DataManagerMocking.Model.ConfigurationSection
{
    using Dhgms.DataManager.Model.ConfigurationElementCollection;

    /// <summary>
    /// Mocked config section for run sets
    /// </summary>
    public class RunSet
        : System.Configuration.ConfigurationSection, IRunSetCollection<Model.ConfigurationElement.RunSet>
    {
        /// <summary>
        /// Collection of RunSets
        /// </summary>
        [System.Configuration.ConfigurationProperty("RunSets", IsRequired = true)]
        public RunSetCollection<ConfigurationElement.RunSet> RunSets
        {
            get
            {
                return (RunSetCollection<ConfigurationElement.RunSet>)this["RunSets"];
            }
            set
            {
                this["RunSets"] = value;
            }
        }
    }
}
