using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    internal class ConsoleInputService : IInputService
    {
        public event EventHandler<string> InputRecieved;

        public void GetInput()
        {
            string inputString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputString) == false)
            {
                InputRecieved?.Invoke(this, inputString);
            }
        }
    }
}
