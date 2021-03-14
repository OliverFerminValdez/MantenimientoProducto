﻿using MantenimientoProducto.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantenimientoProducto.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
