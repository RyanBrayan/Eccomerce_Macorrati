using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteMVC.Context;
using SiteMVC.Models;
using SiteMVC.Repositories.Interfaces;

namespace SiteMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context){
            _context = context;
        }

        
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}