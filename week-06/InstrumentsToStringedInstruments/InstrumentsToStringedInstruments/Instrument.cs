using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    abstract class Instrument
    {
        protected string InstrumentName;

        public abstract void Play();
    }
}
