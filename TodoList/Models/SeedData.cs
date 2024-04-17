using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoList.Data;

namespace TodoList.Models
{
    public class SeedData
    {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
            new TodoListContext(serviceProvider.GetRequiredService<DbContextOptions<TodoListContext>>()))
            {

                if (context.Note.Any())
                {
                    // Supprime toutes les données existantes.
                    context.Note.RemoveRange(context.Note);
                    await context.SaveChangesAsync();
                }

                context.Note.AddRange(
                        new Note { Title = "Devoir", Contenu = "Math", Priorite = false },
                        new Note { Title = "Course", Contenu = "Tomates, Oignons, Viandes", Priorite = true }
                    );

                context.SaveChanges();
            }
        }
    }
}
