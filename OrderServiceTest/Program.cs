using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderServiceTest {
    class Program {
        static void Main(string[] args)
        {
            OrderServiceElsmartV3Client client = new OrderServiceElsmartV3Client();

            // Bruk variabelen "client" til å kalle operasjoner på tjenesten.
            var s = client.GetCallbackMsg("Hello!");

            Console.Out.WriteLine(s);

            var o = new orderservices.elsmart.com.v3.OrderRequest();
            o.OrderHead = new orderservices.elsmart.com.v3.OrderHeadType();
            o.OrderHead.ContractorPrefix = "999";
            var r = client.UpdateWorkOrder(o);


        }
    }
}
