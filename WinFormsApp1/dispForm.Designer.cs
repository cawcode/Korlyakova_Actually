namespace WinFormsApp1
{
    partial class dispForm
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
            tabPage1 = new TabPage();
            dgvOrders = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            label9 = new Label();
            label8 = new Label();
            dgvClients = new DataGridView();
            client_id = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txtBoxPnum = new TextBox();
            btnPushClient = new Button();
            btnCreateOrder = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBoxEadress = new TextBox();
            txtBoxBadress = new TextBox();
            txtBoxPtrnmc = new TextBox();
            txtBoxFname = new TextBox();
            txtBoxSname = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1238, 448);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvOrders);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1230, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заказы";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(1230, 415);
            dgvOrders.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Фамилия клиента";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Имя клиента";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Телефон клиента";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Время принятие заказа";
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
            // Column7
            // 
            Column7.HeaderText = "Статус заказа";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Фамилия водителя";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Имя водителя";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Телефон водителя";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dgvClients);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtBoxPnum);
            tabPage2.Controls.Add(btnPushClient);
            tabPage2.Controls.Add(btnCreateOrder);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtBoxEadress);
            tabPage2.Controls.Add(txtBoxBadress);
            tabPage2.Controls.Add(txtBoxPtrnmc);
            tabPage2.Controls.Add(txtBoxFname);
            tabPage2.Controls.Add(txtBoxSname);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1230, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Создать заказ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(256, 20);
            label9.Name = "label9";
            label9.Size = new Size(189, 20);
            label9.TabIndex = 18;
            label9.Text = "ДОБАВИТЬ ЗАКАЗЧИКА";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(19, 20);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 17;
            label8.Text = "СОЗДАНИЕ ЗАКАЗА";
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Columns.AddRange(new DataGridViewColumn[] { client_id, Column11, Column12, Column13, Column14 });
            dgvClients.Location = new Point(485, 20);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.Size = new Size(723, 371);
            dgvClients.TabIndex = 16;
            // 
            // client_id
            // 
            client_id.HeaderText = "ID";
            client_id.MinimumWidth = 6;
            client_id.Name = "client_id";
            client_id.ReadOnly = true;
            client_id.Width = 53;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column11.HeaderText = "Фамилия";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column12.HeaderText = "Имя";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column13.HeaderText = "Отчество";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            // 
            // Column14
            // 
            Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column14.HeaderText = "Телефон";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 230);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 15;
            label7.Text = "Телефон";
            // 
            // txtBoxPnum
            // 
            txtBoxPnum.Location = new Point(256, 253);
            txtBoxPnum.Name = "txtBoxPnum";
            txtBoxPnum.Size = new Size(200, 27);
            txtBoxPnum.TabIndex = 14;
            txtBoxPnum.TextChanged += textBox7_TextChanged;
            // 
            // btnPushClient
            // 
            btnPushClient.Location = new Point(256, 362);
            btnPushClient.Name = "btnPushClient";
            btnPushClient.Size = new Size(200, 29);
            btnPushClient.TabIndex = 13;
            btnPushClient.Text = "Внести";
            btnPushClient.UseVisualStyleBackColor = true;
            btnPushClient.Click += btnPushClient_Click;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(19, 362);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(200, 29);
            btnCreateOrder.TabIndex = 12;
            btnCreateOrder.Text = "Создать заказ";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 173);
            label6.Name = "label6";
            label6.Size = new Size(136, 20);
            label6.TabIndex = 11;
            label6.Text = "Пункт назначения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 59);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 10;
            label5.Text = "Пункт отправления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 173);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Отчество";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 116);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 7;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 59);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 6;
            label1.Text = "Фамилия";
            // 
            // txtBoxEadress
            // 
            txtBoxEadress.Location = new Point(19, 196);
            txtBoxEadress.Multiline = true;
            txtBoxEadress.Name = "txtBoxEadress";
            txtBoxEadress.Size = new Size(200, 84);
            txtBoxEadress.TabIndex = 4;
            // 
            // txtBoxBadress
            // 
            txtBoxBadress.Location = new Point(19, 82);
            txtBoxBadress.Multiline = true;
            txtBoxBadress.Name = "txtBoxBadress";
            txtBoxBadress.Size = new Size(200, 84);
            txtBoxBadress.TabIndex = 3;
            // 
            // txtBoxPtrnmc
            // 
            txtBoxPtrnmc.Location = new Point(256, 196);
            txtBoxPtrnmc.Name = "txtBoxPtrnmc";
            txtBoxPtrnmc.Size = new Size(200, 27);
            txtBoxPtrnmc.TabIndex = 2;
            // 
            // txtBoxFname
            // 
            txtBoxFname.Location = new Point(256, 139);
            txtBoxFname.Name = "txtBoxFname";
            txtBoxFname.Size = new Size(200, 27);
            txtBoxFname.TabIndex = 1;
            // 
            // txtBoxSname
            // 
            txtBoxSname.Location = new Point(256, 82);
            txtBoxSname.Name = "txtBoxSname";
            txtBoxSname.Size = new Size(200, 27);
            txtBoxSname.TabIndex = 0;
            // 
            // dispForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 473);
            Controls.Add(tabControl1);
            Name = "dispForm";
            Text = "dispForm";
            FormClosing += dispForm_FormClosing;
            Load += dispForm_Load;
            Leave += dispForm_Leave;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private TabPage tabPage2;
        private TextBox txtBoxFname;
        private TextBox txtBoxSname;
        private TextBox txtBoxBadress;
        private TextBox txtBoxPtrnmc;
        private TextBox txtBoxEadress;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCreateOrder;
        private Label label7;
        private TextBox txtBoxPnum;
        private Button btnPushClient;
        private Label label9;
        private Label label8;
        private DataGridView dgvClients;
        private DataGridViewTextBoxColumn client_id;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
    }
}