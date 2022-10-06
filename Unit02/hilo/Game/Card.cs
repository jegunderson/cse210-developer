using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A card with a given value between 1 and 13.
        /// 
        /// The responsibility of Card is to keep track of its current face value
        /// </summary> 

        public class Card
        {
            public int value;

            public Card()
            {
                Random r = new Random();
                value = r.Next(1,14);

            }
        }
        ///   <summary>
        /// Generates a new random value for the card.
        /// </summary>
        

    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>

    
    // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        
}