using GeminiDotnet;
using GeminiDotnet.Extensions.AI;
using Microsoft.Extensions.AI;
using NucAIChat.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var geminiOptions = new GeminiClientOptions
{
    ApiKey = builder.Configuration["GeminiApiKey"],

    ApiVersion = "v1beta"
};

IChatClient chatClient = new GeminiChatClient(geminiOptions);

builder.Services.AddSingleton<IChatClient>(chatClient);


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();