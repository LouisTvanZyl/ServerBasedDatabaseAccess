namespace MammaProgramFinal
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.chkAdd = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lstbEmails = new System.Windows.Forms.ListBox();
            this.lstbNumbers = new System.Windows.Forms.ListBox();
            this.btnCopyEmails = new System.Windows.Forms.Button();
            this.btnCopyNumbers = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSInitials = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSSurname = new System.Windows.Forms.TextBox();
            this.btnSCopyEmail = new System.Windows.Forms.Button();
            this.btnSCopyNumber = new System.Windows.Forms.Button();
            this.tmrDat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(283, 12);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 20;
            this.dgvData.Size = new System.Drawing.Size(770, 227);
            this.dgvData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initials : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(701, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(866, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Number :";
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(293, 385);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(430, 385);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(566, 385);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(704, 385);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(872, 385);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(555, 468);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(124, 42);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // chkAdd
            // 
            this.chkAdd.AutoSize = true;
            this.chkAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdd.Location = new System.Drawing.Point(685, 482);
            this.chkAdd.Name = "chkAdd";
            this.chkAdd.Size = new System.Drawing.Size(88, 17);
            this.chkAdd.TabIndex = 12;
            this.chkAdd.Text = "Add Check";
            this.chkAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Emails :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Numbers :";
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(15, 586);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(230, 28);
            this.btnGetData.TabIndex = 17;
            this.btnGetData.Text = "Refresh";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lstbEmails
            // 
            this.lstbEmails.FormattingEnabled = true;
            this.lstbEmails.Location = new System.Drawing.Point(15, 37);
            this.lstbEmails.Name = "lstbEmails";
            this.lstbEmails.Size = new System.Drawing.Size(227, 251);
            this.lstbEmails.TabIndex = 18;
            // 
            // lstbNumbers
            // 
            this.lstbNumbers.FormattingEnabled = true;
            this.lstbNumbers.Location = new System.Drawing.Point(15, 329);
            this.lstbNumbers.Name = "lstbNumbers";
            this.lstbNumbers.Size = new System.Drawing.Size(227, 251);
            this.lstbNumbers.TabIndex = 19;
            // 
            // btnCopyEmails
            // 
            this.btnCopyEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyEmails.Location = new System.Drawing.Point(248, 420);
            this.btnCopyEmails.Name = "btnCopyEmails";
            this.btnCopyEmails.Size = new System.Drawing.Size(110, 23);
            this.btnCopyEmails.TabIndex = 20;
            this.btnCopyEmails.Text = "Copy Emails";
            this.btnCopyEmails.UseVisualStyleBackColor = true;
            this.btnCopyEmails.Click += new System.EventHandler(this.btnCopyEmails_Click);
            // 
            // btnCopyNumbers
            // 
            this.btnCopyNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyNumbers.Location = new System.Drawing.Point(248, 449);
            this.btnCopyNumbers.Name = "btnCopyNumbers";
            this.btnCopyNumbers.Size = new System.Drawing.Size(110, 23);
            this.btnCopyNumbers.TabIndex = 21;
            this.btnCopyNumbers.Text = "Copy Numbers";
            this.btnCopyNumbers.UseVisualStyleBackColor = true;
            this.btnCopyNumbers.Click += new System.EventHandler(this.btnCopyNumbers_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1059, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Search :";
            // 
            // txtSInitials
            // 
            this.txtSInitials.Location = new System.Drawing.Point(1062, 60);
            this.txtSInitials.Name = "txtSInitials";
            this.txtSInitials.Size = new System.Drawing.Size(138, 20);
            this.txtSInitials.TabIndex = 23;
            this.txtSInitials.TextChanged += new System.EventHandler(this.txtSInitials_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1059, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Initials : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1059, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Surname :";
            // 
            // txtSSurname
            // 
            this.txtSSurname.Location = new System.Drawing.Point(1062, 103);
            this.txtSSurname.Name = "txtSSurname";
            this.txtSSurname.Size = new System.Drawing.Size(138, 20);
            this.txtSSurname.TabIndex = 26;
            this.txtSSurname.TextChanged += new System.EventHandler(this.txtSName_TextChanged);
            // 
            // btnSCopyEmail
            // 
            this.btnSCopyEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCopyEmail.Location = new System.Drawing.Point(1062, 129);
            this.btnSCopyEmail.Name = "btnSCopyEmail";
            this.btnSCopyEmail.Size = new System.Drawing.Size(110, 23);
            this.btnSCopyEmail.TabIndex = 27;
            this.btnSCopyEmail.Text = "Copy Email";
            this.btnSCopyEmail.UseVisualStyleBackColor = true;
            this.btnSCopyEmail.Click += new System.EventHandler(this.btnSCopyEmail_Click);
            // 
            // btnSCopyNumber
            // 
            this.btnSCopyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCopyNumber.Location = new System.Drawing.Point(1062, 158);
            this.btnSCopyNumber.Name = "btnSCopyNumber";
            this.btnSCopyNumber.Size = new System.Drawing.Size(110, 23);
            this.btnSCopyNumber.TabIndex = 28;
            this.btnSCopyNumber.Text = "Copy Number";
            this.btnSCopyNumber.UseVisualStyleBackColor = true;
            this.btnSCopyNumber.Click += new System.EventHandler(this.btnSCopyNumber_Click);
            // 
            // tmrDat
            // 
            this.tmrDat.Tick += new System.EventHandler(this.tmrDat_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 728);
            this.Controls.Add(this.btnSCopyNumber);
            this.Controls.Add(this.btnSCopyEmail);
            this.Controls.Add(this.txtSSurname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSInitials);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCopyNumbers);
            this.Controls.Add(this.btnCopyEmails);
            this.Controls.Add(this.lstbNumbers);
            this.Controls.Add(this.lstbEmails);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkAdd);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInitials);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.CheckBox chkAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ListBox lstbEmails;
        private System.Windows.Forms.ListBox lstbNumbers;
        private System.Windows.Forms.Button btnCopyEmails;
        private System.Windows.Forms.Button btnCopyNumbers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSInitials;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSSurname;
        private System.Windows.Forms.Button btnSCopyEmail;
        private System.Windows.Forms.Button btnSCopyNumber;
        private System.Windows.Forms.Timer tmrDat;
    }
}

