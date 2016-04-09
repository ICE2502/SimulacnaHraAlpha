using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimulacnaHra.spravaZvuku
{
    /// <summary>
    /// Vlastná úprava pôvodného kódu na:
    /// https://msdn.microsoft.com/en-us/library/7a2f3ay4(v=vs.90).aspx
    /// </summary>
    public class Vlakno
    {
        private static SpravcaPrehravania aSpravcaPrehravania;
        private static Thread aWorkerThread;
        public static void Pracuj()
        {
            // Create the thread object. This does not start the thread.
            aSpravcaPrehravania = new SpravcaPrehravania();
            aWorkerThread = new Thread(aSpravcaPrehravania.DoWork);

            // Start the worker thread.
            aWorkerThread.Start();
        }

        public static void Ukonci()
        {
            // Request that the worker thread stop itself:
            aSpravcaPrehravania.RequestStop();

            // Use the Join method to block the current thread  
            // until the object's thread terminates.
            aWorkerThread.Join();
        
        }
    }
}
