using System;
using System.Collections.Generic;

namespace Unit03
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    class Director
    {
        private Word w1 = new Word();
        private Jumper jumper = new Jumper();
        private bool _isPlaying = true;

        private TerminalService terminalservice = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            terminalservice.WriteText(jumper.PrintJumper());
            terminalservice.WriteText(w1.PrintHint());
        }

            /// <summary>
            /// Starts the game by running the main game loop.
            /// </summary>
            public void StartGame()
            {
                while (_isPlaying)
                {
                    char guess = GetInput();
                    DoUpdate(guess);
                    DoOutput();
                }
            }
            /// <summary>
            /// Gets guess
            /// </summary>
            private char GetInput()
            {
                char guess = terminalservice.ReadChar("What is your guess? ");
                return guess;
            }

            /// <summary>
            /// Checks if letter is correct and updates jumper
            /// </summary>

            private void DoUpdate(char guess)
            {
                bool CorrectGuess = w1.CheckLetter(guess);
                if (CorrectGuess)
                {
                    w1.PrintHint();
                }
                else
                {
                    jumper.BreakParachute();
                }

                if (jumper._jumperpic.Count <= 3)
                {
                    jumper._jumperpic[0] = "  X";
                    _isPlaying = false;
                }
                if (!w1._hint.Contains('_')){
                    _isPlaying = false;
                }
            }

            /// <summary>
            /// Prints jumper and hint
            /// </summary>
            private void DoOutput()
            {
                terminalservice.WriteText("");
                terminalservice.WriteText(jumper.PrintJumper());
                terminalservice.WriteText("");
                terminalservice.WriteText(w1.PrintHint());
            }
    }
}