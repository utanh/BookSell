using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Bán_sách
{
    public partial class TradeInfo : Form
    {
        private Trade tradeProcessing = new Trade(new ManyBooks(), new DateTime(), "Đang xử lý");
        private User user = new User();
        private bool isSuccess = false;

        private Dictionary<string, float> codes = new Dictionary<string, float>();

        //Send status and tradeProcessing to BookSell
        public delegate void sendDataToBookSell(bool isSuccess, Trade tradeProcessing, User user);
        public sendDataToBookSell sendInfor;

        public TradeInfo(Trade tradeProcessing, User user)
        {
            InitializeComponent();

            codes.Add("APPDEPLAM", 20000);
            codes.Add("UIT", (float)0.2);
            codes.Add("STAYHOME", (float)0.5);

            this.tradeProcessing = tradeProcessing;
            this.user = user;

            listViewBook.View = View.Details;
            listViewBook.FullRowSelect = true;
            listViewBook.SmallImageList = imageListBook;
            listViewBook.GridLines = true;
            listViewBook.Columns.Add("                                            THÔNG TIN SÁCH", 600);
            loadTradeProcessing();

            loadInfo();
        }

        private void loadTradeProcessing()
        {
            foreach(Book bk in tradeProcessing.getDataTrade().books)
            {
                string info = "    Tên sách:  " + bk.getName() + "\n    Tác giả:     " + bk.getAuthor() + "\n    Thể loại:   " + bk.getType().Replace(" |", ",") + "\n    Giá bán:    " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", bk.getPrice()) + " vnđ" + "\n\n\n";
                ListViewItem item = new ListViewItem(info, bk.getIdxImg());
                listViewBook.Items.Add(item);
            }
        }
        private void loadInfo()
        {
            txtUserName.Text = user.getName();
            txtNumPhoneUser.Text = user.getPhoneNum();
            txtAddressUser.Text = user.getAddress();
            txtMoneyUser.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", user.getMoney()) + " vnđ"; ;

            lbNumBook.Text = tradeProcessing.getDataTrade().books.Count.ToString();
            lbBookMoneyTrade.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tradeProcessing.totalMoney()) + " vnđ";
            lbShipMoneyTrade.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tradeProcessing.getShipMoney()) + " vnđ";
        }

        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            if(this.dtTimeStart.Value < DateTime.Now)
            {
                MessageBox.Show("Thời gian giao hàng không hợp lệ!", "Báo lỗi!");
                return;
            }
            if (this.tradeProcessing.getDataTrade().books.Count == 0)
            {
                MessageBox.Show("Đơn hàng trống", "Báo lỗi!");
                return;
            }

            if (tradeProcessing.totalMoney() > user.getMoney())
            {
                isSuccess = false;
                MessageBox.Show("Thất bại vì không đủ tiền!","Thông báo giao dịch");
            }    
            else
            {
                isSuccess = true;
                user.subMoney(tradeProcessing.totalMoney() + tradeProcessing.getShipMoney());
                tradeProcessing.calNumEachBook();
                MessageBox.Show("Thành công!", "Thông báo giao dịch");
                sendInfor(isSuccess, tradeProcessing, user);
            }    

            this.Close();
        }

        //Remove one book
        private void listViewBook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listViewBook.SelectedItems.Count > 0)
                {
                    int idx = listViewBook.SelectedItems[0].Index;
                    tradeProcessing.removeBook(idx);

                    loadInfo();
                    listViewBook.Items.RemoveAt(idx);
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            this.user.setName(txtUserName.Text);
        }

        private void txtNumPhoneUser_TextChanged(object sender, EventArgs e)
        {
            this.user.setPhoneNum(txtNumPhoneUser.Text);
        }

        private void txtAddressUser_TextChanged(object sender, EventArgs e)
        {
            this.user.setAddress(txtAddressUser.Text);
        }

        private void dtTimeStart_ValueChanged(object sender, EventArgs e)
        {
            tradeProcessing.setDateTrade(dtTimeStart.Value);
        }

        private void txtAddressUser_DoubleClick(object sender, EventArgs e)
        {
        }

        private void txtSale_TextChanged(object sender, EventArgs e)
        {
            foreach(string cd in codes.Keys)
            {
                if (txtSale.Text.Equals(cd))
                { 
                    tradeProcessing.setSale(codes[cd]);
                    lbBookMoneyTrade.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tradeProcessing.totalMoney()) + " vnđ";
                }
            }    
        }
    }
}
