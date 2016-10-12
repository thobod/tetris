using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Tetris;


class TetrisGrid
{
    tetrisblock blok = new tetrisblock();
    int[,] grid = new int[12,20];
    public TetrisGrid(Texture2D b)
    {
        gridblock = b;
        position = Vector2.Zero;
        //teststuff1();
        drawblock(3, 4, 0); // voer in: (bloksoort, x pos, y pos)
        //ClearLine(0);
        //this.Clear();
    }
    Texture2D gridblock;
    Vector2 position = new Vector2();
    public int Width
    {
        get { return 12; }
    }
    public int Height
    {
        get { return 20; }
    }
    public void Clear()
    {
        for (int x = 0; x < Width; x++) // maak alle blokken grijs
            for (int y = 0; y < Height; y++)
                grid[x, y] = 0;
    }
    public void drawblock(int block, int xpos, int ypos)
    {
        //block determines the kind of blosk being drawn: 0=I, 1=S, 2=Z, 3=J, 4=L, 5=T, 6=O 7=SUPRISE MF
        //int xpos = 4;  //determines the x pos of the block being drawn
        //int ypos = 1;  //determines the y pos of the block being drawn
        tetrisblock blok = new tetrisblock();
        for (int x = 0; x < 4; x++)
            for (int y = 0; y < 4; y++)
                grid[x + xpos, y + ypos] = blok.tetrispieces(block, x, y);
    }
    public void teststuff1() //methode om te testen of clear methodes werken (niet in de final game)
    {
        
        grid[1, 0] = 1;
        grid[1, 1] = 2;
        grid[1, 2] = 1;
        grid[1, 3] = 2;
        grid[1, 4] = 3;
        grid[1, 5] = 4;
        grid[1,6] = 3;
    }
    public void ClearLine(int y) // maakt de lijn met y coordinaat y leeg en schuift grid naar onder
    {
        for (int x = 0; x < Width; x++)
        {
            for (int i = y; i > 0; i--)
            {
                grid[x, i] = grid[x, i - 1];
            }
            grid[x, 0] = 0; // zet de bovenste lijn grijs na een clearline()
        }
    }
    public void Draw(GameTime gameTime, SpriteBatch s)
    {
        for (int x = 0; x < Width; x++) // draw de blokken
            for (int y = 0; y < Height; y++)
            {
                // drawed de blocken in wit 0 blauw 1 rood 2 groen 3 paars 4 oranje 5 cyan 6 bruin 7
                if (grid[x, y] == 0)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.White);
                }
                else if (grid[x, y] == 1)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Blue);
                }
                else if (grid[x, y] == 2)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Red);
                }
                else if (grid[x, y] == 3)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Green);
                }
                else if (grid[x, y] == 4)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Purple);
                }
                else if (grid[x, y] == 5)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Orange);
                }
                else if (grid[x, y] == 6)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.DarkCyan);
                }
                else if (grid[x, y] == 7)
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Brown);
                }
            }
    }
}

