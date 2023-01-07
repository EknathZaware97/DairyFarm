using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DFStore.Models;
using AkEk.model;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;



namespace DFStore.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    
public IActionResult Postproducts( int productId, string title,
        string brand,string category, float unitPrice, int balance)
    {
          Product pt=new Product( productId, title, brand,
                     category,  unitPrice,  balance);
        Productsmanagement.AddProduct( pt );
       return Redirect("/Products");
       }


}





