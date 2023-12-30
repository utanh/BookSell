
namespace Bán_sách
{
    partial class TradeHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradeHistory));
            this.tableLayoutInfo = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxReason = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBoxTradeInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDateTrade = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.lbNumBook = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAddressUser = new System.Windows.Forms.TextBox();
            this.txtNumPhoneUser = new System.Windows.Forms.TextBox();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.imageListBtn = new System.Windows.Forms.ImageList(this.components);
            this.imageListBook = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.listViewBook = new System.Windows.Forms.ListView();
            this.tableLayoutInfo.SuspendLayout();
            this.groupBoxReason.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxTradeInfo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutInfo
            // 
            this.tableLayoutInfo.ColumnCount = 1;
            this.tableLayoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutInfo.Controls.Add(this.groupBoxReason, 0, 2);
            this.tableLayoutInfo.Controls.Add(this.groupBoxTradeInfo, 0, 1);
            this.tableLayoutInfo.Controls.Add(this.groupBoxUserInfo, 0, 0);
            this.tableLayoutInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutInfo.Location = new System.Drawing.Point(510, 0);
            this.tableLayoutInfo.Name = "tableLayoutInfo";
            this.tableLayoutInfo.RowCount = 3;
            this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutInfo.Size = new System.Drawing.Size(324, 420);
            this.tableLayoutInfo.TabIndex = 2;
            // 
            // groupBoxReason
            // 
            this.groupBoxReason.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReason.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBoxReason.Location = new System.Drawing.Point(10, 280);
            this.groupBoxReason.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.groupBoxReason.Name = "groupBoxReason";
            this.groupBoxReason.Size = new System.Drawing.Size(304, 130);
            this.groupBoxReason.TabIndex = 2;
            this.groupBoxReason.TabStop = false;
            this.groupBoxReason.Text = "Nguyên nhân hủy đơn hàng";
            this.groupBoxReason.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.txtReason, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirm, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 104);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtReason
            // 
            this.txtReason.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReason.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtReason.Location = new System.Drawing.Point(5, 10);
            this.txtReason.Margin = new System.Windows.Forms.Padding(5, 10, 5, 2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(208, 92);
            this.txtReason.TabIndex = 9;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirm.Font = new System.Drawing.Font("Constantia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.Location = new System.Drawing.Point(223, 10);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5, 10, 10, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 92);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // groupBoxTradeInfo
            // 
            this.groupBoxTradeInfo.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxTradeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTradeInfo.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxTradeInfo.Location = new System.Drawing.Point(10, 140);
            this.groupBoxTradeInfo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.groupBoxTradeInfo.Name = "groupBoxTradeInfo";
            this.groupBoxTradeInfo.Size = new System.Drawing.Size(304, 130);
            this.groupBoxTradeInfo.TabIndex = 1;
            this.groupBoxTradeInfo.TabStop = false;
            this.groupBoxTradeInfo.Text = "Thông tin đơn hàng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.txtDateTrade, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbDate, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lbTotalMoney, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbNumBook, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbTotal, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbNum, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(298, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtDateTrade
            // 
            this.txtDateTrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateTrade.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDateTrade.Location = new System.Drawing.Point(120, 71);
            this.txtDateTrade.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.txtDateTrade.Name = "txtDateTrade";
            this.txtDateTrade.ReadOnly = true;
            this.txtDateTrade.Size = new System.Drawing.Size(168, 25);
            this.txtDateTrade.TabIndex = 11;
            this.txtDateTrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbDate
            // 
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(20, 66);
            this.lbDate.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(100, 34);
            this.lbDate.TabIndex = 6;
            this.lbDate.Text = "Thời gian:";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalMoney.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalMoney.Location = new System.Drawing.Point(120, 33);
            this.lbTotalMoney.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(168, 33);
            this.lbTotalMoney.TabIndex = 5;
            this.lbTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumBook
            // 
            this.lbNumBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNumBook.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNumBook.Location = new System.Drawing.Point(120, 0);
            this.lbNumBook.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbNumBook.Name = "lbNumBook";
            this.lbNumBook.Size = new System.Drawing.Size(168, 33);
            this.lbNumBook.TabIndex = 4;
            this.lbNumBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotal
            // 
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(20, 33);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(100, 33);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Tổng tiền:";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNum
            // 
            this.lbNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNum.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNum.Location = new System.Drawing.Point(20, 0);
            this.lbNum.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(100, 33);
            this.lbNum.TabIndex = 0;
            this.lbNum.Text = "Số lượng sách:";
            this.lbNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUserInfo.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(10, 10);
            this.groupBoxUserInfo.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(304, 120);
            this.groupBoxUserInfo.TabIndex = 0;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "Thông tin người nhận";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.txtAddressUser, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtNumPhoneUser, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbPhoneNum, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbAddress, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtUserName, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(298, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtAddressUser
            // 
            this.txtAddressUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddressUser.Location = new System.Drawing.Point(120, 65);
            this.txtAddressUser.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.txtAddressUser.Name = "txtAddressUser";
            this.txtAddressUser.ReadOnly = true;
            this.txtAddressUser.Size = new System.Drawing.Size(168, 25);
            this.txtAddressUser.TabIndex = 10;
            this.txtAddressUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumPhoneUser
            // 
            this.txtNumPhoneUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumPhoneUser.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumPhoneUser.Location = new System.Drawing.Point(120, 35);
            this.txtNumPhoneUser.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.txtNumPhoneUser.Name = "txtNumPhoneUser";
            this.txtNumPhoneUser.ReadOnly = true;
            this.txtNumPhoneUser.Size = new System.Drawing.Size(168, 25);
            this.txtNumPhoneUser.TabIndex = 9;
            this.txtNumPhoneUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPhoneNum.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneNum.Location = new System.Drawing.Point(40, 30);
            this.lbPhoneNum.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(80, 30);
            this.lbPhoneNum.TabIndex = 2;
            this.lbPhoneNum.Text = "SĐT:";
            this.lbPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAddress
            // 
            this.lbAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddress.Location = new System.Drawing.Point(40, 60);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(80, 30);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Địa chỉ:";
            this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(40, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(80, 30);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ tên:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(120, 5);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(168, 25);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageListBtn
            // 
            this.imageListBtn.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListBtn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBtn.ImageStream")));
            this.imageListBtn.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBtn.Images.SetKeyName(0, "cancel.png");
            // 
            // imageListBook
            // 
            this.imageListBook.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListBook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBook.ImageStream")));
            this.imageListBook.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBook.Images.SetKeyName(0, "0.jpg");
            this.imageListBook.Images.SetKeyName(1, "1.jpg");
            this.imageListBook.Images.SetKeyName(2, "2.jpg");
            this.imageListBook.Images.SetKeyName(3, "3.jpg");
            this.imageListBook.Images.SetKeyName(4, "4.jpg");
            this.imageListBook.Images.SetKeyName(5, "5.png");
            this.imageListBook.Images.SetKeyName(6, "6.jpg");
            this.imageListBook.Images.SetKeyName(7, "7.jpg");
            this.imageListBook.Images.SetKeyName(8, "8.jpg");
            this.imageListBook.Images.SetKeyName(9, "9.jpg");
            this.imageListBook.Images.SetKeyName(10, "10.jpg");
            this.imageListBook.Images.SetKeyName(11, "11.jpg");
            this.imageListBook.Images.SetKeyName(12, "12.jpg");
            this.imageListBook.Images.SetKeyName(13, "13.jpg");
            this.imageListBook.Images.SetKeyName(14, "14.jpg");
            this.imageListBook.Images.SetKeyName(15, "15.jpg");
            this.imageListBook.Images.SetKeyName(16, "16.jpg");
            this.imageListBook.Images.SetKeyName(17, "17.jpg");
            this.imageListBook.Images.SetKeyName(18, "18.jpg");
            this.imageListBook.Images.SetKeyName(19, "19.jpg");
            this.imageListBook.Images.SetKeyName(20, "20.jpg");
            this.imageListBook.Images.SetKeyName(21, "21.png");
            this.imageListBook.Images.SetKeyName(22, "22.png");
            this.imageListBook.Images.SetKeyName(23, "23.png");
            this.imageListBook.Images.SetKeyName(24, "24.jpg");
            this.imageListBook.Images.SetKeyName(25, "25.jpg");
            this.imageListBook.Images.SetKeyName(26, "26.jpg");
            this.imageListBook.Images.SetKeyName(27, "27.jpg");
            this.imageListBook.Images.SetKeyName(28, "28.jpg");
            this.imageListBook.Images.SetKeyName(29, "29.jpg");
            this.imageListBook.Images.SetKeyName(30, "30.jpg");
            this.imageListBook.Images.SetKeyName(31, "31.jpg");
            this.imageListBook.Images.SetKeyName(32, "32.jpg");
            this.imageListBook.Images.SetKeyName(33, "33.jpg");
            this.imageListBook.Images.SetKeyName(34, "34.jpg");
            this.imageListBook.Images.SetKeyName(35, "35.jpg");
            this.imageListBook.Images.SetKeyName(36, "36.jpg");
            this.imageListBook.Images.SetKeyName(37, "37.png");
            this.imageListBook.Images.SetKeyName(38, "38.jpg");
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageKey = "cancel.png";
            this.btnCancel.ImageList = this.imageListBtn;
            this.btnCancel.Location = new System.Drawing.Point(259, 269);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(60, 30, 60, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(204, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "            Hủy đơn";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listViewBook
            // 
            this.listViewBook.BackColor = System.Drawing.Color.White;
            this.listViewBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.listViewBook.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewBook.HideSelection = false;
            this.listViewBook.Location = new System.Drawing.Point(0, 0);
            this.listViewBook.Margin = new System.Windows.Forms.Padding(0);
            this.listViewBook.Name = "listViewBook";
            this.listViewBook.Size = new System.Drawing.Size(510, 420);
            this.listViewBook.TabIndex = 5;
            this.listViewBook.UseCompatibleStateImageBehavior = false;
            // 
            // TradeHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 420);
            this.Controls.Add(this.listViewBook);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tableLayoutInfo);
            this.Name = "TradeHistory";
            this.Text = "TradeHistory";
            this.tableLayoutInfo.ResumeLayout(false);
            this.groupBoxReason.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxTradeInfo.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutInfo;
        private System.Windows.Forms.GroupBox groupBoxTradeInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label lbNumBook;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtAddressUser;
        private System.Windows.Forms.TextBox txtNumPhoneUser;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ImageList imageListBtn;
        private System.Windows.Forms.ImageList imageListBook;
        private System.Windows.Forms.TextBox txtDateTrade;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.GroupBox groupBoxReason;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView listViewBook;
    }
}