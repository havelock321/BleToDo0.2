using System.Data.Entity;


namespace BleToDo0._2.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("strConexao")
        {

        }
        public System.Data.Entity.DbSet<BleToDo0._2.Models.Afazer> Afazer { get; set; }

    }
}