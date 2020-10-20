namespace Vatsim_Trafic_and_ATC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Vatsim_CID = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.Label();
            this.vCID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ATC_PILOT = new System.Windows.Forms.MenuStrip();
            this.ATC = new System.Windows.Forms.ToolStripMenuItem();
            this.Pilot = new System.Windows.Forms.ToolStripMenuItem();
            this.ATC_PILOT.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vatsim_CID
            // 
            this.Vatsim_CID.Location = new System.Drawing.Point(85, 45);
            this.Vatsim_CID.Name = "Vatsim_CID";
            this.Vatsim_CID.Size = new System.Drawing.Size(113, 23);
            this.Vatsim_CID.TabIndex = 0;
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Location = new System.Drawing.Point(12, 48);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(67, 15);
            this.CID.TabIndex = 1;
            this.CID.Text = "Vatsim CID:";
            // 
            // vCID
            // 
            this.vCID.Location = new System.Drawing.Point(204, 44);
            this.vCID.Name = "vCID";
            this.vCID.Size = new System.Drawing.Size(66, 25);
            this.vCID.TabIndex = 2;
            this.vCID.Text = "Submit";
            this.vCID.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Atis:";
            // 
            // ATC_PILOT
            // 
            this.ATC_PILOT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ATC,
            this.Pilot});
            this.ATC_PILOT.Location = new System.Drawing.Point(0, 0);
            this.ATC_PILOT.Name = "ATC_PILOT";
            this.ATC_PILOT.Size = new System.Drawing.Size(800, 24);
            this.ATC_PILOT.TabIndex = 4;
            this.ATC_PILOT.Text = "ATC/PILOT";
            this.ATC_PILOT.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ATC
            // 
            this.ATC.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.ATC.Name = "ATC";
            this.ATC.Size = new System.Drawing.Size(39, 20);
            this.ATC.Text = "ATC";
            // 
            // Pilot
            // 
            this.Pilot.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Pilot.Name = "Pilot";
            this.Pilot.Size = new System.Drawing.Size(43, 20);
            this.Pilot.Text = "Pilot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ATC_PILOT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vCID);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.Vatsim_CID);
            this.MainMenuStrip = this.ATC_PILOT;
            this.Name = "Form1";
            this.Text = "Vatsim Information for ATC and Pilots";
            this.ATC_PILOT.ResumeLayout(false);
            this.ATC_PILOT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ATC_PILOT;
        private System.Windows.Forms.TextBox Vatsim_CID;
        private System.Windows.Forms.Label CID;
        private System.Windows.Forms.Button vCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ATC;
        private System.Windows.Forms.ToolStripMenuItem Pilot;
    }
}

