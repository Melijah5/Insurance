namespace waliyaDemo2.usercontrol
{
    partial class VehicleInsurance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblzipCode = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.cobVehicleType = new System.Windows.Forms.ComboBox();
            this.btngetQuote = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(537, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 600);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Motorcycle",
            "ATV",
            "RV",
            "Boat/PWC",
            "Collactor Auto"});
            this.comboBox2.Location = new System.Drawing.Point(8, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 32);
            this.comboBox2.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::waliyaDemo2.Properties.Resources.Keys_icon;
            this.pictureBox2.Location = new System.Drawing.Point(35, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(51, 406);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(104, 29);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.txtPassword.Location = new System.Drawing.Point(8, 352);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 32);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.txtUsername.Location = new System.Drawing.Point(8, 283);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 32);
            this.txtUsername.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(43, 253);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(92, 19);
            this.lblusername.TabIndex = 1;
            this.lblusername.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access Your Policy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Location = new System.Drawing.Point(109, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 42);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vehicle Insurance";
            // 
            // lblzipCode
            // 
            this.lblzipCode.AutoSize = true;
            this.lblzipCode.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzipCode.Location = new System.Drawing.Point(6, 27);
            this.lblzipCode.Name = "lblzipCode";
            this.lblzipCode.Size = new System.Drawing.Size(81, 19);
            this.lblzipCode.TabIndex = 2;
            this.lblzipCode.Text = "Zip Code";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(6, 81);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(113, 19);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "Vehicle Type";
            this.lbluser.Click += new System.EventHandler(this.label6_Click);
            // 
            // cobVehicleType
            // 
            this.cobVehicleType.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.cobVehicleType.FormattingEnabled = true;
            this.cobVehicleType.Items.AddRange(new object[] {
            "Motorcycle",
            "ATV",
            "RV",
            "Boat/PWC",
            "Collactor Auto"});
            this.cobVehicleType.Location = new System.Drawing.Point(136, 75);
            this.cobVehicleType.Name = "cobVehicleType";
            this.cobVehicleType.Size = new System.Drawing.Size(245, 32);
            this.cobVehicleType.TabIndex = 4;
            // 
            // btngetQuote
            // 
            this.btngetQuote.BackColor = System.Drawing.Color.MediumBlue;
            this.btngetQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngetQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btngetQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngetQuote.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngetQuote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngetQuote.Location = new System.Drawing.Point(346, 496);
            this.btngetQuote.Name = "btngetQuote";
            this.btngetQuote.Size = new System.Drawing.Size(156, 43);
            this.btngetQuote.TabIndex = 7;
            this.btngetQuote.Text = "Get Quote";
            this.btngetQuote.UseVisualStyleBackColor = false;
            this.btngetQuote.Click += new System.EventHandler(this.btngetQuote_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 24;
            this.comboBox1.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Location = new System.Drawing.Point(136, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 32);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::waliyaDemo2.Properties.Resources.insurance_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(204, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblzipCode);
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cobVehicleType);
            this.groupBox1.Location = new System.Drawing.Point(68, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 140);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(134, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Get an Online Quote";
            // 
            // VehicleInsurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngetQuote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleInsurance";
            this.Size = new System.Drawing.Size(753, 600);
            this.Load += new System.EventHandler(this.VehicleInsurance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblzipCode;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.ComboBox cobVehicleType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngetQuote;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}
