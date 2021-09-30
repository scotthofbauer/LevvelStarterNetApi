using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.SharedKernel.Interfaces
{
    public interface IBlog
    {
        int BlogId { get; set; }
        string Author { get; set; }
        string Title { get; set; }
        string Text { get; set; }
    }
}
