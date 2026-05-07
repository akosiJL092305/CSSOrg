using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;

namespace CSSOrgAPI
{
    internal class Member
    {
        public class MemberView
        {
            public int id { get; set; }
            public string full_name { get; set; }
            public string year_section { get; set; }
            public string address { get; set; }
            public string contact { get; set; }
        }
    }
}
