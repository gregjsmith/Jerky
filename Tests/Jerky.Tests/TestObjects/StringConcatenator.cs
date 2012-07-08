namespace Jerky.Tests.TestObjects
{
    public class StringConcatenator
    {
        private readonly string _stringOne;
        private readonly string _stringTwo;

        public StringConcatenator(string stringOne, string stringTwo)
        {
            _stringOne = stringOne;
            _stringTwo = stringTwo;
        }

        public string Concanenate()
        {
            return _stringOne + " " + _stringTwo;
        }
    }
}