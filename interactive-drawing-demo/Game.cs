// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        // Custom colours
        Color darkBlue  = new Color("#0f052d");
        Color blue      = new Color("#203671");
        Color lightBlue = new Color("#36868f");
        Color green     = new Color("#5fc75d");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Cool Title");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Drawing rows of clouds
            Window.ClearBackground(darkBlue);
            DrawRowOfClouds(blue,       275, 25, 15, 33);
            DrawRowOfClouds(lightBlue,  325, 50, 7, 67);
            DrawRowOfClouds(green,      400, 75, 5, 100);
        }
        // Function to draw rows of clouds
        void DrawRowOfClouds(Color cloudColor, int y, int r, int count, float space)
        {
            Draw.FillColor = cloudColor;
            Draw.LineSize = 0;
            for (int i = 0; i < count; i++)
            {
                Draw.Circle(space * i, y, r);
            }
        }
    }

}
