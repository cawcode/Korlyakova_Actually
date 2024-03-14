namespace WinFormsApp1
{
    partial class driverForm
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
            tabControl1 = new TabControl();
            Profile = new TabPage();
            label1 = new Label();
            Orders = new TabPage();
            btnDeny = new Button();
            btnAccept = new Button();
            dataGridView1 = new DataGridView();
            order_id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Forms = new TabPage();
            loadBtn = new Button();
            docPictures = new PictureBox();
            tabControl1.SuspendLayout();
            Profile.SuspendLayout();
            Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Forms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)docPictures).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Profile);
            tabControl1.Controls.Add(Orders);
            tabControl1.Controls.Add(Forms);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(951, 649);
            tabControl1.TabIndex = 0;
            // 
            // Profile
            // 
            Profile.Controls.Add(label1);
            Profile.Location = new Point(4, 29);
            Profile.Name = "Profile";
            Profile.Padding = new Padding(3);
            Profile.Size = new Size(943, 616);
            Profile.TabIndex = 1;
            Profile.Text = "Профиль";
            Profile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(807, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Orders
            // 
            Orders.Controls.Add(btnDeny);
            Orders.Controls.Add(btnAccept);
            Orders.Controls.Add(dataGridView1);
            Orders.Location = new Point(4, 29);
            Orders.Name = "Orders";
            Orders.Size = new Size(943, 616);
            Orders.TabIndex = 2;
            Orders.Text = "Заказы";
            Orders.UseVisualStyleBackColor = true;
            Orders.Click += Orders_Click;
            // 
            // btnDeny
            // 
            btnDeny.Location = new Point(646, 313);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(94, 29);
            btnDeny.TabIndex = 2;
            btnDeny.Text = "Отказаться";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(759, 313);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(94, 29);
            btnAccept.TabIndex = 1;
            btnAccept.Text = "Принять";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { order_id, Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(940, 304);
            dataGridView1.TabIndex = 0;
            // 
            // order_id
            // 
            order_id.HeaderText = "ID заказа";
            order_id.MinimumWidth = 6;
            order_id.Name = "order_id";
            order_id.ReadOnly = true;
            order_id.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Фамилия заказчика";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Имя заказчика";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Телефон заказчика";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Время принятия заказа";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Пункт отправления";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Пункт назначения";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Forms
            // 
            Forms.Controls.Add(loadBtn);
            Forms.Controls.Add(docPictures);
            Forms.Location = new Point(4, 29);
            Forms.Name = "Forms";
            Forms.Size = new Size(943, 616);
            Forms.TabIndex = 3;
            Forms.Text = "Отчеты";
            Forms.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            loadBtn.Location = new Point(305, 169);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(94, 29);
            loadBtn.TabIndex = 1;
            loadBtn.Text = "Загрузить";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // docPictures
            // 
            docPictures.Location = new Point(497, 246);
            docPictures.Name = "docPictures";
            docPictures.Size = new Size(125, 62);
            docPictures.TabIndex = 0;
            docPictures.TabStop = false;
            // 
            // driverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 673);
            Controls.Add(tabControl1);
            Name = "driverForm";
            Text = "driverForm";
            Load += driverForm_Load;
            tabControl1.ResumeLayout(false);
            Profile.ResumeLayout(false);
            Profile.PerformLayout();
            Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Forms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)docPictures).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage Profile;
        private TabPage Orders;
        private TabPage Forms;
        private DataGridView dataGridView1;
        private Button btnDeny;
        private Button btnAccept;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label1;
        private PictureBox docPictures;
        private Button loadBtn;
    }
}