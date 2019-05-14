using Cibertec.Models;
using Cibertec.Repositories.BD;
using Examen.Repositories.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cibertec.Repositories.Dapper.BD
{
    public class ComentarioRepository : Repository<Comentario>, IComentarioRepository
    {
        public ComentarioRepository(string connectionString) : base(connectionString)
        {

        }
    }
}
