using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class TetrisGame : Game
{
    SpriteBatch spriteBatch;
    InputHelper inputHelper;
    protected static GameWorld gameWorld;

    [STAThread]
    static void Main(string[] args)
    {
        TetrisGame game = new TetrisGame();
        game.Run();
    }

    public TetrisGame()
    {
        GraphicsDeviceManager graphics = new GraphicsDeviceManager(this); // initialize the graphics device
        this.Content.RootDirectory = "Content";// set the directory where game assets are located
        graphics.PreferredBackBufferWidth = 800; // set the desired window size
        graphics.PreferredBackBufferHeight = 600;
        inputHelper = new InputHelper();// create the input helper object
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        // create and reset the game world
        gameWorld = new GameWorld(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, Content);
        gameWorld.Reset();
    }

    protected override void Update(GameTime gameTime)
    {
        inputHelper.Update(gameTime);
        gameWorld.HandleInput(gameTime, inputHelper);
        gameWorld.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);
        gameWorld.Draw(gameTime, spriteBatch);
    }
    public static GameWorld GameWorld
    {
        get { return gameWorld; }
    }
}