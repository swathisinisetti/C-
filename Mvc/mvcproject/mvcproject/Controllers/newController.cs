using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;



namespace mvcproject.Controllers
{
    public class newController : Controller
    {
       

        public  String process()
        {
            return  @"<ul>
               <li>swathi</li>
              <li>manoj</li>
                <li>jaya</li>
                <li>nagesh</li>
               </ul>";
                    
        }
    }
}