using Amazon.S3;
using CEProjectServer.Services;
using CEProjectServer.Data;
using CEProjectServer.Renderers;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Amazon.SimpleEmailV2;
using Amazon.Extensions.NETCore.Setup;
using Amazon;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
var sqlBuilder = new SqlConnectionStringBuilder();
//var sqlBuilder = new SqlConnectionStringBuilder(
//              builder.Configuration.GetConnectionString("CEsConnection"));

//builder.Configuration.AddSystemsManager("/ceproject");
//sqlBuilder.Password = builder.Configuration["DbPassword"];
//sqlBuilder.UserID = builder.Configuration["DbUser"];

sqlBuilder.ConnectionString = "";
sqlBuilder.Password = "";
sqlBuilder.UserID = "";


//builder.WebHost.ConfigureAppConfiguration((context, config) =>
//{
//    if (context.HostingEnvironment.IsDevelopment())
//    {
//        sqlBuilder.Password = builder.Configuration["DbPassword"];
//        sqlBuilder.UserID = builder.Configuration["DbUser"];
//    }
//    else if (context.HostingEnvironment.IsProduction())
//    {
//        builder.Configuration.AddSystemsManager("/ceproject");
//    }
//});




var connection = sqlBuilder.ConnectionString;
var S3options = builder.Configuration.GetAWSOptions("AWS");
builder.Services.AddDefaultAWSOptions(S3options);
builder.Services.AddAWSService<IAmazonS3>();
builder.Services.AddDbContext<CEContext>(options => options.UseSqlServer(connection));
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient<IInterventionDownloadService, InterventionDownloadService>()
    .SetHandlerLifetime(TimeSpan.FromMinutes(5));
builder.Services.AddAWSService<IAmazonSimpleEmailServiceV2>();
builder.Services.AddScoped<IRazorTemplateRenderer, RazorTemplateRenderer>();
builder.Services.AddTransient<IInterventionEmailSender, InterventionEmailSender>();
builder.Services.AddScoped<IInterventionCalculatorService, InterventionCalculatorService>();
builder.Services.AddScoped<IInterventionPDFGeneratorService, InterventionPDFGeneratorService>();
builder.Services.AddScoped<IInterventionPDFUploaderService, InterventionPDFUploaderService>();
builder.Services.AddScoped<IInterventionAnalyticsService, InterventionAnalyticsService>();
builder.Services.AddScoped<IInterventionDownloadService, InterventionDownloadService>();

var app = builder.Build();


app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "Pod")),
    RequestPath = "/Pod",
    EnableDirectoryBrowsing = false
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();