using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace Forcasting.Repo
{
    public interface IBaseRepo<T>
    {
        bool TestConnection();
    }

    public class BaseRepo<T> : IBaseRepo<T>
    {
        public BaseRepo()
        {
            _dbtype = SimpleCRUD.Dialect.SQLite;
        }
        public BaseRepo(SimpleCRUD.Dialect dbtype)
        {
            _dbtype = dbtype;
        }
        private SimpleCRUD.Dialect _dbtype;

        private IDbConnection GetOpenConnection()
        {
            IDbConnection connection = null;
            if (_dbtype == SimpleCRUD.Dialect.SQLite)
            {
                connection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
                SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            }
            connection.Open();
            return connection;
        }

        public bool TestConnection()
        {
            using (var conn = GetOpenConnection())
            {
                if (conn.State == ConnectionState.Open)
                {
                    return true;
                }
                else if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    return true;
                }
            }
            return false;
        }
    }
}
