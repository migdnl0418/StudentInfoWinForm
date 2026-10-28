using System;

namespace Student_Info
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbAcadLevel = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.YearLevel,
            this.Column5,
            this.Column7});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 152);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 62;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.YellowGreen;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(802, 602);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Last Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "First Name ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Middle Name ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Gender";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // YearLevel
            // 
            this.YearLevel.HeaderText = "Year Level";
            this.YearLevel.MinimumWidth = 8;
            this.YearLevel.Name = "YearLevel";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Section";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // cmbSection
            // 
            this.cmbSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(27, 433);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(196, 40);
            this.cmbSection.TabIndex = 8;
            // 
            // cmbAcadLevel
            // 
            this.cmbAcadLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAcadLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbAcadLevel.FormattingEnabled = true;
            this.cmbAcadLevel.Location = new System.Drawing.Point(256, 433);
            this.cmbAcadLevel.Name = "cmbAcadLevel";
            this.cmbAcadLevel.Size = new System.Drawing.Size(196, 40);
            this.cmbAcadLevel.TabIndex = 9;
            // 
            // cmbGender
            // 
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transformer"});
            this.cmbGender.Location = new System.Drawing.Point(255, 280);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(197, 40);
            this.cmbGender.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.cmbSection);
            this.panel1.Controls.Add(this.cmbAcadLevel);
            this.panel1.Controls.Add(this.txtMiddlename);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(820, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 702);
            this.panel1.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(334, 615);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 53);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(176, 615);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 53);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(321, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 53);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 565);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 44);
            this.txtEmail.TabIndex = 22;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMiddlename.Location = new System.Drawing.Point(19, 281);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(196, 39);
            this.txtMiddlename.TabIndex = 21;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtFirstname.Location = new System.Drawing.Point(242, 130);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(197, 39);
            this.txtFirstname.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(262, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Section";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(14, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Academic Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(262, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(22, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Middle Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(250, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name ";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLastname.Location = new System.Drawing.Point(19, 130);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(190, 39);
            this.txtLastname.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(145, 100);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(595, 44);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 37);
            this.label9.TabIndex = 24;
            this.label9.Text = "Search:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(420, 52);
            this.label10.TabIndex = 25;
            this.label10.Text = "Student Information";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DimGray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(529, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(129, 55);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DimGray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(697, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 55);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(176, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 53);
            this.button2.TabIndex = 24;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.comboBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(321, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 53);
            this.button3.TabIndex = 23;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 565);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 44);
            this.textBox1.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(255, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 40);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(27, 433);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 40);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(256, 433);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(196, 40);
            this.comboBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox2.Location = new System.Drawing.Point(19, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 39);
            this.textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox3.Location = new System.Drawing.Point(242, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 39);
            this.textBox3.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 515);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label12.Location = new System.Drawing.Point(262, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "Section";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label13.Location = new System.Drawing.Point(14, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 32);
            this.label13.TabIndex = 17;
            this.label13.Text = "Academic Level";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label14.Location = new System.Drawing.Point(262, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 32);
            this.label14.TabIndex = 16;
            this.label14.Text = "Gender";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label15.Location = new System.Drawing.Point(22, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 32);
            this.label15.TabIndex = 15;
            this.label15.Text = "Middle Name ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.Location = new System.Drawing.Point(250, 84);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 32);
            this.label16.TabIndex = 14;
            this.label16.Text = "First Name ";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox4.Location = new System.Drawing.Point(19, 130);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(190, 39);
            this.textBox4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1306, 780);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbAcadLevel;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
    }
}

