using PROVA_H1.Models;


namespace PROVA_H1.Repository
{
    public class ConvidadoRepository : IConvidadoRepository
    {
        public static List<Convidado> listaConvidado = new List<Convidado>();

        public void InserirDados(Convidado convidado)
        {
            listaConvidado.Add(convidado);
        }

        public List<Convidado> GetDados()
        {
            return listaConvidado;
        }
    }
}
