// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Base.cs" company="">
//   
// </copyright>
// <summary>
//   Base class for database helper methods
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper.Database
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;

    using Dhgms.DataManager.Model.Exception;

    /// <summary>
    /// Base class for database helper methods
    /// </summary>
    /// <typeparam name="TParameter">
    /// The .NET Database Parameter type
    /// </typeparam>
    public abstract class Base<TParameter>
        where TParameter : DbParameter
    {
        #region Public Methods and Operators

        /// <summary>
        /// Opens a data reader then uses an action to process it
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="dataReaderAction">
        /// The method that is going to use the data reader
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// The act on data reader.
        /// </returns>
        public abstract int ActOnDataReader(
            string databaseConnectionString, 
            string sqlCommand, 
            TParameter[] parameters, 
            Func<DbDataReader, int> dataReaderAction, 
            bool assumeSqlSafe);

        /// <summary>
        /// Executes a Non query Stored Procedure
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="procedureName">
        /// The stored procedure to call
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        public abstract void ExecuteNonQueryStoredProcedure(
            string databaseConnectionString, string procedureName, TParameter[] parameters, bool assumeSqlSafe);

        /// <summary>
        /// Gets a boolean from a scalar query
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relevant to the query
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// Date or null
        /// </returns>
        public abstract bool? GetBoolean(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

        /// <summary>
        /// Gets a date from a scalar query without parameters
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relevant to the query
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// Date or null
        /// </returns>
        public abstract DateTime? GetDate(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

        /// <summary>
        /// Gets an integer from a scalar query without parameters
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relevant to the query
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// integer result of the SQL query
        /// </returns>
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", 
            Justification = "Is returning a very specific type from a database query.")]
        public abstract int GetInteger32(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

        /// <summary>
        /// Gets the number of records in a table
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="table">
        /// The table
        /// </param>
        /// <returns>
        /// Number of records in the table
        /// </returns>
        public abstract int GetRecordCount(string databaseConnectionString, string table);

        /// <summary>
        /// Gets a strongly typed object that represents a record
        /// </summary>
        /// <typeparam name="TInfoClass">
        /// The data type to convert the data to
        /// </typeparam>
        /// <typeparam name="TAdoNetHelperClass">
        /// Type for the ADO.NET Helper class
        /// </typeparam>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="sqlParameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        public abstract TInfoClass GetSingleRecord<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString, string sqlCommand, TParameter[] sqlParameters, bool assumeSqlSafe)
            where TInfoClass : Info.Base<TInfoClass>, new()
            where TAdoNetHelperClass : Helper.AdoNet.Base<TInfoClass>, new();

        /// <summary>
        /// Gets a collection of strings from a select
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// collection of strings
        /// </returns>
        public abstract IList<string> GetStrings(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

        /// <summary>
        /// Gets a strongly typed object that represents a record
        /// </summary>
        /// <typeparam name="TInfoClass">
        /// The data type to convert the data to
        /// </typeparam>
        /// <typeparam name="TAdoNetHelperClass">
        /// Type for the ADO.NET Helper class
        /// </typeparam>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to execute
        /// </param>
        /// <param name="sqlParameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", 
            Justification = "We do basic checks.")]
        public abstract List<TInfoClass> GetStronglyTypedCollection<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString, string sqlCommand, TParameter[] sqlParameters, bool assumeSqlSafe)
            where TInfoClass : Info.Base<TInfoClass>, new()
            where TAdoNetHelperClass : Helper.AdoNet.Base<TInfoClass>, new();

        /// <summary>
        /// checks if a table exists in database
        /// </summary>
        /// <param name="databaseConnectionString">
        /// </param>
        /// <param name="databaseName">
        /// </param>
        /// <param name="schema">
        /// </param>
        /// <param name="tableName">
        /// </param>
        /// <returns>
        /// The get table exists.
        /// </returns>
        public abstract bool GetTableExists(
            string databaseConnectionString, string databaseName, string schema, string tableName);

        /// <summary>
        /// Wrapper for processing a non query SQL command
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="sqlCommand">
        /// Command to Execute
        /// </param>
        /// <param name="parameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        public abstract void ProcessNonQuery(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

        /// <summary>
        /// Shrinks a database file
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database connection string
        /// </param>
        /// <param name="fileName">
        /// file name to shrink
        /// </param>
        public abstract void ShrinkFile(string databaseConnectionString, string fileName);

        /// <summary>
        /// Shrink all files used for a database
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database connection string
        /// </param>
        public abstract void ShrinkFiles(string databaseConnectionString);

        /// <summary>
        /// Truncates a table.
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="databaseName">
        /// Name of the database containing the table
        /// </param>
        /// <param name="schema">
        /// The name of the schema containing the table
        /// </param>
        /// <param name="tableName">
        /// The name of the table to truncate
        /// </param>
        public abstract void TruncateTable(
            string databaseConnectionString, string databaseName, string schema, string tableName);

        /// <summary>
        /// Deletes the contents of a table and reseeds the identity index(es) to 0.
        /// Designed to be used on tables that can't be truncated due to foreign key
        /// constraints.  Even if the other tables are empty.
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="databaseName">
        /// Name of the database containing the table
        /// </param>
        /// <param name="schema">
        /// The name of the schema containing the table
        /// </param>
        /// <param name="tableName">
        /// The name of the table to wipe
        /// </param>
        public abstract void WipeAndReseed(
            string databaseConnectionString, string databaseName, string schema, string tableName);

        #endregion

        #region Methods

        /// <summary>
        /// Checks for possible SQL injection attempts. Isn't fully fool proof.  Responsibility needs to be with the caller to the library.
        /// </summary>
        /// <param name="sqlCommand">
        /// The SQL command to parse
        /// </param>
        protected static void CheckForPossibleSqlInjection(string sqlCommand)
        {
            if (sqlCommand == null)
            {
                throw new ArgumentNullException("sqlCommand");
            }

            if (sqlCommand.Contains("''"))
            {
                throw new PossibleSqlInjectionException('\'');
            }

            if (sqlCommand.Contains(";"))
            {
                throw new PossibleSqlInjectionException(';');
            }
        }

        #endregion
    }
}