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
            this.button1 = new System.Windows.Forms.Button();
            this.panelColour1 = new System.Windows.Forms.Panel();
            this.panelColour2 = new System.Windows.Forms.Panel();
            this.panelColour4 = new System.Windows.Forms.Panel();
            this.panelColour3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxDrawGrid = new System.Windows.Forms.CheckBox();
            this.myPanel = new CrossStitch.myPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(823, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "New colour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelColour1
            // 
            this.panelColour1.BackColor = System.Drawing.Color.White;
            this.panelColour1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour1.Location = new System.Drawing.Point(826, 80);
            this.panelColour1.Name = "panelColour1";
            this.panelColour1.Size = new System.Drawing.Size(25, 25);
            this.panelColour1.TabIndex = 5;
            this.panelColour1.Click += new System.EventHandler(this.panelColour1_Click);
            // 
            // panelColour2
            // 
            this.panelColour2.BackColor = System.Drawing.Color.Black;
            this.panelColour2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour2.Location = new System.Drawing.Point(858, 80);
            this.panelColour2.Name = "panelColour2";
            this.panelColour2.Size = new System.Drawing.Size(25, 25);
            this.panelColour2.TabIndex = 6;
            this.panelColour2.Click += new System.EventHandler(this.panelColour2_Click);
            // 
            // panelColour4
            // 
            this.panelColour4.BackColor = System.Drawing.Color.Aqua;
            this.panelColour4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour4.Location = new System.Drawing.Point(858, 111);
            this.panelColour4.Name = "panelColour4";
            this.panelColour4.Size = new System.Drawing.Size(25, 25);
            this.panelColour4.TabIndex = 8;
            this.panelColour4.Click += new System.EventHandler(this.panelColour4_Click);
            // 
            // panelColour3
            // 
            this.panelColour3.BackColor = System.Drawing.Color.Red;
            this.panelColour3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour3.Location = new System.Drawing.Point(826, 111);
            this.panelColour3.Name = "panelColour3";
            this.panelColour3.Size = new System.Drawing.Size(25, 25);
            this.panelColour3.TabIndex = 7;
            this.panelColour3.Click += new System.EventHandler(this.panelColour3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // checkBoxDrawGrid
            // 
            this.checkBoxDrawGrid.AutoSize = true;
            this.checkBoxDrawGrid.Checked = true;
            this.checkBoxDrawGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawGrid.Location = new System.Drawing.Point(818, 322);
            this.checkBoxDrawGrid.Name = "checkBoxDrawGrid";
            this.checkBoxDrawGrid.Size = new System.Drawing.Size(71, 17);
            this.checkBoxDrawGrid.TabIndex = 11;
            this.checkBoxDrawGrid.Text = "Draw grid";
            this.checkBoxDrawGrid.UseVisualStyleBackColor = true;
            this.checkBoxDrawGrid.CheckedChanged += new System.EventHandler(this.checkBoxDrawGrid_CheckedChanged);
            // 
            // myPanel
            // 
            this.myPanel.BackColor = System.Drawing.Color.White;
            this.myPanel.Location = new System.Drawing.Point(12, 28);
            this.myPanel.Name = "myPanel";
            this.myPanel.Size = new System.Drawing.Size(800, 800);
            this.myPanel.TabIndex = 9;
            this.myPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel_Paint);
            this.myPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseDown);
            this.myPanel.MouseLeave += new System.EventHandler(this.myPanel_MouseLeave);
            this.myPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseMove);
            this.myPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 847);
            this.Controls.Add(this.checkBoxDrawGrid);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.panelColour4);
            this.Controls.Add(this.panelColour2);
            this.Controls.Add(this.panelColour3);
            this.Controls.Add(this.panelColour1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Cross Stitch Designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelColour1;
        private System.Windows.Forms.Panel panelColour2;
        private System.Windows.Forms.Panel panelColour4;
        private System.Windows.Forms.Panel panelColour3;
        private myPanel myPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDrawGrid;
    }
}

