using System.Windows.Forms;

namespace AACSharp_Assignment_Serialization_Deserialization
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lbl_name = new Label();
            lbl_price = new Label();
            btn_addJson = new Button();
            text_name = new TextBox();
            text_price = new TextBox();
            btn_list = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_name.Location = new Point(25, 62);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(103, 25);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Ürün Ad : ";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbl_price.Location = new Point(25, 140);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(120, 25);
            lbl_price.TabIndex = 1;
            lbl_price.Text = "Ürün Fiyat : ";
            // 
            // btn_addJson
            // 
            btn_addJson.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_addJson.Location = new Point(145, 197);
            btn_addJson.Name = "btn_addJson";
            btn_addJson.Size = new Size(293, 44);
            btn_addJson.TabIndex = 2;
            btn_addJson.Text = "Json'a Ekle";
            btn_addJson.UseVisualStyleBackColor = true;
            btn_addJson.Click += btn_addJson_Click;
            // 
            // text_name
            // 
            text_name.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_name.Location = new Point(145, 59);
            text_name.Name = "text_name";
            text_name.Size = new Size(293, 32);
            text_name.TabIndex = 3;
            // 
            // text_price
            // 
            text_price.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            text_price.Location = new Point(145, 137);
            text_price.Name = "text_price";
            text_price.Size = new Size(293, 32);
            text_price.TabIndex = 4;
            // 
            // btn_list
            // 
            btn_list.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_list.Location = new Point(145, 266);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(293, 44);
            btn_list.TabIndex = 5;
            btn_list.Text = "Json'ı Listele";
            btn_list.UseVisualStyleBackColor = true;
            btn_list.Click += btn_list_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(458, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(330, 251);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowHeadersVisible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_list);
            Controls.Add(text_price);
            Controls.Add(text_name);
            Controls.Add(btn_addJson);
            Controls.Add(lbl_price);
            Controls.Add(lbl_name);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private Label lbl_price;
        private Button btn_addJson;
        private TextBox text_name;
        private TextBox text_price;
        private Button btn_list;
        private DataGridView dataGridView1;



    }


}
