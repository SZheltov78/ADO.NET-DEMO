using ADO.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataAccess dataAccess = new DataAccess();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = dataAccess.GetTable("Users");
                dataGridView1.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int n = dataAccess.SaveChanges();
                MessageBox.Show($"{n} rows changed.");

                if (dataAccess.EnableTransaction)
                {
                    ShowTransactionButtons();
                }
                else
                {
                    HideTransactionButtons();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonCommit_Click(object sender, EventArgs e)
        {
            dataAccess.Commit();
            HideTransactionButtons();
        }

        private void buttonRoolback_Click(object sender, EventArgs e)
        {
            dataAccess.Rollback();
            HideTransactionButtons();
        }      

        private void checkBoxUseTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseTransaction.Checked)
            {
                dataAccess.EnableTransaction = true;
            }
            else
            {
                dataAccess.EnableTransaction = false;
            }

        }

        private void HideTransactionButtons()
        {
            buttonCommit.Enabled = false;
            buttonRoolback.Enabled = false;
        }

        private void ShowTransactionButtons()
        {
            buttonCommit.Enabled = true;
            buttonRoolback.Enabled = true;
        }

    }
}
