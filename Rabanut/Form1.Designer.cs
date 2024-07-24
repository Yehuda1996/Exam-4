namespace Rabanut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TitleLbl = new Label();
            DayWeekLbl = new Label();
            DayMonthLbl = new Label();
            MonthLbl = new Label();
            YearLbl = new Label();
            YearCmbx = new ComboBox();
            MonthCmbx = new ComboBox();
            DayMonthCmbx = new ComboBox();
            DayWeekCmbx = new ComboBox();
            EnterBtn = new Button();
            SuspendLayout();
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            TitleLbl.Location = new Point(409, 38);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(271, 54);
            TitleLbl.TabIndex = 0;
            TitleLbl.Text = "כתיבת תאריך";
            // 
            // DayWeekLbl
            // 
            DayWeekLbl.AutoSize = true;
            DayWeekLbl.Location = new Point(805, 112);
            DayWeekLbl.Name = "DayWeekLbl";
            DayWeekLbl.Size = new Size(134, 32);
            DayWeekLbl.TabIndex = 1;
            DayWeekLbl.Text = "היום בשבוע";
            // 
            // DayMonthLbl
            // 
            DayMonthLbl.AutoSize = true;
            DayMonthLbl.Location = new Point(603, 112);
            DayMonthLbl.Name = "DayMonthLbl";
            DayMonthLbl.Size = new Size(133, 32);
            DayMonthLbl.TabIndex = 2;
            DayMonthLbl.Text = "היום בחודש";
            // 
            // MonthLbl
            // 
            MonthLbl.AutoSize = true;
            MonthLbl.Location = new Point(424, 112);
            MonthLbl.Name = "MonthLbl";
            MonthLbl.Size = new Size(67, 32);
            MonthLbl.TabIndex = 3;
            MonthLbl.Text = "חודש";
            // 
            // YearLbl
            // 
            YearLbl.AutoSize = true;
            YearLbl.Location = new Point(207, 112);
            YearLbl.Name = "YearLbl";
            YearLbl.Size = new Size(59, 32);
            YearLbl.TabIndex = 4;
            YearLbl.Text = "שנה";
            // 
            // YearCmbx
            // 
            YearCmbx.FormattingEnabled = true;
            YearCmbx.Items.AddRange(new object[] { "השתשפד", "התשפה", "התשפו", "התשפז", "התשפח", "התשפט", "התשצ", "התשצא", "התשצב", "התשצג" });
            YearCmbx.Location = new Point(153, 169);
            YearCmbx.Name = "YearCmbx";
            YearCmbx.Size = new Size(163, 40);
            YearCmbx.TabIndex = 5;
            // 
            // MonthCmbx
            // 
            MonthCmbx.FormattingEnabled = true;
            MonthCmbx.Items.AddRange(new object[] { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" });
            MonthCmbx.Location = new Point(372, 169);
            MonthCmbx.Name = "MonthCmbx";
            MonthCmbx.Size = new Size(163, 40);
            MonthCmbx.TabIndex = 6;
            // 
            // DayMonthCmbx
            // 
            DayMonthCmbx.FormattingEnabled = true;
            DayMonthCmbx.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            DayMonthCmbx.Location = new Point(586, 169);
            DayMonthCmbx.Name = "DayMonthCmbx";
            DayMonthCmbx.Size = new Size(163, 40);
            DayMonthCmbx.TabIndex = 7;
            // 
            // DayWeekCmbx
            // 
            DayWeekCmbx.FormattingEnabled = true;
            DayWeekCmbx.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "ששי" });
            DayWeekCmbx.Location = new Point(790, 169);
            DayWeekCmbx.Name = "DayWeekCmbx";
            DayWeekCmbx.Size = new Size(163, 40);
            DayWeekCmbx.TabIndex = 8;
            // 
            // EnterBtn
            // 
            EnterBtn.Location = new Point(455, 470);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(150, 46);
            EnterBtn.TabIndex = 9;
            EnterBtn.Text = "הכנס";
            EnterBtn.UseVisualStyleBackColor = true;
            EnterBtn.Click += onInsertClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 640);
            Controls.Add(EnterBtn);
            Controls.Add(DayWeekCmbx);
            Controls.Add(DayMonthCmbx);
            Controls.Add(MonthCmbx);
            Controls.Add(YearCmbx);
            Controls.Add(YearLbl);
            Controls.Add(MonthLbl);
            Controls.Add(DayMonthLbl);
            Controls.Add(DayWeekLbl);
            Controls.Add(TitleLbl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLbl;
        private Label DayWeekLbl;
        private Label DayMonthLbl;
        private Label MonthLbl;
        private Label YearLbl;
        private ComboBox YearCmbx;
        private ComboBox MonthCmbx;
        private ComboBox DayMonthCmbx;
        private ComboBox DayWeekCmbx;
        private Button EnterBtn;
    }
}
