using Cibertec.Repositories.BD;
using Examen.Repositories.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.UnitOfWork
{
    public interface IUnitOfWork
    {
            IEventosRepository Eventos { get; }
            IComentarioRepository Comentario { get; }
    }
}
