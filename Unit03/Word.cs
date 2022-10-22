using System.Collections.Generic;

namespace Unit03
{
    class Word
    {
        int _length;
        string _word;
        public List<char> _hint = new List<char>();

        public Word()
        {
            _word = "happy";
            _length = _word.Length;

            foreach (char letter in _word)
                _hint.Add('_');
        }

        public string PrintHint()
        {
            string hintString = string.Join(" ", _hint);
            return hintString;
        }

        public bool CheckLetter(char guess)
        {
            int indexValue = 0;
            bool CorrectGuess = false;

            if (_word.Contains(guess))
            {
                CorrectGuess = true;
                foreach (char letter in _word)
                {
                    indexValue += 1;
                    // update hint from _ to letter  
                    if (letter == guess)
                    {
                        _hint[indexValue - 1] = guess;
                    }
                }     
            } 
            return CorrectGuess;
        }
    }
}