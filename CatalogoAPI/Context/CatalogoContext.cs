using CatalogoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAPI.Context;

public class CatalogoContext : DbContext
{
    public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options)
    { }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }    
}

