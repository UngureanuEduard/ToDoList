using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class AgendaItem
    {
        public AgendaItem() { }

        public String Nume { get; set; }
        public DateTime Data { get; set; }
        public int Prioritate { get; set; }

        public String Descriere { get; set; }
    }
}
