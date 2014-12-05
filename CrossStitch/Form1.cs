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

namespace CrossStitch
{
    public enum Units { Pixels, Cells }

    public partial class Form1 : Form
    {
        Bitmap bmp;

        int panelWidth;
        int panelHeight;

        int stitchCellCountWidth;
        int stitchCellCountHeight;

        int cellWidth;

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

            //stitch.PointList.Add(new PointPair(0, 0, 200, 200));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializeStitch();
        }

        private void SerializeStitch()
        {
            string path = @"C:\Users\Will\Desktop\text.XML";
            FileStream outFile = File.Create(path);
            XmlSerializer formatter = new XmlSerializer(stitch.stitchCells.GetType());
            formatter.Serialize(outFile, stitch.stitchCells);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = saveFileDialog1.FileName;
            stitch.FileName = fileName;

            SaveFile(fileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(stitch.FileName);
        }

        private void SaveFile(string FileName)
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
            catch(ArgumentNullException)
            {
                saveFileDialog1.ShowDialog();
                //MessageBox.Show("Invalid file path to save to.");
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
            cellWidth = density;
            selectedColor = Color.White;

            stitchCellCountWidth = width;
            stitchCellCountHeight = height;

            Console.WriteLine(stitchCellCountWidth);

            ResizePanel(stitchCellCountWidth * cellWidth, stitchCellCountHeight * cellWidth);

            stitch = new Stitch(stitchCellCountWidth, stitchCellCountHeight);
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
            //QuickColourList.Last() = colorToAdd;

            QuickColourList.Insert(0, colorToAdd);
            QuickColourList.RemoveAt(10);
            
            for(int i = 0; i < ColourPanels.Count; i++)
            {
                ColourPanels[i].BackColor = QuickColourList[i];
            }
        }
        private void PaintCell(Point coordinates)
        {
            int x = coordinates.X / cellWidth;
            int y = coordinates.Y / cellWidth;

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

            for (int sX = 0; sX < stitchCellCountWidth; sX++)
            {
                for (int sY = 0; sY < stitchCellCountHeight; sY++)
                {
                    g.FillRectangle(new SolidBrush(stitch.stitchCells[sX, sY]), (sX * cellWidth) + 1, (sY * cellWidth) + 1, cellWidth - 1, cellWidth - 1);
                }
            }

            // draw grid
            if (drawGrid)
            {
                // VERTICAL LINES //
                for (int i = 0; i < stitchCellCountWidth; i++)
                {
                    if (i % 10 != 0)
                    {
                        g.DrawLine(grey, i * cellWidth, 0, // main lines
                            i * cellWidth, 800);
                    }
                    else
                    {
                        g.DrawLine(darkGrey, i * cellWidth, 0, // interval lines
                            i * cellWidth, 800);
                    }
                }

                // HORIZONTAL LINES //
                for (int i = 0; i < stitchCellCountHeight; i++)
                {
                    if (i % 10 != 0)
                    {
                        g.DrawLine(grey, 0, i * cellWidth, // main lines
                            800, i * cellWidth);
                    }
                    else
                    {
                        g.DrawLine(darkGrey, 0, i * cellWidth, // interval lines
                            800, i * cellWidth);
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
