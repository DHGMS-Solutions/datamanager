namespace Dhgms.DataManager.Model.Info.CommandLineSettings
{
    /// <summary>
    /// Interface for command line settings that will allow use of /runset
    /// </summary>
    public interface IRunSet
    {
        /// <summary>
        /// Name of the required run set
        /// </summary>
        string RunSet { get; set; }
    }
}
