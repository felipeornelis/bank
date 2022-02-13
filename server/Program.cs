var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<ICategoryRepository, CategoryRepository>();
builder.Services.AddSingleton<IAccountRepository, AccountRepository>();
builder.Services.AddSingleton<IInstitutionRepository, InstitutionRepository>();
// builder.Services.AddSingleton<ICreditCardRepository, CreditCardRepository>();
// builder.Services.AddSingleton<IStatementRepository, StatementRepository>();
// builder.Services.AddSingleton<ITransactionRepository, TransactionRepository>();

builder.Services.AddScoped<CreateUserService>();
builder.Services.AddScoped<FindUserByIdService>();
builder.Services.AddScoped<DeleteUserService>();
builder.Services.AddScoped<ListAllUsersService>();

builder.Services.AddScoped<CreateCategoryService>();
builder.Services.AddScoped<DeleteCategoryService>();
builder.Services.AddScoped<ListAllCategoriesService>();

builder.Services.AddScoped<CreateAccountService>();

builder.Services.AddScoped<CreateInstitutionService>();
builder.Services.AddScoped<ListAllInstitutionsService>();

// builder.Services.AddScoped<Service>();
// builder.Services.AddScoped<FindUserByEmailService>();
// builder.Services.AddScoped<FindUserByUsernameService>();

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
