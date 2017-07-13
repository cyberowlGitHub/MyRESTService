using System;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRESTService.svc or ProductRESTService.svc.cs at the Solution Explorer and start debugging.
    public class MessageService : IMessageService
    {
        Service1 svc; 
        public string GetTeste()
        {
            svc = new Service1();
            return svc.GetTeste();
        }

        public string SetTeste(string data)
        {
            svc = new Service1();
            svc.SetTeste(data);
            return data;
        }


    }
}
