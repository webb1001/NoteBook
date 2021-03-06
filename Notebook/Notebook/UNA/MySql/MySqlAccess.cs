﻿using MySql.Data.MySqlClient;
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

        public MySqlAccess()
        {
            ConnectionString = "server=localhost;database=DbNotebook;uid=root;pwd=mfml1603";
        }

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

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public bool VerificarLogin(string usuario, string contraseña)
        {
            string pUsuario= "";
            string pContraseña = "";
            MySqlCommand command = new MySqlCommand(string.Format("SELECT id_usuario, nombre_usuario, contraseña FROM Usuarios where nombre_usuario = '{0}' and contraseña = '{1}'", usuario, contraseña));
            var connection = GetConnection();
            connection.Open();
            command.Connection = connection;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                idUsuario = reader.GetInt32(0);
                pUsuario = reader.GetString(1);
                pContraseña = (reader.GetString(2));
            }
            if(pUsuario == usuario && pContraseña == (contraseña))
            {
                
                return true;
            }
            else
            {
               
                return false;
            }
        }

        public int RetornaUsuario()
        {
            return idUsuario;
        }

    }
}
