using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using AutoMapper;

namespace BE {
    public class User {

        public int UserId { get; set; }
        public String UserName { get; set; }


        public static string Save(User item) {
            /**/
            return "";
        }

        public static List<User> GetUserForLookup() {
            var items = new List<User>();

            var ctx = new DE.GCSEntities();
            foreach (var item in ctx.UserProfiles.OrderBy(it => it.UserName)) {
                var d = new User(){UserId = item.UserId, UserName=item.UserName};
                items.Add(d);
            }
            
            return items;
        }

        public static List<Customer> GetCustomers() {
            var items = new List<BE.Customer>();
            var ctx = new DE.GCSEntities();

            var customerItem = new Customer() { };

            Mapper.CreateMap<DE.Customer, Customer>();

            foreach (var item in ctx.Customers.OrderBy(it => it.FirstName)) {
                customerItem = Mapper.Map<DE.Customer, Customer>(item);
                customerItem.Name = customerItem.FirstName + " " + customerItem.LastName;
                items.Add(customerItem);
            }
            return items;
        }

    }
}
