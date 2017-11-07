using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace CSI.DataTransferObjects.Responses
{
    [DataContract]
    public class CustomerDto
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        [DataMember]
       public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [DataMember]
       public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
