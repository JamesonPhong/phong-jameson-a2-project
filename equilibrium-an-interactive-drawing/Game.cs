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
            Window.SetTitle("Equilibrium");
            Window.SetSize(400, 400);
            Window.ClearBackground(palette[3]);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Draw Character's Head
            Draw.LineSize = 0;
            Draw.FillColor = palette[4];
            Draw.Circle(num[7], num[8], num[9]);

            // Draw Character's Eye
            Draw.LineSize = 0;
            Draw.FillColor = palette[5];
            Draw.Circle(num[4], num[5], num[6]);

            // Draw Character's Body
            Draw.LineSize = 0;
            Draw.FillColor = palette[4];
            Draw.Ellipse(num[7], num[3], num[10], num[8]);

            /* Draw Frame Corner Reference
                
                Draw.LineSize = 3;
                Draw.LineColor = palette[2];
                Draw.FillColor = palette[0];
                Draw.Square(num[0], num[0], num[1]);

               Draw Frame Body Reference
                
                Draw.LineSize = 3;
                Draw.LineColor = palette[2];
                Draw.FillColor = palette[1];
                Draw.Rectangle(num[1], num[0], num[2], num[1]);

               Draw Frame Decoration Reference

                Draw.LineSize = 3;
                Draw.LineColor = palette[2];
                Draw.FillColor = palette[0];
                for (int i = 0; i < 8; i++)
                {
                    Draw.Circle(60 + (40 * i), 0 + (0 * i), num[6]);
                }
            */

            // Activate Draw Frame Corner Function
            drawFrameCorner(0, 0, 1);
            drawFrameCorner(3, 0, 1);
            drawFrameCorner(0, 3, 1);
            drawFrameCorner(3, 3, 1);

            // Activate Draw Frame Body Function
            drawFrameBody(1, 0, 2, 1);
            drawFrameBody(0, 1, 1, 2);
            drawFrameBody(3, 1, 1, 2);
            drawFrameBody(1, 3, 2, 1);

            // Activate Draw Frame Decoration Function
            drawFrameDecoration(60, 40, 0, 0, 6);
            drawFrameDecoration(0, 0, 60, 40, 6);
            drawFrameDecoration(400, 0, 60, 40, 6);
            drawFrameDecoration(60, 40, 400, 0, 6);
        }
        // Function: Draw Frame Corner
        void drawFrameCorner(int x, int y, int size)
        {
            // Draw Frame Corner
            Draw.LineSize = 3;
            Draw.LineColor = palette[2];
            Draw.FillColor = palette[0];
            Draw.Square(num[x], num[y], num[size]);
        }

        // Function: Draw Frame Body
        void drawFrameBody(int x, int y, int w, int h)
        {
            // Draw Frame Body
            Draw.LineSize = 3;
            Draw.LineColor = palette[2];
            Draw.FillColor = palette[1];
            Draw.Rectangle(num[x], num[y], num[w], num[h]);
        }

        // Function: Draw Frame Decoration
        void drawFrameDecoration(int x1, int x2, int y1, int y2, int index)
        {
            // Draw Frame Decoration
            Draw.LineSize = 3;
            Draw.LineColor = palette[2];
            Draw.FillColor = palette[0];
            for (int i = 0; i < 8; i++)
            {
                Draw.Circle(x1 + (x2 * i), y1 + (y2 * i), num[index]);
            }
        }
    }

}
