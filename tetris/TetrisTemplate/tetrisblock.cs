using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class tetrisblock
    {
        int x;
        int y;
        int length;
        int width;
        int[,] shape = new int[4, 4];
        public void rotateblock()
        {
            shape[x, y] = shape[y, -x];
        }
    }
}