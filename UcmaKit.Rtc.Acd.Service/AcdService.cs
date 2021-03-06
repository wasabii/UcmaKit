﻿using System.ServiceProcess;

using UcmaKit.Rtc.Service;

namespace UcmaKit.Rtc.Acd.Service
{

    public partial class AcdService : RtcService
    {

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public AcdService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
        }

        protected override void OnStop()
        {
            base.OnStop();
        }

        public static void Main()
        {
            ServiceBase.Run(new[] { new AcdService() });
        }

    }

}
