namespace StudentManagementSystemApp.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txtid = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtpassword = new TextBox();
            btnlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(409, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtid
            // 
            txtid.Location = new Point(76, 423);
            txtid.Name = "txtid";
            txtid.Size = new Size(330, 27);
            txtid.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sylfaen", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(76, 380);
            label3.Name = "label3";
            label3.Size = new Size(97, 26);
            label3.TabIndex = 4;
            label3.Text = "ID GİRİN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Italic);
            label4.Location = new Point(76, 478);
            label4.Name = "label4";
            label4.Size = new Size(129, 26);
            label4.TabIndex = 6;
            label4.Text = "ŞİFRE GİRİN";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(76, 521);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(330, 27);
            txtpassword.TabIndex = 5;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = SystemColors.ControlLight;
            btnlogin.Font = new Font("Sylfaen", 12F, FontStyle.Italic);
            btnlogin.Location = new Point(176, 579);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(134, 39);
            btnlogin.TabIndex = 7;
            btnlogin.Text = "GİRİŞ YAP";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(482, 647);
            Controls.Add(btnlogin);
            Controls.Add(label4);
            Controls.Add(txtpassword);
            Controls.Add(label3);
            Controls.Add(txtid);
            Controls.Add(pictureBox1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtid;
        private Label label3;
        private Label label4;
        private TextBox txtpassword;
        private Button btnlogin;
    }
}