using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


class TetrisGrid
{
    int x;
    int y;
    int[,] grid = new int[12,20];
    public TetrisGrid(Texture2D b)
    {
        gridblock = b;
        position = Vector2.Zero;
        this.Clear();
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
    public void Update()
    {
        grid[2, 19] = 1;
    }
    public void ClearLine(int y)
    {
        for (int x = 0; x < Width; x++)
            grid[x, y] = 0;
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
            }
    }
}

