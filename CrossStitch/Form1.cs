using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;

namespace CrossStitch
{
    public enum Units { Pixels, Cells }

    public partial class Form1 : Form
    {
        Random random;

        int panelWidth;
        int panelHeight;

        int stitchCellCountWidth;
        int stitchCellCountHeight;

        int cellWidth;

        Stitch stitch;

        Color selectedColor;

        bool mouseDown;

        bool DrawGrid;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateNewStitch(20, 20, Units.Cells);
            DrawGrid = checkBoxDrawGrid.Checked;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(NewFile nF = new NewFile())
            {
                if(nF.ShowDialog() == DialogResult.OK)
                {
                    GenerateNewStitch(nF.width, nF.height, nF.units);
                }
            }
        }

        private void GenerateNewStitch(int width, int height, Units units)
        {
            cellWidth = 10;
            selectedColor = Color.White;

            if (units == Units.Pixels)
            {
                stitchCellCountWidth = width / 10;
                stitchCellCountHeight = height / 10;
            }
            else
            {
                stitchCellCountWidth = width;
                stitchCellCountHeight = height;
            }

            ResizePanel(stitchCellCountWidth * 10, stitchCellCountHeight * 10);

            stitch = new Stitch(stitchCellCountWidth, stitchCellCountHeight);
        }

        private void ResizePanel(int width, int height)
        {
            myPanel.Width = width;
            myPanel.Height = height;
            panelWidth = myPanel.Width;
            panelHeight = myPanel.Height;
        }


        private void PaintCell(Point coordinates)
        {
            int x = coordinates.X / 10;
            int y = coordinates.Y / 10;

            if (x < stitch.stitchCells.GetLength(0) && x >= 0 && y >= 0 && y < stitch.stitchCells.GetLength(1))
            {
                if (stitch.stitchCells[x, y] != selectedColor)
                {
                    stitch.stitchCells[x, y] = selectedColor;
                    myPanel.Invalidate(); // call this to redraw
                }
            }
        }

        private void myPanel_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode) return;
            Render(e.Graphics);
        }

        private void myPanel_MouseDown(object sender, MouseEventArgs e)
        {
            //Console.WriteLine("Mouse down");
            mouseDown = true;
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            PaintCell(coordinates);
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

            var darkGrey = new Pen(Color.FromArgb(255, Color.Black),1);
            var grey = new Pen(Color.FromArgb(85, Color.Black),1);

            for (int sX = 0; sX < stitchCellCountWidth; sX++)
            {
                for (int sY = 0; sY < stitchCellCountHeight; sY++)
                {
                    g.FillRectangle(new SolidBrush(stitch.stitchCells[sX, sY]), (sX * cellWidth) + 1, (sY * cellWidth) + 1, 9, 9);
                }
            }

            if (DrawGrid)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.AllowFullOpen = true;
            colorDialog.FullOpen = true;

            colorDialog.ShowHelp = false;

            colorDialog.Color = Color.Blue;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                selectedColor = colorDialog.Color;

            panelColour1.BackColor = selectedColor;

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

        private void checkBoxDrawGrid_CheckedChanged(object sender, EventArgs e)
        {
            DrawGrid = !DrawGrid;
        }
    }
}
