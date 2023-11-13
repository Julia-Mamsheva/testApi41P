using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();//Добавляем сервисы CORS
builder.Services.AddControllers();//Добавляем контроллеры
//Добавление генератора Swagger
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "", Version = "v1" });
    option.TagActionsBy(api =>
    {
        if (api.GroupName != null)
        {
            return new[] { api.GroupName };
        }

        var controllerActionDescriptor = api.ActionDescriptor as ControllerActionDescriptor;
        if (controllerActionDescriptor != null)
        {
            return new[] { controllerActionDescriptor.ControllerName };
        }

        throw new InvalidOperationException("Unable to determine tag for endpoint.");
    });
    option.DocInclusionPredicate((name, api) => true);
});

var app = builder.Build();


//Устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller =Home}/{action=Index}/{id?}");

app.UseCors(builder => builder.AllowAnyOrigin()); //Подключаем CORS

//Разрешение использования ПО для обслуживания созданного документа JSON и пользовательского интерфейса Swagger
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("./v1/swagger.json", "v1"); //Относительный путь до пользовательского интерфейса
});
app.Run();
