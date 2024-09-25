using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationData
{
    public abstract class PaginationData
    {
        public virtual List<string> GetData()
        {
            List<string> menuOptions = new List<string>
            {
                "Apple",
                "Beetroot",
                "Chili",
                "Dagwood",
                "Epic",
                "FastFood",
                "Golf",
                "Hotel",
                "India"
            };

            return menuOptions;
        }
    }
}
