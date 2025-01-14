
using RecordShop.Service;

namespace RecordShop
/*TASKS
    Store information about the records they have in stock.
    Query this data in various ways.
    Update it accordingly.

    Create API endpoints with the appropriate HTTP verbs.
    API base URL and endpoints must be appropriately named.
    Make sure your API is production-quality code - good separation of concerns, clean and readable.
    Your API must be well-tested, i.e. good coverage of unit tests.
    Write a descriptive README to document the key features of your solution, your assumptions, approaches and future thoughts.
    Apply error and exception handling considerations in your API design.
    All projects should include a /health endpoint to give the health of the application - showing whether the API itself is responding, can it contact the database, etc
 */

{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<AlbumService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
