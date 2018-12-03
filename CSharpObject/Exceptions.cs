using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpObject
{
    class TreeHouseDefenseExceptions : System.Exception
    {
        public TreeHouseDefenseExceptions()
        {

        }
        public TreeHouseDefenseExceptions(string message) : base(message)
        {
        }
    }

    class OutOfBoundsException : TreeHouseDefenseExceptions
    {
        public OutOfBoundsException()
        {

        }
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
