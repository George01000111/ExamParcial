using Cibertec.Repositories.BD;
using Cibertec.Repositories.Dapper.BD;
using Examen.Repositories.BD;
using Examen.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Repositories.Dapper.BD
{
    public class BDUnitOfWork : IUnitOfWork
    {
        public BDUnitOfWork(string connectionString)
        {
            Eventos = new EventosRepository(connectionString);
            Comentario = new ComentarioRepository(connectionString);
        }

        public IEventosRepository Eventos { get; private set; }
        public IComentarioRepository Comentario { get; private set; }
    }
}
