namespace PetShop
{
    partial class form_login
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
            this.tbUsername = new Guna.UI.WinForms.GunaTextBox();
            this.tbPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btEnter = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.Transparent;
            this.tbUsername.BaseColor = System.Drawing.Color.White;
            this.tbUsername.BorderColor = System.Drawing.Color.Silver;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.tbUsername.FocusedBorderColor = System.Drawing.Color.LightSeaGreen;
            this.tbUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsername.Location = new System.Drawing.Point(73, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.Radius = 13;
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(226, 30);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsername_KeyPress);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BaseColor = System.Drawing.Color.White;
            this.tbPassword.BorderColor = System.Drawing.Color.Silver;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPassword.FocusedBorderColor = System.Drawing.Color.LightSeaGreen;
            this.tbPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.Location = new System.Drawing.Point(73, 48);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.Radius = 13;
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(226, 30);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btEnter
            // 
            this.btEnter.AnimationHoverSpeed = 0.07F;
            this.btEnter.AnimationSpeed = 0.03F;
            this.btEnter.BackColor = System.Drawing.Color.Transparent;
            this.btEnter.BaseColor = System.Drawing.Color.Silver;
            this.btEnter.BorderColor = System.Drawing.Color.Black;
            this.btEnter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btEnter.FocusedColor = System.Drawing.Color.Empty;
            this.btEnter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btEnter.ForeColor = System.Drawing.Color.White;
            this.btEnter.Image = null;
            this.btEnter.ImageSize = new System.Drawing.Size(20, 20);
            this.btEnter.Location = new System.Drawing.Point(211, 86);
            this.btEnter.Name = "btEnter";
            this.btEnter.OnHoverBaseColor = System.Drawing.Color.LightSeaGreen;
            this.btEnter.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btEnter.OnHoverForeColor = System.Drawing.Color.White;
            this.btEnter.OnHoverImage = null;
            this.btEnter.OnPressedColor = System.Drawing.Color.Black;
            this.btEnter.Radius = 13;
            this.btEnter.Size = new System.Drawing.Size(88, 30);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Enter";
            this.btEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 128);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.MaximizeBox = false;
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox tbUsername;
        private Guna.UI.WinForms.GunaTextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btEnter;
    }
}