using Catálogo_de_jogos_usando_.NET.InputModel;
using Catálogo_de_jogos_usando_.NET.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catálogo_de_jogos_usando_.NET.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
