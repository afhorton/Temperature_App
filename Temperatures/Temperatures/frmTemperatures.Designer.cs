namespace Temperatures
{
    partial class frmTemperatures
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
            this.grpEntry = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNewTemp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHighest = new System.Windows.Forms.TextBox();
            this.txtLowest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHotDays = new System.Windows.Forms.TextBox();
            this.txtAverageTemp = new System.Windows.Forms.TextBox();
            this.txtNrOfDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTemperatures = new System.Windows.Forms.ListBox();
            this.grpEntry.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEntry
            // 
            this.grpEntry.Controls.Add(this.btnAdd);
            this.grpEntry.Controls.Add(this.txtNewTemp);
            this.grpEntry.Controls.Add(this.label4);
            this.grpEntry.Location = new System.Drawing.Point(76, 52);
            this.grpEntry.Name = "grpEntry";
            this.grpEntry.Size = new System.Drawing.Size(280, 121);
            this.grpEntry.TabIndex = 0;
            this.grpEntry.TabStop = false;
            this.grpEntry.Text = "New Temperature";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNewTemp
            // 
            this.txtNewTemp.Location = new System.Drawing.Point(44, 75);
            this.txtNewTemp.Name = "txtNewTemp";
            this.txtNewTemp.Size = new System.Drawing.Size(100, 26);
            this.txtNewTemp.TabIndex = 1;
            this.txtNewTemp.Tag = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHighest);
            this.groupBox2.Controls.Add(this.txtLowest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHotDays);
            this.groupBox2.Controls.Add(this.txtAverageTemp);
            this.groupBox2.Controls.Add(this.txtNrOfDays);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(76, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Statistics";
            // 
            // txtHighest
            // 
            this.txtHighest.Location = new System.Drawing.Point(180, 242);
            this.txtHighest.Name = "txtHighest";
            this.txtHighest.ReadOnly = true;
            this.txtHighest.Size = new System.Drawing.Size(100, 26);
            this.txtHighest.TabIndex = 9;
            // 
            // txtLowest
            // 
            this.txtLowest.Location = new System.Drawing.Point(180, 190);
            this.txtLowest.Name = "txtLowest";
            this.txtLowest.ReadOnly = true;
            this.txtLowest.Size = new System.Drawing.Size(100, 26);
            this.txtLowest.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Highest Temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lowest Temp";
            // 
            // txtHotDays
            // 
            this.txtHotDays.Location = new System.Drawing.Point(180, 140);
            this.txtHotDays.Name = "txtHotDays";
            this.txtHotDays.ReadOnly = true;
            this.txtHotDays.Size = new System.Drawing.Size(100, 26);
            this.txtHotDays.TabIndex = 5;
            // 
            // txtAverageTemp
            // 
            this.txtAverageTemp.Location = new System.Drawing.Point(180, 91);
            this.txtAverageTemp.Name = "txtAverageTemp";
            this.txtAverageTemp.ReadOnly = true;
            this.txtAverageTemp.Size = new System.Drawing.Size(100, 26);
            this.txtAverageTemp.TabIndex = 4;
            // 
            // txtNrOfDays
            // 
            this.txtNrOfDays.Location = new System.Drawing.Point(180, 46);
            this.txtNrOfDays.Name = "txtNrOfDays";
            this.txtNrOfDays.ReadOnly = true;
            this.txtNrOfDays.Size = new System.Drawing.Size(100, 26);
            this.txtNrOfDays.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Days Above Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average Temp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr of Days";
            // 
            // lstTemperatures
            // 
            this.lstTemperatures.FormattingEnabled = true;
            this.lstTemperatures.ItemHeight = 20;
            this.lstTemperatures.Location = new System.Drawing.Point(657, 104);
            this.lstTemperatures.Name = "lstTemperatures";
            this.lstTemperatures.Size = new System.Drawing.Size(243, 384);
            this.lstTemperatures.TabIndex = 2;
            // 
            // frmTemperatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 529);
            this.Controls.Add(this.lstTemperatures);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpEntry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTemperatures";
            this.Text = "Temperature Tracker";
            this.grpEntry.ResumeLayout(false);
            this.grpEntry.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHotDays;
        private System.Windows.Forms.TextBox txtAverageTemp;
        private System.Windows.Forms.TextBox txtNrOfDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstTemperatures;
        private System.Windows.Forms.TextBox txtHighest;
        private System.Windows.Forms.TextBox txtLowest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

