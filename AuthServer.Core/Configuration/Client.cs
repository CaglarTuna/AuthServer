using System;
using System.Collections.Generic;
using System.Text;

namespace AuthServer.Core.Configuration
{
    public class Client
    {
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public List<string> Audiences{ get; set; }
    }
}
