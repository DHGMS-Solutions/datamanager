using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dhgms.DataManager.Mocking.Model.ConfigurationLoader
{
    public class MockCodeBasedConfiguration : IMockConfiguration
    {
        public int One
        {
            get
            {
                return 1;
            }
        }

        public int Two
        {
            get
            {
                return 2;
            }
        }
    }
}
