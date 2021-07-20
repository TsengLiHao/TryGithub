using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLicenseTax
{
    public partial class VehicleLicenseTaxForm : Form
    {
        public VehicleLicenseTaxForm()
        {
            InitializeComponent();
        }

        private void VehicleLicenseTaxForm_Load(object sender, EventArgs e)
        {
            Init();
        }
        
        private void btnCommit_Click(object sender, EventArgs e)
        {
            //不知道怎麼寫才可以將內容以跨年度的方式顯示,
            //想請問老師,把每個結果都寫成Method,是否會導致寫死而沒辦法和網站一樣將結果以跨年度的方式呈現呢?

            this.lbxResult.Visible = true;
            this.lbxResult.Items.Clear();

            DatePriod();
            _totalDays();
            DataOfInput();
            DataOfInput2();
            Calculate();
                 
             if (this.rbtnYear.Checked)
            {
                DateTime dateStart = new DateTime(DateTime.Now.Year, 1,1 );
                DateTime dateEnd = new DateTime(DateTime.Now.Year, 12, 31);
                this.lbxResult.Items[0] = $"使用期間 : {dateStart.ToString("yyyy/MM/dd")} ~ {dateEnd.ToString("yyyy/MM/dd")}";
            }

            if(!this.rbtnPeriod.Checked && !this.rbtnYear.Checked)
            {
                Init();
                MessageBox.Show("請選取使用期間", "注意",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if (this.dateTimePicker1.Value > this.dateTimePicker2.Value)
            {
                Init();
                MessageBox.Show("不合理的時間選取範圍", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();  
        }
        private void rbtnPeriod_CheckedChanged(object sender, EventArgs e)
        {
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
        }
        private void rbtnYear_CheckedChanged(object sender, EventArgs e)
        {
             this.label5.Visible = false;
             this.label6.Visible = false;
             this.dateTimePicker1.Visible = false;
             this.dateTimePicker2.Visible = false;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (cbxType1.Text)
            {
                case "機車":
                    cbxType2.Items.Clear();
                    cbxType2.Items.Add("150以下/12HP以下(12.2PS以下)");
                    cbxType2.Items.Add("151-250/12.1-20HP(12.3-20.3PS)");
                    cbxType2.Items.Add("251-500/20.1HP以上(20.4PS以上)");
                    cbxType2.Items.Add("501-600");
                    cbxType2.Items.Add("601-1200");
                    cbxType2.Items.Add("1201-1800");
                    cbxType2.Items.Add("1801以上");
                    break;
                case "貨車":
                    cbxType2.Items.Clear();
                    cbxType2.Items.Add("500以下");
                    cbxType2.Items.Add("501-600");
                    cbxType2.Items.Add("601-1200");
                    cbxType2.Items.Add("1201-1800");
                    cbxType2.Items.Add("1801-2400");
                    cbxType2.Items.Add("2401-3000(138HP以下(140.1PS以下))");
                    cbxType2.Items.Add("3001-3600");
                    cbxType2.Items.Add("3601-4200/138.1-200HP(140.2-203.0PS)");
                    cbxType2.Items.Add("4201-4800");
                    cbxType2.Items.Add("4801-5400/200.1-247HP(203.1-250.7PS)");
                    cbxType2.Items.Add("5401-6000");
                    cbxType2.Items.Add("6001-6600/247.1-286HP(250.8-290.3PS)");
                    cbxType2.Items.Add("6601-7200");
                    cbxType2.Items.Add("7201-7800/286.1-336HP(290.4-341.0PS)");
                    cbxType2.Items.Add("7801-8400");
                    cbxType2.Items.Add("8401-9000/336.1-361HP(341.1-366.4PS)");
                    cbxType2.Items.Add("9001-9600");
                    cbxType2.Items.Add("9601-10200/361.1HP以上(366.5PS以上)");
                    cbxType2.Items.Add("10201以上");
                    break;
                case "大客車":
                    cbxType2.Items.Clear();
                    cbxType2.Items.Add("600以下");
                    cbxType2.Items.Add("601-1200");
                    cbxType2.Items.Add("1201-1800");
                    cbxType2.Items.Add("1801-2400");
                    cbxType2.Items.Add("2401-3000(138HP以下(140.1PS以下))");
                    cbxType2.Items.Add("3001-3600");
                    cbxType2.Items.Add("3601-4200/138.1-200HP(140.2-203.0PS)");
                    cbxType2.Items.Add("4201-4800");
                    cbxType2.Items.Add("4801-5400/200.1-247HP(203.1-250.7PS)");
                    cbxType2.Items.Add("5401-6000");
                    cbxType2.Items.Add("6001-6600/247.1-286HP(250.8-290.3PS)");
                    cbxType2.Items.Add("6601-7200");
                    cbxType2.Items.Add("7201-7800/286.1-336HP(290.4-341.0PS)");
                    cbxType2.Items.Add("7801-8400");
                    cbxType2.Items.Add("8401-9000/336.1-361HP(341.1-366.4PS)");
                    cbxType2.Items.Add("9001-9600");
                    cbxType2.Items.Add("9601-10200/361.1HP以上(366.5PS以上)");
                    cbxType2.Items.Add("10201以上");
                    break;
                case "自用小客車":
                    cbxType2.Items.Clear();
                    cbxType2.Items.Add("500以下/38HP以下(38.6PS以下)");
                    cbxType2.Items.Add("501~600/38.1-56HP(38.7-56.8PS)");
                    cbxType2.Items.Add("601~1200/56.1-83HP(56.9-84.2PS)");
                    cbxType2.Items.Add("1201~1800/83.1-182HP(84.3-184.7PS)");
                    cbxType2.Items.Add("1801~2400/182.1-262HP(184.8-265.9PS)");
                    cbxType2.Items.Add("2401~3000/262.1-322HP(266-326.8PS)");
                    cbxType2.Items.Add("3001-4200/322.1-414HP(326.9-420.2PS)");
                    cbxType2.Items.Add("4201-5400/414.1-469HP(420.3-476.0PS)");
                    cbxType2.Items.Add("5401-6600/469.1-509HP(476.1-516.6PS)");
                    cbxType2.Items.Add("6601-7800/509.1HP以上(516.7PS以上)");
                    cbxType2.Items.Add("7801以上");
                    break;
                case "營業用小客車":
                    cbxType2.Items.Clear();
                    cbxType2.Items.Add("500以下/38HP以下(38.6PS以下)");
                    cbxType2.Items.Add("501~600/38.1-56HP(38.7-56.8PS)");
                    cbxType2.Items.Add("601~1200/56.1-83HP(56.9-84.2PS)");
                    cbxType2.Items.Add("1201~1800/83.1-182HP(84.3-184.7PS)");
                    cbxType2.Items.Add("1801~2400/182.1-262HP(184.8-265.9PS)");
                    cbxType2.Items.Add("2401~3000/262.1-322HP(266-326.8PS)");
                    cbxType2.Items.Add("3001-4200/322.1-414HP(326.9-420.2PS)");
                    cbxType2.Items.Add("4201-5400/414.1-469HP(420.3-476.0PS)");
                    cbxType2.Items.Add("5401-6600/469.1-509HP(476.1-516.6PS)");
                    cbxType2.Items.Add("6601-7800/509.1HP以上(516.7PS以上)");
                    cbxType2.Items.Add("7801以上");
                    break;
            }

            this.cbxType2.SelectedIndex = 0;
        }

 
        #region method
        private void Init()
        {
            this.cbxType1.SelectedIndex = 0;
            this.cbxType2.SelectedIndex = 0;

            this.lbxResult.Items.Clear();
            this.lbxResult.Visible = false;
        }

        private void DatePriod()
        {
            this.lbxResult.Items.Add($"使用期間 : {this.dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~{this.dateTimePicker2.Value.ToString("yyyy/MM/dd")} ");
        }

        private  void _totalDays()
        {
            TimeSpan p = dateTimePicker2.Value - dateTimePicker1.Value;
            int days = p.Days + 1;
            if (rbtnPeriod.Checked)
            {
                this.lbxResult.Items.Add($"計算天數 : {(days).ToString()}天");
            }

            bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            if (rbtnYear.Checked)
            {
                if(isLeapYear)
                    this.lbxResult.Items.Add("計算天數 : 366天");
                else
                    this.lbxResult.Items.Add("計算天數 : 365天");
            }
        }

        private void DataOfInput()
        {
            this.lbxResult.Items.Add($"汽缸CC數/馬達馬力 : {cbxType2.SelectedItem.ToString()}");
        }
        private void DataOfInput2()
        {
            this.lbxResult.Items.Add($"用途 : {cbxType1.SelectedItem.ToString()}");
        }

        private void Calculate()
        {
            int tax = 0;
            TimeSpan p = dateTimePicker2.Value - dateTimePicker1.Value;
            int days = p.Days + 1;

            if (this.cbxType1.Text == "機車")
            {
                if (this.cbxType2.Text == "150以下/12HP以下(12.2PS以下")
                    tax = 0;
                else if (this.cbxType2.Text == "151-250/12.1-20HP(12.3-20.3PS)")
                    tax = 800;
                else if (this.cbxType2.Text == "251-500/20.1HP以上(20.4PS以上)")
                    tax = 1620;
                else if (this.cbxType2.Text == "501-600")
                    tax = 2160;
                else if (this.cbxType2.Text == "601-1200")
                    tax = 4320;
                else if (this.cbxType2.Text == "1201-1800")
                    tax = 7120;
                else if (this.cbxType2.Text == "1801以上")
                    tax = 11230;
            }
            else if (this.cbxType1.Text == "貨車")
            {
                if (this.cbxType2.Text == "500以下")
                    tax = 900;
                else if (this.cbxType2.Text == "501-600")
                    tax = 1080;
                else if (this.cbxType2.Text == "601-1200")
                    tax = 1800;
                else if (this.cbxType2.Text == "1201-1800")
                    tax = 2700;
                else if (this.cbxType2.Text == "1801-2400")
                    tax = 3600;
                else if (this.cbxType2.Text == "2401-3000(138HP以下(140.1PS以下))")
                    tax = 4500;
                else if (this.cbxType2.Text == "3001-3600")
                    tax = 5400;
                else if (this.cbxType2.Text == "3601-4200/138.1-200HP(140.2-203.0PS)")
                    tax = 6300;
                else if (this.cbxType2.Text == "4201-4800")
                    tax = 7200;
                else if (this.cbxType2.Text == "4801-5400/200.1-247HP(203.1-250.7PS)")
                    tax = 8100;
                else if (this.cbxType2.Text == "5401-6000")
                    tax = 9000;
                else if (this.cbxType2.Text == "6001-6600/247.1-286HP(250.8-290.3PS)")
                    tax = 9900;
                else if (this.cbxType2.Text == "6601-7200")
                    tax = 10800;
                else if (this.cbxType2.Text == "7201-7800/286.1-336HP(290.4-341.0PS)")
                    tax = 11700;
                else if (this.cbxType2.Text == "7801-8400")
                    tax = 12600;
                else if (this.cbxType2.Text == "8401-9000/336.1-361HP(341.1-366.4PS)")
                    tax = 13500;
                else if (this.cbxType2.Text == "9001-9600")
                    tax = 14400;
                else if (this.cbxType2.Text == "9601-10200/361.1HP以上(366.5PS以上)")
                    tax = 15300;
                else if (this.cbxType2.Text == "10201以上")
                    tax = 16200;
            }
            else if (this.cbxType1.Text == "大客車")
            {
                if (this.cbxType2.Text == "600以下")
                    tax = 1080;
                else if (this.cbxType2.Text == "601-1200")
                    tax = 1800;
                else if (this.cbxType2.Text == "1201-1800")
                    tax = 2700;
                else if (this.cbxType2.Text == "1801-2400")
                    tax = 3600;
                else if (this.cbxType2.Text == "2401-3000(138HP以下(140.1PS以下))")
                    tax = 4500;
                else if (this.cbxType2.Text == "3001-3600")
                    tax = 5400;
                else if (this.cbxType2.Text == "3601-4200/138.1-200HP(140.2-203.0PS)")
                    tax = 6300;
                else if (this.cbxType2.Text == "4201-4800")
                    tax = 7200;
                else if (this.cbxType2.Text == "4801-5400/200.1-247HP(203.1-250.7PS)")
                    tax = 8100;
                else if (this.cbxType2.Text == "5401-6000")
                    tax = 9000;
                else if (this.cbxType2.Text == "6001-6600/247.1-286HP(250.8-290.3PS)")
                    tax = 9900;
                else if (this.cbxType2.Text == "6601-7200")
                    tax = 10800;
                else if (this.cbxType2.Text == "7201-7800/286.1-336HP(290.4-341.0PS)")
                    tax = 11700;
                else if (this.cbxType2.Text == "7801-8400")
                    tax = 12600;
                else if (this.cbxType2.Text == "8401-9000/336.1-361HP(341.1-366.4PS)")
                    tax = 13500;
                else if (this.cbxType2.Text == "9001-9600")
                    tax = 14400;
                else if (this.cbxType2.Text == "9601-10200/361.1HP以上(366.5PS以上)")
                    tax = 15300;
                else if (this.cbxType2.Text == "10201以上")
                    tax = 16200;
            }
            else if (this.cbxType1.Text == "自用小客車")
            {
                if (this.cbxType2.Text == "500以下/38HP以下(38.6PS以下)")
                    tax = 1620;
                else if (this.cbxType2.Text == "501~600/38.1-56HP(38.7-56.8PS)")
                    tax = 2160;
                else if (this.cbxType2.Text == "601~1200/56.1-83HP(56.9-84.2PS)")
                    tax = 4320;
                else if (this.cbxType2.Text == "1201~1800/83.1-182HP(84.3-184.7PS)")
                    tax = 7120;
                else if (this.cbxType2.Text == "1801~2400/182.1-262HP(184.8-265.9PS)")
                    tax = 11230;
                else if (this.cbxType2.Text == "2401~3000/262.1-322HP(266-326.8PS)")
                    tax = 15210;
                else if (this.cbxType2.Text == "3001-4200/322.1-414HP(326.9-420.2PS)")
                    tax = 28220;
                else if (this.cbxType2.Text == "4201-5400/414.1-469HP(420.3-476.0PS)")
                    tax = 46170;
                else if (this.cbxType2.Text == "5401-6600/469.1-509HP(476.1-516.6PS)")
                    tax = 69690;
                else if (this.cbxType2.Text == "6601-7800/509.1HP以上(516.7PS以上)")
                    tax = 117000;
                else if (this.cbxType2.Text == "7801以上")
                    tax = 151200;
            }
            else if (this.cbxType1.Text == "營業用小客車")
            {
                if (this.cbxType2.Text == "500以下/38HP以下(38.6PS以下)")
                    tax = 900;
                else if (this.cbxType2.Text == "501~600/38.1-56HP(38.7-56.8PS)")
                    tax = 1260;
                else if (this.cbxType2.Text == "601~1200/56.1-83HP(56.9-84.2PS)")
                    tax = 2160;
                else if (this.cbxType2.Text == "1201~1800/83.1-182HP(84.3-184.7PS)")
                    tax = 3060;
                else if (this.cbxType2.Text == "1801~2400/182.1-262HP(184.8-265.9PS)")
                    tax = 6480;
                else if (this.cbxType2.Text == "2401~3000/262.1-322HP(266-326.8PS)")
                    tax = 9900;
                else if (this.cbxType2.Text == "3001-4200/322.1-414HP(326.9-420.2PS)")
                    tax = 16380;
                else if (this.cbxType2.Text == "4201-5400/414.1-469HP(420.3-476.0PS)")
                    tax = 24300;
                else if (this.cbxType2.Text == "5401-6600/469.1-509HP(476.1-516.6PS)")
                    tax = 33660;
                else if (this.cbxType2.Text == "6601-7800/509.1HP以上(516.7PS以上)")
                    tax = 44460;
                else if (this.cbxType2.Text == "7801以上")
                    tax = 56700;
            }

            int y = this.dateTimePicker1.Value.Year;
            int year = 0;
            if (rbtnPeriod.Checked)
            {
                if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                    year = 366;
                else
                    year = 365;
            }


            if (rbtnYear.Checked)
            {
                this.lbxResult.Items.Add($"計算公式 : {tax.ToString("###,0")} * 365 / 365 = {((tax * 365) / 365).ToString("###,0")}");
                this.lbxResult.Items.Add($"應納稅額 : 共{((tax * 365) / 365).ToString("###,0")}元");
            }
            else if (rbtnPeriod.Checked)
            {
                this.lbxResult.Items.Add($"計算公式 : {tax.ToString("###,0")} * {days} / {year} = {((tax * days) / year).ToString("###,0")}");
                this.lbxResult.Items.Add($"應納稅額 : 共{((tax * days) / year).ToString("###,0")}元");
            }
        }
        #endregion
    }
}
