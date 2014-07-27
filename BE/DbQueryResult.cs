using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE {
    public class AppResponseMessage {
        public string Message { get; set; }
        public bool Success { get; set; }
        public object SavedItem { get; set; }
        public AppResponseMessage() {
            Success = false;
        }

        public string ExceptionMessage { get; set; }

        internal Exception exception {
            set {
                if (value.InnerException == null) this.ExceptionMessage = value.Message + "\n" + value.StackTrace;
                else this.ExceptionMessage = value.Message + "\n" + value.InnerException.Message + "\n" + value.StackTrace;
            }
        }
    }
}
