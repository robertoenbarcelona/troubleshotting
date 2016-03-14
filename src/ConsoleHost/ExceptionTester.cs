
using System.Text;

namespace ConsoleHost
{
    internal class ExceptionTester
    {
        private readonly int depth;

        public ExceptionTester(int depth)
        {
            this.depth = depth;
        }

        internal string CallingMethod()
        {
            return this.CalledMethod();
        }

        private string CalledMethod()
        {
            var build = new StringBuilder();
            build.Append(this.RecursiveMethod(this.depth));
            return build.ToString();
        }

        private string RecursiveMethod(int depth)
        {
            if (depth == 1)
            {
                throw new System.Exception();
                return "end";
            }
            else
            { return "1" + this.RecursiveMethod(--depth); }
        }
    }
}
