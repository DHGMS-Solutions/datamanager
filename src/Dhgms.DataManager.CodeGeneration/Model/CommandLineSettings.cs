using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhgms.DataManager.CodeGeneration.Model
{
    using Dhgms.Nucleotide.Model.Info.PropertyInfo;

    public sealed class CommandLineSettings : ProjectClassGenerationParamtersBase
    {
        /// <summary>
        /// Gets the main namespace name.
        /// </summary>
        public override string MainNamespaceName
        {
            get
            {
                return "Dhgms.DataManager";
            }
        }

        /// <summary>
        /// Gets the sub namespace.
        /// </summary>
        public override string SubNamespace
        {
            get
            {
                return "CommandLineSettings";
            }
        }

        /// <summary>
        /// Gets the class name.
        /// </summary>
        public override string ClassName
        {
            get
            {
                return "CommandLineSettingsBase";
            }
        }

        /// <summary>
        /// Gets the properties.
        /// </summary>
        public override Base[] Properties
        {
            get
            {
                return new[]
                           {
                               (Base)new Dhgms.Nucleotide.Model.Info.PropertyInfo.ClrBoolean(
                                   Dhgms.Nucleotide.Model.Info.CollectionType.None,
                                   "WantsHelp",
                                   "a value indicating whether the user wants the help info displayed",
                                   false,
                                   false,
                                   null)
                           };
            }
        }

        public override Base[] BaseClassProperties
        {
            get
            {
                return null;
            }
        }

        public override string BaseClassName
        {
            get
            {
                return null;
            }
        }

        public override string ClassRemarks
        {
            get
            {
                return "Represents the base command line settings";
            }
        }
    }
}
