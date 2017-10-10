using System;
using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Contracts.Repositories;
using ProjetoModeloDDD.Domain.Contracts.Services;
using ProjetoModeloDDD.Domain.Entities;
using System.Linq;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository) 
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> BuscarClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
