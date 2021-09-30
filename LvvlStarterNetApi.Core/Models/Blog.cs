using LvvlStarterNetApi.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace LvvlStarterNetApi.Core.Models
{
    public partial class Blog : IBlog
    {
        public Blog()
        {
        }

        public int BlogId { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}