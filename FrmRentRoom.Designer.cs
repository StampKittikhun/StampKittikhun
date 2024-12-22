namespace MidtermUIProject
{
    partial class FrmRentRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRentRoom));
            label1 = new Label();
            btok = new Button();
            btcancel = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            chkPhone = new CheckBox();
            chkInternet = new CheckBox();
            chkwater = new CheckBox();
            chkpower = new CheckBox();
            groupBox1 = new GroupBox();
            MtbIDcard = new MaskedTextBox();
            tblastname = new TextBox();
            tbname = new TextBox();
            Rdomss = new RadioButton();
            Rdomiss = new RadioButton();
            Rdomr = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            cbbtyperoom = new ComboBox();
            tbtelephone = new TextBox();
            tbInternet = new TextBox();
            tbwater = new TextBox();
            tbpower = new TextBox();
            groupBox2 = new GroupBox();
            lblshowre = new Label();
            lblpowerPay = new Label();
            lblwaterPay = new Label();
            lblInternetPay = new Label();
            lblpowerunit = new Label();
            lblwaterunit = new Label();
            lblInternetunit = new Label();
            lblphonePay = new Label();
            lblPhoneunit = new Label();
            lbltyperoom = new Label();
            lblnamelastname = new Label();
            lblIDcard = new Label();
            lblDatepay = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label17 = new Label();
            label16 = new Label();
            label19 = new Label();
            label18 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 43);
            label1.TabIndex = 0;
            label1.Text = "โปรแกรมชำระค่าเช่าห้อง";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // btok
            // 
            btok.ForeColor = Color.Black;
            btok.Image = Properties.Resources.ok3;
            btok.ImageAlign = ContentAlignment.TopCenter;
            btok.Location = new Point(436, 358);
            btok.Name = "btok";
            btok.Size = new Size(114, 52);
            btok.TabIndex = 1;
            btok.Text = "คำนวน";
            btok.TextAlign = ContentAlignment.BottomCenter;
            btok.UseVisualStyleBackColor = true;
            btok.Click += btok_Click;
            // 
            // btcancel
            // 
            btcancel.ForeColor = Color.Black;
            btcancel.Image = Properties.Resources.cancel;
            btcancel.ImageAlign = ContentAlignment.TopCenter;
            btcancel.Location = new Point(436, 436);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(114, 47);
            btcancel.TabIndex = 2;
            btcancel.Text = "ยกเลิก";
            btcancel.TextAlign = ContentAlignment.BottomCenter;
            btcancel.UseVisualStyleBackColor = true;
            btcancel.Click += btcancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Angsana New", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(245, 85);
            label2.Name = "label2";
            label2.Size = new Size(93, 40);
            label2.TabIndex = 3;
            label2.Text = "วันที่ชำระ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(351, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 304);
            label3.Name = "label3";
            label3.Size = new Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "ประเภทห้องพัก";
            // 
            // chkPhone
            // 
            chkPhone.AutoSize = true;
            chkPhone.ForeColor = Color.Black;
            chkPhone.Location = new Point(13, 358);
            chkPhone.Name = "chkPhone";
            chkPhone.Size = new Size(106, 29);
            chkPhone.TabIndex = 6;
            chkPhone.Text = "โทรศัพท์";
            chkPhone.UseVisualStyleBackColor = true;
            chkPhone.Click += chkPhone_Click;
            // 
            // chkInternet
            // 
            chkInternet.AutoSize = true;
            chkInternet.ForeColor = Color.Black;
            chkInternet.Location = new Point(13, 391);
            chkInternet.Name = "chkInternet";
            chkInternet.Size = new Size(131, 29);
            chkInternet.TabIndex = 7;
            chkInternet.Text = "อินเทอร์เน็ต";
            chkInternet.UseVisualStyleBackColor = true;
            chkInternet.Click += chkInternet_Click;
            // 
            // chkwater
            // 
            chkwater.AutoSize = true;
            chkwater.ForeColor = Color.Black;
            chkwater.Location = new Point(13, 426);
            chkwater.Name = "chkwater";
            chkwater.Size = new Size(61, 29);
            chkwater.TabIndex = 8;
            chkwater.Text = "น้ำ";
            chkwater.UseVisualStyleBackColor = true;
            chkwater.Click += chkwater_Click;
            // 
            // chkpower
            // 
            chkpower.AutoSize = true;
            chkpower.ForeColor = Color.Black;
            chkpower.Location = new Point(13, 463);
            chkpower.Name = "chkpower";
            chkpower.Size = new Size(85, 29);
            chkpower.TabIndex = 9;
            chkpower.Text = "ไฟฟ้า";
            chkpower.UseVisualStyleBackColor = true;
            chkpower.Click += chkpower_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MtbIDcard);
            groupBox1.Controls.Add(tblastname);
            groupBox1.Controls.Add(tbname);
            groupBox1.Controls.Add(Rdomss);
            groupBox1.Controls.Add(Rdomiss);
            groupBox1.Controls.Add(Rdomr);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(49, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 131);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลผู้เช่า";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // MtbIDcard
            // 
            MtbIDcard.Location = new Point(189, 24);
            MtbIDcard.Mask = "0-0000-00000-00-0";
            MtbIDcard.Name = "MtbIDcard";
            MtbIDcard.Size = new Size(119, 31);
            MtbIDcard.TabIndex = 28;
            // 
            // tblastname
            // 
            tblastname.Location = new Point(229, 95);
            tblastname.Name = "tblastname";
            tblastname.Size = new Size(156, 31);
            tblastname.TabIndex = 27;
            // 
            // tbname
            // 
            tbname.Location = new Point(33, 95);
            tbname.Name = "tbname";
            tbname.Size = new Size(156, 31);
            tbname.TabIndex = 27;
            // 
            // Rdomss
            // 
            Rdomss.AutoSize = true;
            Rdomss.ForeColor = Color.Black;
            Rdomss.Location = new Point(279, 60);
            Rdomss.Name = "Rdomss";
            Rdomss.Size = new Size(99, 29);
            Rdomss.TabIndex = 17;
            Rdomss.Text = "นางสาว";
            Rdomss.UseVisualStyleBackColor = true;
            // 
            // Rdomiss
            // 
            Rdomiss.AutoSize = true;
            Rdomiss.ForeColor = Color.Black;
            Rdomiss.Location = new Point(195, 60);
            Rdomiss.Name = "Rdomiss";
            Rdomiss.Size = new Size(68, 29);
            Rdomiss.TabIndex = 16;
            Rdomiss.Text = "นาง";
            Rdomiss.UseVisualStyleBackColor = true;
            // 
            // Rdomr
            // 
            Rdomr.AutoSize = true;
            Rdomr.Checked = true;
            Rdomr.ForeColor = Color.Black;
            Rdomr.Location = new Point(104, 60);
            Rdomr.Name = "Rdomr";
            Rdomr.Size = new Size(71, 29);
            Rdomr.TabIndex = 15;
            Rdomr.TabStop = true;
            Rdomr.Text = "นาย";
            Rdomr.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(195, 98);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 14;
            label7.Text = "สกุล";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(6, 98);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 13;
            label6.Text = "ชื่อ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(6, 64);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 12;
            label5.Text = "คำนำหน้า";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(221, 25);
            label4.TabIndex = 11;
            label4.Text = "รหัสบัตรประจำตัวประชาชน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Black;
            label8.Location = new Point(290, 358);
            label8.Name = "label8";
            label8.Size = new Size(48, 25);
            label8.TabIndex = 18;
            label8.Text = "นาที";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Black;
            label9.Location = new Point(290, 392);
            label9.Name = "label9";
            label9.Size = new Size(48, 25);
            label9.TabIndex = 19;
            label9.Text = "นาที";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Black;
            label10.Location = new Point(290, 427);
            label10.Name = "label10";
            label10.Size = new Size(58, 25);
            label10.TabIndex = 20;
            label10.Text = "หน่วย";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Black;
            label11.Location = new Point(290, 464);
            label11.Name = "label11";
            label11.Size = new Size(58, 25);
            label11.TabIndex = 21;
            label11.Text = "หน่วย";
            // 
            // cbbtyperoom
            // 
            cbbtyperoom.FormattingEnabled = true;
            cbbtyperoom.Items.AddRange(new object[] { "ห้องแอร์ (มุม) 3500 บาท", "ห้องแอร์  3000 บาท", "ห้องพัดลม (มุม) 2500 บาท", "ห้องพัดลม 2000 บาท" });
            cbbtyperoom.Location = new Point(134, 304);
            cbbtyperoom.Name = "cbbtyperoom";
            cbbtyperoom.Size = new Size(185, 33);
            cbbtyperoom.TabIndex = 22;
            cbbtyperoom.KeyPress += cbbtyperoom_KeyPress;
            // 
            // tbtelephone
            // 
            tbtelephone.Enabled = false;
            tbtelephone.Location = new Point(116, 355);
            tbtelephone.Name = "tbtelephone";
            tbtelephone.Size = new Size(156, 31);
            tbtelephone.TabIndex = 23;
            tbtelephone.KeyPress += tbtelephone_KeyPress;
            tbtelephone.KeyUp += tbtelephone_KeyUp;
            // 
            // tbInternet
            // 
            tbInternet.Enabled = false;
            tbInternet.Location = new Point(116, 391);
            tbInternet.Name = "tbInternet";
            tbInternet.Size = new Size(156, 31);
            tbInternet.TabIndex = 24;
            tbInternet.KeyPress += tbInternet_KeyPress;
            tbInternet.KeyUp += tbInternet_KeyUp;
            // 
            // tbwater
            // 
            tbwater.Enabled = false;
            tbwater.Location = new Point(116, 427);
            tbwater.Name = "tbwater";
            tbwater.Size = new Size(156, 31);
            tbwater.TabIndex = 25;
            tbwater.KeyPress += tbwater_KeyPress;
            tbwater.KeyUp += tbwater_KeyUp;
            // 
            // tbpower
            // 
            tbpower.Enabled = false;
            tbpower.Location = new Point(116, 464);
            tbpower.Name = "tbpower";
            tbpower.Size = new Size(156, 31);
            tbpower.TabIndex = 26;
            tbpower.KeyPress += tbpower_KeyPress;
            tbpower.KeyUp += tbpower_KeyUp;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblshowre);
            groupBox2.Controls.Add(lblpowerPay);
            groupBox2.Controls.Add(lblwaterPay);
            groupBox2.Controls.Add(lblInternetPay);
            groupBox2.Controls.Add(lblpowerunit);
            groupBox2.Controls.Add(lblwaterunit);
            groupBox2.Controls.Add(lblInternetunit);
            groupBox2.Controls.Add(lblphonePay);
            groupBox2.Controls.Add(lblPhoneunit);
            groupBox2.Controls.Add(lbltyperoom);
            groupBox2.Controls.Add(lblnamelastname);
            groupBox2.Controls.Add(lblIDcard);
            groupBox2.Controls.Add(lblDatepay);
            groupBox2.Controls.Add(label29);
            groupBox2.Controls.Add(label28);
            groupBox2.Controls.Add(label27);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(label25);
            groupBox2.Controls.Add(label24);
            groupBox2.Controls.Add(label23);
            groupBox2.Controls.Add(label22);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(597, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(519, 615);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblshowre
            // 
            lblshowre.BackColor = Color.LightGreen;
            lblshowre.Font = new Font("Microsoft Sans Serif", 10F);
            lblshowre.ForeColor = Color.FromArgb(192, 0, 0);
            lblshowre.Location = new Point(113, 481);
            lblshowre.Name = "lblshowre";
            lblshowre.Size = new Size(316, 37);
            lblshowre.TabIndex = 54;
            lblshowre.Text = "0.00";
            lblshowre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblpowerPay
            // 
            lblpowerPay.BackColor = Color.LightGreen;
            lblpowerPay.Font = new Font("Microsoft Sans Serif", 10F);
            lblpowerPay.ForeColor = Color.FromArgb(192, 0, 0);
            lblpowerPay.Location = new Point(309, 414);
            lblpowerPay.Name = "lblpowerPay";
            lblpowerPay.Size = new Size(120, 23);
            lblpowerPay.TabIndex = 53;
            lblpowerPay.Text = "0.00";
            lblpowerPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblwaterPay
            // 
            lblwaterPay.BackColor = Color.LightGreen;
            lblwaterPay.Font = new Font("Microsoft Sans Serif", 10F);
            lblwaterPay.ForeColor = Color.FromArgb(192, 0, 0);
            lblwaterPay.Location = new Point(309, 368);
            lblwaterPay.Name = "lblwaterPay";
            lblwaterPay.Size = new Size(120, 23);
            lblwaterPay.TabIndex = 52;
            lblwaterPay.Text = "0.00";
            lblwaterPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInternetPay
            // 
            lblInternetPay.BackColor = Color.LightGreen;
            lblInternetPay.Font = new Font("Microsoft Sans Serif", 10F);
            lblInternetPay.ForeColor = Color.FromArgb(192, 0, 0);
            lblInternetPay.Location = new Point(309, 325);
            lblInternetPay.Name = "lblInternetPay";
            lblInternetPay.Size = new Size(120, 23);
            lblInternetPay.TabIndex = 51;
            lblInternetPay.Text = "0.00";
            lblInternetPay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblpowerunit
            // 
            lblpowerunit.BackColor = Color.LightGreen;
            lblpowerunit.Font = new Font("Microsoft Sans Serif", 10F);
            lblpowerunit.ForeColor = Color.FromArgb(192, 0, 0);
            lblpowerunit.Location = new Point(133, 411);
            lblpowerunit.Name = "lblpowerunit";
            lblpowerunit.Size = new Size(45, 23);
            lblpowerunit.TabIndex = 50;
            lblpowerunit.Text = "0";
            lblpowerunit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblwaterunit
            // 
            lblwaterunit.BackColor = Color.LightGreen;
            lblwaterunit.Font = new Font("Microsoft Sans Serif", 10F);
            lblwaterunit.ForeColor = Color.FromArgb(192, 0, 0);
            lblwaterunit.Location = new Point(133, 365);
            lblwaterunit.Name = "lblwaterunit";
            lblwaterunit.Size = new Size(45, 23);
            lblwaterunit.TabIndex = 49;
            lblwaterunit.Text = "0";
            lblwaterunit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInternetunit
            // 
            lblInternetunit.BackColor = Color.LightGreen;
            lblInternetunit.Font = new Font("Microsoft Sans Serif", 10F);
            lblInternetunit.ForeColor = Color.FromArgb(192, 0, 0);
            lblInternetunit.Location = new Point(133, 322);
            lblInternetunit.Name = "lblInternetunit";
            lblInternetunit.Size = new Size(45, 23);
            lblInternetunit.TabIndex = 48;
            lblInternetunit.Text = "0";
            lblInternetunit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblphonePay
            // 
            lblphonePay.BackColor = Color.LightGreen;
            lblphonePay.Font = new Font("Microsoft Sans Serif", 10F);
            lblphonePay.ForeColor = Color.FromArgb(192, 0, 0);
            lblphonePay.Location = new Point(309, 279);
            lblphonePay.Name = "lblphonePay";
            lblphonePay.Size = new Size(120, 23);
            lblphonePay.TabIndex = 47;
            lblphonePay.Text = "0.00";
            lblphonePay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhoneunit
            // 
            lblPhoneunit.BackColor = Color.LightGreen;
            lblPhoneunit.Font = new Font("Microsoft Sans Serif", 10F);
            lblPhoneunit.ForeColor = Color.FromArgb(192, 0, 0);
            lblPhoneunit.Location = new Point(133, 276);
            lblPhoneunit.Name = "lblPhoneunit";
            lblPhoneunit.Size = new Size(45, 23);
            lblPhoneunit.TabIndex = 46;
            lblPhoneunit.Text = "0";
            lblPhoneunit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbltyperoom
            // 
            lbltyperoom.BackColor = Color.LightGreen;
            lbltyperoom.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lbltyperoom.ForeColor = Color.FromArgb(192, 0, 0);
            lbltyperoom.Location = new Point(249, 218);
            lbltyperoom.Name = "lbltyperoom";
            lbltyperoom.Size = new Size(241, 26);
            lbltyperoom.TabIndex = 45;
            lbltyperoom.Text = "-";
            lbltyperoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblnamelastname
            // 
            lblnamelastname.BackColor = Color.LightGreen;
            lblnamelastname.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblnamelastname.ForeColor = Color.FromArgb(192, 0, 0);
            lblnamelastname.Location = new Point(249, 168);
            lblnamelastname.Name = "lblnamelastname";
            lblnamelastname.Size = new Size(241, 26);
            lblnamelastname.TabIndex = 44;
            lblnamelastname.Text = "-";
            lblnamelastname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIDcard
            // 
            lblIDcard.BackColor = Color.LightGreen;
            lblIDcard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblIDcard.ForeColor = Color.FromArgb(192, 0, 0);
            lblIDcard.Location = new Point(249, 122);
            lblIDcard.Name = "lblIDcard";
            lblIDcard.Size = new Size(241, 26);
            lblIDcard.TabIndex = 43;
            lblIDcard.Text = "-";
            lblIDcard.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatepay
            // 
            lblDatepay.BackColor = Color.LightGreen;
            lblDatepay.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblDatepay.ForeColor = Color.FromArgb(192, 0, 0);
            lblDatepay.Location = new Point(249, 74);
            lblDatepay.Name = "lblDatepay";
            lblDatepay.Size = new Size(241, 26);
            lblDatepay.TabIndex = 42;
            lblDatepay.Text = "-";
            lblDatepay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = Color.Black;
            label29.Location = new Point(444, 414);
            label29.Name = "label29";
            label29.Size = new Size(46, 25);
            label29.TabIndex = 41;
            label29.Text = "บาท";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = Color.Black;
            label28.Location = new Point(444, 363);
            label28.Name = "label28";
            label28.Size = new Size(46, 25);
            label28.TabIndex = 40;
            label28.Text = "บาท";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.ForeColor = Color.Black;
            label27.Location = new Point(444, 320);
            label27.Name = "label27";
            label27.Size = new Size(46, 25);
            label27.TabIndex = 39;
            label27.Text = "บาท";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.ForeColor = Color.Black;
            label26.Location = new Point(444, 274);
            label26.Name = "label26";
            label26.Size = new Size(46, 25);
            label26.TabIndex = 38;
            label26.Text = "บาท";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.ForeColor = Color.Black;
            label25.Location = new Point(184, 416);
            label25.Name = "label25";
            label25.Size = new Size(120, 25);
            label25.TabIndex = 37;
            label25.Text = "หน่วย เป็นเงิน";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.ForeColor = Color.Black;
            label24.Location = new Point(184, 365);
            label24.Name = "label24";
            label24.Size = new Size(120, 25);
            label24.TabIndex = 36;
            label24.Text = "หน่วย เป็นเงิน";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.Black;
            label23.Location = new Point(184, 322);
            label23.Name = "label23";
            label23.Size = new Size(110, 25);
            label23.TabIndex = 35;
            label23.Text = "นาที เป็นเงิน";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.Black;
            label22.Location = new Point(184, 276);
            label22.Name = "label22";
            label22.Size = new Size(110, 25);
            label22.TabIndex = 34;
            label22.Text = "นาที เป็นเงิน";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Black;
            label21.Location = new Point(56, 416);
            label21.Name = "label21";
            label21.Size = new Size(59, 25);
            label21.TabIndex = 33;
            label21.Text = "ไฟฟ้า";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.Black;
            label20.Location = new Point(56, 365);
            label20.Name = "label20";
            label20.Size = new Size(35, 25);
            label20.TabIndex = 32;
            label20.Text = "น้ำ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Black;
            label17.Location = new Point(56, 322);
            label17.Name = "label17";
            label17.Size = new Size(105, 25);
            label17.TabIndex = 31;
            label17.Text = "อินเทอร์เน็ต";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(56, 276);
            label16.Name = "label16";
            label16.Size = new Size(80, 25);
            label16.TabIndex = 30;
            label16.Text = "โทรศัพท์";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Black;
            label19.Location = new Point(56, 215);
            label19.Name = "label19";
            label19.Size = new Size(126, 25);
            label19.TabIndex = 28;
            label19.Text = "ประเภทห้องพัก";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.Black;
            label18.Location = new Point(96, 165);
            label18.Name = "label18";
            label18.Size = new Size(77, 25);
            label18.TabIndex = 28;
            label18.Text = "ชื่อ-สกุล";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(18, 165);
            label15.Name = "label15";
            label15.Size = new Size(91, 25);
            label15.TabIndex = 28;
            label15.Text = "คำนำหน้า";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(18, 119);
            label14.Name = "label14";
            label14.Size = new Size(221, 25);
            label14.TabIndex = 29;
            label14.Text = "รหัสบัตรประจำตัวประชาชน";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(18, 71);
            label13.Name = "label13";
            label13.Size = new Size(87, 25);
            label13.TabIndex = 28;
            label13.Text = "วันที่ขำระ";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(70, 19);
            label12.Name = "label12";
            label12.Size = new Size(326, 43);
            label12.TabIndex = 28;
            label12.Text = "ข้อมูลการชำระเงิน";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmRentRoom
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 639);
            Controls.Add(groupBox2);
            Controls.Add(tbpower);
            Controls.Add(tbwater);
            Controls.Add(tbInternet);
            Controls.Add(tbtelephone);
            Controls.Add(cbbtyperoom);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(chkpower);
            Controls.Add(chkwater);
            Controls.Add(chkInternet);
            Controls.Add(chkPhone);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(btcancel);
            Controls.Add(btok);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Blue;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRentRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "โปรแกรมชำระค่าเช่าห้อง";
            Load += FrmRentRoom_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btok;
        private Button btcancel;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private CheckBox chkPhone;
        private CheckBox chkInternet;
        private CheckBox chkwater;
        private CheckBox chkpower;
        private GroupBox groupBox1;
        private RadioButton Rdomss;
        private RadioButton Rdomiss;
        private RadioButton Rdomr;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox tblastname;
        private TextBox tbname;
        private ComboBox cbbtyperoom;
        private TextBox tbtelephone;
        private TextBox tbInternet;
        private TextBox tbwater;
        private TextBox tbpower;
        private GroupBox groupBox2;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label lblDatepay;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label17;
        private Label label16;
        private Label label19;
        private Label label18;
        private Label lblInternetunit;
        private Label lblphonePay;
        private Label lblPhoneunit;
        private Label lbltyperoom;
        private Label lblnamelastname;
        private Label lblIDcard;
        private Label lblshowre;
        private Label lblpowerPay;
        private Label lblwaterPay;
        private Label lblInternetPay;
        private Label lblpowerunit;
        private Label lblwaterunit;
        private MaskedTextBox MtbIDcard;
    }
}