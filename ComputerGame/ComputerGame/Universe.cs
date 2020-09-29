using System;
using System.Drawing;

namespace ComputerGame
{
    class Universe : BaseObject
    {
        public Universe(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
        }
        public override void Draw()
        {
            Image newImage = Image.FromFile("1.png");
            Game.Buffer.Graphics.DrawImage(newImage, Pos.X, Pos.Y);
        }
        public override void Update()
        {
            Pos.X = Pos.X - Dir.X;
            if (Pos.X < 0) Pos.X = Game.Width;
            if (Pos.X > Game.Width) Pos.X = 0;
        }
    }
}
