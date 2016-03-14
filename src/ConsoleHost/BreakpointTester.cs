

namespace ConsoleHost
{

    using System;
    using System.Collections.Generic;

    internal class BreakpointTester
    {
        private readonly List<Tuple<int, int>> operators;

        public BreakpointTester(List<Tuple<int, int>> operators)
        {
            this.operators = operators;
        }

        internal int TestExcactDivision(int divisor)
        {
            var stepResult = 0;
            foreach (var oper in this.operators)
            {
                stepResult += oper.Item1 / (oper.Item2 + divisor);
            }
            return stepResult;
        }
    }
}
