using filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddTransient<SampleResultFilterAttribute>();

builder.Services.AddSingleton<SampleResultFilterAttribute>();


builder.Services.AddControllers(options =>{
    // options.Filters.Add(new MySampleActionFilter());
     //options.Filters.Add(new MySampleAsyncActionFilterAttribute("Global"));
     options.Filters.Add(new MyOrderActionFilterAttribute("Order",1));

     options.Filters.Add(new ResourceFileAttribute("Global"));
     options.Filters.AddService<SampleResultFilterAttribute>();

} );


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

 builder.Services.AddSwaggerGen();

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
