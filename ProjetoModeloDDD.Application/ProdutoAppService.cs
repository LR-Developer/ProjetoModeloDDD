﻿using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Contracts.Services;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) 
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
