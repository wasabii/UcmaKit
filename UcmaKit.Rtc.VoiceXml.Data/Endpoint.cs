//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UcmaKit.Rtc.VoiceXml.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Endpoint
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> ApplicationId { get; set; }
        public string Address { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
