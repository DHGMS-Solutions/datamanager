// -----------------------------------------------------------------------
// <copyright file="Base.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper.AdoNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Base class for ADO.NET helpers
    /// </summary>
    public abstract class Base<TInformationClass>
        where TInformationClass : Dhgms.DataManager.Model.Info.Base<TInformationClass>
    {
        /// <summary>
        /// Gets a collection of data columns representing the type
        /// </summary>
        /// <returns>a collection of strings representing the data record</returns>
        public abstract System.Data.DataColumn[] GetDataColumns();

        /// <summary>
        /// Get Strongly Typed Object from a data reader
        /// </summary>
        /// <param name="dataReader">
        /// The data Reader.
        /// </param>
        /// <returns>
        /// strongly typed object.
        /// </returns>
        public abstract TInformationClass GetStronglyTypedObjectFromDataReaderRow(System.Data.Common.DbDataReader dataReader);
    }
}
