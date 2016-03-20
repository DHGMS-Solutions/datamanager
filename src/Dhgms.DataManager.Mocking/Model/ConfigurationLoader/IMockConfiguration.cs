using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.Mocking.Model.ConfigurationLoader
{
    public interface IMockConfiguration : Dhgms.DataManager.Model.IApplicationConfiguration
    {
        int One { get; }

        int Two { get; }
    }
}
