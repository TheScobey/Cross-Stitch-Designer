namespace CrossStitch
{
    partial class NewFile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericWidth = new System.Windows.Forms.NumericUpDown();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelDensity = new System.Windows.Forms.Label();
            this.numericUpDownDensity = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDownDensity);
            this.panel1.Controls.Add(this.labelDensity);
            this.panel1.Controls.Add(this.numericHeight);
            this.panel1.Controls.Add(this.numericWidth);
            this.panel1.Controls.Add(this.comboBoxUnits);
            this.panel1.Controls.Add(this.labelHeight);
            this.panel1.Controls.Add(this.labelWidth);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 205);
            this.panel1.TabIndex = 0;
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(122, 62);
            this.numericHeight.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(75, 20);
            this.numericHeight.TabIndex = 6;
            this.numericHeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // numericWidth
            // 
            this.numericWidth.Location = new System.Drawing.Point(122, 36);
            this.numericWidth.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericWidth.Name = "numericWidth";
            this.numericWidth.Size = new System.Drawing.Size(75, 20);
            this.numericWidth.TabIndex = 5;
            this.numericWidth.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Items.AddRange(new object[] {
            "Cells",
            "Pixels"});
            this.comboBoxUnits.Location = new System.Drawing.Point(122, 88);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(75, 21);
            this.comboBoxUnits.TabIndex = 2;
            this.comboBoxUnits.Text = "Cells";
            this.comboBoxUnits.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnits_SelectedIndexChanged);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(51, 60);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(56, 19);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(55, 34);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(52, 19);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(116, 223);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 26);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(197, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 26);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDensity.Location = new System.Drawing.Point(17, 119);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(99, 19);
            this.labelDensity.TabIndex = 7;
            this.labelDensity.Text = "Pixels per cell";
            // 
            // numericUpDownDensity
            // 
            this.numericUpDownDensity.Location = new System.Drawing.Point(122, 119);
            this.numericUpDownDensity.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownDensity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDensity.Name = "numericUpDownDensity";
            this.numericUpDownDensity.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownDensity.TabIndex = 8;
            this.numericUpDownDensity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDensity.ValueChanged += new System.EventHandler(this.numericUpDownDensity_ValueChanged);
            // 
            // NewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.panel1);
            this.Name = "NewFile";
            this.Text = "Create new file";
            this.Load += new System.EventHandler(this.NewFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDensity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericWidth;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownDensity;
        private System.Windows.Forms.Label labelDensity;
    }
}