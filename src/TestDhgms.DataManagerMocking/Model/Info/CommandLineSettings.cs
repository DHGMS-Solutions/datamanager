// -----------------------------------------------------------------------
// <copyright file="RunSet.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace TestDhgms.DataManagerMocking.Model.Info
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Dhgms.DataManager.Model.Info.CommandLineSettings;

    /// <summary>
    /// Mock for testing command line settings
    /// </summary>
    public class CommandLineSettings
        : Dhgms.DataManager.Model.Info.CommandLineSettings.Base, IRunSet
    {
        /// <summary>
        /// Name of the required run set
        /// </summary>
        public string RunSet
        {
            get;
            set;
        }
    }
}
