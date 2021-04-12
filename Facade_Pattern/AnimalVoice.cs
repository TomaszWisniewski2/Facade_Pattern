using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class AnimalVoice
    {
        public void SetVoice()
        {
            Console.WriteLine(" AnimalVoice - muuu");
        }
        public void SetVoice2()
        {
            Console.WriteLine(" AnimalVoice - czekaj 5 nóg?");
        }
    }
}
