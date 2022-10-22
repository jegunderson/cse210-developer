using System;
using System.Collections.Generic;

namespace Unit03
{
    class Director
    {
        private Word w1 = new Word();
        private Jumper jumper = new Jumper();
        private bool _isPlaying = true;

        private TerminalService terminalservice = new TerminalService();

        public Director()
        {
            terminalservice.WriteText(jumper.PrintJumper());
            terminalservice.WriteText(w1.PrintHint());
        }

            public void StartGame()
            {
                while (_isPlaying)
                {
                    char guess = GetInput();
                    DoUpdate(guess);
                    DoOutput();
                }
            }
            private char GetInput()
            {
                char guess = terminalservice.ReadChar("What is your guess? ");
                return guess;
            }
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

            private void DoOutput()
            {
                terminalservice.WriteText("");
                terminalservice.WriteText(jumper.PrintJumper());
                terminalservice.WriteText("");
                terminalservice.WriteText(w1.PrintHint());
            }
    }
}