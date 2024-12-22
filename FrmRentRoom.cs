using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidtermUIProject
{
    public partial class FrmRentRoom : Form
    {
        public FrmRentRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void FrmRentRoom_Load(object sender, EventArgs e)
        {
            cbbtyperoom.SelectedIndex = 0;
        }

        private void cbbtyperoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void chkPhone_Click(object sender, EventArgs e)
        {
            if (chkPhone.Checked)
            {
                tbtelephone.Enabled = true;
                // อัปเดตข้อมูลเมื่อถูกติ๊ก
                UpdatePhoneLabels();
            }
            else
            {
                tbtelephone.Text = "0";
                lblPhoneunit.Text = "0";
                lblphonePay.Text = "0.00";
                tbtelephone.Enabled = false;
            }
        }

        private void tbtelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbtelephone_KeyUp(object sender, KeyEventArgs e)
        {
            // อัปเดตข้อมูลเมื่อมีการเปลี่ยนแปลงใน tbtelephone
            UpdatePhoneLabels();


        }

        private void UpdatePhoneLabels()
        {
            if (chkPhone.Checked)
            {
                if (int.TryParse(tbtelephone.Text, out int phoneMinutes))
                {
                    lblPhoneunit.Text = phoneMinutes.ToString(); // แสดงจำนวนหน่วยที่ป้อนใน tbtelephone
                    double pay = phoneMinutes * 2; // คำนวณค่าใช้จ่าย
                    lblphonePay.Text = pay.ToString("0.00"); // แสดงค่าใช้จ่ายใน lblphonePay
                }
                else
                {
                    lblPhoneunit.Text = "0"; // ถ้าค่าที่ป้อนไม่ใช่ตัวเลข ให้แสดงค่าเริ่มต้นเป็น 0
                    lblphonePay.Text = "0.00"; // ถ้าค่าที่ป้อนไม่ใช่ตัวเลข ให้แสดงค่าเริ่มต้นเป็น 0.00
                }
            }
        }

        private void chkInternet_Click(object sender, EventArgs e)
        {
            if (chkInternet.Checked)
            {
                tbInternet.Enabled = true;

                UpdateInternetLabels();
            }
            else
            {
                tbInternet.Text = "0";
                lblInternetunit.Text = "0";
                lblInternetPay.Text = "0.00";
                tbInternet.Enabled = false;
            }
        }

        private void tbInternet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbInternet_KeyUp(object sender, KeyEventArgs e)
        {

            UpdateInternetLabels();
        }

        private void UpdateInternetLabels()
        {
            if (chkInternet.Checked)
            {
                if (int.TryParse(tbInternet.Text, out int InternetMinutes))
                {
                    lblInternetunit.Text = InternetMinutes.ToString();
                    double pay = InternetMinutes * 1;
                    lblInternetPay.Text = pay.ToString("0.00");
                }
                else
                {
                    lblInternetunit.Text = "0";
                    lblInternetPay.Text = "0.00";
                }
            }
        }

        private void chkwater_Click(object sender, EventArgs e)
        {
            if (chkwater.Checked)
            {
                tbwater.Enabled = true;

                UpdateWaterLabels();
            }
            else
            {
                tbwater.Text = "0";
                lblwaterunit.Text = "0";
                lblwaterPay.Text = "0.00";
                tbwater.Enabled = false;
            }
        }

        private void UpdateWaterLabels()
        {
            if (chkwater.Checked)
            {
                if (int.TryParse(tbwater.Text, out int waterUnit))
                {
                    lblwaterunit.Text = waterUnit.ToString();
                    double pay = waterUnit * 12;
                    lblwaterPay.Text = pay.ToString("0.00");
                }
                else
                {
                    lblwaterunit.Text = "0";
                    lblwaterPay.Text = "0.00";
                }
            }
        }

        private void tbwater_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbwater_KeyUp(object sender, KeyEventArgs e)
        {

            UpdateWaterLabels();
        }

        private void chkpower_Click(object sender, EventArgs e)
        {
            if (chkpower.Checked)
            {
                tbpower.Enabled = true;

                UpdatePowerbels();
            }
            else
            {
                tbpower.Text = "0";
                lblpowerunit.Text = "0";
                lblpowerPay.Text = "0.00";
                tbpower.Enabled = false;
            }
        }

        private void tbpower_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbpower_KeyUp(object sender, KeyEventArgs e)
        {

            UpdatePowerbels();
        }

        private void UpdatePowerbels()
        {
            if (chkpower.Checked)
            {
                if (int.TryParse(tbpower.Text, out int PowerUnit))
                {
                    lblpowerunit.Text = PowerUnit.ToString();
                    double pay = PowerUnit * 15;
                    lblpowerPay.Text = pay.ToString("0.00");
                }
                else
                {
                    lblpowerunit.Text = "0";
                    lblpowerPay.Text = "0.00";
                }
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if (MtbIDcard.MaskCompleted == false)
            {
                ShareData.showWarnigMSG("ตรวจสอบการป้อนข้อมูลบัตรประชาชน");
            }
            else if (tbname.Text.Length == 0)
            {
                ShareData.showWarnigMSG("ตรวจสอบการป้อนชื่อด้วย");
            }
            else if (tblastname.Text.Length == 0)
            {
                ShareData.showWarnigMSG("ตรวจสอบป้อนามสกุลด้วย");
            }
            else
            {
                lblIDcard.Text = MtbIDcard.Text;

                // เช็คว่าคำนำหน้าชื่อใดที่ถูกติ๊ก
                string title = "";
                if (Rdomr.Checked)
                {
                    title = Rdomr.Text;
                }
                else if (Rdomss.Checked)
                {
                    title = Rdomss.Text;
                }
                else if (Rdomiss.Checked)
                {
                    title = Rdomiss.Text;
                }

                // รวมค่าชื่อ นามสกุล และคำนำหน้าชื่อ
                lblnamelastname.Text = $"{title} {tbname.Text} {tblastname.Text}";

                // อัปเดตวันที่ที่เลือกจาก dateTimePicker1 ใน lblDatepay
                lblDatepay.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");

                // อัปเดตประเภทห้องพักจาก cbbtyperoom ไปที่ lbltyperoom
                lbltyperoom.Text = cbbtyperoom.SelectedItem.ToString();

                // คำนวณค่าใช้จ่ายทั้งหมด
                double payTotal = double.Parse(lblphonePay.Text) +
                                  double.Parse(lblInternetPay.Text) +
                                  double.Parse(lblwaterPay.Text) +
                                  double.Parse(lblpowerPay.Text);

                // ตรวจสอบประเภทห้องพักและเพิ่มค่าใช้จ่ายห้องพัก
                double roomCharge = 0;
                if (cbbtyperoom.SelectedIndex == 0)
                {
                    roomCharge = 3500; // ห้องแอร์ (มุม)
                }
                else if (cbbtyperoom.SelectedIndex == 1)
                {
                    roomCharge = 3000; // ห้องแอร์
                }
                else if (cbbtyperoom.SelectedIndex == 2)
                {
                    roomCharge = 2500; // ห้องพัดลม (มุม)
                }
                else if (cbbtyperoom.SelectedIndex == 3)
                {
                    roomCharge = 2000; // ห้องพัดลม
                }

                // รวมค่าใช้จ่ายห้องพักกับค่าใช้จ่ายทั้งหมด
                double payTotalEnd = payTotal + roomCharge;

                // แสดงผลลัพธ์ใน lblshowre
                lblshowre.Text = payTotalEnd.ToString("0.00");
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            chkInternet.Checked = false;
            chkPhone.Checked = false;
            chkpower.Checked = false;
            chkwater.Checked = false;

            tbtelephone.Text = "0";
            tbtelephone.Enabled = false;

            tbInternet.Text = "0";
            tbInternet.Enabled = false;

            tbwater.Text = "0";
            tbwater.Enabled = false;

            tbpower.Text = "0";
            tbpower.Enabled = false;

            MtbIDcard.Clear();
            tbname.Clear();
            tblastname.Clear();
            dateTimePicker1.Value = DateTime.Now;
            lblDatepay.Text = "-";
            lblIDcard.Text = "-";
            lblnamelastname.Text = "-";
            lbltyperoom.Text = "-";


            lblPhoneunit.Text = "0";
            lblInternetunit.Text = "0";
            lblwaterunit.Text = "0";
            lblpowerunit.Text = "0";

            lblInternetPay.Text = "0.00";
            lblphonePay.Text = "0.00";
            lblpowerPay.Text = "0.00";
            lblwaterPay.Text = "0.00";

            lblshowre.Text = "0.00";

            cbbtyperoom.SelectedIndex = 0;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
