using System.Collections.Generic;
using miguelprovaapi.Models;

namespace miguelprovaapi.Repository
{
    public interface IAusenteRepository
    {
        bool RegistrarAusente(Ausente dadosAusente);
        List<Ausente> AusenteRegistrados();
        List<Ausente> ListarAusente(); 
    }
}
