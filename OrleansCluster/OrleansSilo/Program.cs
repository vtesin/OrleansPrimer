using System;
using Orleans.Runtime.Configuration;
using OrleansSilo.OrleansSiloHost;

namespace OrleansSilo
{
    class Program
    {
        private static OrleansHostWrapper _hostWrapper;

        static int Main(string[] args)
        {
            int exitCode = StartSilo(args);

            Console.WriteLine("Press Enter to terminate...");
            Console.ReadLine();

            exitCode += ShutdownSilo();

            //either StartSilo or ShutdownSilo failed would result on a non-zero exit code. 
            return exitCode;
        }


        private static int StartSilo(string[] args)
        {
            // define the cluster configuration
            var config = ClusterConfiguration.LocalhostPrimarySilo(siloPort: 11111, gatewayPort: 30000);
            config.AddMemoryStorageProvider();

            _hostWrapper = new OrleansHostWrapper(config, args);
            return _hostWrapper.Run();
        }

        private static int ShutdownSilo()
        {
            return _hostWrapper?.Stop() ?? 0;
        }
    }
}
