﻿using System.Threading.Tasks;

using Topshelf;

namespace UcmaKit.Rtc.Queue.Service
{

    public class Program
    {

        public static int Main(string[] args)
        {
            return (int)HostFactory.Run(x =>
            {
                x.Service<RtcApplicationRuntime>(s =>
                {
                    s.ConstructUsing(() => new RtcApplicationRuntime());
                    s.WhenStarted(h => Task.Run(async () => await h.Start()).Wait());
                    s.WhenStopped(h => Task.Run(async () => await h.Shutdown()).Wait());
                });
                x.SetServiceName("UcmaKit.Rtc.Queue");
                x.RunAsNetworkService();
            });
        }

    }

}
