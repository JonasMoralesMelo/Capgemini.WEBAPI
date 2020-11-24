using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.APIREST
{
    public class RepositoryClient
    {
        private static List<Client> clients;

        public static List<Client> Clients
        {
            get
            {
                if (clients == null)
                    GerarClient();
                return clients;
            }
            set
            {
                clients = value;
            }
        }

        private static void GerarClient()
        {
            clients = new List<Client>();

            clients.Add(new Client
            {
                ID = 1,
                Name = "Maria",
                Email = "Maria@gmail.com"
            });

            clients.Add(new Client
            {
                ID = 2,
                Name = "Francisco",
                Email = "francisco@gmail.com"
            });

            clients.Add(new Client
            {
                ID = 3,
                Name = "Mariana",
                Email = "Mariana@gmail.com"
            });
        }
    }
}