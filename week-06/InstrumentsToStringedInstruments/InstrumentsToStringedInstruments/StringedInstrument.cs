using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings;

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine("{0}, a {1} - stringed instrument that " + Sound(), InstrumentName, NumberOfStrings);
        }
    }
}
