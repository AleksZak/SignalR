using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.DataAccess.Enteties
{
    internal class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public HashSet<string> UserConnectiionId{ get; set; }
        public List<Message> Messages{ get; set; }
    }
}
