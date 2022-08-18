using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship
{
    internal class Ship
    {
        static public Vector2 defaultPosition = new Vector2(640, 360);
        public Vector2 position = defaultPosition;
        public int speed = 240;
        public int radius = 30;

        public void shipUpdate(GameTime gameTime)
        {
            KeyboardState kstate = Keyboard.GetState();
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (kstate.IsKeyDown(Keys.Right) && position.X < 1280)
            {
                position.X += speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Left) && position.X > 0)
            {
                position.X -= speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Up) && position.Y > 0)
            {
                position.Y -= speed * dt;
            }
            if (kstate.IsKeyDown(Keys.Down) && position.Y < 720)
            {
                position.Y += speed * dt;
            }
        }
    }
}