using System;
using System.Collections.Generic;
using System.Text;
using CSI.DataTransferObjects.Responses;

namespace CSI.BusinessObjects
{
    public class CustomerBusinessLayer
    {
        public List<CustomerDto>GetAllCustomers()
        {
            List<CustomerDto> SampleCustomers = new List<CustomerDto>();
            SampleCustomers.Add(new CustomerDto { FirstName = "Chrishantha", LastName = "Rajasekara" });
            SampleCustomers.Add(new CustomerDto { FirstName = "Isuru", LastName = "Amarathunga" });
            SampleCustomers.Add(new CustomerDto { FirstName = "Nalin", LastName = "Perera" });
            return SampleCustomers;
        }
    }
}
