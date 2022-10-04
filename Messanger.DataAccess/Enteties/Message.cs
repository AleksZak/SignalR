using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.DataAccess.Enteties
{
    public class Message
    {
        public int MassageID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public User User { get; set; }
    }
}
