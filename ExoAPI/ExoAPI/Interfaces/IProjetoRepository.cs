using ExoAPI.Models;

namespace ExoAPI.Interfaces
{
    public interface IProjetoRepository
    {
        public List<Projeto> Listar();
        public Projeto BuscarPorId(int id);
        void Cadastrar(Projeto projeto);
        void Atualizar(int id, Projeto projeto);
        void Deletar(int id);
    }
}
