using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CrossStitch
{
    class Stitch
    {
        public Color[,] stitchCells;
        public string FileName;

        public int Width
        {
            get
            {
                return width;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        private int width;
        private int height;

        public Stitch(int width, int height)
        {
            this.width = width;
            this.height = height;

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
