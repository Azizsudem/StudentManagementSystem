namespace StudentManagementSystemApp
{
    partial class AcademicianRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademicianRegistration));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtSection = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtRole = new TextBox();
            txtStatus = new TextBox();
            label13 = new Label();
            Statü = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(853, 266);
            button3.Name = "button3";
            button3.Size = new Size(117, 67);
            button3.TabIndex = 37;
            button3.Text = "Düzenle";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(730, 266);
            button2.Name = "button2";
            button2.Size = new Size(117, 67);
            button2.TabIndex = 36;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete;
            // 
            // button1
            // 
            button1.Location = new Point(607, 266);
            button1.Name = "button1";
            button1.Size = new Size(117, 67);
            button1.TabIndex = 35;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(165, 466);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(276, 27);
            txtSection.TabIndex = 32;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(165, 426);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(276, 27);
            txtPhone.TabIndex = 31;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 386);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 27);
            txtEmail.TabIndex = 30;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(165, 346);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(276, 27);
            txtSurname.TabIndex = 29;
            // 
            // txtName
            // 
            txtName.Location = new Point(165, 306);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 27);
            txtName.TabIndex = 28;
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 266);
            txtId.Name = "txtId";
            txtId.Size = new Size(276, 27);
            txtId.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 466);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 25;
            label6.Text = "Bölüm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 426);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 24;
            label5.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 386);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 23;
            label4.Text = "E-Posta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 346);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 22;
            label3.Text = "Soyisim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 306);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 21;
            label2.Text = "İsim";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 266);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 20;
            label1.Text = "Id";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(165, 546);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(276, 27);
            txtRole.TabIndex = 46;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(165, 506);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(276, 27);
            txtStatus.TabIndex = 45;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(65, 546);
            label13.Name = "label13";
            label13.Size = new Size(39, 20);
            label13.TabIndex = 39;
            label13.Text = "Role";
            // 
            // Statü
            // 
            Statü.AutoSize = true;
            Statü.Location = new Point(65, 506);
            Statü.Name = "Statü";
            Statü.Size = new Size(58, 20);
            Statü.TabIndex = 38;
            Statü.Text = "Dönem";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(165, 586);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 27);
            txtPassword.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 586);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 47;
            label7.Text = "Şifre";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(521, 346);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(449, 267);
            dataGridView1.TabIndex = 49;
            // 
            // AcademicianRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 647);
            Controls.Add(dataGridView1);
            Controls.Add(txtPassword);
            Controls.Add(label7);
            Controls.Add(txtRole);
            Controls.Add(txtStatus);
            Controls.Add(label13);
            Controls.Add(Statü);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtSection);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "AcademicianRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AcademicianRegistration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtSection;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtRole;
        private TextBox txtStatus;
        private Label label13;
        private Label Statü;
        private TextBox txtPassword;
        private Label label7;
        private DataGridView dataGridView1;
    }
}