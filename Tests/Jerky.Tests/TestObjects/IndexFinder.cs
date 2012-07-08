namespace Jerky.Tests.TestObjects
{
    public class IndexFinder
    {
        private readonly int[] _arr;

        public IndexFinder(int[] arr)
        {
            _arr = arr;
        }

        public int Find(int i)
        {
            return _arr[i];
        }
    }
}
