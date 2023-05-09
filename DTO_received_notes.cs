using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_received_notes
    {
        int received_id;
        string received_date;
        public DTO_received_notes() { }
        public DTO_received_notes(int received_id, string received_date)
        {
            this.received_id = received_id;
            
            this.received_date = received_date;
        }

        public int Received_id { get { return received_id; } set { received_id = value; } }
        public string Received_date { get { return received_date; } set { received_date = value;} }
    }
}
