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
        test();
        //Update();
        //ClearLine(3);
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
    public void test()
    {
        int xpos = 0;
        int ypos = 0;
        tetrisblock blok = new tetrisblock();
        for (int x = 0; x < 4; x++)
            for (int y = 0; y < 4; y++)
                grid[x + xpos, y + ypos] = blok.tetrispieces(3, xpos, ypos);
    }
    /*public void test()
    {
        int xpos = 0;
        int ypos = 0;
        int[,]
        T_PIECE = { { 0, 6, 0, 0 },
                    { 6, 6, 6, 0 },
                    { 0, 0, 0, 0 },
                    { 0, 0, 0, 0 } };
        for (int x = 0; x < 4; x++)
            for (int y = 0; y < 4; y++)
                grid[x+xpos, y+ypos] = T_PIECE[x, y];

    }*/
    public void Update() //methode om te testen of clear methodes werken (niet in de final game)
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
                if (grid[x, y] == 0) // 0 = grijs
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.White);
                }
                else if (grid[x, y] == 1) // 1 = blauw 
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Blue);
                }
                else if (grid[x, y] == 2) // 2 = rood
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Red);
                }
                else if (grid[x, y] == 3) // 3 = groen
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Green);
                }
                else if (grid[x, y] == 4) // 4 = paars
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Purple);
                }
                else if (grid[x, y] == 5) // 4 = paars
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.Orange);
                }
                else if (grid[x, y] == 6) // 4 = paars
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.DarkCyan);
                }
                else if (grid[x, y] == 7) // 4 = paars
                {
                    s.Draw(gridblock, position = new Vector2(x * 30, y * 30), Color.LightGreen);
                }
            }
    }
}

