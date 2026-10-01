using miguelprovaapi.Models;

namespace miguelprovaapi.Repository
{
    public class EleitorRepository : IEleitorRepository
    {
        private readonly static List<EleitorDados> eleitor = new List<EleitorDados>();

        public bool CadastrarEleitor(EleitorDados dados)
        {
            var existe = eleitor.Where(a => a.cpf == dados.cpf).FirstOrDefault();

            if (existe is not null)
                return false;

            eleitor.Add(dados);
            return true;
        }

        public List<EleitorDados> ListarEleitor()
        {
            return eleitor;
        }
    }
}
