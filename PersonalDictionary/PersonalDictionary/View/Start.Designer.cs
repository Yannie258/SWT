namespace PersonalDictionary
{
    partial class Start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.LoginGrpBox = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txb_pass = new System.Windows.Forms.TextBox();
            this.txb_usr = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.usr_lbl = new System.Windows.Forms.Label();
            this.Dictionary_lbl = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_Management = new System.Windows.Forms.Button();
            this.LoginGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGrpBox
            // 
            this.LoginGrpBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoginGrpBox.Controls.Add(this.btn_Exit);
            this.LoginGrpBox.Controls.Add(this.btn_Login);
            this.LoginGrpBox.Controls.Add(this.txb_pass);
            this.LoginGrpBox.Controls.Add(this.txb_usr);
            this.LoginGrpBox.Controls.Add(this.pass_lbl);
            this.LoginGrpBox.Controls.Add(this.usr_lbl);
            this.LoginGrpBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LoginGrpBox.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGrpBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoginGrpBox.Location = new System.Drawing.Point(0, 370);
            this.LoginGrpBox.Name = "LoginGrpBox";
            this.LoginGrpBox.Size = new System.Drawing.Size(1023, 280);
            this.LoginGrpBox.TabIndex = 0;
            this.LoginGrpBox.TabStop = false;
            this.LoginGrpBox.Text = "Login";
            this.LoginGrpBox.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(597, 202);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(124, 50);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(328, 202);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 50);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txb_pass
            // 
            this.txb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txb_pass.Location = new System.Drawing.Point(328, 120);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '*';
            this.txb_pass.Size = new System.Drawing.Size(393, 44);
            this.txb_pass.TabIndex = 1;
            // 
            // txb_usr
            // 
            this.txb_usr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txb_usr.Location = new System.Drawing.Point(328, 48);
            this.txb_usr.Name = "txb_usr";
            this.txb_usr.Size = new System.Drawing.Size(393, 44);
            this.txb_usr.TabIndex = 1;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lbl.Location = new System.Drawing.Point(163, 135);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(106, 29);
            this.pass_lbl.TabIndex = 0;
            this.pass_lbl.Text = "Password";
            // 
            // usr_lbl
            // 
            this.usr_lbl.AutoSize = true;
            this.usr_lbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usr_lbl.Location = new System.Drawing.Point(163, 63);
            this.usr_lbl.Name = "usr_lbl";
            this.usr_lbl.Size = new System.Drawing.Size(109, 29);
            this.usr_lbl.TabIndex = 0;
            this.usr_lbl.Text = "Username";
            // 
            // Dictionary_lbl
            // 
            this.Dictionary_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dictionary_lbl.AutoSize = true;
            this.Dictionary_lbl.Font = new System.Drawing.Font("Papyrus", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dictionary_lbl.ForeColor = System.Drawing.Color.Red;
            this.Dictionary_lbl.Location = new System.Drawing.Point(174, 36);
            this.Dictionary_lbl.Name = "Dictionary_lbl";
            this.Dictionary_lbl.Size = new System.Drawing.Size(674, 88);
            this.Dictionary_lbl.TabIndex = 2;
            this.Dictionary_lbl.Text = "Personal Dictionary Tool";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_search.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_search.Location = new System.Drawing.Point(45, 186);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(346, 67);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btn_Management
            // 
            this.btn_Management.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Management.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Management.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Management.Location = new System.Drawing.Point(624, 186);
            this.btn_Management.Name = "btn_Management";
            this.btn_Management.Size = new System.Drawing.Size(339, 67);
            this.btn_Management.TabIndex = 1;
            this.btn_Management.Text = "Management";
            this.btn_Management.UseVisualStyleBackColor = false;
            this.btn_Management.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1023, 650);
            this.Controls.Add(this.Dictionary_lbl);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Management);
            this.Controls.Add(this.LoginGrpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.LoginGrpBox.ResumeLayout(false);
            this.LoginGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGrpBox;
        private System.Windows.Forms.TextBox txb_pass;
        private System.Windows.Forms.TextBox txb_usr;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label usr_lbl;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label Dictionary_lbl;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_Management;
    }
}

