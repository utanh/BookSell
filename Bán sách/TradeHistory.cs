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
    public partial class TradeHistory : Form
    {
        private Trade tradeHis = new Trade(new ManyBooks(), new DateTime(), "Đang xử lý");
        private User user = new User();

        private bool isCancel = false;
        //Send status and tradeProcessing to BookSell
        public delegate void sendDataToBookSell(bool isCancel, Trade tradeHis);
        public sendDataToBookSell sendInfor;

        public TradeHistory(Trade tradeHis, User user)
        {
            InitializeComponent();

            this.tradeHis = tradeHis;
            this.user = user;

            listViewBook.View = View.Details;
            listViewBook.FullRowSelect = true;
            listViewBook.SmallImageList = imageListBook;
            listViewBook.GridLines = true;
            listViewBook.Columns.Add("                                            THÔNG TIN SÁCH", 600);
            loadTradeHis();

            if (this.tradeHis.getStatusTrade().Equals("Hoàn thành"))
            {
                groupBoxReason.Visible = false;
                btnCancel.Visible = true;

                btnCancel.Location = new Point(570, 360);
                btnCancel.Enabled = false;
            }
            else if(this.tradeHis.getStatusTrade().Equals("Hủy bỏ"))
            {
                btnCancel.Visible = false;
                groupBoxReason.Visible = true;

                btnConfirm.Enabled = false;
                txtReason.Text = tradeHis.getReasonCancel();
                txtReason.ReadOnly = true;
            }
            else
            {
                btnCancel.Visible = true;
                groupBoxReason.Visible = false;

                btnCancel.Location = new Point(570, 360);
                btnCancel.Enabled = true;
            }

            loadInfo();
        }

        private void loadTradeHis()
        { 
            foreach (Book bk in tradeHis.getNumEachBook().Keys)
            {
                string info = "    Tên sách:  " + bk.getName() + "\n    Tác giả:     " + bk.getAuthor() + "\n    Thể loại:   " + bk.getType().Replace(" |", ",") + "\n    Giá bán:    " + string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", bk.getPrice()) + " vnđ" + "\n    Số lượng:   " + tradeHis.getNumEachBook()[bk];
                ListViewItem item = new ListViewItem(info, bk.getIdxImg());
                listViewBook.Items.Add(item);
            }
        }
        private void loadInfo()
        {
            txtUserName.Text = user.getName();
            txtNumPhoneUser.Text = user.getPhoneNum();
            txtAddressUser.Text = user.getAddress();
            txtDateTrade.Text = tradeHis.getDateTrade().ToString();

            lbNumBook.Text = tradeHis.getDataTrade().books.Count.ToString();
            lbTotalMoney.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", tradeHis.totalMoney() + tradeHis.getShipMoney()) + " vnđ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            groupBoxReason.Visible = true;

            btnConfirm.Enabled = true;
            txtReason.Text = tradeHis.getReasonCancel();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(!txtReason.Text.Equals(""))
            {
                this.isCancel = true;

                tradeHis.cancelTrade();
                tradeHis.setReasonCancel(txtReason.Text);
                MessageBox.Show("Hủy đơn thành công!", "Thông báo giao dịch");

                sendInfor(isCancel, tradeHis);
                this.Close();
            }    
        }
    }
}
