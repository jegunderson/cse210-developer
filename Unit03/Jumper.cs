using System.Collections.Generic;
using System;

namespace Unit03
{
    class Jumper
    {
        public List<string> _jumperpic = new List<string>();
        

        public Jumper()
        {
            // populate entire jumper pic
            _jumperpic.Add(@" ___ ");
            _jumperpic.Add(@"/___\");
            _jumperpic.Add(@"\   /");
            _jumperpic.Add(@" \ / ");
            _jumperpic.Add(@"  0  ");
            _jumperpic.Add(@" /|\ ");
            _jumperpic.Add(@" / \ ");

        }

        public string PrintJumper()
        {
            return String.Join('\n', _jumperpic);
            // foreach (string line in _jumperpic)
            // {
            //     terminalservice.WriteText(line);
            // }
        }

        public void BreakParachute()
        {
            // break pic one item at a time
            _jumperpic.RemoveAt(0);
        }
    }
}