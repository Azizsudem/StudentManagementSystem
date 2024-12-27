namespace StudentManagementSystemApp
{
    partial class StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistration));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtSection = new TextBox();
            txtPeriod = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            txtPassword = new TextBox();
            txtRole = new TextBox();
            label8 = new Label();
            label9 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 239);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 279);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "İsim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 319);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 3;
            label3.Text = "Soyisim";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 359);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "E-Posta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 399);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 5;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 439);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 6;
            label6.Text = "Bölüm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 479);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 7;
            label7.Text = "Dönem";
            // 
            // txtId
            // 
            txtId.Location = new Point(188, 239);
            txtId.Name = "txtId";
            txtId.Size = new Size(276, 27);
            txtId.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(188, 279);
            txtName.Name = "txtName";
            txtName.Size = new Size(276, 27);
            txtName.TabIndex = 9;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(188, 319);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(276, 27);
            txtSurname.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 359);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(188, 399);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(276, 27);
            txtPhone.TabIndex = 12;
            // 
            // txtSection
            // 
            txtSection.Location = new Point(188, 439);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(276, 27);
            txtSection.TabIndex = 13;
            // 
            // txtPeriod
            // 
            txtPeriod.CharacterCasing = CharacterCasing.Upper;
            txtPeriod.Location = new Point(188, 479);
            txtPeriod.Name = "txtPeriod";
            txtPeriod.Size = new Size(276, 27);
            txtPeriod.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(536, 319);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(434, 264);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(606, 239);
            button1.Name = "button1";
            button1.Size = new Size(117, 67);
            button1.TabIndex = 16;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Add;
            // 
            // button2
            // 
            button2.Location = new Point(729, 239);
            button2.Name = "button2";
            button2.Size = new Size(117, 67);
            button2.TabIndex = 17;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Delete;
            // 
            // txtPassword
            // 
            txtPassword.CharacterCasing = CharacterCasing.Upper;
            txtPassword.Location = new Point(188, 556);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(276, 27);
            txtPassword.TabIndex = 22;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(188, 516);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(276, 27);
            txtRole.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 556);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 19;
            label8.Text = "Şifre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(71, 516);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 18;
            label9.Text = "Role";
            // 
            // button3
            // 
            button3.Location = new Point(853, 239);
            button3.Name = "button3";
            button3.Size = new Size(117, 67);
            button3.TabIndex = 23;
            button3.Text = "EKLE";
            button3.UseVisualStyleBackColor = true;
            // 
            // StudentRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 647);
            Controls.Add(button3);
            Controls.Add(txtPassword);
            Controls.Add(txtRole);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPeriod);
            Controls.Add(txtSection);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "StudentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentRegistration";
            Load += StudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtSection;
        private TextBox txtPeriod;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox txtPassword;
        private TextBox txtRole;
        private Label label8;
        private Label label9;
        private Button button3;
    }
}