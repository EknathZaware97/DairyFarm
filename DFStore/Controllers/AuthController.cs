using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DFStore.Models;

namespace DFStore.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }
   
    public IActionResult Login(){
         Console.WriteLine("Invoking Home Controller Login method. ");
         

        return View();
    }

    //  List<Register> restable=new List<Register>();
    //    public IActionResult Postregister(string firstname,string lastname,
    //    string email, string password,string contactno){
    //     string fileName=@"E:\eknath akshay\.NET\DOTNET\register.json";
    //     string jsonString =System.IO.File.ReadAllText(fileName);

    //         List<Register> restablecopy = JsonSerializer.Deserialize<List<Register>>(jsonString);
    //         restable=restablecopy;
    //    restable.Add(new Register(firstname,lastname,email,password,contactno));
    //    var registerJson=JsonSerializer.Serialize<List<Register>>(restable);
        
    //     System.IO.File.WriteAllText(fileName,registerJson);
    //     return Redirect("/home/Login");
    //    }


     public IActionResult Register(){
         Console.WriteLine("Invoking Home Controller Login method. ");
           
        return View();
    }
    
}