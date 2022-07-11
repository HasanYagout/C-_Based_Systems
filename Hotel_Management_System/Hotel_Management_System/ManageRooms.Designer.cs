namespace Hotel_Management_System
{
    partial class ManageRooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number = new System.Windows.Forms.Label();
            this.room_type_label = new System.Windows.Forms.Label();
            this.bed_type_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.room_number_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.my_DataBaseDataSet4 = new Hotel_Management_System.My_DataBaseDataSet4();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Hotel_Management_System.My_DataBaseDataSet4TableAdapters.RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(612, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Location = new System.Drawing.Point(30, 23);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(0, 17);
            this.number.TabIndex = 1;
            // 
            // room_type_label
            // 
            this.room_type_label.AutoSize = true;
            this.room_type_label.Location = new System.Drawing.Point(30, 87);
            this.room_type_label.Name = "room_type_label";
            this.room_type_label.Size = new System.Drawing.Size(71, 17);
            this.room_type_label.TabIndex = 1;
            this.room_type_label.Text = "room type";
            // 
            // bed_type_label
            // 
            this.bed_type_label.AutoSize = true;
            this.bed_type_label.Location = new System.Drawing.Point(30, 152);
            this.bed_type_label.Name = "bed_type_label";
            this.bed_type_label.Size = new System.Drawing.Size(63, 17);
            this.bed_type_label.TabIndex = 1;
            this.bed_type_label.Text = "bed type";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(30, 202);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(39, 17);
            this.price_label.TabIndex = 1;
            this.price_label.Text = "price";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 2;
            // 
            // room_number_label
            // 
            this.room_number_label.AutoSize = true;
            this.room_number_label.Location = new System.Drawing.Point(30, 23);
            this.room_number_label.Name = "room_number_label";
            this.room_number_label.Size = new System.Drawing.Size(56, 17);
            this.room_number_label.TabIndex = 1;
            this.room_number_label.Text = "number";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(33, 273);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 3;
            this.add_button.Text = "add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AC",
            "No AC"});
            this.comboBox1.Location = new System.Drawing.Point(129, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Single",
            "Double\t\t"});
            this.comboBox2.Location = new System.Drawing.Point(129, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 5;
            // 
            // my_DataBaseDataSet4
            // 
            this.my_DataBaseDataSet4.DataSetName = "My_DataBaseDataSet4";
            this.my_DataBaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.my_DataBaseDataSet4;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 494);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.bed_type_label);
            this.Controls.Add(this.room_number_label);
            this.Controls.Add(this.room_type_label);
            this.Controls.Add(this.number);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageRooms";
            this.Text = "ManageRooms";
            this.Load += new System.EventHandler(this.ManageRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label room_type_label;
        private System.Windows.Forms.Label bed_type_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label room_number_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private My_DataBaseDataSet4 my_DataBaseDataSet4;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private My_DataBaseDataSet4TableAdapters.RoomsTableAdapter roomsTableAdapter;
    }
}