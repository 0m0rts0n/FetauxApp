namespace FetauxApp
{
    partial class WatchPatientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AnalysisNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ResusIDTB = new System.Windows.Forms.TextBox();
            this.BloodIDTB = new System.Windows.Forms.TextBox();
            this.HosNumTB = new System.Windows.Forms.TextBox();
            this.AgencyIDTB = new System.Windows.Forms.TextBox();
            this.PolNumTB = new System.Windows.Forms.TextBox();
            this.AddrTB = new System.Windows.Forms.TextBox();
            this.TelephoneTB = new System.Windows.Forms.TextBox();
            this.BirthdayTB = new System.Windows.Forms.TextBox();
            this.FIOTB = new System.Windows.Forms.TextBox();
            this.DataIDTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnalysisNum,
            this.AnalysisName,
            this.AnalysisTime});
            this.dataGridView1.Location = new System.Drawing.Point(12, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 183);
            this.dataGridView1.TabIndex = 46;
            // 
            // AnalysisNum
            // 
            this.AnalysisNum.HeaderText = "№ анализа";
            this.AnalysisNum.Name = "AnalysisNum";
            // 
            // AnalysisName
            // 
            this.AnalysisName.HeaderText = "Анализ";
            this.AnalysisName.Name = "AnalysisName";
            // 
            // AnalysisTime
            // 
            this.AnalysisTime.HeaderText = "Срок анализа";
            this.AnalysisTime.Name = "AnalysisTime";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(28, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Резус-фактор";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(28, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Группа крови";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(28, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "№ больницы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "ID агентства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "№ полиса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(28, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "№ телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "ФИО";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLabel.Location = new System.Drawing.Point(28, 23);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 15);
            this.IDLabel.TabIndex = 35;
            this.IDLabel.Text = "ID";
            // 
            // ResusIDTB
            // 
            this.ResusIDTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResusIDTB.Location = new System.Drawing.Point(122, 253);
            this.ResusIDTB.Name = "ResusIDTB";
            this.ResusIDTB.ReadOnly = true;
            this.ResusIDTB.Size = new System.Drawing.Size(211, 23);
            this.ResusIDTB.TabIndex = 33;
            // 
            // BloodIDTB
            // 
            this.BloodIDTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BloodIDTB.Location = new System.Drawing.Point(122, 227);
            this.BloodIDTB.Name = "BloodIDTB";
            this.BloodIDTB.ReadOnly = true;
            this.BloodIDTB.Size = new System.Drawing.Size(211, 23);
            this.BloodIDTB.TabIndex = 32;
            // 
            // HosNumTB
            // 
            this.HosNumTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HosNumTB.Location = new System.Drawing.Point(122, 201);
            this.HosNumTB.Name = "HosNumTB";
            this.HosNumTB.ReadOnly = true;
            this.HosNumTB.Size = new System.Drawing.Size(211, 23);
            this.HosNumTB.TabIndex = 31;
            // 
            // AgencyIDTB
            // 
            this.AgencyIDTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgencyIDTB.Location = new System.Drawing.Point(122, 175);
            this.AgencyIDTB.Name = "AgencyIDTB";
            this.AgencyIDTB.ReadOnly = true;
            this.AgencyIDTB.Size = new System.Drawing.Size(211, 23);
            this.AgencyIDTB.TabIndex = 30;
            // 
            // PolNumTB
            // 
            this.PolNumTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolNumTB.Location = new System.Drawing.Point(122, 149);
            this.PolNumTB.Name = "PolNumTB";
            this.PolNumTB.ReadOnly = true;
            this.PolNumTB.Size = new System.Drawing.Size(211, 23);
            this.PolNumTB.TabIndex = 29;
            // 
            // AddrTB
            // 
            this.AddrTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddrTB.Location = new System.Drawing.Point(122, 123);
            this.AddrTB.Name = "AddrTB";
            this.AddrTB.ReadOnly = true;
            this.AddrTB.Size = new System.Drawing.Size(211, 23);
            this.AddrTB.TabIndex = 28;
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneTB.Location = new System.Drawing.Point(122, 97);
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.ReadOnly = true;
            this.TelephoneTB.Size = new System.Drawing.Size(211, 23);
            this.TelephoneTB.TabIndex = 27;
            // 
            // BirthdayTB
            // 
            this.BirthdayTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayTB.Location = new System.Drawing.Point(122, 71);
            this.BirthdayTB.Name = "BirthdayTB";
            this.BirthdayTB.ReadOnly = true;
            this.BirthdayTB.Size = new System.Drawing.Size(211, 23);
            this.BirthdayTB.TabIndex = 26;
            // 
            // FIOTB
            // 
            this.FIOTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOTB.Location = new System.Drawing.Point(122, 45);
            this.FIOTB.Name = "FIOTB";
            this.FIOTB.ReadOnly = true;
            this.FIOTB.Size = new System.Drawing.Size(211, 23);
            this.FIOTB.TabIndex = 25;
            // 
            // DataIDTB
            // 
            this.DataIDTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataIDTB.Location = new System.Drawing.Point(122, 20);
            this.DataIDTB.Name = "DataIDTB";
            this.DataIDTB.ReadOnly = true;
            this.DataIDTB.Size = new System.Drawing.Size(211, 23);
            this.DataIDTB.TabIndex = 24;
            // 
            // WatchPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ResusIDTB);
            this.Controls.Add(this.BloodIDTB);
            this.Controls.Add(this.HosNumTB);
            this.Controls.Add(this.AgencyIDTB);
            this.Controls.Add(this.PolNumTB);
            this.Controls.Add(this.AddrTB);
            this.Controls.Add(this.TelephoneTB);
            this.Controls.Add(this.BirthdayTB);
            this.Controls.Add(this.FIOTB);
            this.Controls.Add(this.DataIDTB);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(382, 524);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(382, 524);
            this.Name = "WatchPatientForm";
            this.Text = "Личная карточка";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox ResusIDTB;
        private System.Windows.Forms.TextBox BloodIDTB;
        private System.Windows.Forms.TextBox HosNumTB;
        private System.Windows.Forms.TextBox AgencyIDTB;
        private System.Windows.Forms.TextBox PolNumTB;
        private System.Windows.Forms.TextBox AddrTB;
        private System.Windows.Forms.TextBox TelephoneTB;
        private System.Windows.Forms.TextBox BirthdayTB;
        private System.Windows.Forms.TextBox FIOTB;
        private System.Windows.Forms.TextBox DataIDTB;
    }
}