using System.ServiceProcess;

namespace FDNS.Service
{
    partial class FDNSService : ServiceBase
    {
        private Core.Server server;
        public FDNSService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            server = new Core.Server();
            server.Run();
        }

        protected override void OnStop()
        {
            server.Stop();
            server = null;
        }

        protected override void OnPause() => server.Stop();

        protected override void OnContinue() => server.Run();
    }
}
