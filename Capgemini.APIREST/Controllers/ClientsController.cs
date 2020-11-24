﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.APIREST.Controllers
{
    [Route("api/client")]
    public class ClientController : ControllerBase
    {

        // GET: api/client
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return RepositoryClient.Clients;
        }

        // GET: api/clients/5

        public ActionResult<IEnumerable<Client>> Get(int id)
        {
            Client client = RepositoryClient.Clients.FirstOrDefault(l => l.ID == id);

            return RepositoryClient.Clients;
        }

        // POST: api/client
        [HttpPost]
        public ActionResult<IEnumerable<Client>> Post([FromBody] Client objeto)
        {
            Client livro = RepositoryClient.Clients.FirstOrDefault(l => l.ID == objeto.ID);


            RepositoryClient.Clients.Add(objeto);
            return RepositoryClient.Clients;

        }

        [HttpPut]
        // PUT: api/client/5
        public ActionResult<IEnumerable<Client>> Put([FromBody] Client objeto)
        {
            Client client = RepositoryClient.Clients.FirstOrDefault(l => l.ID == objeto.ID);

            client.Name = objeto.Name;
            client.Email = objeto.Email;
            return RepositoryClient.Clients;
        }
        [HttpPatch]
        // PUT: api/client/5
        public ActionResult<IEnumerable<Client>> Patch([FromBody] Client objeto)
        {
            Client client = RepositoryClient.Clients.FirstOrDefault(l => l.ID == objeto.ID);

            client.Name = objeto.Name;
            client.Email = objeto.Email;
            return RepositoryClient.Clients;
        }
        [HttpDelete("{id}")]
        // DELETE: api/clients/5
        public ActionResult<IEnumerable<Client>> Delete(int id)
        {
            Client client = RepositoryClient.Clients.FirstOrDefault(l => l.ID == id);

            RepositoryClient.Clients.Remove(client);
            return RepositoryClient.Clients;
        }


    }
}
