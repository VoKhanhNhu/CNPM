using BUS;
using DTO;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PhoneProvider
{
    public partial class DetailedReceipt : Form
    {
        int received_id = -1;
        string receipted_date;
        DTO_received_products proInfo = new DTO_received_products();    
        BUS_received_products Brp = new BUS_received_products();
        List<DTO_received_products> listDrp = new List<DTO_received_products>();
        private ListBox lb;
        public int Received_id { get { return received_id; }set { received_id = value; } }
        public string Received_date { get { return receipted_date; } set { receipted_date = value; } }    
        public DetailedReceipt()
        {
            InitializeComponent();
        }

        private void DetailedReceipt_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void setReceiptInformation()
        {
            receiptedIdTxt.Text = received_id.ToString();
            receiptedDateTxt.Text = receipted_date.ToString();  
        }
        public void setReceiptInfor()
        {
            setReceiptInformation();
        }

        private void getData()
        {
            listDrp = Brp.getData(received_id);
        }
        private void loadListView()
        {
            receivedProductsLv.Items.Clear();
            getData();
            float total = 0f;
            if (listDrp.Count > 0) 
            {
                foreach(DTO_received_products items in listDrp)
                {
                    ListViewItem item = new ListViewItem(items.Product_id.ToString());
                    item.SubItems.Add(items.Product_name.ToString());
                    item.SubItems.Add(items.Price.ToString());
                    item.SubItems.Add(items.Quantity.ToString());
                    item.SubItems.Add(items.ToTal.ToString());
                    total += items.ToTal;
                    receivedProductsLv.Items.Add(item); 
                }
            }
            totalTxb.Text = total.ToString();
        }

        public void loadLv()
        {
            loadListView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(proInfo.Product_id))
            {
                try
                {
                    if (proInfo.Quantity > 0)
                    {
                        Brp.insertProduct(proInfo, received_id);
                        loadListView();
                        MessageBox.Show("Add Success");
                        productNameTxb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Quantity is zero");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(receivedProductsLv.SelectedItems.Count > 0)
            {
                DialogResult dialogResult= MessageBox.Show("Are you sure you want to delete this item?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    string product_id = receivedProductsLv.SelectedItems[0].SubItems[0].Text.ToString();
                    try
                    {
                        Brp.deleteProduct(received_id, product_id);
                        MessageBox.Show("Delete Success");
                        loadListView();
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void productNameTxb_TextChanged(object sender, EventArgs e)
        {
            List<string> listPN = new List<string>();
            if (!string.IsNullOrEmpty(productNameTxb.Text))
            {
                listPN = Brp.searchProductName(productNameTxb.Text);
            }

            if (Brp.isProductName(productNameTxb.Text))
            {
                DTO_received_products rproduct = Brp.getProductInfo(productNameTxb.Text);
                productIdTxb.Text = rproduct.Product_id.ToString();
                priceTxb.Text = rproduct.Price.ToString();
                quantityTxb.Text = "0";
            }
            else
            {
                productIdTxb.Text = "";
                priceTxb.Text = "";
                quantityTxb.Text = "";
            }
                if (lb != null && addPnl.Controls.Contains(lb))
                {
                    addPnl.Controls.Remove(lb);
                    lb.Dispose();
                    lb = null;
                }
                if (listPN.Count > 0)
                {
                    lb = new ListBox();
                    lb.Location = new Point(productNameTxb.Left, productNameTxb.Bottom + 10);
                    lb.Size = new Size(productIdTxb.Width, 100);
                    addPnl.Controls.Add(lb);
                    lb.BringToFront();
                    foreach (string item in listPN)
                    {
                        lb.Items.Add(item);
                    }
                    lb.DoubleClick += lb_DoubleClick;
                }
            
        }

        private void lb_DoubleClick(object sender, EventArgs e)
        {
            if(lb.SelectedIndex >= 0 && lb.SelectedItems[0]!= null)
            {
                productNameTxb.Text = lb.SelectedItems[0].ToString();
                proInfo.Product_name = productNameTxb.Text.ToString();
                DTO_received_products rproduct = Brp.getProductInfo(productNameTxb.Text);
                productIdTxb.Text = rproduct.Product_id.ToString();
                priceTxb.Text = rproduct.Price.ToString();
                quantityTxb.Text = "0";
                addPnl.Controls.Remove(lb);
                lb.Dispose();
                lb = null;
            }
       
            
        }
        private void priceTxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void productIdTxb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productIdTxb.Text))
                proInfo.Product_id = productIdTxb.Text.ToString();
            else
                proInfo.Product_id = "";
        }

        private void quantityTxb_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(quantityTxb.Text))
                proInfo.Quantity = Convert.ToInt32(quantityTxb.Text);
            else
                proInfo.Quantity = -1;
        }

        private void receivedProductsLv_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
        static string newQuantity = "";
        private void receivedProductsLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            newQuantity = "";
            string proId = receivedProductsLv.Items[0].SubItems[0].Text;
            string proName = receivedProductsLv.Items[0].SubItems[1].Text;
            int quantity = Convert.ToInt32(receivedProductsLv.Items[0].SubItems[3].Text);
            DialogResult dl = inputBox("Change quantity",proName,ref quantity);
            if(dl == DialogResult.OK)
            {
                int nQ = -1;
                if(int.TryParse(newQuantity,out nQ))
                {
                    if(nQ >= 0)
                    {
                        try
                        {
                            Brp.updateNewQuantity(received_id, proId,quantity,nQ);
                            receivedProductsLv.Items[0].SubItems[3].Text = newQuantity;
                            MessageBox.Show("Change Success");
                        }
                        catch { MessageBox.Show("Change is not success"); }
                    }
                }
                else
                {
                    MessageBox.Show("Quantity is invalid");
                }
               
            }          
        }

        private static DialogResult inputBox(string title, string promptMsg,ref int quantity)
        {
            Form form = new Form();
            Label lb = new Label();
            TextBox txb = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();
            txb.TextChanged += Txb_TextChanged;
            form.Text = title;
            lb.Text = promptMsg;
            btnOk.Text = "Change";
            btnCancel.Text = "Cancel";
            txb.Text = quantity.ToString();
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            lb.SetBounds(9, 20, 327, 13);
            btnOk.SetBounds(228, 76, 75, 29);
            btnCancel.SetBounds(309, 76, 75, 29);
            txb.SetBounds(12, 45, 372, 20);
            lb.AutoSize = true;
            txb.Anchor = txb.Anchor | AnchorStyles.Right;
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            form.ClientSize = new Size(396, 150);
            form.Controls.AddRange(new Control[] { lb, txb, btnOk, btnCancel });
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AcceptButton = btnOk;
            form.CancelButton = btnCancel;
            
            DialogResult dialogResult = form.ShowDialog();
            return dialogResult;
        }

        private static void Txb_TextChanged(object? sender, EventArgs e)
        {
            TextBox txb = sender as TextBox;
            if (txb != null)
            {
                newQuantity = txb.Text;
            }
        }
    }
}
