namespace Dairy;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Register {
public string FirstName{get;set;}

public string LastName{get;set;}

public string Email{get;set;}

public string ContactNo{get;set;}

public string Password{get;set;}
public Register (string firstName,string lastName, 
string email ,string contactNo , string password ){
    this.FirstName=firstName;
    this.LastName=lastName;
    this.Email=email;
    this.ContactNo=contactNo;
     this.Password=password;

}}

