using System;
using System.Collections.Generic;
using System.Text;

namespace InstrumentsToStringedInstruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            InstrumentName = "Electric Guitar";
            NumberOfStrings = 6;
        }

        public ElectricGuitar(int stringsElectricGuitar)
        {
            InstrumentName = "Electric Guitar";
            NumberOfStrings = stringsElectricGuitar;
        }

        public override string Sound()
        {
            return "twang";
        }
    }
}
