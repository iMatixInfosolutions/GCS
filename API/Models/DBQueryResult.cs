using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models {
    public class DBQueryResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public System.Exception Exception { get; set; }
        public object SavedItem { get; set; }
        public DBQueryResult()
        {
            Success = false;
        }

        public string ExceptionMessage { get; set; }
        internal Exception exception
        {
            set
            {
                if (value.InnerException == null) this.ExceptionMessage = value.Message + "\n" + value.StackTrace;
                else this.ExceptionMessage = value.Message + "\n" + value.InnerException.Message + "\n" + value.StackTrace;
            }
        }
        public IEnumerable<Object> NewList { get; set; }
        public int NewId { get; set; }

        public object DuplicateRecord { get; set; }
    }
}