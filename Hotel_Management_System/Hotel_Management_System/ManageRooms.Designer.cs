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
            this.price_label = new System.Windows.Forms.Label();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.room_number_label = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.RoomType_ComboBox = new System.Windows.Forms.ComboBox();
            this.my_DataBaseDataSet4 = new Hotel_Management_System.My_DataBaseDataSet4();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new Hotel_Management_System.My_DataBaseDataSet4TableAdapters.RoomsTableAdapter();
            this.RoomNumber_TextBox = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Clear_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_DataBaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(592, 300);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Transparent;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.Color.DodgerBlue;
            this.number.Location = new System.Drawing.Point(302, 91);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(0, 29);
            this.number.TabIndex = 1;
            // 
            // room_type_label
            // 
            this.room_type_label.AutoSize = true;
            this.room_type_label.BackColor = System.Drawing.Color.Transparent;
            this.room_type_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_type_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.room_type_label.Location = new System.Drawing.Point(277, 155);
            this.room_type_label.Name = "room_type_label";
            this.room_type_label.Size = new System.Drawing.Size(148, 29);
            this.room_type_label.TabIndex = 1;
            this.room_type_label.Text = "Room Type";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.BackColor = System.Drawing.Color.Transparent;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.price_label.Location = new System.Drawing.Point(277, 211);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(74, 29);
            this.price_label.TabIndex = 1;
            this.price_label.Text = "Price";
            // 
            // Price_textBox
            // 
            this.Price_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_textBox.Location = new System.Drawing.Point(436, 211);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(192, 32);
            this.Price_textBox.TabIndex = 3;
            this.Price_textBox.TextChanged += new System.EventHandler(this.Price_textBox_TextChanged);
            this.Price_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // room_number_label
            // 
            this.room_number_label.AutoSize = true;
            this.room_number_label.BackColor = System.Drawing.Color.Transparent;
            this.room_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_number_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.room_number_label.Location = new System.Drawing.Point(277, 91);
            this.room_number_label.Name = "room_number_label";
            this.room_number_label.Size = new System.Drawing.Size(106, 29);
            this.room_number_label.TabIndex = 1;
            this.room_number_label.Text = "Number";
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_button.FlatAppearance.BorderSize = 0;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(282, 295);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(121, 37);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // RoomType_ComboBox
            // 
            this.RoomType_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomType_ComboBox.FormattingEnabled = true;
            this.RoomType_ComboBox.Items.AddRange(new object[] {
            "standard",
            "single",
            "VIP",
            "King"});
            this.RoomType_ComboBox.Location = new System.Drawing.Point(436, 155);
            this.RoomType_ComboBox.Name = "RoomType_ComboBox";
            this.RoomType_ComboBox.Size = new System.Drawing.Size(192, 34);
            this.RoomType_ComboBox.TabIndex = 1;
            this.RoomType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.RoomType_ComboBox_SelectedIndexChanged);
            this.RoomType_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomType_ComboBox_KeyPress);
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
            // RoomNumber_TextBox
            // 
            this.RoomNumber_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumber_TextBox.Location = new System.Drawing.Point(436, 91);
            this.RoomNumber_TextBox.Name = "RoomNumber_TextBox";
            this.RoomNumber_TextBox.Size = new System.Drawing.Size(192, 32);
            this.RoomNumber_TextBox.TabIndex = 0;
            this.RoomNumber_TextBox.TextChanged += new System.EventHandler(this.RoomNumber_TextBox_TextChanged);
            this.RoomNumber_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Delete_Button.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Delete_Button.FlatAppearance.BorderSize = 0;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(436, 295);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(121, 37);
            this.Delete_Button.TabIndex = 5;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Clear_Button
            // 
            this.Clear_Button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear_Button.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Clear_Button.FlatAppearance.BorderSize = 0;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_Button.ForeColor = System.Drawing.Color.White;
            this.Clear_Button.Location = new System.Drawing.Point(586, 295);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(121, 37);
            this.Clear_Button.TabIndex = 6;
            this.Clear_Button.Text = "Clear";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // ManageRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel_Management_System.Properties.Resources.Lawrencium;
            this.ClientSize = new System.Drawing.Size(886, 700);
            this.Controls.Add(this.RoomType_ComboBox);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.Price_textBox);
            this.Controls.Add(this.RoomNumber_TextBox);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.room_number_label);
            this.Controls.Add(this.room_type_label);
            this.Controls.Add(this.number);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Label room_number_label;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox RoomType_ComboBox;
        private My_DataBaseDataSet4 my_DataBaseDataSet4;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private My_DataBaseDataSet4TableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.TextBox RoomNumber_TextBox;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Clear_Button;
    }
}