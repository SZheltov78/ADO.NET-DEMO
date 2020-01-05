namespace ADO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCommit = new System.Windows.Forms.Button();
            this.buttonRoolback = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUseTransaction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonCommit
            // 
            this.buttonCommit.Enabled = false;
            this.buttonCommit.Location = new System.Drawing.Point(114, 13);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(75, 23);
            this.buttonCommit.TabIndex = 1;
            this.buttonCommit.Text = "Commit";
            this.buttonCommit.UseVisualStyleBackColor = true;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // buttonRoolback
            // 
            this.buttonRoolback.Enabled = false;
            this.buttonRoolback.Location = new System.Drawing.Point(195, 13);
            this.buttonRoolback.Name = "buttonRoolback";
            this.buttonRoolback.Size = new System.Drawing.Size(75, 23);
            this.buttonRoolback.TabIndex = 2;
            this.buttonRoolback.Text = "Roolback";
            this.buttonRoolback.UseVisualStyleBackColor = true;
            this.buttonRoolback.Click += new System.EventHandler(this.buttonRoolback_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(406, 282);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(406, 25);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUseTransaction);
            this.groupBox1.Controls.Add(this.buttonRoolback);
            this.groupBox1.Controls.Add(this.buttonCommit);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 48);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction";
            // 
            // checkBoxUseTransaction
            // 
            this.checkBoxUseTransaction.AutoSize = true;
            this.checkBoxUseTransaction.Location = new System.Drawing.Point(6, 19);
            this.checkBoxUseTransaction.Name = "checkBoxUseTransaction";
            this.checkBoxUseTransaction.Size = new System.Drawing.Size(101, 17);
            this.checkBoxUseTransaction.TabIndex = 0;
            this.checkBoxUseTransaction.Text = "UseTransaction";
            this.checkBoxUseTransaction.UseVisualStyleBackColor = true;
            this.checkBoxUseTransaction.CheckedChanged += new System.EventHandler(this.checkBoxUseTransaction_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADO.NET Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCommit;
        private System.Windows.Forms.Button buttonRoolback;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUseTransaction;
    }
}

