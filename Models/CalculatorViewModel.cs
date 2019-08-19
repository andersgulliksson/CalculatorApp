using System;    
using System.Collections.Generic;    
using System.Linq;    
using System.Web;    
namespace Calculator.Models {    
    public class CalculatorViewModel {    
        //public int A { get; set; }    
        //public int B { get; set; }    
        //public int Result { get; set; }    
        public double A {    
            get;    
            set;    
        }    
        public double B {    
            get;    
            set;    
        }
        public string Operator {    
            get;    
            set;    
        }       
        public double Result {    
            get;    
            set;    
        }    
    }    
}