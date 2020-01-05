using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.DAL
{    
    public class DataAccess    
    {
        public string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= |DataDirectory|\DAL\DemoDatabase.mdf;Integrated Security=True";
        public SqlConnection Connection;

        private SqlDataAdapter dataAdapter;

        private SqlTransaction transaction;
        public bool IsTransactionOn = false;
        public bool EnableTransaction = false;

        private DataTable dataTable;

        public DataAccess()
        {
            Connection = new SqlConnection(ConnectionString);            
        }

        public BindingSource GetTable(string tableName)
        {
            if (string.IsNullOrEmpty(tableName)) throw new Exception("Table name is empty.");

            //Rollback and close old transaction
            if (IsTransactionOn) Rollback();

            //New DataAdapter
            if (dataAdapter!=null) dataAdapter.Dispose();
            dataAdapter = new SqlDataAdapter($"select * from {tableName}", Connection);

            //Default 'CRUD' commands
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.DeleteCommand = sqlCommandBuilder.GetDeleteCommand();
            dataAdapter.InsertCommand = sqlCommandBuilder.GetInsertCommand();
            dataAdapter.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();

            //Binding data
            BindingSource bindingSource = new BindingSource();
            dataTable = new DataTable();
            bindingSource.DataSource = dataTable;
            dataAdapter.Fill(dataTable);    

            return bindingSource;            
        }

        public int SaveChanges()
        {
            //If transaction is not started but enabled then start it.
            if (!IsTransactionOn) if (EnableTransaction) StartTransaction();           

            int rowsChanged = dataAdapter.Update(dataTable);
            return rowsChanged;
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch(Exception ex)
            {
                throw new Exception("Error at 'Commit()': " + ex.ToString());
            }
            finally
            {
                EndTransaction();
            }            
        }

        public void Rollback()
        {
            try
            {
                transaction.Rollback();
            }
            catch (Exception ex)
            {
                throw new Exception("Error at 'Rollback()': " + ex.ToString());
            }
            finally
            {
                EndTransaction();
            }
        }

        public void StartTransaction()
        {
            try
            {
                Connection.Open();
                transaction = Connection.BeginTransaction();

                //Prepare adapter
                dataAdapter.DeleteCommand.Connection = transaction.Connection;
                dataAdapter.InsertCommand.Connection = transaction.Connection;
                dataAdapter.UpdateCommand.Connection = transaction.Connection;

                dataAdapter.DeleteCommand.Transaction = transaction;
                dataAdapter.InsertCommand.Transaction = transaction;
                dataAdapter.UpdateCommand.Transaction = transaction;

                IsTransactionOn = true;
            }
            catch (Exception ex)
            {
                EndTransaction();
                throw new Exception("Error at 'StartTransaction()': " + ex.ToString());
            }

        }

        public void EndTransaction()
        {            
            Connection.Close();
            transaction.Dispose();            
            IsTransactionOn = false;
        }

    }
}
