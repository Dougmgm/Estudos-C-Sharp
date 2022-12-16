using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Checkpoint_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Checkpoint_Api.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        DbSet<Cliente> Clientes {get; set;}
        DbSet<Endereco> Enderecos {get; set;}
    }
}