using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Xml.Serialization;
using System.Globalization;

namespace CrossStitch
{
    public enum Units { Pixels, Cells }

    public partial class Form1 : Form
    {
        Bitmap bmp;

        int panelWidth;
        int panelHeight;

        Stitch stitch;

        List<Panel> ColourPanels;
        List<Color> QuickColourList;
        Color selectedColor;
        Color drawColor;

        // Modes
        bool copyingColourMode;
        bool mouseDown;
        bool drawGrid;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateNewStitch(80, 80, Units.Cells, 10);

            drawGrid = checkBoxDrawGrid.Checked;

            ColourPanels = new List<Panel> { panelColour1,
                panelColour2,
                panelColour3,
                panelColour4,
                panelColour5,
                panelColour6,
                panelColour7,
                panelColour8,
                panelColour9,
                panelColour10 };

            QuickColourList = new List<Color> { Color.White, 
                Color.Red, 
                Color.Blue, 
                Color.Teal, 
                Color.Purple, 
                Color.Yellow, 
                Color.Orange, 
                Color.Green, 
                Color.Pink, 
                Color.Green, 
                Color.Brown };
        }

        private byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }

        private Stitch LoadStitch(string filePath)
        {
            byte[] readBytes = new byte[40000];
            Stitch stitchTemp;
            int loadedstitchWidth, loadedstitchHeight, loadedstitchCellWidth;

            using (FileStream fs = File.OpenRead(filePath))
            {
                while (fs.Read(readBytes, 0, readBytes.Length) > 0)
                {
                }
            }

            loadedstitchWidth = readBytes[0];
            loadedstitchHeight = readBytes[1];
            loadedstitchCellWidth = readBytes[2];

            stitchTemp = new Stitch(loadedstitchWidth, loadedstitchHeight, loadedstitchCellWidth);

            ResizePanel(stitchTemp.Width * stitchTemp.CellWidth, stitchTemp.Height * stitchTemp.CellWidth);

            int count = 4;

            for (int x = 0; x < stitch.Width; x++)
            {
                for (int y = 0; y < stitch.Height; y++)
                {
                    stitchTemp.stitchCells[x, y] = Color.FromArgb(255, readBytes[count], readBytes[count + 1], readBytes[count + 2]);
                    count += 3;
                }
            }
            return stitchTemp;
        }

        private void SaveStitch(string filepath, Stitch stitch)
        {
            ColorConverter c = new ColorConverter();

            byte[] header = new byte[4];
            header[0] = (byte)stitch.Width;
            header[1] = (byte)stitch.Height;
            header[2] = (byte)stitch.CellWidth;

            byte[] stitchCells = new byte[stitch.Width * stitch.Height * 3];
            int count = 0;

            for (int x = 0; x < stitch.Width; x++)
            {
                for (int y = 0; y < stitch.Height; y++)
                {
                    stitchCells[count] = stitch.stitchCells[x, y].R;
                    count++;
                    stitchCells[count] = stitch.stitchCells[x, y].G;
                    count++;
                    stitchCells[count] = stitch.stitchCells[x, y].B;
                    count++;
                }
            }

            byte[] toWrite = Combine(header, stitchCells);

            using (FileStream fs = File.Create(filepath))
            {
                for (int i = 0; i < toWrite.Length; i++)
                {
                    fs.WriteByte(toWrite[i]);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenStitch();
            myPanel.Invalidate();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void OpenStitch()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stitch = LoadStitch(openFileDialog.FileName);
            }
        }

        private void SaveFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveStitch(saveFileDialog.FileName, stitch);
            }
        }

        private void exportAsPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialogExport.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialogExport.FileName;
                stitch.FileName = fileName;

                ExportImage(fileName);
            }
        }

        private void ExportImage(string FileName)
        {
            try
            {
                bmp = new Bitmap(panelWidth, panelHeight);

                using (Graphics bmpG = Graphics.FromImage(bmp))
                {
                    Render(bmpG);
                }

                bmp.Save(FileName, ImageFormat.Png);
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not export file.");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(NewFile nF = new NewFile())
            {
                if(nF.ShowDialog() == DialogResult.OK)
                {
                    GenerateNewStitch(nF.width, nF.height, nF.units, nF.density);
                    myPanel.Invalidate();
                }
            }
        }

        private void GenerateNewStitch(int width, int height, Units units, int density)
        {
            stitch = new Stitch(width, height, density);

            selectedColor = Color.White;

            ResizePanel(stitch.Width * stitch.CellWidth, stitch.Height * stitch.CellWidth);
        }

        private void ResizePanel(int width, int height)
        {
            myPanel.Width = width;
            myPanel.Height = height;
            panelWidth = myPanel.Width;
            panelHeight = myPanel.Height;
        }

        private void AddColourToPanel(Color colorToAdd)
        {
            QuickColourList.Insert(0, colorToAdd);
            QuickColourList.RemoveAt(10);
            
            for(int i = 0; i < ColourPanels.Count; i++)
            {
                ColourPanels[i].BackColor = QuickColourList[i];
            }
        }

        private void PaintCell(Point coordinates)
        {
            int x = coordinates.X / stitch.CellWidth;
            int y = coordinates.Y / stitch.CellWidth;

            if (x < stitch.stitchCells.GetLength(0) && x >= 0 && y >= 0 && y < stitch.stitchCells.GetLength(1) && copyingColourMode == false)
            {
                if (stitch.stitchCells[x, y] != drawColor)
                {
                    stitch.stitchCells[x, y] = drawColor;
                    myPanel.Invalidate(); // call this to redraw
                }
            }
        }

        private int RoundToTen(double i)
        {
            return 10 * (int)Math.Round((i / 10.0));
        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode) return;
            Render(e.Graphics);
        }

        private void myPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;

            if(copyingColourMode)
            {
                selectedColor = stitch.stitchCells[me.X / 10, me.Y / 10];
                AddColourToPanel(selectedColor);
                copyingColourMode = false;
                this.Cursor = Cursors.Default;
            }
            else if (me.Button == MouseButtons.Left)
            {
                drawColor = selectedColor;
                PaintCell(coordinates); 
            }
            else if(me.Button == MouseButtons.Right)
            {
                drawColor = Color.White;
                PaintCell(coordinates); 
            }
        }

        private void myPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void myPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;
                PaintCell(coordinates);
            }
        }

        private void myPanel_MouseLeave(object sender, EventArgs e)
        {
            mouseDown = false;
        }

        private void Render(System.Drawing.Graphics g)
        {
            if (DesignMode) return;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen darkGrey = new Pen(Color.FromArgb(255, Color.Black),1);
            Pen grey = new Pen(Color.FromArgb(85, Color.Black), 1);

            darkGrey.DashPattern = new float[] { 2, 4 };

            float[] dashValues = {2,2};
            grey.DashPattern = dashValues;

            for (int sX = 0; sX < stitch.Width; sX++)
            {
                for (int sY = 0; sY < stitch.Height; sY++)
                {
                    g.FillRectangle(new SolidBrush(stitch.stitchCells[sX, sY]), (sX * stitch.CellWidth) + 1, (sY * stitch.CellWidth) + 1, stitch.CellWidth - 1, stitch.CellWidth - 1);
                }
            }

            // draw grid
            if (drawGrid)
            {
                // VERTICAL LINES //
                for (int i = 0; i < stitch.Width; i++)
                {
                    if (i % 10 != 0)
                    {
                        g.DrawLine(grey, i * stitch.CellWidth, 0, // main lines
                            i * stitch.CellWidth, 800);
                    }
                    else
                    {
                        g.DrawLine(darkGrey, i * stitch.CellWidth, 0, // interval lines
                            i * stitch.CellWidth, 800);
                    }
                }

                // HORIZONTAL LINES //
                for (int i = 0; i < stitch.Height; i++)
                {
                    if (i % 10 != 0)
                    {
                        g.DrawLine(grey, 0, i * stitch.CellWidth, // main lines
                            800, i * stitch.CellWidth);
                    }
                    else
                    {
                        g.DrawLine(darkGrey, 0, i * stitch.CellWidth, // interval lines
                            800, i * stitch.CellWidth);
                    }
                }
            }

            g.DrawLine(darkGrey, panelWidth - 1, 0, panelWidth - 1, panelHeight - 1);
            g.DrawLine(darkGrey, 0, panelHeight - 1, panelWidth, panelHeight - 1);
        }

        private void buttonNewColour_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;

            colorDialog.ShowHelp = false;

            colorDialog.Color = Color.Blue;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
                panelColour1.BackColor = selectedColor;
                AddColourToPanel(colorDialog.Color);
            }
        }

        private void buttonCopyColour_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            copyingColourMode = true;
        }

        private void checkBoxDrawGrid_CheckedChanged(object sender, EventArgs e)
        {
            drawGrid = !drawGrid;
            myPanel.Invalidate();
        }

        private void panelColour1_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour1.BackColor;
        }

        private void panelColour2_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour2.BackColor;
        }

        private void panelColour3_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour3.BackColor;
        }

        private void panelColour4_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour4.BackColor;
        }

        private void panelColour5_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour5.BackColor;
        }

        private void panelColour6_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour6.BackColor;
        }

        private void panelColour7_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour7.BackColor;
        }

        private void panelColour8_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour8.BackColor;
        }

        private void panelColour9_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour9.BackColor;
        }

        private void panelColour10_Click(object sender, EventArgs e)
        {
            selectedColor = panelColour10.BackColor;
        }
    }
}
