// -----------------------------------------------------------------------
// <copyright file="IRunsetCollection.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.ConfigurationElementCollection.Interface
{
    /// <summary>
    /// Used for a xml config that supports run sets
    /// </summary>
    public interface IRunSetCollection<TRunSetElementClass>
        where TRunSetElementClass : ConfigurationElement.RunSet<TRunSetElementClass>, new()
    {
        /// <summary>
        /// Gets or sets the run sets in the config file
        /// </summary>
        RunSetCollection<TRunSetElementClass> RunSets { get; set; }
    }
}
