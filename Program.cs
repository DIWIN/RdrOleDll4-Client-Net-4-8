using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RdrOleDll4_Client_Net_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Sunrise");
            RdrOleDll4.IOleReaderServer readerServer;
            RdrOleDll4.IOleInstrument instrument;

            try
            {
                readerServer = new RdrOleDll4.ReaderServer();
                readerServer.InstrumentName = "Sunrise";
                readerServer.CommType = 0; // 1 == Simulate instrument (this only works, if simulation is available)
                instrument = readerServer.CreateInstrumentObject();
                Debug.Assert((instrument as Object) != null);

                Console.WriteLine($"Name={instrument.InstrumentName}");
                Console.WriteLine($"Serial number={instrument.SerialNumber}");
            } 
            catch (Exception ex) 
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
