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
            this.NumberOfStrings = 6;
        }

        public ElectricGuitar(int stringsElectricGuitar)
        {
            InstrumentName = "Electric Guitar";
            this.NumberOfStrings = stringsElectricGuitar;
        }

        public override void Sound()
        {
            Console.WriteLine("twang");
        }
    }
}
