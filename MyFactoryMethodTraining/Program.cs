using MyFactoryMethodTraining;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

var messanger = new TestMassanger("TheCotOfTehas", "1234");
messanger.SendMessage("Тут текст сообщения", "TheCotOfTehas", "Кто-то");

var twitter = new TwitterMessager("TheCotOfTehas", "1234");
var twit = twitter.CreateMassanger("Тут текст сообщения", "TheCotOfTehas", "Кто-то");
twit.Send();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
