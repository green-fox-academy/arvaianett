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
            this.NumberOfStrings = 6;
        }

        public BassGuitar(int stringsBassGuitar)
        {
            InstrumentName = "Bass Guitar";
            this.NumberOfStrings = stringsBassGuitar;
        }

        public override void Sound()
        {
            Console.WriteLine("duum-duum-duum");
        }
    }
}
