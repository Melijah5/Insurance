namespace waliyaDemo2.forms
{
    partial class GetQuotes
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.custo1 = new waliyaDemo2.usercontrol.custo();
            this.vehicle1 = new waliyaDemo2.usercontrol.Vehicle();
            this.driver1 = new waliyaDemo2.usercontrol.Driver();
            this.detail1 = new waliyaDemo2.usercontrol.Detail();
            this.quoteDetail1 = new waliyaDemo2.usercontrol.QuoteDetail();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelcontainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 71);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::waliyaDemo2.Properties.Resources.Actions_session_exit_icon2;
            this.pictureBox1.Location = new System.Drawing.Point(841, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 69);
            this.panel2.TabIndex = 1;
            // 
            // panelcontainer
            // 
            this.panelcontainer.Controls.Add(this.custo1);
            this.panelcontainer.Controls.Add(this.vehicle1);
            this.panelcontainer.Controls.Add(this.driver1);
            this.panelcontainer.Controls.Add(this.detail1);
            this.panelcontainer.Controls.Add(this.quoteDetail1);
            this.panelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontainer.Location = new System.Drawing.Point(0, 71);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(886, 521);
            this.panelcontainer.TabIndex = 2;
            // 
            // custo1
            // 
            this.custo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custo1.Location = new System.Drawing.Point(0, 0);
            this.custo1.Name = "custo1";
            this.custo1.Size = new System.Drawing.Size(886, 521);
            this.custo1.TabIndex = 4;
            // 
            // vehicle1
            // 
            this.vehicle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicle1.Location = new System.Drawing.Point(0, 0);
            this.vehicle1.Name = "vehicle1";
            this.vehicle1.Size = new System.Drawing.Size(886, 521);
            this.vehicle1.TabIndex = 3;
            // 
            // driver1
            // 
            this.driver1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driver1.Location = new System.Drawing.Point(0, 0);
            this.driver1.Name = "driver1";
            this.driver1.Size = new System.Drawing.Size(886, 521);
            this.driver1.TabIndex = 2;
            // 
            // detail1
            // 
            this.detail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detail1.Location = new System.Drawing.Point(0, 0);
            this.detail1.Name = "detail1";
            this.detail1.Size = new System.Drawing.Size(886, 521);
            this.detail1.TabIndex = 1;
            // 
            // quoteDetail1
            // 
            this.quoteDetail1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quoteDetail1.Location = new System.Drawing.Point(0, 0);
            this.quoteDetail1.Name = "quoteDetail1";
            this.quoteDetail1.Size = new System.Drawing.Size(886, 521);
            this.quoteDetail1.TabIndex = 0;
            // 
            // GetQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 661);
            this.Controls.Add(this.panelcontainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GetQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetQuotes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelcontainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelcontainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private usercontrol.Vehicle vehicle1;
        private usercontrol.Driver driver1;
        private usercontrol.Detail detail1;
        private usercontrol.QuoteDetail quoteDetail1;
        private usercontrol.custo custo1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}