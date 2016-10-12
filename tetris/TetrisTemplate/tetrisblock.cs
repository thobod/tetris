using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tetris
{
    class tetrisblock
    {
        int[,]
        I_PIECE = { { 1, 1, 1, 1 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };

        int[,]
        S_PIECE = { { 0, 2, 2, 0 },
                    { 2, 2, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };
        int[,]
        Z_PIECE = { { 3, 3, 0, 0 },
                    { 0, 3, 3, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };

        int[,]
        J_PIECE = { { 4, 4, 4, 0 },
                    { 0, 0, 4, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };

        int[,]
        L_PIECE = { { 5, 5, 5, 0 },
                    { 5, 0, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };

        int[,]
        T_PIECE = { { 6, 6, 6, 0 },
                    { 0, 6, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };

        int[,]
        O_PIECE = { { 7, 7, 0, 0 },
                    { 7, 7, 0, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };
        public int tetrispieces(int a, int b, int c)
        {
            int[][,] tetrisPIECES = { I_PIECE, S_PIECE, Z_PIECE, L_PIECE, J_PIECE, T_PIECE, O_PIECE };
            int d = tetrisPIECES[a][b, c];
            return d;
        }
    }
}