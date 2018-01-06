using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class BassGuitar : StringedInstrument
    {
        
        public BassGuitar()
        {
            InstrumentName = "Bass Guitar";
            NumberOfStrings = 6;
        }

        public BassGuitar(int stringsBassGuitar)
        {
            InstrumentName = "Bass Guitar";
            NumberOfStrings = stringsBassGuitar;
        }

        public override string Sound()
        {
            return "duum-duum-duum";
        }
    }
}
