using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers {    
    public class HomeController: Controller {    
        //    
        // GET: /Home/    
        [HttpGet]    
        public ActionResult Index() {    
                return View();    
            }    
            
        [HttpPost]    
        public ActionResult Index(CalculatorViewModel model, string command) {    
             
                switch (model.Operator)
                {
                    case "add":
                        model.Result = model.A + model.B; 
                        break;
                     case "sub":
                        model.Result = model.A - model.B; 
                        break;
                    case "div":
                        model.Result = model.A / model.B; 
                        break;
                    case "mul":
                        model.Result = model.A * model.B; 
                        break;  
            }       
            return View(model);    
        }    
    }    
}