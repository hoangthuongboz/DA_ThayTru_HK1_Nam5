using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Summary_RPT : Summary
    {
        public string MONTH { get; set; }
        public long? CURRENT_YEAR { get; set; }
        public long? LAST_YEAR { get; set; }
        public long? AVERAGE { get; set; }
    }
}
