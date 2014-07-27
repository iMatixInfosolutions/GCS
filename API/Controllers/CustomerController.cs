using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using API.Models;
using BE;

namespace API.Controllers {
    public class CustomerController : ApiController {

        [EnableCors(origins: "http://localhost:53649", headers: "*", methods: "*")]
        public DataTableMessage GetAllCustomers(HttpRequestMessage request) {
            /*BEContext becontext = new BEContext();
            var list = becontext.GetCustomers();*/

            var list = Customer.GetCustomers();
            
            DataTableMessage dtm = new DataTableMessage() {
                draw = Convert.ToInt32(request.RequestUri.ParseQueryString()["draw"].ToString()),
                recordsFiltered = list.Count(),
                recordsTotal = list.Count(),
                data = list.OfType<Object>().ToList()
            };

            return dtm; // "{'data':[['<input type='checkbox' name='id[]' value='21'>',21,'12/09/2013','Jhon Doe','Jhon Doe','450.60$',7,'<span class='label label-sm label-success'>Pending</span>','<a href='javascript:;' class='btn btn-xs default'><i class='fa fa-search'></i> View</a>']],'draw':2,'recordsTotal':178,'recordsFiltered':178}";
        }

        [EnableCors(origins: "http://localhost:53649", headers: "*", methods: "*")]
        public AppResponseMessage SaveCustomer(Customer item) {
            var msg = BE.Customer.Save(item);
            return new AppResponseMessage() { Message = msg, Success = true }; 
        }

    }
}