
namespace Quiz_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStudentLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentRegister = new Guna.UI2.WinForms.Guna2Button();
            this.txtEnrollment = new Guna.UI2.WinForms.Guna2TextBox();
            this.WrongLebel2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select User";
            // 
            // txtSelectedUser
            // 
            this.txtSelectedUser.Animated = true;
            this.txtSelectedUser.AutoRoundedCorners = true;
            this.txtSelectedUser.BackColor = System.Drawing.Color.Transparent;
            this.txtSelectedUser.BorderRadius = 17;
            this.txtSelectedUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSelectedUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSelectedUser.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectedUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSelectedUser.FocusedState.Parent = this.txtSelectedUser;
            this.txtSelectedUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSelectedUser.ForeColor = System.Drawing.Color.Black;
            this.txtSelectedUser.HoverState.Parent = this.txtSelectedUser;
            this.txtSelectedUser.ItemHeight = 30;
            this.txtSelectedUser.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.txtSelectedUser.ItemsAppearance.Parent = this.txtSelectedUser;
            this.txtSelectedUser.Location = new System.Drawing.Point(152, 139);
            this.txtSelectedUser.Name = "txtSelectedUser";
            this.txtSelectedUser.ShadowDecoration.Parent = this.txtSelectedUser;
            this.txtSelectedUser.Size = new System.Drawing.Size(214, 36);
            this.txtSelectedUser.TabIndex = 2;
            this.txtSelectedUser.SelectedIndexChanged += new System.EventHandler(this.txtSelectedUser_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderRadius = 9;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(494, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.WrongLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(150, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 272);
            this.panel1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(61, 185);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(51, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(120, 25);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BorderRadius = 9;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.Parent = this.txtPass;
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.FocusedState.Parent = this.txtPass;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPass.HoverState.Parent = this.txtPass;
            this.txtPass.Location = new System.Drawing.Point(11, 136);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '$';
            this.txtPass.PlaceholderText = "Enter Password";
            this.txtPass.SelectedText = "";
            this.txtPass.ShadowDecoration.Parent = this.txtPass;
            this.txtPass.Size = new System.Drawing.Size(200, 36);
            this.txtPass.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 9;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.Parent = this.txtUsername;
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState.Parent = this.txtUsername;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.HoverState.Parent = this.txtUsername;
            this.txtUsername.Location = new System.Drawing.Point(11, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.ShadowDecoration.Parent = this.txtUsername;
            this.txtUsername.Size = new System.Drawing.Size(200, 36);
            this.txtUsername.TabIndex = 4;
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongLabel.Location = new System.Drawing.Point(26, 243);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(172, 15);
            this.WrongLabel.TabIndex = 3;
            this.WrongLabel.Text = "Wrong username or password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnStudentLogin);
            this.panel2.Controls.Add(this.btnStudentRegister);
            this.panel2.Controls.Add(this.txtEnrollment);
            this.panel2.Controls.Add(this.WrongLebel2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(150, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 272);
            this.panel2.TabIndex = 7;
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Animated = true;
            this.btnStudentLogin.BorderRadius = 10;
            this.btnStudentLogin.CheckedState.Parent = this.btnStudentLogin;
            this.btnStudentLogin.CustomImages.Parent = this.btnStudentLogin;
            this.btnStudentLogin.FillColor = System.Drawing.Color.LimeGreen;
            this.btnStudentLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStudentLogin.ForeColor = System.Drawing.Color.White;
            this.btnStudentLogin.HoverState.Parent = this.btnStudentLogin;
            this.btnStudentLogin.Location = new System.Drawing.Point(51, 153);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.ShadowDecoration.Parent = this.btnStudentLogin;
            this.btnStudentLogin.Size = new System.Drawing.Size(120, 25);
            this.btnStudentLogin.TabIndex = 6;
            this.btnStudentLogin.Text = "Login";
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.Animated = true;
            this.btnStudentRegister.BorderRadius = 10;
            this.btnStudentRegister.CheckedState.Parent = this.btnStudentRegister;
            this.btnStudentRegister.CustomImages.Parent = this.btnStudentRegister;
            this.btnStudentRegister.FillColor = System.Drawing.Color.LimeGreen;
            this.btnStudentRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnStudentRegister.ForeColor = System.Drawing.Color.White;
            this.btnStudentRegister.HoverState.Parent = this.btnStudentRegister;
            this.btnStudentRegister.Location = new System.Drawing.Point(51, 189);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.ShadowDecoration.Parent = this.btnStudentRegister;
            this.btnStudentRegister.Size = new System.Drawing.Size(120, 25);
            this.btnStudentRegister.TabIndex = 5;
            this.btnStudentRegister.Text = "Register";
            // 
            // txtEnrollment
            // 
            this.txtEnrollment.BorderRadius = 9;
            this.txtEnrollment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnrollment.DefaultText = "";
            this.txtEnrollment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnrollment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnrollment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnrollment.DisabledState.Parent = this.txtEnrollment;
            this.txtEnrollment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnrollment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnrollment.FocusedState.Parent = this.txtEnrollment;
            this.txtEnrollment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnrollment.HoverState.Parent = this.txtEnrollment;
            this.txtEnrollment.Location = new System.Drawing.Point(11, 97);
            this.txtEnrollment.Name = "txtEnrollment";
            this.txtEnrollment.PasswordChar = '\0';
            this.txtEnrollment.PlaceholderText = "Enter Username";
            this.txtEnrollment.SelectedText = "";
            this.txtEnrollment.ShadowDecoration.Parent = this.txtEnrollment;
            this.txtEnrollment.Size = new System.Drawing.Size(200, 36);
            this.txtEnrollment.TabIndex = 4;
            // 
            // WrongLebel2
            // 
            this.WrongLebel2.AutoSize = true;
            this.WrongLebel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongLebel2.ForeColor = System.Drawing.Color.Red;
            this.WrongLebel2.Location = new System.Drawing.Point(26, 243);
            this.WrongLebel2.Name = "WrongLebel2";
            this.WrongLebel2.Size = new System.Drawing.Size(172, 15);
            this.WrongLebel2.TabIndex = 3;
            this.WrongLebel2.Text = "Wrong username or password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Student ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Student Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSelectedUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox txtSelectedUser;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label WrongLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnStudentLogin;
        private Guna.UI2.WinForms.Guna2Button btnStudentRegister;
        private Guna.UI2.WinForms.Guna2TextBox txtEnrollment;
        private System.Windows.Forms.Label WrongLebel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

