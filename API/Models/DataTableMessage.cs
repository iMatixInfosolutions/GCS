using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class DataTableMessage {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Object> data { get; set; }
    }
}