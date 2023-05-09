using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_received_notes
    {
        public BUS_received_notes() { }
        DAL_received_notes drp = new DAL_received_notes();
        public List<DTO_received_notes> getData()
        {
            return drp.getData();
        }
        public int getMaxReceivedId()
        {
            return drp.getMaxReceivedId();
        }
        public void deleteReceivedNote(int received_id)
        {
            drp.deleteReceivedNote(received_id);
        }
        public void insertReceivedNote(int received_id,string received_date)
        {
            drp.insertReceivedNote(received_id,received_date);
        }
    }
}
