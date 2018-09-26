namespace waliyaDemo2.usercontrol
{
    partial class commute
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
            this.cobAmilage = new System.Windows.Forms.ComboBox();
            this.lblAMilage = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.CobMilage = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cobAmilage
            // 
            this.cobAmilage.FormattingEnabled = true;
            this.cobAmilage.Items.AddRange(new object[] {
            "1 - 2999",
            "3000 -3999",
            "4000 - 4999",
            "5000 - 5999",
            "6000 - 6999",
            "7000 - 7999",
            "8000 - 8999",
            "9000 - 9999",
            "10000 - 10999",
            "11000 - 11999",
            "12000 - 12999",
            "more"});
            this.cobAmilage.Location = new System.Drawing.Point(274, 105);
            this.cobAmilage.Name = "cobAmilage";
            this.cobAmilage.Size = new System.Drawing.Size(121, 21);
            this.cobAmilage.TabIndex = 72;
            // 
            // lblAMilage
            // 
            this.lblAMilage.AutoSize = true;
            this.lblAMilage.Location = new System.Drawing.Point(39, 105);
            this.lblAMilage.Name = "lblAMilage";
            this.lblAMilage.Size = new System.Drawing.Size(68, 13);
            this.lblAMilage.TabIndex = 71;
            this.lblAMilage.Text = "Anual Milage";
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(39, 64);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(193, 13);
            this.lblMiles.TabIndex = 70;
            this.lblMiles.Text = "Miles driven to work/School (One Way)";
            // 
            // CobMilage
            // 
            this.CobMilage.FormattingEnabled = true;
            this.CobMilage.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.CobMilage.Location = new System.Drawing.Point(274, 25);
            this.CobMilage.Name = "CobMilage";
            this.CobMilage.Size = new System.Drawing.Size(100, 21);
            this.CobMilage.TabIndex = 69;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(39, 25);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(180, 13);
            this.lblDay.TabIndex = 68;
            this.lblDay.Text = "Days Drive to Work and /or School?";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(274, 64);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(166, 20);
            this.txtDay.TabIndex = 67;
            // 
            // commute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cobAmilage);
            this.Controls.Add(this.lblAMilage);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.CobMilage);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txtDay);
            this.Name = "commute";
            this.Size = new System.Drawing.Size(493, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cobAmilage;
        private System.Windows.Forms.Label lblAMilage;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.ComboBox CobMilage;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtDay;
    }
}
