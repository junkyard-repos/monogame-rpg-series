﻿using DaGameEngine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DaGame
{
    class MainGame : Game
    {
        private GraphicsDeviceManager manager;
        private Map myMap;
        private SpriteBatch spriteBatch;

        public MainGame()
        {
            manager = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            myMap = new Map(GraphicsDevice, 32, 32, 10, 10);
        }

        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            Vector2 moveVelocity = Vector2.Zero;

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                moveVelocity += new Vector2(1, 0);
            }

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                moveVelocity += new Vector2(-1, 0);
            }

            if (keyboardState.IsKeyDown(Keys.Up))
            {
                moveVelocity += new Vector2(0, -1);
            }

            if (keyboardState.IsKeyDown(Keys.Down))
            {
                moveVelocity += new Vector2(0, 1);
            }

            myMap.Camera.Move(moveVelocity);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            myMap.Draw(spriteBatch);
        }
    }
}