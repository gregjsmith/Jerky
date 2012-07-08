using System;

namespace Jerky.Tests.TestObjects
{
    public class StringReverser
    {
        private string _stringOne;
        private string _stringTwo;

        public StringReverser(string stringOne, string stringTwo)
        {
            _stringOne = stringOne;
            _stringTwo = stringTwo;
        }

        public void Reverse()
        {
            var c = _stringOne.ToCharArray();
            Array.Reverse(c);
            _stringOne = new string(c);

            c = _stringTwo.ToCharArray();
            Array.Reverse(c);
            _stringTwo = new string(c);
        }


        public void Compare()
        {
            if (!_stringOne.Equals(_stringTwo))
            {
                throw new NotSupportedException("The strings do not match");
            }
        }
    }
}
