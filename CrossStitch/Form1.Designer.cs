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
            this.buttonNewColour = new System.Windows.Forms.Button();
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
            this.exportAsPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxDrawGrid = new System.Windows.Forms.CheckBox();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.panelColour6 = new System.Windows.Forms.Panel();
            this.panelColour5 = new System.Windows.Forms.Panel();
            this.panelColour8 = new System.Windows.Forms.Panel();
            this.panelColour7 = new System.Windows.Forms.Panel();
            this.panelColour10 = new System.Windows.Forms.Panel();
            this.panelColour9 = new System.Windows.Forms.Panel();
            this.buttonCopyColour = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.myPanel = new CrossStitch.myPanel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewColour
            // 
            this.buttonNewColour.Location = new System.Drawing.Point(823, 27);
            this.buttonNewColour.Name = "buttonNewColour";
            this.buttonNewColour.Size = new System.Drawing.Size(63, 47);
            this.buttonNewColour.TabIndex = 4;
            this.buttonNewColour.Text = "New colour";
            this.buttonNewColour.UseVisualStyleBackColor = true;
            this.buttonNewColour.Click += new System.EventHandler(this.buttonNewColour_Click);
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
            this.saveAsToolStripMenuItem,
            this.exportAsPNGToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportAsPNGToolStripMenuItem
            // 
            this.exportAsPNGToolStripMenuItem.Name = "exportAsPNGToolStripMenuItem";
            this.exportAsPNGToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exportAsPNGToolStripMenuItem.Text = "Export as PNG";
            this.exportAsPNGToolStripMenuItem.Click += new System.EventHandler(this.exportAsPNGToolStripMenuItem_Click);
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
            this.checkBoxDrawGrid.Location = new System.Drawing.Point(92, 5);
            this.checkBoxDrawGrid.Name = "checkBoxDrawGrid";
            this.checkBoxDrawGrid.Size = new System.Drawing.Size(71, 17);
            this.checkBoxDrawGrid.TabIndex = 11;
            this.checkBoxDrawGrid.Text = "Draw grid";
            this.checkBoxDrawGrid.UseVisualStyleBackColor = true;
            this.checkBoxDrawGrid.CheckedChanged += new System.EventHandler(this.checkBoxDrawGrid_CheckedChanged);
            // 
            // saveFileDialogExport
            // 
            this.saveFileDialogExport.DefaultExt = "bmp";
            this.saveFileDialogExport.Filter = "PNG (.png)|*.png";
            // 
            // panelColour6
            // 
            this.panelColour6.BackColor = System.Drawing.Color.Maroon;
            this.panelColour6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour6.Location = new System.Drawing.Point(858, 142);
            this.panelColour6.Name = "panelColour6";
            this.panelColour6.Size = new System.Drawing.Size(25, 25);
            this.panelColour6.TabIndex = 10;
            this.panelColour6.Click += new System.EventHandler(this.panelColour6_Click);
            // 
            // panelColour5
            // 
            this.panelColour5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelColour5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour5.Location = new System.Drawing.Point(826, 142);
            this.panelColour5.Name = "panelColour5";
            this.panelColour5.Size = new System.Drawing.Size(25, 25);
            this.panelColour5.TabIndex = 9;
            this.panelColour5.Click += new System.EventHandler(this.panelColour5_Click);
            // 
            // panelColour8
            // 
            this.panelColour8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelColour8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour8.Location = new System.Drawing.Point(858, 173);
            this.panelColour8.Name = "panelColour8";
            this.panelColour8.Size = new System.Drawing.Size(25, 25);
            this.panelColour8.TabIndex = 10;
            this.panelColour8.Click += new System.EventHandler(this.panelColour8_Click);
            // 
            // panelColour7
            // 
            this.panelColour7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelColour7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour7.Location = new System.Drawing.Point(826, 173);
            this.panelColour7.Name = "panelColour7";
            this.panelColour7.Size = new System.Drawing.Size(25, 25);
            this.panelColour7.TabIndex = 9;
            this.panelColour7.Click += new System.EventHandler(this.panelColour7_Click);
            // 
            // panelColour10
            // 
            this.panelColour10.BackColor = System.Drawing.Color.Aqua;
            this.panelColour10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour10.Location = new System.Drawing.Point(858, 204);
            this.panelColour10.Name = "panelColour10";
            this.panelColour10.Size = new System.Drawing.Size(25, 25);
            this.panelColour10.TabIndex = 10;
            this.panelColour10.Click += new System.EventHandler(this.panelColour10_Click);
            // 
            // panelColour9
            // 
            this.panelColour9.BackColor = System.Drawing.Color.Yellow;
            this.panelColour9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColour9.Location = new System.Drawing.Point(826, 204);
            this.panelColour9.Name = "panelColour9";
            this.panelColour9.Size = new System.Drawing.Size(25, 25);
            this.panelColour9.TabIndex = 9;
            this.panelColour9.Click += new System.EventHandler(this.panelColour9_Click);
            // 
            // buttonCopyColour
            // 
            this.buttonCopyColour.Location = new System.Drawing.Point(823, 235);
            this.buttonCopyColour.Name = "buttonCopyColour";
            this.buttonCopyColour.Size = new System.Drawing.Size(63, 47);
            this.buttonCopyColour.TabIndex = 12;
            this.buttonCopyColour.Text = "Copy colour";
            this.buttonCopyColour.UseVisualStyleBackColor = true;
            this.buttonCopyColour.Click += new System.EventHandler(this.buttonCopyColour_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "TXT (.txt)|*.txt";
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
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 847);
            this.Controls.Add(this.buttonCopyColour);
            this.Controls.Add(this.panelColour10);
            this.Controls.Add(this.panelColour9);
            this.Controls.Add(this.panelColour8);
            this.Controls.Add(this.panelColour7);
            this.Controls.Add(this.panelColour6);
            this.Controls.Add(this.panelColour5);
            this.Controls.Add(this.checkBoxDrawGrid);
            this.Controls.Add(this.myPanel);
            this.Controls.Add(this.panelColour4);
            this.Controls.Add(this.panelColour2);
            this.Controls.Add(this.panelColour3);
            this.Controls.Add(this.panelColour1);
            this.Controls.Add(this.buttonNewColour);
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

        private System.Windows.Forms.Button buttonNewColour;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private System.Windows.Forms.Panel panelColour6;
        private System.Windows.Forms.Panel panelColour5;
        private System.Windows.Forms.Panel panelColour8;
        private System.Windows.Forms.Panel panelColour7;
        private System.Windows.Forms.Panel panelColour10;
        private System.Windows.Forms.Panel panelColour9;
        private System.Windows.Forms.Button buttonCopyColour;
        private System.Windows.Forms.ToolStripMenuItem exportAsPNGToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

