// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseHelperBase.cs" company="DHGMS Solutions">
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
//   DatabaseHelperBase class for database helper methods
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper.Database
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;

    using Dhgms.DataManager.Model.Exception;

    /// <summary>
    /// DatabaseHelperBase class for database helper methods
    /// </summary>
    /// <typeparam name="TParameter">
    /// The .NET Database Parameter type
    /// </typeparam>
    /// <typeparam name="TParameterCollection">
    /// The .NET Database Parameter Collection type
    /// </typeparam>
    public abstract class DatabaseHelperBase<TParameter, TParameterCollection>
        where TParameter : DbParameter
        where TParameterCollection : DbParameterCollection
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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// The act on data reader.
        /// </returns>
        public long ActUponDataReader(
            string databaseConnectionString,
            string sqlCommand,
            TParameter[] parameters,
            Func<IDataReader, long> dataReaderAction,
            bool assumeSqlSafe)
        {
            if (dataReaderAction == null)
            {
                throw new ArgumentNullException("dataReaderAction");
            }

            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(sqlCommand);
            }

            return this.OnActUponDataReader(databaseConnectionString, sqlCommand, parameters, dataReaderAction);
        }

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
        /// <returns>
        /// The act on data reader.
        /// </returns>
        public abstract long OnActUponDataReader(
            string databaseConnectionString, 
            string sqlCommand, 
            TParameter[] parameters, 
            Func<IDataReader, long> dataReaderAction);

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        public abstract void ExecuteNonQueryStoredProcedure(
            string databaseConnectionString, string procedureName, TParameter[] parameters, bool assumeSqlSafe);

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        public abstract TInfoClass GetSingleRecord<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString, string sqlCommand, TParameter[] sqlParameters, bool assumeSqlSafe)
            where TInfoClass : Info.InfoBase<TInfoClass>, new()
            where TAdoNetHelperClass : AdoNet.AdoNetBase<TInfoClass>, new();

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// collection of strings
        /// </returns>
        public abstract IList<string> GetStrings(string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", 
            Justification = "We do basic checks.")]
        public abstract IList<TInfoClass> GetStronglyTypedCollection<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString, string sqlCommand, TParameter[] sqlParameters, bool assumeSqlSafe)
            where TInfoClass : Info.InfoBase<TInfoClass>, new()
            where TAdoNetHelperClass : AdoNet.AdoNetBase<TInfoClass>, new();

        /// <summary>
        /// Checks if a table exists.
        /// </summary>
        /// <param name="databaseConnectionString">
        /// The database connection string.
        /// </param>
        /// <param name="databaseName">
        /// The database name.
        /// </param>
        /// <param name="schema">
        /// The schema.
        /// </param>
        /// <param name="tableName">
        /// The table name.
        /// </param>
        /// <returns>
        /// A flag indicating whether the table exists.
        /// </returns>
        public abstract bool GetTableExists(string databaseConnectionString, string databaseName, string schema, string tableName);

        /// <summary>
        /// Wrapper for processing a function and dealing with the parameter collection results
        /// </summary>
        /// <param name="databaseConnectionString">Database Connection String
        ///             </param><param name="sqlCommand">Command to Execute
        ///             </param><param name="parameters">Collection of parameters relating to the command
        ///             </param><param name="assumeSqlSafe">Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        ///             </param>
        /// <param name="parameterProcessingFunction">Function for processing the parameter result collection and returning it as a POCO object.</param>
        public abstract TInfoClass ProcessFunction<TInfoClass>(string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe, Func<TParameterCollection, TInfoClass> parameterProcessingFunction);

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        public abstract void ProcessNonQuery(string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe);

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
        /// Deletes the contents of a table and reseeds the identity index to 0.
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
        public abstract void WipeAndReseed(string databaseConnectionString, string databaseName, string schema, string tableName);

        #endregion

        #region Methods

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// Date or null
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public bool? GetBoolean(string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe)
        {
            var scalar = this.GetScalar(databaseConnectionString, sqlCommand, parameters, assumeSqlSafe);
            if (scalar == null)
            {
                return null;
            }

            return (bool)scalar;
        }

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// Date or null
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public DateTime? GetDate(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe)
        {
            var scalar = this.GetScalar(databaseConnectionString, sqlCommand, parameters, assumeSqlSafe);
            if (scalar == null)
            {
                return null;
            }

            return (DateTime)scalar;
        }

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// a 32-bit integer from the query
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "We want to retrieve a specific type of int")]
        public int? GetInteger32(string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe)
        {
            var scalar = this.GetScalar(databaseConnectionString, sqlCommand, parameters, assumeSqlSafe);
            if (scalar == null)
            {
                return null;
            }

            return (int)scalar;
        }

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// a 64-bit integer from the query
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "We want to retrieve a specific type of int")]
        public long? GetInteger64(
            string databaseConnectionString, string sqlCommand, TParameter[] parameters, bool assumeSqlSafe)
        {
            var scalar = this.GetScalar(databaseConnectionString, sqlCommand, parameters, assumeSqlSafe);
            if (scalar == null)
            {
                return null;
            }

            return Convert.ToInt64(scalar, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Checks for possible SQL injection attempts. Isn't fully fool proof.  Responsibility needs to be with the caller to the library.
        /// </summary>
        /// <param name="sqlCommand">
        /// The SQL command to parse
        /// </param>
        protected void CheckForPossibleSqlInjection(string sqlCommand)
        {
            if (sqlCommand == null)
            {
                throw new ArgumentNullException("sqlCommand");
            }

            sqlCommand = sqlCommand.Normalize();

            if (sqlCommand.Contains("''"))
            {
                throw new PossibleSqlInjectionException('\'');
            }

            if (sqlCommand.Contains(";"))
            {
                throw new PossibleSqlInjectionException(';');
            }

            if (sqlCommand.Contains("--"))
            {
                throw new PossibleSqlInjectionException("--");
            }

            if (sqlCommand.Contains("/*"))
            {
                throw new PossibleSqlInjectionException(";");
            }
        }

        /// <summary>
        /// Gets a scalar from a database query.
        /// </summary>
        /// <param name="databaseConnectionString">
        /// The database connection string.
        /// </param>
        /// <param name="sqlCommand">
        /// The SQL command.
        /// </param>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to assume the SQL is safe
        /// </param>
        /// <returns>
        /// The scalar object.
        /// </returns>
        protected abstract object GetScalar(
            string databaseConnectionString,
            string sqlCommand,
            TParameter[] parameters,
            bool assumeSqlSafe);

        #endregion
    }
}