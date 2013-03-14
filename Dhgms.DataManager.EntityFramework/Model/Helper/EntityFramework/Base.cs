// -----------------------------------------------------------------------
// <copyright file="Base.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper.EntityFramework
{
    using System.Data.Entity;

    /// <summary>
    /// Base class for entity framework helpers
    /// </summary>
    public abstract class Base<TInformationClass>
        where TInformationClass : Info.Base<TInformationClass>
    {
        /// <summary>
        /// Maps the information class to the entity framework model
        /// </summary>
        /// <param name="modelBuilder">
        /// model builder object
        /// </param>
        /// <param name="schemaName">
        /// The schema Name in the database
        /// </param>
        /// <param name="tableName">
        /// The table Name in the database
        /// </param>
        public abstract void DoEntityFrameworkModel(DbModelBuilder modelBuilder, string schemaName, string tableName);
    }
}
