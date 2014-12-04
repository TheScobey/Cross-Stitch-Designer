using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossStitch
{
    public partial class NewFile : Form
    {
        public int width;
        public int height;
        public Units units;

        ToolTip ToolTipUnits;

        public NewFile()
        {
            InitializeComponent(); 
        }

        private void NewFile_Load(object sender, EventArgs e)
        {
            ToolTipUnits = new ToolTip();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxUnits.SelectedIndex > -1)
            {
                if ((string)comboBoxUnits.SelectedItem == "Pixels")
                {
                    units = Units.Pixels;
                }
                else
                {
                    units = Units.Cells;
                }

                try
                {
                    width = Convert.ToInt16(numericWidth.Value);
                    height = Convert.ToInt16(numericHeight.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                ToolTipUnits.Show("Select the units to use.", this.comboBoxUnits, 4000);
            }

            DialogResult = DialogResult.OK;
        }

        private void comboBoxUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxUnits.SelectedItem == "Pixels")
            {
                numericWidth.Minimum = 100;
                numericHeight.Minimum = 100;
                numericWidth.Maximum = 800;
                numericHeight.Maximum = 800;
            }
            else
            {
                numericWidth.Minimum = 10;
                numericHeight.Minimum = 10;
                numericWidth.Maximum = 80;
                numericHeight.Maximum = 80;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
