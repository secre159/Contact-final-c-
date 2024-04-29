namespace WindowsFormsApp2
{
    partial class eContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eContact));
            this.txtbox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.txtbox_Fname = new System.Windows.Forms.TextBox();
            this.txtbox_Lname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_Gender = new CustomControls.RJControls.RJComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.txtbox_ContactNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbox_ContactId1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new CustomControls.RJControls.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Delete = new CustomControls.RJControls.RJButton();
            this.btn_Add = new CustomControls.RJControls.RJButton();
            this.btn_Update = new CustomControls.RJControls.RJButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_Search
            // 
            this.txtbox_Search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtbox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Search.Location = new System.Drawing.Point(890, 131);
            this.txtbox_Search.Multiline = true;
            this.txtbox_Search.Name = "txtbox_Search";
            this.txtbox_Search.Size = new System.Drawing.Size(457, 36);
            this.txtbox_Search.TabIndex = 1;
            this.txtbox_Search.TextChanged += new System.EventHandler(this.txtbox_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contact ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(751, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search";
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AllowUserToAddRows = false;
            this.dataGridViewDisplay.AllowUserToDeleteRows = false;
            this.dataGridViewDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplay.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(433, 179);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.ReadOnly = true;
            this.dataGridViewDisplay.RowHeadersWidth = 51;
            this.dataGridViewDisplay.RowTemplate.Height = 24;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(914, 538);
            this.dataGridViewDisplay.TabIndex = 6;
            // 
            // txtbox_Fname
            // 
            this.txtbox_Fname.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_Fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Fname.Location = new System.Drawing.Point(184, 227);
            this.txtbox_Fname.Multiline = true;
            this.txtbox_Fname.Name = "txtbox_Fname";
            this.txtbox_Fname.Size = new System.Drawing.Size(220, 36);
            this.txtbox_Fname.TabIndex = 0;
            this.txtbox_Fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Fname_KeyPress);
            // 
            // txtbox_Lname
            // 
            this.txtbox_Lname.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_Lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Lname.Location = new System.Drawing.Point(184, 290);
            this.txtbox_Lname.Multiline = true;
            this.txtbox_Lname.Name = "txtbox_Lname";
            this.txtbox_Lname.Size = new System.Drawing.Size(220, 36);
            this.txtbox_Lname.TabIndex = 0;
            this.txtbox_Lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Lname_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cmb_Gender);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbox_Address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbox_ContactNo);
            this.panel1.Controls.Add(this.txtbox_Fname);
            this.panel1.Controls.Add(this.txtbox_Lname);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 863);
            this.panel1.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(184, 388);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(221, 1);
            this.panel6.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(184, 325);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 1);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(183, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 1);
            this.panel4.TabIndex = 10;
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.BackColor = System.Drawing.Color.DodgerBlue;
            this.cmb_Gender.BorderColor = System.Drawing.Color.Black;
            this.cmb_Gender.BorderSize = 1;
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Gender.ForeColor = System.Drawing.Color.Black;
            this.cmb_Gender.IconColor = System.Drawing.Color.Black;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Alien",
            "Dog"});
            this.cmb_Gender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_Gender.ListTextColor = System.Drawing.Color.Black;
            this.cmb_Gender.Location = new System.Drawing.Point(185, 415);
            this.cmb_Gender.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_Gender.Size = new System.Drawing.Size(220, 41);
            this.cmb_Gender.TabIndex = 7;
            this.cmb_Gender.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contact No. :";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Address.Location = new System.Drawing.Point(179, 505);
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(225, 154);
            this.txtbox_Address.TabIndex = 0;
            this.txtbox_Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_Address_KeyPress);
            // 
            // txtbox_ContactNo
            // 
            this.txtbox_ContactNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtbox_ContactNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_ContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ContactNo.Location = new System.Drawing.Point(184, 353);
            this.txtbox_ContactNo.Multiline = true;
            this.txtbox_ContactNo.Name = "txtbox_ContactNo";
            this.txtbox_ContactNo.Size = new System.Drawing.Size(220, 36);
            this.txtbox_ContactNo.TabIndex = 0;
            this.txtbox_ContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_ContactNo_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtbox_ContactId1);
            this.panel3.Location = new System.Drawing.Point(3, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 99);
            this.panel3.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(177, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(224, 1);
            this.panel8.TabIndex = 10;
            // 
            // txtbox_ContactId1
            // 
            this.txtbox_ContactId1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtbox_ContactId1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_ContactId1.Enabled = false;
            this.txtbox_ContactId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_ContactId1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbox_ContactId1.Location = new System.Drawing.Point(182, 21);
            this.txtbox_ContactId1.Multiline = true;
            this.txtbox_ContactId1.Name = "txtbox_ContactId1";
            this.txtbox_ContactId1.ReadOnly = true;
            this.txtbox_ContactId1.Size = new System.Drawing.Size(216, 60);
            this.txtbox_ContactId1.TabIndex = 0;
            this.txtbox_ContactId1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(890, 169);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 1);
            this.panel7.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Update);
            this.panel2.Location = new System.Drawing.Point(433, 723);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 142);
            this.panel2.TabIndex = 8;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.SlateGray;
            this.btn_Clear.BackgroundColor = System.Drawing.Color.SlateGray;
            this.btn_Clear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Clear.BorderRadius = 10;
            this.btn_Clear.BorderSize = 0;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(566, 39);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(145, 64);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextColor = System.Drawing.Color.White;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(754, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_Delete.BackgroundColor = System.Drawing.Color.Crimson;
            this.btn_Delete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Delete.BorderRadius = 10;
            this.btn_Delete.BorderSize = 0;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(392, 39);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(145, 64);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Lime;
            this.btn_Add.BackgroundColor = System.Drawing.Color.Lime;
            this.btn_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Add.BorderRadius = 10;
            this.btn_Add.BorderSize = 0;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(49, 39);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(145, 64);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Update.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_Update.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Update.BorderRadius = 10;
            this.btn_Update.BorderSize = 0;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(220, 39);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(145, 64);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextColor = System.Drawing.Color.White;
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp2.Properties.Resources.exit_icon_4600;
            this.pictureBox3.Location = new System.Drawing.Point(1272, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.E_Contact_4_19_2024_unscreen;
            this.pictureBox1.Location = new System.Drawing.Point(549, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // eContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1358, 864);
            this.ControlBox = false;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_Search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "eContact";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.TextBox txtbox_Fname;
        private System.Windows.Forms.TextBox txtbox_Lname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_ContactNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.RJControls.RJButton btn_Add;
        private CustomControls.RJControls.RJButton btn_Update;
        private CustomControls.RJControls.RJButton btn_Delete;
        private CustomControls.RJControls.RJButton btn_Clear;
        private CustomControls.RJControls.RJComboBox cmb_Gender;
       // private CustomControls.RJControls.RJTextBox txtbox_ContactId;
        private System.Windows.Forms.TextBox txtbox_ContactId1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbox_Address;
    }
}

