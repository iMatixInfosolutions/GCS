using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BE {
    public class Customer {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Street { get; set; }
        public int? CityId { get; set; }
        public bool? EmailVerified { get; set; }
        public bool? IsVerifiedAsBuyer { get; set; }
        public string IP { get; set; }
        public string AccountStatus { get; set; }
        public string ReasonForDeactivation { get; set; }
        public int? LinkedAccount { get; set; }
        public string RegistrationSource { get; set; }
        public bool? IsSupplier { get; set; }
        public bool? IsBulkSupplier { get; set; }
        public bool? IsVerifiedAsSupplier { get; set; }
        public int? VerifiedBy { get; set; }
        public string Comments { get; set; }
        public int? rcb { get; set; }
        public int? rub { get; set; }
        public DateTime? rct { get; set; }
        public DateTime? rut { get; set; }
        public string Name { get; set; }



        public static string Save(Customer item) {
            string msg = "";

            var DbContext = new DE.GCSEntities();
            var dbItem = new DE.Customer() { };


            Mapper.CreateMap<Customer, DE.Customer>();
            dbItem = Mapper.Map<Customer, DE.Customer>(item);
            dbItem.rct = DateTime.Now;

            try {
                DbContext.Customers.Add(dbItem);
                DbContext.SaveChanges();
                msg = "Customer Saved Successfully!";
            }
            catch (System.Exception ex) {
                msg = "Unable to Save record! \n" + ex.Message;
            }

            return msg;
        }

        public static List<Customer> GetCustomers() {
            var items = new List<BE.Customer>();
            var DbContext = new DE.GCSEntities();

            var customerItem = new Customer() { };

            Mapper.CreateMap<DE.Customer, Customer>();

            foreach (var item in DbContext.Customers.OrderBy(it => it.FirstName)) {
                customerItem = Mapper.Map<DE.Customer, Customer>(item);
                customerItem.Name = customerItem.FirstName + " " + customerItem.LastName;
                items.Add(customerItem);
            }
            return items;
        }

    }
}
