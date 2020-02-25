namespace personeltakip
{
    partial class Frmpersonelcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmpersonelcs));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.btniptal = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtplaka);
            this.tabPage1.Controls.Add(this.btniptal);
            this.tabPage1.Controls.Add(this.btnekle);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txttc);
            this.tabPage1.Controls.Add(this.txtsoyad);
            this.tabPage1.Controls.Add(this.txtad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(235, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 45;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageIndex = 0;
            this.button1.Location = new System.Drawing.Point(454, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 29);
            this.button1.TabIndex = 44;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 167);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(91, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Araç Plaka";
            // 
            // txtplaka
            // 
            this.txtplaka.Location = new System.Drawing.Point(224, 144);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(201, 20);
            this.txtplaka.TabIndex = 41;
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btniptal.ImageIndex = 1;
            this.btniptal.Location = new System.Drawing.Point(372, 192);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(107, 32);
            this.btniptal.TabIndex = 40;
            this.btniptal.Text = "Sil";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click_1);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.White;
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnekle.ImageIndex = 0;
            this.btnekle.Location = new System.Drawing.Point(93, 192);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(118, 32);
            this.btnekle.TabIndex = 39;
            this.btnekle.Text = "Kaydet";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(90, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Kullanıcı Tc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kullanıcı Soyad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kullanıcı Ad";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(224, 3);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(201, 20);
            this.txttc.TabIndex = 35;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(224, 93);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(201, 20);
            this.txtsoyad.TabIndex = 34;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(224, 47);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(201, 20);
            this.txtad.TabIndex = 33;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kontrol";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(605, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(75, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(651, 375);
            this.dataGridView2.TabIndex = 6;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "magnifying-glass.png");
            this.ımageList1.Images.SetKeyName(1, "previous.png");
            this.ımageList1.Images.SetKeyName(2, "back.png");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(19, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 40);
            this.button3.TabIndex = 46;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frmpersonelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 497);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frmpersonelcs";
            this.Text = "PERSONEL ";
            this.Load += new System.EventHandler(this.Frmpersonelcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button3;
    }
}