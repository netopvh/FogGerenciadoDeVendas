﻿using FogGerenciadorDeVendas.Dados.Contexto;
using FogGerenciadorDeVendas.Dados.Repositorio;
using FogGerenciadorDeVendas.Dominio.Consumos;
using FogGerenciadorDeVendas.Dominio.Produtos;
using FogGerenciadorDeVendas.Dominio.Repositorio;
using FogGerenciadorDeVendas.Dominio.Vendas;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace FogGerenciadorDeVendas.CrossCutting
{
    public class DependencyRegister 
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<FogContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositorio<int, Produto>, RepositorioBase<int, Produto>>();
            container.RegisterType<IRepositorio<int, Consumo>, RepositorioBase<int, Consumo>>();
            container.RegisterType<IRepositorio<int, Venda>, RepositorioBase<int, Venda>>();
            container.RegisterType<IProdutosRepositorio, ProdutosRepositorio>();
            container.RegisterType<IConsumoRepositorio, ConsumoRepositorio>();
            container.RegisterType<IVendaRepositorio, VendaRepositorio>();

            container.RegisterType<ListarProdutosServico>();
            container.RegisterType<InstanciarConsumoService>();
            
        }
    }
}
