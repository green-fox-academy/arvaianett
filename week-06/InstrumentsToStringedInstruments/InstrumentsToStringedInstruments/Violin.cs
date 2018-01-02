using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            this.InstrumentName = "Violin";
            this.NumberOfStrings = 4;
        }

        public Violin(int stringsViolin)
        {
            this.InstrumentName = "Violin";
            this.NumberOfStrings = stringsViolin;
        }

        public override void Sound()
        {
            Console.WriteLine("screech");
        }
    }
}
