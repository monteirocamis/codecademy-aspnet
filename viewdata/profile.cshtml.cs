using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
  public class ProfileModel : PageModel
  {
    public void OnGet()
    {
      ViewData["myName"] = "John lorem";
      ViewData["username"] = "John123";
      ViewData["myOccupation"] = "Codecademy Student";
      ViewData["myAge"] = 24;
      ViewData["currentDate"] = "01/01/20";
    }
  }
}
