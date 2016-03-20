// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="MsSql10.cs">
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
//   MS SQL Server 10 (2008) Helper methods for Database connections
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Dhgms.DataManager.Model.Helper.Database
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    using Dhgms.DataManager.Model.Exception;

    /// <summary>
    /// MS SQL Server 10 (2008) Helper methods for Database connections
    /// </summary>
    public class MSSql10 : DatabaseHelperBase<SqlParameter, SqlParameterCollection>
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
        /// <returns>
        /// The act on data reader.
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override long OnActUponDataReader(
            string databaseConnectionString, 
            string sqlCommand, 
            SqlParameter[] parameters, 
            Func<IDataReader, long> dataReaderAction)
        {
            if (dataReaderAction == null)
            {
                throw new ArgumentNullException("dataReaderAction");
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn);

                // don't change this to an initialisation list
                // fxcop doesn't like
                cmd.CommandTimeout = 0;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return dataReaderAction(cmd.ExecuteReader());
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override void ExecuteNonQueryStoredProcedure(
            string databaseConnectionString, string procedureName, SqlParameter[] parameters, bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(procedureName);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(procedureName, conn);

                // don't change this to an initialisation list
                // fxcop doesn't like
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

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
        public override int GetRecordCount(string databaseConnectionString, string table)
        {
            // ReSharper disable PossibleInvalidOperationException
            return this.GetInteger32(databaseConnectionString, "SELECT COUNT(*) FROM " + table, null, false).Value;
            // ReSharper restore PossibleInvalidOperationException
        }

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
        /// <param name="parameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override TInfoClass GetSingleRecord<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString,
            string sqlCommand,
            SqlParameter[] parameters,
            bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn);
                cmd.CommandTimeout = 0;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                DbDataReader reader = cmd.ExecuteReader();
                var helper = new TAdoNetHelperClass();
                TInfoClass result = null;
                if (reader.HasRows)
                {
                    result = helper.GetStronglyTypedObjectFromDataReaderRow(reader);
                }

                return result;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override IList<string> GetStrings(
            string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn);
                cmd.CommandTimeout = 0;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                DbDataReader reader = cmd.ExecuteReader();
                var result = new List<string>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0));
                    }
                }

                return result;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

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
        /// <param name="parameters">
        /// Collection of parameters relating to the command
        /// </param>
        /// <param name="assumeSqlSafe">
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the safety check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override IList<TInfoClass> GetStronglyTypedCollection<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString,
            string sqlCommand,
            SqlParameter[] parameters,
            bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn);
                cmd.CommandTimeout = 0;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                DbDataReader reader = cmd.ExecuteReader();
                var result = new List<TInfoClass>();
                if (reader.HasRows)
                {
                    var helper = new TAdoNetHelperClass();
                    while (reader.Read())
                    {
                        result.Add(helper.GetStronglyTypedObjectFromDataReaderRow(reader));
                    }
                }

                return result;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// checks if a table exists in database
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database Connection String
        /// </param>
        /// <param name="databaseName">
        /// Name of the database containing the table
        /// </param>
        /// <param name="schema">
        /// Name of the schema containing the table
        /// </param>
        /// <param name="tableName">
        /// Name of the table
        /// </param>
        /// <returns>
        /// The get table exists.
        /// </returns>
        public override bool GetTableExists(
            string databaseConnectionString, string databaseName, string schema, string tableName)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                const string SqlCommand =
                    "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES" + "WHERE" + " TABLE_NAME = @tableName"
                    + " AND TABLE_SCHEMA = @schemaName" + " AND TABLE_CATALOG = @catalogName";

                cmd = new SqlCommand(SqlCommand, conn);
                cmd.CommandTimeout = 0;

                cmd.Parameters.AddWithValue("@catalogName", databaseName);
                cmd.Parameters.AddWithValue("@schemaName", schema);
                cmd.Parameters.AddWithValue("@tableName", tableName);

                var result = (int)cmd.ExecuteScalar();

                if (!result.Between(0, 1))
                {
                    throw new InvalidTableCountException();
                }

                // returns true or false
                return result == 1;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// Wrapper for processing a function and dealing with the parameter collection results
        /// </summary>
        /// <param name="databaseConnectionString">Database Connection String
        ///             </param><param name="sqlCommand">Command to Execute
        ///             </param><param name="parameters">Collection of parameters relating to the command
        ///             </param><param name="assumeSqlSafe">Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        ///             </param>
        /// <param name="parameterProcessingFunction">Function for processing the parameter result collection and returning it as a POCO object.</param>
        public override TInfoClass ProcessFunction<TInfoClass>(string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe, Func<SqlParameterCollection, TInfoClass> parameterProcessingFunction)
        {
            if (parameterProcessingFunction == null)
            {
                throw new ArgumentNullException("parameterProcessingFunction");
            }

            if (!assumeSqlSafe)
            {
                CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                // don't use initialization list with IDisposable - upsets FXCOP
                // ReSharper disable UseObjectOrCollectionInitializer
                cmd = new SqlCommand(sqlCommand, conn);
                // ReSharper restore UseObjectOrCollectionInitializer
                cmd.CommandTimeout = 0;
                cmd.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                cmd.ExecuteNonQuery();
                return parameterProcessingFunction(cmd.Parameters);
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override void ProcessNonQuery(
            string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn);
                cmd.CommandTimeout = 0;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }

        /// <summary>
        /// Shrinks a database file
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database connection string
        /// </param>
        /// <param name="fileName">
        /// file name to shrink
        /// </param>
        public override void ShrinkFile(string databaseConnectionString, string fileName)
        {
            this.ProcessNonQuery(databaseConnectionString, "DBCC SHRINKFILE(" + fileName + ")", null, false);
        }

        /// <summary>
        /// Shrink all files used for a database
        /// </summary>
        /// <param name="databaseConnectionString">
        /// Database connection string
        /// </param>
        public override void ShrinkFiles(string databaseConnectionString)
        {
            var sb = new StringBuilder();
            sb.AppendLine("SELECT NAME");
            sb.AppendLine("FROM sys.sysfiles");

            IList<string> filenames = this.GetStrings(databaseConnectionString, sb.ToString(), null, false);

            foreach (string filename in filenames)
            {
                this.ShrinkFile(databaseConnectionString, filename);
            }
        }

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
        public override void TruncateTable(
            string databaseConnectionString, string databaseName, string schema, string tableName)
        {
            this.ProcessNonQuery(
                databaseConnectionString, "TRUNCATE TABLE " + databaseName + "." + schema + "." + tableName, null, false);
        }

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
        public override void WipeAndReseed(
            string databaseConnectionString, string databaseName, string schema, string tableName)
        {
            this.ProcessNonQuery(
                databaseConnectionString, 
                "DELETE FROM [" + databaseName + "].[" + schema + "].[" + tableName + "]", 
                null, 
                false);
            this.ProcessNonQuery(
                databaseConnectionString, 
                "DBCC CHECKIDENT(\"" + schema + "." + tableName + "\", RESEED, 0)", 
                null, 
                false);
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        protected override object GetScalar(string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                this.CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn);
                cmd.CommandTimeout = 0;

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteScalar();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }
        #endregion
    }
}