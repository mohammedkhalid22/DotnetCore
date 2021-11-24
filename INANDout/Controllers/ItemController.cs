using INANDout.Folder_1_Data;
using INANDout.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        public readonly AppDbcontext appDbcontext;
            public ItemController(AppDbcontext appDbcontext)
        {
           
        }



        public IActionResult Index()
        {
            IEnumerable<item> objectlist = appDbcontext.Items;
           
            return View(objectlist);
        }
    }

    
}

