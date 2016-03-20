// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdoNetBase.cs" company="DHGMS Solutions">
//   Copyright 2004-2014 DHGMS Solutions.
//      
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//      
//   http://www.apache.org/licenses/LICENSE-2.0
//      
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
// <summary>
//   Base class for ADO.NET helpers
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper.AdoNet
{
    using System.Data;

    /// <summary>
    /// Base class for ADO.NET helpers
    /// </summary>
    /// <typeparam name="TInformationClass">
    /// The type for the information class.
    /// </typeparam>
    public abstract class AdoNetBase<TInformationClass>
        where TInformationClass : Info.InfoBase<TInformationClass>
    {
        /// <summary>
        /// Gets a collection of data columns representing the type
        /// </summary>
        /// <returns>a collection of strings representing the data record</returns>
        public abstract DataColumn[] GetDataColumns();

        /// <summary>
        /// Get Strongly Typed Object from a data reader
        /// </summary>
        /// <param name="dataReader">
        /// The data Reader.
        /// </param>
        /// <returns>
        /// strongly typed object.
        /// </returns>
        public abstract TInformationClass GetStronglyTypedObjectFromDataReaderRow(IDataReader dataReader);
    }
}
