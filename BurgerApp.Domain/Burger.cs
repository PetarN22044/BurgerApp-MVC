using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp.Domain
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }
    }

}
// pocnav sea od domain kako so bese na cas e sea so ovde pa info za to so se barase istoto vazit i za order