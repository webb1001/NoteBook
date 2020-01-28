using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notebook.UNA.MySql
{
    public class MySqlAccess : DbAccess
    {
        public override void BeginTransaction()
        {
            if(Connection != null)
            {
                Transaction = Connection.BeginTransaction();
            }
        }

        public override void CloseConnection()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }

        public override void CommitTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Commit();
            }
        }

        public override long EjectSQL(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, (MySqlConnection)Connection);
            return command.ExecuteNonQuery();
        }

        public override bool IsTransaction()
        {
            BeginTransaction();
            if (Transaction == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        public override DataTable QuerySQL(string sql)
        {
            DataTable result = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, (MySqlConnection)Connection);
            mySqlDataAdapter.Fill(result);
            return result;
        }

        public override void RollBackTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Rollback();
            }
        }
    }
}
