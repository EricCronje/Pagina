using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationData
{
    public abstract class PaginationData : IDisposable
    {
        private List<string> MenuOptions;

        public void Dispose()
        {
            MenuOptions = null;
        }

        public virtual List<string> GetData()
        {
            MenuOptions = new List<string>
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

            return MenuOptions;
        }
    }
}
