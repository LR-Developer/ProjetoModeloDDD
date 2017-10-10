using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get
            {
                return "DomainToViewModelMappings";
            }
        }

        public void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}