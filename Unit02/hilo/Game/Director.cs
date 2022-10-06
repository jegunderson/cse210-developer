using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        
        bool _isPlaying = true;
        int _score = 300;
        string user_guess;
        int currentCardValue;
        int nextCardValue;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            Card card = new Card();
            currentCardValue = card.value;
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {

                GetInputs();
                DoUpdates();
                DoOutputs();
                PlayAgain();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {

            Console.WriteLine($"The card is: {currentCardValue}");
            Console.WriteLine("Higher or Lower? [h/l] ");
            user_guess = Console.ReadLine();

        }

        public void PlayAgain()
        {

            Console.Write("Play again? [y/n] ");
            string play_again = Console.ReadLine();
            _isPlaying = (play_again.ToLower() == "y");
            
        }
        
        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }


            Card nextCard = new Card();
            nextCardValue = nextCard.value;

            _score += (currentCardValue == nextCardValue) ? 0: ((user_guess == "h") == (currentCardValue < nextCardValue)) ? 100: -75;
            
            currentCardValue = nextCardValue;
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }
            Console.WriteLine($"The card was {currentCardValue}");
            Console.WriteLine($"You're score is {_score}");


            // _isPlaying = (_score > 0);
        }
    }
}


