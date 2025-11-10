1) in program.cs

add this aftr builder

- builder.Services.AddSession();

add this before app.UseHttpsRedirection();

- app.UseSession();

2) create session variable in controller check controller for details
   
public IActionResult Index()
   {
       HttpContext.Session.SetString("MyKey", "Programentor"); // session variable
       return View();
   }

3) access session variable
public IActionResult About()
   {
       if(HttpContext.Session.GetString("MyKey") != null){

ViewBag.Data = HttpContext.Session.GetString("MyKey").ToString();

}
       return View();
   }

<h1>@ViewBag.Data</h1>

- or directly in view 

@using Microsoft.AspNetCore.Http
@inject Microsoft.AspNetCore.Http.IHttpContextAccessor accessor;

@{
    ViewData["Title"] = "About";
}


<h2>Direct: @accessor.HttpContext.Session.GetString("MyKey")</h2>

in program.cs

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();


- session destroy as browser close 
- session active for 20 mins by default
- also destroy manually 

public IActionResult Logout()
{
 
    if (HttpContext.Session.GetString("MyKey") != null)
    {

        HttpContext.Session.Remove("MyKey");
    }
    return View();
}


- custom time 

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60); // session expire time (destroy time)
}


- unique id

       public IActionResult About()
        {
            var sessionId = HttpContext.Session.Id; 
            ViewBag.SessionID = sessionId;
            return View();
        }





























