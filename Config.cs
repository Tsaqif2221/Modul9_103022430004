using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Modul9_103022430004
{
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public Confirmation confimation { get; set; }
        public List<string> methods { get; set; }
        public Config()
        {
            
        }
        public Config(string lang, Transfer transfer, Confirmation confimation, List<string> methods)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.confimation = confimation;
            this.methods = methods;
        }
    }
}
