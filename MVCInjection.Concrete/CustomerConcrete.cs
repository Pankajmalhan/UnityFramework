using MVCInjection.Interface;
using MVCInjection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCInjection.Concrete
{
 public   class CustomerConcrete: ICustomer
    {

        public static IList<CustomerModel> objCustomerModel = new List<CustomerModel>();
        static CustomerConcrete()
        {
            objCustomerModel.Add(new CustomerModel()
            {
                CustomerID=1200,
                Address="House No 10",
                City="Alwar",
                Country="India",
                Name="Pankaj Choudhary",
                Phoneno="8505071127"
            }); ;
            objCustomerModel.Add(new CustomerModel()
            {
                CustomerID = 1201,
                Address = "House No 11",
                City = "Alwar",
                Country = "India",
                Name = "Pankaj Choudhary",
                Phoneno = "8505071127"
            });
            objCustomerModel.Add(new CustomerModel()
            {
                CustomerID = 1202,
                Address = "House No 12",
                City = "Alwar",
                Country = "India",
                Name = "Pankaj Choudhary",
                Phoneno = "8505071127"
            });
        }
        public void Add(CustomerModel Customer)
        {
            try
            {

              


            }
            catch (System.Exception)
            {
                throw;
            }

        }

        public void Update(CustomerModel Customer)
        {
            try
            {
                
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Delete(CustomerModel Customer)
        {
            try
            {
                
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public CustomerModel GetById(int id)
        {
            try
            {
                CustomerModel obj = new CustomerModel();
                return obj;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            try
            {

                return  objCustomerModel;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
