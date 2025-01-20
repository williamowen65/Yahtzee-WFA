

using System;
using System.Windows.Forms;
using Yahtzee_WFA;

namespace Yahtzee_WFA
{
    /// <summary>
    /// Represents a single six-sided die (1 -6 )
    /// </summary>
    public class Die
    {

        private static int dieWidth = 55;
        private static int dieHeight = dieWidth;
        private static int spriteYOffset = 28;
        private static int spriteXOffset = 28;


        /// <summary>
        /// Map that tracks the location of die on the sprite
        /// </summary>
        private static readonly Dictionary<byte, Rectangle> DieFaceMap = new Dictionary<byte, Rectangle>
        {
            { 1, new Rectangle(spriteXOffset, spriteYOffset, dieWidth, dieHeight) },
            { 2, new Rectangle(spriteXOffset + dieWidth, spriteYOffset, dieWidth, dieHeight) },
            { 3, new Rectangle(spriteXOffset + dieWidth * 2, spriteYOffset, dieWidth, dieHeight) },
            { 4, new Rectangle(spriteXOffset + dieWidth * 3, spriteYOffset, dieWidth, dieHeight) },
            { 5, new Rectangle(spriteXOffset + dieWidth * 4, spriteYOffset, dieWidth, dieHeight) },
            { 6, new Rectangle(spriteXOffset + dieWidth * 5, spriteYOffset, dieWidth, dieHeight) }
        };

        // ctor ← shorthand for constructor

        /// <summary>
        /// Creates the die and rolls it to start with 
        /// a random number
        /// </summary>
        public Die(GameBoard board, PictureBox targetDieDisplay)
        {
            Roll();
            InitializePictureBox(board, targetDieDisplay);
        }

        // prop ← shorthand for intellisense

        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; } // Initializes FaceValue to 1 and allows private set

        /// <summary>
        /// True is the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Random
        /// </summary>
        private static Random _random = new Random();

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// Rolls the die and sets the face value to the new number
        /// Rolls the die and sets the <see cref="FaceValue" />to the new number
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            // Generate random number
            byte newValue = (byte)_random.Next(1, _random.Next(1, 7));
            // Set to face value
            FaceValue = newValue;

            //setDieImage();

            return FaceValue;
        }

        PictureBox _pictureBox;
        private void InitializePictureBox(GameBoard board, PictureBox targetDieDisplay)
        {

            _pictureBox = targetDieDisplay;

            setDieImage();
        }

        public void setDieImage() {

            _pictureBox.Paint += (sender, e) =>
            {
                using (Image spriteSheet = Image.FromFile(@"..\..\..\diceSprite.png")) // Use the relative path
                {
                    // Use the DieFaceMap to get the coordinates
                    Rectangle sourceRect = DieFaceMap[FaceValue];
                    // Define the portion of the sprite sheet to draw (e.g., the first sprite)
                    Rectangle destRect = new Rectangle(0, 0, _pictureBox.Width, _pictureBox.Height);

                    e.Graphics.DrawImage(spriteSheet, destRect, sourceRect, GraphicsUnit.Pixel);
                }
            };
        }

        public int MyProperty { get; set; }

    }

}
