

namespace ConsoleHost
{
    using System.Diagnostics;

    internal class AssertTester
    {
        private const int offset = 3;
        private readonly string sentence;

        public AssertTester(string sentence)
        {
            this.sentence = sentence;
        }

        internal string TestCryptMessage(bool offsetOption)
        {
            var cryptMessage = new MessageInfo();
            this.CalculateCharOffset(cryptMessage, offsetOption);
            return cryptMessage.message;
        }

        private void CalculateCharOffset(MessageInfo cryptMessage, bool offsetOption)
        {
            if (offsetOption)
            {
                cryptMessage.message = this.sentence.Substring(2, sentence.Length - 2) + this.sentence.Substring(0, 2);
            }
            else
            {
                cryptMessage.message = this.sentence.ToLowerInvariant();
            }
        }
    }
}
