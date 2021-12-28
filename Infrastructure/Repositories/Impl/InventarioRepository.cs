using HW27122021.Infrastructure.DataContext;
using HW27122021.Infrastructure.Repositories.Interfaces;
using HW27122021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW27122021.Infrastructure.Repositories.Impl
{
    public class InventarioRepository:GenericRepository<Inventario>,IInventarioRepository
    {
        public InventarioRepository(DbContextHW DbContextHW) : base(DbContextHW)
        {

        }
    }
}
