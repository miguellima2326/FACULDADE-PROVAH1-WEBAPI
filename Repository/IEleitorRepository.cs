using System.Collections.Generic;
using miguelprovaapi.Models;

namespace miguelprovaapi.Repository
{
    public interface IEleitorRepository
    {
        bool CadastrarEleitor(EleitorDados dados);
        List<EleitorDados> ListarEleitor(); 
    }
}
