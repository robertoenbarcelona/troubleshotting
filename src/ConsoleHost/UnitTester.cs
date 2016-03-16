
using System.Text;

namespace ConsoleHost
{
    public class UnitTester
    {
        private int limiter;

        public UnitTester(int limiter)
        {
            this.limiter = limiter;
        }

        internal string BuildPhrase()
        {
            var step = 0.1;
            var phrase = new StringBuilder();
            while (limiter != step)
            {
                phrase.Append('A');
                //limiter += step;
            }
            return phrase.ToString();
        }
    }
}
