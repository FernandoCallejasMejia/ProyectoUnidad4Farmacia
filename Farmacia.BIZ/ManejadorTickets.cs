using Farmacia.COMMON.Entidades;
using Farmacia.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacia.BIZ
{
    public class ManejadorTickets:IManejadorTicket
    {
        IRepositorio<Ticket> repositorio;
        public ManejadorTickets(IRepositorio<Ticket> repo)
        {
            repositorio = repo;
        }

        public List<Ticket> Listar => repositorio.Read;

        public Ticket BuscarPorId(string id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Agregar(Ticket entidad)
        {
            return repositorio.Create(entidad);
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Ticket entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}