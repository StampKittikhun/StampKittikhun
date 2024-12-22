using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MidtermUIProject
{
    public partial class FrmInternetCafe : Form
    {
        public FrmInternetCafe()
        {
            InitializeComponent();
        }

        private void btEndProgram_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการจบบการใช้งานใช่ไหม", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();

                FrmMainMenu mainProgram = new FrmMainMenu();
                mainProgram.Show();
            }
        }

        private void btReNew_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            tbnamelastname.Clear();
            tbUnit.Clear();

            monthCalendar1.SetDate(DateTime.Now);


            lblDatetime.Text = "-";
            lblIDcard.Text = "-";
            lblnamelastname.Text = "-";
            lblTypeuser.Text = "-";

            lblTotalPay.Text = "00.00";

            CbbTypeUse.SelectedIndex = 0;
        }

        private void btCalculator_Click(object sender, EventArgs e)
        {
            if (mtbIDcard.MaskCompleted == false)
            {
                ShareData.showWarnigMSG("ตรวจสอบการป้อนข้อมูลบัตรประชาชน");
            }
            else if (tbnamelastname.Text.Length == 0)
            {
                ShareData.showWarnigMSG("ตรวจสอบการป้อนชื่อ-นามสกุลด้วย");
            }

            else
            {
                lblIDcard.Text = mtbIDcard.Text;
            }

            // เช็คว่าคำนำหน้าชื่อใดที่ถูกติ๊ก
            string title = "";
            if (RdoMember.Checked)
            {
                title = RdoMember.Text;
            }
            else if (RdoGeneral.Checked)
            {
                title = RdoGeneral.Text;
            }
            else if (RdoStd.Checked)
            {
                title = RdoStd.Text;
            }

            lblTypeuser.Text = $"{title}";
            lblnamelastname.Text = tbnamelastname.Text;
            lblDatetime.Text = monthCalendar1.SelectionStart.ToString("dd/MM/yyyy");


            double Priceuse = 0;
            if (CbbTypeUse.SelectedIndex == 0)
            {
                Priceuse = 15;
            }
            else if (CbbTypeUse.SelectedIndex == 1)
            {
                Priceuse = 10;
            }
            else if (CbbTypeUse.SelectedIndex == 2)
            {
                Priceuse = 5;
            }

            // ตรวจสอบว่าข้อมูลใน tbUnit เป็นตัวเลขหรือไม่
            if (double.TryParse(tbUnit.Text, out double hours))
            {
                // คำนวณค่าใช้จ่าย
                double totalPay = Priceuse * hours;
                lblTotalPay.Text = totalPay.ToString("F2"); // แสดงค่าใช้จ่ายในรูปแบบทศนิยม 2 ตำแหน่ง
            }
            else
            {
                ////
            }

        }



        private void CbbTypeUse_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {
            CbbTypeUse.SelectedIndex = 0;
        }

        private void tbUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbnamelastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbnamelastname_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
