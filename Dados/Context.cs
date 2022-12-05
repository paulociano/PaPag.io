﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using papagio.Models;

namespace papagio.Dados
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Despesa> Despesas { get; set; }

        public DbSet<CategoriaDespesa> CategoriaDespesas { get; set; }

        public DbSet<Conta> Contas { get; set; }
    }
}
