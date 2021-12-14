using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Films.Pages.Models;

namespace Films.Pages
{
    public class IndexModel : PageModel
    {
        public List<FilmsModal> lists = new List<FilmsModal>();
        public IndexModel()
        {
                 FilmsModal obj = new FilmsModal();
                obj.Title = "Movie Title : RRR";
                obj.Description = "Description : This is a fictional movie which revolves around two Indian freedom fighters Alluri Seetarama Raju and Komaram Bheem" +
                "Cast: NTR,Ram Charan,AaliaBhatt" +
                "Director: S S Rajamouli" +
                "Music Director: M M Keeravani";
                obj.Duration = 120 ;
                lists.Add(obj);
        }
        public void OnGet()
        {

        }
        
    }
   
}
