using Examen.Models;
using Examen.Repositories.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Repositories.Dapper.BD
{
    public class EventosRepository : Repository<Eventos>, IEventosRepository
    {
        public EventosRepository(string connectionString) : base(connectionString)
        {

        }

    }
}
