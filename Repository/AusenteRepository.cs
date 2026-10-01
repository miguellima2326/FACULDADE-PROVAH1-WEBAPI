using miguelprovaapi.Models;
using System.Linq;
using System.Collections.Generic;

namespace miguelprovaapi.Repository
{
    public class AusenteRepository : IAusenteRepository
    {
        private readonly static List<Ausente> ausente = new List<Ausente>();
        private readonly static List<Ausente> registrados = new List<Ausente>();

        public bool RegistrarAusente(Ausente dadosAusente)
        {
            var existe = ausente.Where(a => a.cpf == dadosAusente.cpf).FirstOrDefault(); ;

            if (existe is not null)
                return false;

            registrados.Add(dadosAusente);

            

            if (dadosAusente.ausente == true)
                ausente.Add(dadosAusente);

            return true;
        }

        public List<Ausente> ListarAusente()
        {
            return ausente;
        }

        public List<Ausente> AusenteRegistrados()
        {
            return registrados;
        }
    }
}