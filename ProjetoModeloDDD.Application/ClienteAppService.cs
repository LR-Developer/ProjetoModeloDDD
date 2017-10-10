using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Contracts.Services;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Services;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> BuscarClientesEspeciais()
        {
            return _clienteService.BuscarClientesEspeciais(_clienteService.GetAll());
        }
    }
}
