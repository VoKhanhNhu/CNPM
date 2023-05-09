using BUS;
using DTO;
using System.Globalization;

namespace PhoneProvider
{
    public partial class ReceiptForm : Form
    {
        BUS_received_notes BUSrp = new BUS_received_notes();
        List<DTO_received_notes> DTOrp = new List<DTO_received_notes>();
        int received_id = -1;
        public int Received_id { get { return received_id; } set { received_id= value; } }    
        public ReceiptForm()
        {
            InitializeComponent();
        }

        private void getData()
        {
            DTOrp = BUSrp.getData();
        }

        private void loadLv()
        {
            receivedLv.Items.Clear();   
            getData();
            if(DTOrp.Count> 0)
            {
                foreach(DTO_received_notes items in DTOrp)
                {
                    DateTime received_date = Convert.ToDateTime(items.Received_date);
                    if (received_date.Date <= toDtp.Value.Date)
                    {
                        if (received_date.Date >= fromDtp.Value.Date)
                        {
                            ListViewItem item = new ListViewItem(items.Received_id.ToString());
                            item.SubItems.Add(items.Received_date.ToString());
                            receivedLv.Items.Add(item);
                        }

                    }
                }
            }
        }
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loadLv();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(received_id.ToString());
        }

        private void receivedLv_DoubleClick(object sender, EventArgs e)
        {
            DetailedReceipt dr = new DetailedReceipt();
            dr.Received_id = received_id;
            dr.Received_date = receivedLv.SelectedItems[0].SubItems[1].Text;
            dr.Show();
            dr.setReceiptInfor();
            dr.loadLv();    
        }

        private void receivedLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(receivedLv.SelectedItems.Count > 0)
            {
                received_id = int.Parse(receivedLv.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                received_id = BUSrp.getMaxReceivedId();
                BUSrp.insertReceivedNote(received_id, DateTime.Now.ToString("MM/dd/yyyy"));
                loadLv();
            }catch(Exception ex) { throw ex; }
            DetailedReceipt dr = new DetailedReceipt();
            dr.Received_id = received_id;
            dr.Received_date = DateTime.Now.ToString("MM/dd/yyyy");
            dr.Show();
            dr.setReceiptInfor();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(receivedLv.SelectedItems.Count > 0)
            {
                DialogResult dialog = MessageBox.Show("Are you sure want to delete this received note ?","Delete Received Note",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialog == DialogResult.Yes)
                {
                    BUSrp.deleteReceivedNote(received_id);
                    MessageBox.Show("Delete SUccess");
                    loadLv();
                }
            }
        }

        private void toDtp_ValueChanged(object sender, EventArgs e)
        {
            loadLv();
        }

        private void fromDtp_ValueChanged(object sender, EventArgs e)
        {
            loadLv();
            toDtp.MinDate = fromDtp.Value;        
        }
    }
}