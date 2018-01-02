using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }

        public abstract void Sound();

        public override void Play()
        {
            Console.Write("{0}, a {1} - stringed instrument that ", InstrumentName, NumberOfStrings);
            Sound();
        }
    }
}
