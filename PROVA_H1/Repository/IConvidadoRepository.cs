using PROVA_H1.Models;
namespace PROVA_H1.Repository
{
    public interface IConvidadoRepository
    {
        public void InserirDados(Convidado convidado);

        public List<Convidado> GetDados();
    }
}
