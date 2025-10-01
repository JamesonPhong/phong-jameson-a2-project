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

        /* 
            Colour palette legend:

            Color lightBrown    = new Color("#B87333");
            Color darkBrown     = new Color("#7B3F00");
            Color gold          = new Color("#FFBF00");
            Color white         = new Color("#F6F6F6");
            Color black         = new Color("#090909");
            Color lightBlue     = new Color("#57B9FF");
            Color red           = new Color("#D22B2B");
        */

        Color[] palette = { new Color("#B87333"),   // Index 0
                            new Color("#7B3F00"),   // Index 1
                            new Color("#FFBF00"),   // Index 2
                            new Color("#F6F6F6"),   // Index 3
                            new Color("#090909"),   // Index 4
                            new Color("#57B9FF"),   // Index 5
                            new Color("#D22B2B") }; // Index 6

        /*
            Important numbers:
            
            Square Coords: 0, 360
            Square Size: 40
            
            Rectangle Coords: 40, 0, 360
            Rectangle Size: 320, 40

            Circle Coords: 220, 140, 200, 160
            Circle Size: 20, 80

            Ellipse Coords: 200, 360
            Ellipse Size: 240, 160
            
        */

        int[] num = [ 0,    // Index 0
                      40,   // Index 1
                      320,  // Index 2
                      360,  // Index 3
                      220,  // Index 4
                      140,  // Index 5
                      20,   // Index 6
                      200,  // Index 7
                      160,  // Index 8
                      80,   // Index 9
                      240]; // Index 10

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }
    }

}
