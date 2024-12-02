namespace Responsi_2_500276
{
    partial class FormHome
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            tbNama = new TextBox();
            tbDep = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(362, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 114);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 10);
            label1.Name = "label1";
            label1.Size = new Size(87, 90);
            label1.TabIndex = 0;
            label1.Text = "ID Departemen\r\nHR : HR\r\nENG: Engineer\r\nDEV: Developer\r\nPM: Product M\r\nFIN: Finance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 22);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Logo";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(136, 70);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(173, 23);
            tbNama.TabIndex = 2;
            // 
            // tbDep
            // 
            tbDep.FormattingEnabled = true;
            tbDep.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            tbDep.Location = new Point(136, 99);
            tbDep.Name = "tbDep";
            tbDep.Size = new Size(173, 23);
            tbDep.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 70);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 4;
            label3.Text = "Nama Karyawan :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 102);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 5;
            label4.Text = "Dep Karyawan :";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(25, 154);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(108, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(200, 154);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(378, 154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(25, 200);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(461, 210);
            dgvData.TabIndex = 9;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 431);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbDep);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox tbNama;
        private ComboBox tbDep;
        private Label label3;
        private Label label4;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
    }
}