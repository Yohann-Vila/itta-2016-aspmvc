using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstCat
{
    public class Comment
    {
        public int CatThreadId { get; set; }
        public String Login { get; set; }
        public String Titre { get; set; }
        public String UriPhoto { get; set; }
        public bool Deleted { get; set; }
        public DateTime? CreationDate { get; set; }

        public Comment()
        {
            Deleted = false;
            CreationDate = DateTime.Now;
        }
    }
}
