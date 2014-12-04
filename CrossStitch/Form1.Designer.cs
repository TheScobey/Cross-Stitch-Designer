namespace CrossStitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panelColour1 = new System.Windows.Forms.Panel();
            this.panelColour2 = new System.Windows.Forms.Panel();
            this.panelColour4 = new System.Windows.Forms.Panel();
            this.panelColour3 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(12, 27);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 800);
            this.panelMain.TabIndex = 2;
            this.panelMain.Click += new System.EventHandler(this.panelMain_Click);
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNew
            // 
            this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
            this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNew.Name = "toolStripButtonNew";
            this.toolStripButtonNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNew.Text = "toolStripButton1";
            this.toolStripButtonNew.Click += new System.EventHandler(this.toolStripButtonNew_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(823, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Choose colour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelColour1
            // 
            this.panelColour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour1.Location = new System.Drawing.Point(826, 80);
            this.panelColour1.Name = "panelColour1";
            this.panelColour1.Size = new System.Drawing.Size(25, 25);
            this.panelColour1.TabIndex = 5;
            this.panelColour1.Click += new System.EventHandler(this.panelColour1_Click);
            // 
            // panelColour2
            // 
            this.panelColour2.BackColor = System.Drawing.Color.Yellow;
            this.panelColour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour2.Location = new System.Drawing.Point(858, 80);
            this.panelColour2.Name = "panelColour2";
            this.panelColour2.Size = new System.Drawing.Size(25, 25);
            this.panelColour2.TabIndex = 6;
            this.panelColour2.Click += new System.EventHandler(this.panelColour2_Click);
            // 
            // panelColour4
            // 
            this.panelColour4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelColour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour4.Location = new System.Drawing.Point(858, 111);
            this.panelColour4.Name = "panelColour4";
            this.panelColour4.Size = new System.Drawing.Size(25, 25);
            this.panelColour4.TabIndex = 8;
            this.panelColour4.Click += new System.EventHandler(this.panelColour4_Click);
            // 
            // panelColour3
            // 
            this.panelColour3.BackColor = System.Drawing.Color.Maroon;
            this.panelColour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour3.Location = new System.Drawing.Point(826, 111);
            this.panelColour3.Name = "panelColour3";
            this.panelColour3.Size = new System.Drawing.Size(25, 25);
            this.panelColour3.TabIndex = 7;
            this.panelColour3.Click += new System.EventHandler(this.panelColour3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 847);
            this.Controls.Add(this.panelColour4);
            this.Controls.Add(this.panelColour2);
            this.Controls.Add(this.panelColour3);
            this.Controls.Add(this.panelColour1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Cross Stitch Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonNew;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelColour1;
        private System.Windows.Forms.Panel panelColour2;
        private System.Windows.Forms.Panel panelColour4;
        private System.Windows.Forms.Panel panelColour3;
    }
}

