using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections._13.Module
{
    class Client
    {
        public string IIN { get; }
        public ServiceType ServiceType { get; }

        public Client(string iin, ServiceType serviceType)
        {
            IIN = iin;
            ServiceType = serviceType;
        }
    }

    enum ServiceType
    {
        Credit = 1,
        Deposit = 2,
        Consultation = 3
    }
}
