namespace Hotel_Management_System
{
    partial class Reservation
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Phone_txb = new System.Windows.Forms.MaskedTextBox();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OutDTP = new System.Windows.Forms.DateTimePicker();
            this.InDTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.OutDate_Label = new System.Windows.Forms.Label();
            this.try_label = new System.Windows.Forms.Label();
            this.InDate_Label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.Price_txb = new System.Windows.Forms.TextBox();
            this.cb_RoomNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cm_RoomType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Phone_txb);
            this.groupBox3.Controls.Add(this.Name_TextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(437, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 134);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guest Information";
            // 
            // Phone_txb
            // 
            this.Phone_txb.Location = new System.Drawing.Point(120, 81);
            this.Phone_txb.Mask = "(999) 000-0000";
            this.Phone_txb.Name = "Phone_txb";
            this.Phone_txb.Size = new System.Drawing.Size(212, 22);
            this.Phone_txb.TabIndex = 2;
            this.Phone_txb.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(120, 41);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(212, 22);
            this.Name_TextBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(21, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(21, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.OutDTP);
            this.groupBox1.Controls.Add(this.InDTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OutDate_Label);
            this.groupBox1.Controls.Add(this.try_label);
            this.groupBox1.Controls.Add(this.InDate_Label);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 181);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common Information";
            // 
            // OutDTP
            // 
            this.OutDTP.Location = new System.Drawing.Point(28, 137);
            this.OutDTP.Name = "OutDTP";
            this.OutDTP.Size = new System.Drawing.Size(268, 22);
            this.OutDTP.TabIndex = 7;
            // 
            // InDTP
            // 
            this.InDTP.Location = new System.Drawing.Point(26, 55);
            this.InDTP.Name = "InDTP";
            this.InDTP.Size = new System.Drawing.Size(268, 22);
            this.InDTP.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // OutDate_Label
            // 
            this.OutDate_Label.AutoSize = true;
            this.OutDate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutDate_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.OutDate_Label.Location = new System.Drawing.Point(21, 95);
            this.OutDate_Label.Name = "OutDate_Label";
            this.OutDate_Label.Size = new System.Drawing.Size(152, 25);
            this.OutDate_Label.TabIndex = 1;
            this.OutDate_Label.Text = "Check Out Date";
            // 
            // try_label
            // 
            this.try_label.AutoSize = true;
            this.try_label.Location = new System.Drawing.Point(94, 73);
            this.try_label.Name = "try_label";
            this.try_label.Size = new System.Drawing.Size(0, 17);
            this.try_label.TabIndex = 3;
            // 
            // InDate_Label
            // 
            this.InDate_Label.AutoSize = true;
            this.InDate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InDate_Label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InDate_Label.Location = new System.Drawing.Point(21, 27);
            this.InDate_Label.Name = "InDate_Label";
            this.InDate_Label.Size = new System.Drawing.Size(136, 25);
            this.InDate_Label.TabIndex = 1;
            this.InDate_Label.Text = "Check In Date";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.durationTextBox);
            this.groupBox2.Controls.Add(this.Price_txb);
            this.groupBox2.Controls.Add(this.cb_RoomNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cm_RoomType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(23, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 208);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Room Information";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(157, 129);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(121, 22);
            this.durationTextBox.TabIndex = 3;
            this.durationTextBox.TextChanged += new System.EventHandler(this.durationTextBox_TextChanged);
            // 
            // Price_txb
            // 
            this.Price_txb.Location = new System.Drawing.Point(157, 168);
            this.Price_txb.Name = "Price_txb";
            this.Price_txb.Size = new System.Drawing.Size(121, 22);
            this.Price_txb.TabIndex = 3;
            // 
            // cb_RoomNumber
            // 
            this.cb_RoomNumber.FormattingEnabled = true;
            this.cb_RoomNumber.Location = new System.Drawing.Point(157, 87);
            this.cb_RoomNumber.Name = "cb_RoomNumber";
            this.cb_RoomNumber.Size = new System.Drawing.Size(121, 24);
            this.cb_RoomNumber.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(23, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Duration";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(23, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Price";
            // 
            // cm_RoomType
            // 
            this.cm_RoomType.FormattingEnabled = true;
            this.cm_RoomType.Location = new System.Drawing.Point(157, 41);
            this.cm_RoomType.Name = "cm_RoomType";
            this.cm_RoomType.Size = new System.Drawing.Size(121, 24);
            this.cm_RoomType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.Lawrencium;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox Phone_txb;
        private System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label OutDate_Label;
        private System.Windows.Forms.Label try_label;
        private System.Windows.Forms.Label InDate_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox Price_txb;
        private System.Windows.Forms.ComboBox cb_RoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cm_RoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker OutDTP;
        private System.Windows.Forms.DateTimePicker InDTP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}