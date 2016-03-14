
namespace ConsoleHost
{
    using System.Linq;

    internal class SentecesComposer
    {
        private const string starting = "This is";
        private readonly string mode;

        public SentecesComposer(string mode)
        {
            this.mode = mode;
        }

        internal void GenerateResponse(string sentece)
        {
            if (this.mode.FirstOrDefault() < 'l')
            {
                sentece += "debug";
            }
            else
            {
                sentece += "trobleshotting";
            }
        }
    }
}
