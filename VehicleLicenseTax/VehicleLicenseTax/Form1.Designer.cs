
namespace VehicleLicenseTax
{
    partial class VehicleLicenseTaxForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnYear = new System.Windows.Forms.RadioButton();
            this.rbtnPeriod = new System.Windows.Forms.RadioButton();
            this.cbxType1 = new System.Windows.Forms.ComboBox();
            this.cbxType2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數／馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rbtnYear
            // 
            this.rbtnYear.AutoSize = true;
            this.rbtnYear.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnYear.Location = new System.Drawing.Point(350, 79);
            this.rbtnYear.Name = "rbtnYear";
            this.rbtnYear.Size = new System.Drawing.Size(113, 28);
            this.rbtnYear.TabIndex = 4;
            this.rbtnYear.Text = "全年度";
            this.rbtnYear.UseVisualStyleBackColor = false;
            this.rbtnYear.CheckedChanged += new System.EventHandler(this.rbtnYear_CheckedChanged);
            // 
            // rbtnPeriod
            // 
            this.rbtnPeriod.AutoSize = true;
            this.rbtnPeriod.Location = new System.Drawing.Point(497, 79);
            this.rbtnPeriod.Name = "rbtnPeriod";
            this.rbtnPeriod.Size = new System.Drawing.Size(113, 28);
            this.rbtnPeriod.TabIndex = 5;
            this.rbtnPeriod.Text = "依期間";
            this.rbtnPeriod.UseVisualStyleBackColor = true;
            this.rbtnPeriod.CheckedChanged += new System.EventHandler(this.rbtnPeriod_CheckedChanged);
            // 
            // cbxType1
            // 
            this.cbxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType1.FormattingEnabled = true;
            this.cbxType1.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxType1.Location = new System.Drawing.Point(350, 169);
            this.cbxType1.Name = "cbxType1";
            this.cbxType1.Size = new System.Drawing.Size(260, 32);
            this.cbxType1.TabIndex = 6;
            this.cbxType1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxType2
            // 
            this.cbxType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType2.DropDownWidth = 215;
            this.cbxType2.FormattingEnabled = true;
            this.cbxType2.ItemHeight = 24;
            this.cbxType2.Location = new System.Drawing.Point(350, 247);
            this.cbxType2.Name = "cbxType2";
            this.cbxType2.Size = new System.Drawing.Size(260, 32);
            this.cbxType2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "從";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(989, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "至";
            this.label6.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(773, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1029, 73);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 36);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.Visible = false;
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(350, 593);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(138, 85);
            this.btnCommit.TabIndex = 13;
            this.btnCommit.Text = "確認送出";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(520, 593);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 85);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbxResult
            // 
            this.lbxResult.BackColor = System.Drawing.SystemColors.Control;
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.ItemHeight = 24;
            this.lbxResult.Location = new System.Drawing.Point(350, 342);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbxResult.Size = new System.Drawing.Size(596, 244);
            this.lbxResult.TabIndex = 21;
            this.lbxResult.Visible = false;
            // 
            // VehicleLicenseTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1335, 716);
            this.Controls.Add(this.lbxResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxType2);
            this.Controls.Add(this.cbxType1);
            this.Controls.Add(this.rbtnPeriod);
            this.Controls.Add(this.rbtnYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VehicleLicenseTaxForm";
            this.Text = "VehicleLicenseTaxForm";
            this.Load += new System.EventHandler(this.VehicleLicenseTaxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnYear;
        private System.Windows.Forms.RadioButton rbtnPeriod;
        private System.Windows.Forms.ComboBox cbxType1;
        private System.Windows.Forms.ComboBox cbxType2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lbxResult;
    }
}

