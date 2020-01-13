using System;
using Microsoft.AspNetCore.Http;


namespace WebbShop_API.Helpers
{
  public static class Extensions
  {
    // making method void because i dont want it to return anything
    public static void AddApplicationError(this HttpResponse response, string message)
    {
      response.Headers.Add("Application-Error", message);
      response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
      response.Headers.Add("Access-Control-Allow-Origin", "*");
    }
  }
}