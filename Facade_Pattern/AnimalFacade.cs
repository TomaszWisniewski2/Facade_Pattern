using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class AnimalFacade
    {
        AnimalAge model;
        AnimalLeg leg;
        AnimalName name;
        AnimalVoice voice;

       // CarEngine engine;
       // CarBody body;
       // CarAccessories accessories;

        public AnimalFacade()
        {
            model = new AnimalAge();
            leg = new AnimalLeg();
            name = new AnimalName();
            voice = new AnimalVoice();
           // engine = new CarEngine();
           // body = new CarBody();
           // accessories = new CarAccessories();
        }

        public void CreateCompleteAnimal()
        {
            Console.WriteLine("******** Creating an Animal **********\n");
            model.SetAge();
            leg.SetLeg();
            name.SetName();
            voice.SetVoice();

            Console.WriteLine("\n******** Animal creation complete **********");
            Console.WriteLine();
            Console.WriteLine("******** Creating an Animal 2 **********\n");
            model.SetAge2();
            leg.SetLeg2();
            name.SetName2();
            voice.SetVoice2();
            Console.WriteLine("\n******** Animal 2 creation complete **********");
        }




    }
}
