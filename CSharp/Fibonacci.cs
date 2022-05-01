namespace CSharp
{
    public class Fibonacci
    {
        public IEnumerable<uint> Get(uint n) => Next(0, 1).Take(10);

        private IEnumerable<uint> Next(uint previous, uint current)
        {
            yield return previous;

            foreach (var item in Next(current, previous + current)) 
            {
                yield return item;
            }
        }
    }
}