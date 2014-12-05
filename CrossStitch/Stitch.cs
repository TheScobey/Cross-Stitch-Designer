using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CrossStitch
{
    public class Stitch
    {
        public Color[,] stitchCells;
        public string FileName;

        public int CellWidth { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }

        public Stitch()
        {

        }

        public Stitch(int width, int height, int cellWidth)
        {
            this.Width = width;
            this.Height = height;
            this.CellWidth = cellWidth;

            stitchCells = new Color[width, height];

            for(int x = 0; x < width; x++)
            {
                for(int y = 0 ; y < height; y++)
                {
                    stitchCells[x, y] = Color.White;
                }
            }
        }
    }
}
