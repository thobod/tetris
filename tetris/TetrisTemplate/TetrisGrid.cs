using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


class TetrisGrid
{
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
    }
    public void Draw(GameTime gameTime, SpriteBatch s)
    {
       for(int i = 0; i<Width; i++)
            for (int j = 0; j < Height ; j++)
                s.Draw(gridblock, position = new Vector2(i*30, j*30) , Color.White);
    }
}

