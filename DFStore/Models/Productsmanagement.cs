using AkEk.model;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Productsmanagement{
     Product pt=new Product();
   static List<Product> protable=new List<Product>();
  static  string fileName=@"E:\eknath akshay\.NET\DOTNET\products.json";
public static void AddProduct(Product prt ){
     
 string jsonString =System.IO.File.ReadAllText(fileName);
     List<Product> protablecopy = JsonSerializer.Deserialize<List<Product>>(jsonString);
    protable=protablecopy;
    
     protable.Add(prt);
     var registerJson=JsonSerializer.Serialize<List<Product>>(protable);
        System.IO.File.WriteAllText(fileName,registerJson);
}

public static  List<Product> display(){
 static  string fileName=@"E:\eknath akshay\.NET\DOTNET\products.json";
string jsonString =System.IO.File.ReadAllText(fileName);
 List<Product> protablecopy = JsonSerializer.Deserialize<List<Product>>(jsonString);
    
}








}


