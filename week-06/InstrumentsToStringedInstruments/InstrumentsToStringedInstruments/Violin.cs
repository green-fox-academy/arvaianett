using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            InstrumentName = "Violin";
            NumberOfStrings = 4;
        }

        public Violin(int stringsViolin)
        {
            InstrumentName = "Violin";
            NumberOfStrings = stringsViolin;
        }

        public override string Sound()
        {
            return "screech";
        }
    }
}
