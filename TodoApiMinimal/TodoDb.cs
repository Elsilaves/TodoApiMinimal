using Microsoft.EntityFrameworkCore;

namespace TodoApiMinimal
{
    public class TodoDb : DbContext
    {
        // Constructor for the TodoDb class.
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options)
        {
        }

        // Lambda expression to define the DbSet for the Todo entity
        /*
         The app uses an in-memory database named TodoList. 
        The database is registered later in Program.cs 
        with builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));, 
        where the string "TodoList" is the database name. Because the data is stored in memory, 
        it's reset every time the app restarts.
         */
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
