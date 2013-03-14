// --------------------------------------------------------------------------------------------------------------------
// <copyright company="DHGMS Solutions" file="MsSql10.cs">
//   2004-2012 DHGMS Solutions. Some Rights Reserved. Licensed under GNU General Public License version 2 (GPLv2)
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

    /// <summary>
    /// MS SQL Server 10 (2008) Helper methods for Database connections
    /// </summary>
    public class MSSql10 : Base<SqlParameter>
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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override int ActOnDataReader(
            string databaseConnectionString, 
            string sqlCommand, 
            SqlParameter[] parameters, 
            Func<DbDataReader, int> dataReaderAction, 
            bool assumeSqlSafe)
        {
            if (dataReaderAction == null)
            {
                throw new ArgumentNullException("dataReaderAction");
            }

            int result;

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

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                result = dataReaderAction(cmd.ExecuteReader());
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

            return result;
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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override void ExecuteNonQueryStoredProcedure(
            string databaseConnectionString, string procedureName, SqlParameter[] parameters, bool assumeSqlSafe)
        {
            if (!assumeSqlSafe)
            {
                CheckForPossibleSqlInjection(procedureName);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(procedureName, conn)
                    {
                       CommandTimeout = 0, CommandType = CommandType.StoredProcedure 
                    };

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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override bool? GetBoolean(
            string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
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

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                object scalar = cmd.ExecuteScalar();
                if (scalar == null)
                {
                    return null;
                }

                var result = (bool)scalar;

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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override DateTime? GetDate(
            string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
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

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                object scalar = cmd.ExecuteScalar();
                if (scalar == null)
                {
                    return null;
                }

                var result = (DateTime)scalar;

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
        /// a 32-bit integer from the query
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "integer", Justification = "We want to retrieve a specific type of int")]
        public override int GetInteger32(
            string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
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

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                var result = (int)cmd.ExecuteScalar();

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
            return this.GetInteger32(databaseConnectionString, "SELECT COUNT(*) FROM " + table, null, false);
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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
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
                CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
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
                CheckForPossibleSqlInjection(sqlCommand);
            }

            SqlConnection conn = null;
            SqlCommand cmd = null;

            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

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
        /// Whether to skip the SQL injection safety check.  Use only if you know the code you are passing in is safe and contains a quoted string that is preventing it passing the saftey check
        /// </param>
        /// <returns>
        /// A strongly typed object
        /// </returns>
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override List<TInfoClass> GetStronglyTypedCollection<TInfoClass, TAdoNetHelperClass>(
            string databaseConnectionString,
            string sqlCommand,
            SqlParameter[] parameters,
            bool assumeSqlSafe)
        {
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

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

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

                cmd = new SqlCommand(SqlCommand, conn) { CommandTimeout = 0 };

                cmd.Parameters.AddWithValue("@catalogName", databaseName);
                cmd.Parameters.AddWithValue("@schemaName", schema);
                cmd.Parameters.AddWithValue("@tableName", tableName);

                var result = (int)cmd.ExecuteScalar();

                if (!result.Between(0, 1))
                {
                    throw new ArithmeticException("table count is not valid, should be 0 or 1. Got " + result + ".");
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
        [SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "Has basic check for SQL sytnax")]
        public override void ProcessNonQuery(
            string databaseConnectionString, string sqlCommand, SqlParameter[] parameters, bool assumeSqlSafe)
        {
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

                cmd = new SqlCommand(sqlCommand, conn) { CommandTimeout = 0 };

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

        #endregion
    }
}