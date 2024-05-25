using Lab1a;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Test run");

//1
app.MapGet("DDD", (context) =>
{
    string parmA = context.Request.Query["ParmA"];
    string parmB = context.Request.Query["ParmB"];
    string responseText = $"GET-Http-DDD:ParmA = {parmA},ParmB = {parmB}";
    context.Response.ContentType = "text/plain";
    return context.Response.WriteAsync(responseText);
});
//2
app.MapPost("DDD", (context) =>
{
    string parmA = context.Request.Query["ParmA"];
    string parmB = context.Request.Query["ParmB"];
    string responseText = $"POST-Http-DDD:ParmA = {parmA},ParmB = {parmB}";
    context.Response.ContentType = "text/plain";
    return context.Response.WriteAsync(responseText);
});
//3
app.MapPut("DDD", (context) =>
{
    string parmA = context.Request.Query["ParmA"];
    string parmB = context.Request.Query["ParmB"];
    string responseText = $"PUT-Http-DDD:ParmA = {parmA},ParmB = {parmB}";
    context.Response.ContentType = "text/plain";
    return context.Response.WriteAsync(responseText);
});
//4
app.MapPost("add", async (context) =>
{
    int x = int.Parse(context.Request.Query["ParmX"]);
    int y = int.Parse(context.Request.Query["ParmY"]);
    int sum = x + y;

    context.Response.ContentType = "text/plain";
    await context.Response.WriteAsync(sum.ToString());
});
//5
app.MapGet("task5", (context) =>
{
    context.Response.ContentType = "text/html";
    return context.Response.WriteAsync(HtmlPageTask5.GetHtmlPage());
});
app.MapPost("task5", (context) =>
{
    context.Response.ContentType = "text/plain";
    try
    {
        int x = int.Parse(context.Request.Form["x"]);
        int y = int.Parse(context.Request.Form["y"]);
        int product = x * y;
        return context.Response.WriteAsync(product.ToString());
    }
    catch (Exception ex)
    {
        return context.Response.WriteAsync(ex.Message);
    }
});

app.MapGet("task6",(context) =>
{
    context.Response.ContentType = "text/html";
    return context.Response.WriteAsync(HtmlPageTask6.GetHtmlPage());
});

app.Run();
