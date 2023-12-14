namespace WinFormBookingClient
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textcreatedate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textcreateroomtype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textcreateroomno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textcreatephone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateClear = new System.Windows.Forms.Button();
            this.btnCreateSubmit = new System.Windows.Forms.Button();
            this.txtCreategender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreatefullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textupdatedate = new System.Windows.Forms.TextBox();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.textupdatefullname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textupdategender = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textupdateroomtype = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textupdatephone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textupdateroomno = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 33);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowTemplate.Height = 29;
            this.dgvProducts.Size = new System.Drawing.Size(940, 175);
            this.dgvProducts.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(667, 239);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 57);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textcreatedate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textcreateroomtype);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textcreateroomno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textcreatephone);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCreateClear);
            this.groupBox1.Controls.Add(this.btnCreateSubmit);
            this.groupBox1.Controls.Add(this.txtCreategender);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCreatefullname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 234);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(292, 246);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creating Products";
            // 
            // textcreatedate
            // 
            this.textcreatedate.Location = new System.Drawing.Point(70, 185);
            this.textcreatedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textcreatedate.Name = "textcreatedate";
            this.textcreatedate.Size = new System.Drawing.Size(190, 23);
            this.textcreatedate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            // 
            // textcreateroomtype
            // 
            this.textcreateroomtype.Location = new System.Drawing.Point(70, 154);
            this.textcreateroomtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textcreateroomtype.Name = "textcreateroomtype";
            this.textcreateroomtype.Size = new System.Drawing.Size(190, 23);
            this.textcreateroomtype.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "RoomType";
            // 
            // textcreateroomno
            // 
            this.textcreateroomno.Location = new System.Drawing.Point(70, 122);
            this.textcreateroomno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textcreateroomno.Name = "textcreateroomno";
            this.textcreateroomno.Size = new System.Drawing.Size(190, 23);
            this.textcreateroomno.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "RoomNo";
            // 
            // textcreatephone
            // 
            this.textcreatephone.Location = new System.Drawing.Point(70, 91);
            this.textcreatephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textcreatephone.Name = "textcreatephone";
            this.textcreatephone.Size = new System.Drawing.Size(190, 23);
            this.textcreatephone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // btnCreateClear
            // 
            this.btnCreateClear.Location = new System.Drawing.Point(87, 219);
            this.btnCreateClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateClear.Name = "btnCreateClear";
            this.btnCreateClear.Size = new System.Drawing.Size(74, 21);
            this.btnCreateClear.TabIndex = 8;
            this.btnCreateClear.Text = "Clear";
            this.btnCreateClear.UseVisualStyleBackColor = true;
            // 
            // btnCreateSubmit
            // 
            this.btnCreateSubmit.Location = new System.Drawing.Point(171, 218);
            this.btnCreateSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateSubmit.Name = "btnCreateSubmit";
            this.btnCreateSubmit.Size = new System.Drawing.Size(82, 22);
            this.btnCreateSubmit.TabIndex = 6;
            this.btnCreateSubmit.Text = "Submit";
            this.btnCreateSubmit.UseVisualStyleBackColor = true;
            // 
            // txtCreategender
            // 
            this.txtCreategender.Location = new System.Drawing.Point(70, 51);
            this.txtCreategender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreategender.Name = "txtCreategender";
            this.txtCreategender.Size = new System.Drawing.Size(190, 23);
            this.txtCreategender.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender";
            // 
            // txtCreatefullname
            // 
            this.txtCreatefullname.Location = new System.Drawing.Point(70, 20);
            this.txtCreatefullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreatefullname.Name = "txtCreatefullname";
            this.txtCreatefullname.Size = new System.Drawing.Size(190, 23);
            this.txtCreatefullname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textupdatedate);
            this.groupBox2.Controls.Add(this.btnUpdateSubmit);
            this.groupBox2.Controls.Add(this.textupdatefullname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textupdategender);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textupdateroomtype);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textupdatephone);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textupdateroomno);
            this.groupBox2.Location = new System.Drawing.Point(332, 239);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(302, 241);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Updating Products";
            // 
            // textupdatedate
            // 
            this.textupdatedate.Location = new System.Drawing.Point(72, 183);
            this.textupdatedate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdatedate.Name = "textupdatedate";
            this.textupdatedate.Size = new System.Drawing.Size(190, 23);
            this.textupdatedate.TabIndex = 28;
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.Location = new System.Drawing.Point(214, 213);
            this.btnUpdateSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(82, 22);
            this.btnUpdateSubmit.TabIndex = 6;
            this.btnUpdateSubmit.Text = "Submit";
            this.btnUpdateSubmit.UseVisualStyleBackColor = true;
            // 
            // textupdatefullname
            // 
            this.textupdatefullname.Location = new System.Drawing.Point(72, 18);
            this.textupdatefullname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdatefullname.Name = "textupdatefullname";
            this.textupdatefullname.Size = new System.Drawing.Size(190, 23);
            this.textupdatefullname.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Date";
            // 
            // textupdategender
            // 
            this.textupdategender.Location = new System.Drawing.Point(72, 49);
            this.textupdategender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdategender.Name = "textupdategender";
            this.textupdategender.Size = new System.Drawing.Size(190, 23);
            this.textupdategender.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Gender";
            // 
            // textupdateroomtype
            // 
            this.textupdateroomtype.Location = new System.Drawing.Point(72, 152);
            this.textupdateroomtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdateroomtype.Name = "textupdateroomtype";
            this.textupdateroomtype.Size = new System.Drawing.Size(190, 23);
            this.textupdateroomtype.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "FullName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "RoomType";
            // 
            // textupdatephone
            // 
            this.textupdatephone.Location = new System.Drawing.Point(72, 89);
            this.textupdatephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdatephone.Name = "textupdatephone";
            this.textupdatephone.Size = new System.Drawing.Size(190, 23);
            this.textupdatephone.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "RoomNo";
            // 
            // textupdateroomno
            // 
            this.textupdateroomno.Location = new System.Drawing.Point(72, 120);
            this.textupdateroomno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textupdateroomno.Name = "textupdateroomno";
            this.textupdateroomno.Size = new System.Drawing.Size(190, 23);
            this.textupdateroomno.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(818, 239);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 57);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 491);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvProducts);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Delete";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnRefresh;
        private GroupBox groupBox1;
        private Button btnCreateSubmit;
        private TextBox txtCreategender;
        private Label label2;
        private TextBox txtCreatefullname;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnUpdateSubmit;
        private Button btnDelete;
        private Button btnCreateClear;
        private TextBox textcreatedate;
        private Label label7;
        private TextBox textcreateroomtype;
        private Label label8;
        private TextBox textcreateroomno;
        private Label label3;
        private TextBox textcreatephone;
        private Label label4;
        private TextBox textupdatedate;
        private TextBox textupdatefullname;
        private Label label9;
        private TextBox textupdategender;
        private Label label13;
        private TextBox textupdateroomtype;
        private Label label12;
        private Label label14;
        private Label label10;
        private TextBox textupdatephone;
        private Label label11;
        private TextBox textupdateroomno;
    }
}