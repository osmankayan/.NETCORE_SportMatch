namespace SportMatch2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_sportFans = new System.Windows.Forms.DataGridView();
            this.fanNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportFansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new SportMatch2.DataSet1();
            this.dataGridView_ticket = new System.Windows.Forms.DataGridView();
            this.ticketNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_match = new System.Windows.Forms.DataGridView();
            this.matchNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_birthday = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.matchBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sport_FansTableAdapter = new SportMatch2.DataSet1TableAdapters.Sport_FansTableAdapter();
            this.ticketTableAdapter = new SportMatch2.DataSet1TableAdapters.TicketTableAdapter();
            this.matchTableAdapter = new SportMatch2.DataSet1TableAdapters.MatchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sportFans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportFansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_match)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_sportFans
            // 
            this.dataGridView_sportFans.AutoGenerateColumns = false;
            this.dataGridView_sportFans.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView_sportFans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sportFans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fanNoDataGridViewTextBoxColumn,
            this.fanNameDataGridViewTextBoxColumn,
            this.fanLastnameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthdatDataGridViewTextBoxColumn});
            this.dataGridView_sportFans.DataSource = this.sportFansBindingSource;
            this.dataGridView_sportFans.Location = new System.Drawing.Point(23, 12);
            this.dataGridView_sportFans.Name = "dataGridView_sportFans";
            this.dataGridView_sportFans.Size = new System.Drawing.Size(543, 252);
            this.dataGridView_sportFans.TabIndex = 0;
            // 
            // fanNoDataGridViewTextBoxColumn
            // 
            this.fanNoDataGridViewTextBoxColumn.DataPropertyName = "Fan_No";
            this.fanNoDataGridViewTextBoxColumn.HeaderText = "Fan_No";
            this.fanNoDataGridViewTextBoxColumn.Name = "fanNoDataGridViewTextBoxColumn";
            this.fanNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fanNameDataGridViewTextBoxColumn
            // 
            this.fanNameDataGridViewTextBoxColumn.DataPropertyName = "Fan_Name";
            this.fanNameDataGridViewTextBoxColumn.HeaderText = "Fan_Name";
            this.fanNameDataGridViewTextBoxColumn.Name = "fanNameDataGridViewTextBoxColumn";
            // 
            // fanLastnameDataGridViewTextBoxColumn
            // 
            this.fanLastnameDataGridViewTextBoxColumn.DataPropertyName = "Fan_Lastname";
            this.fanLastnameDataGridViewTextBoxColumn.HeaderText = "Fan_Lastname";
            this.fanLastnameDataGridViewTextBoxColumn.Name = "fanLastnameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // birthdatDataGridViewTextBoxColumn
            // 
            this.birthdatDataGridViewTextBoxColumn.DataPropertyName = "birthdat";
            this.birthdatDataGridViewTextBoxColumn.HeaderText = "birthdat";
            this.birthdatDataGridViewTextBoxColumn.Name = "birthdatDataGridViewTextBoxColumn";
            // 
            // sportFansBindingSource
            // 
            this.sportFansBindingSource.DataMember = "Sport Fans";
            this.sportFansBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView_ticket
            // 
            this.dataGridView_ticket.AutoGenerateColumns = false;
            this.dataGridView_ticket.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView_ticket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ticket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketNoDataGridViewTextBoxColumn,
            this.fanNoDataGridViewTextBoxColumn1,
            this.matchNoDataGridViewTextBoxColumn});
            this.dataGridView_ticket.DataSource = this.ticketBindingSource;
            this.dataGridView_ticket.Location = new System.Drawing.Point(636, 12);
            this.dataGridView_ticket.Name = "dataGridView_ticket";
            this.dataGridView_ticket.Size = new System.Drawing.Size(340, 252);
            this.dataGridView_ticket.TabIndex = 0;
            // 
            // ticketNoDataGridViewTextBoxColumn
            // 
            this.ticketNoDataGridViewTextBoxColumn.DataPropertyName = "Ticket_No";
            this.ticketNoDataGridViewTextBoxColumn.HeaderText = "Ticket_No";
            this.ticketNoDataGridViewTextBoxColumn.Name = "ticketNoDataGridViewTextBoxColumn";
            this.ticketNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fanNoDataGridViewTextBoxColumn1
            // 
            this.fanNoDataGridViewTextBoxColumn1.DataPropertyName = "Fan_No";
            this.fanNoDataGridViewTextBoxColumn1.HeaderText = "Fan_No";
            this.fanNoDataGridViewTextBoxColumn1.Name = "fanNoDataGridViewTextBoxColumn1";
            // 
            // matchNoDataGridViewTextBoxColumn
            // 
            this.matchNoDataGridViewTextBoxColumn.DataPropertyName = "Match_No";
            this.matchNoDataGridViewTextBoxColumn.HeaderText = "Match_No";
            this.matchNoDataGridViewTextBoxColumn.Name = "matchNoDataGridViewTextBoxColumn";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.dataSet1;
            // 
            // dataGridView_match
            // 
            this.dataGridView_match.AutoGenerateColumns = false;
            this.dataGridView_match.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_match.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matchNoDataGridViewTextBoxColumn1,
            this.teamNameDataGridViewTextBoxColumn});
            this.dataGridView_match.DataSource = this.matchBindingSource;
            this.dataGridView_match.Location = new System.Drawing.Point(690, 343);
            this.dataGridView_match.Name = "dataGridView_match";
            this.dataGridView_match.Size = new System.Drawing.Size(243, 150);
            this.dataGridView_match.TabIndex = 0;
            // 
            // matchNoDataGridViewTextBoxColumn1
            // 
            this.matchNoDataGridViewTextBoxColumn1.DataPropertyName = "Match_No";
            this.matchNoDataGridViewTextBoxColumn1.HeaderText = "Match_No";
            this.matchNoDataGridViewTextBoxColumn1.Name = "matchNoDataGridViewTextBoxColumn1";
            this.matchNoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "Team_Name";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Team_Name";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataMember = "Match";
            this.matchBindingSource.DataSource = this.dataSet1;
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(404, 301);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 45);
            this.button_insert.TabIndex = 1;
            this.button_insert.Text = "Insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(404, 378);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 45);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(404, 458);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 45);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(242, 298);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname:";
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(242, 340);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // textBox_gender
            // 
            this.textBox_gender.Location = new System.Drawing.Point(242, 387);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.Size = new System.Drawing.Size(100, 20);
            this.textBox_gender.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birthday";
            // 
            // textBox_birthday
            // 
            this.textBox_birthday.Location = new System.Drawing.Point(242, 430);
            this.textBox_birthday.Name = "textBox_birthday";
            this.textBox_birthday.Size = new System.Drawing.Size(100, 20);
            this.textBox_birthday.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.matchBindingSource1;
            this.comboBox1.DisplayMember = "Team_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 477);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Match_No";
            // 
            // matchBindingSource1
            // 
            this.matchBindingSource1.DataMember = "Match";
            this.matchBindingSource1.DataSource = this.dataSet1;
            // 
            // sport_FansTableAdapter
            // 
            this.sport_FansTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // matchTableAdapter
            // 
            this.matchTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1026, 615);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_gender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.dataGridView_match);
            this.Controls.Add(this.dataGridView_ticket);
            this.Controls.Add(this.dataGridView_sportFans);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sportFans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportFansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_match)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_sportFans;
        private System.Windows.Forms.DataGridView dataGridView_ticket;
        private System.Windows.Forms.DataGridView dataGridView_match;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_birthday;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sportFansBindingSource;
        private DataSet1TableAdapters.Sport_FansTableAdapter sport_FansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private DataSet1TableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private DataSet1TableAdapters.MatchTableAdapter matchTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matchNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource matchBindingSource1;
    }
}

