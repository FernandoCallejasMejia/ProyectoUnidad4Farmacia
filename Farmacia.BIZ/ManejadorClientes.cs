﻿using Farmacia.COMMON.Entidades;
using Farmacia.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Farmacia.BIZ
{
    public class ManejadorClientes:IManejadorClientes
    {
        IRepositorio<Cliente> repositorio;
        public ManejadorClientes(IRepositorio<Cliente> repo)
        {
            repositorio = repo;
        }

        public List<Cliente> Listar => repositorio.Read;

        public Cliente BuscarPorId(string id)
        {
            return Listar.Where(e => e.Id == id).SingleOrDefault();
        }

        public bool Agregar(Cliente entidad)
        {
            return repositorio.Create(entidad);
        }

        public bool Eliminar(string id)
        {
            return repositorio.Delete(id);
        }

        public bool Modificar(Cliente entidad)
        {
            return repositorio.Update(entidad);
        }
    }
}