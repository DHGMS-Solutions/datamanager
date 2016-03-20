using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.DataManager.CodeGeneration.Model
{
    public abstract class ProjectClassGenerationParamtersBase : Dhgms.Nucleotide.Model.Info.ClassGenerationParameters
    {
        /// <summary>
        /// Gets the company name.
        /// </summary>
        public sealed override string CompanyName
        {
            get
            {
                return "DHGMS Solutions";
            }
        }

        /// <summary>
        /// Gets the copyright banner.
        /// </summary>
        public sealed override string[] CopyrightBanner
        {
            get
            {
                return new[]
                {
                    "Licensed under the Apache License, Version 2.0 (the \"License\");",
                    "you may not use this file except in compliance with the License.",
                    "You may obtain a copy of the License at",
                    string.Empty,
                    "    http://www.apache.org/licenses/LICENSE-2.0",
                    string.Empty,
                    "Unless required by applicable law or agreed to in writing, software",
                    "distributed under the License is distributed on an \"AS IS\" BASIS,",
                    "WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.",
                    "See the License for the specific language governing permissions and",
                    "limitations under the License."
                };
            }
        }

        public sealed override int CopyrightStartYear
        {
            get
            {
                return 2004;
            }
        }
    }
}