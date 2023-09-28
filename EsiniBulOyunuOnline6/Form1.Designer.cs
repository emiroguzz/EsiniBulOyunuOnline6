namespace EsiniBulOyunuOnline6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlKartlar=new Panel();
            gboYeniOyun=new GroupBox();
            btnOyunuBaslat=new Button();
            rb5=new RadioButton();
            rb4=new RadioButton();
            rb3=new RadioButton();
            rb2=new RadioButton();
            rb1=new RadioButton();
            menuStrip1=new MenuStrip();
            yeniOyunToolStripMenuItem=new ToolStripMenuItem();
            yeniOyunToolStripMenuItem1=new ToolStripMenuItem();
            gboYeniOyun.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKartlar
            // 
            pnlKartlar.Anchor=AnchorStyles.None;
            pnlKartlar.BackColor=Color.Transparent;
            pnlKartlar.Location=new Point(21, 42);
            pnlKartlar.Name="pnlKartlar";
            pnlKartlar.Size=new Size(600, 600);
            pnlKartlar.TabIndex=0;
            // 
            // gboYeniOyun
            // 
            gboYeniOyun.Anchor=AnchorStyles.None;
            gboYeniOyun.BackColor=Color.Transparent;
            gboYeniOyun.Controls.Add(btnOyunuBaslat);
            gboYeniOyun.Controls.Add(rb5);
            gboYeniOyun.Controls.Add(rb4);
            gboYeniOyun.Controls.Add(rb3);
            gboYeniOyun.Controls.Add(rb2);
            gboYeniOyun.Controls.Add(rb1);
            gboYeniOyun.Font=new Font("Segoe UI", 18F, FontStyle.Bold|FontStyle.Underline, GraphicsUnit.Point);
            gboYeniOyun.Location=new Point(190, 154);
            gboYeniOyun.Name="gboYeniOyun";
            gboYeniOyun.Size=new Size(258, 352);
            gboYeniOyun.TabIndex=0;
            gboYeniOyun.TabStop=false;
            gboYeniOyun.Text="Yeni Oyun";
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Anchor=AnchorStyles.None;
            btnOyunuBaslat.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnOyunuBaslat.Location=new Point(6, 286);
            btnOyunuBaslat.Name="btnOyunuBaslat";
            btnOyunuBaslat.Size=new Size(248, 44);
            btnOyunuBaslat.TabIndex=1;
            btnOyunuBaslat.Text="Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor=true;
            btnOyunuBaslat.Click+=btnOyunuBaslat_Click;
            // 
            // rb5
            // 
            rb5.AutoSize=true;
            rb5.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb5.Location=new Point(49, 216);
            rb5.Name="rb5";
            rb5.Size=new Size(122, 36);
            rb5.TabIndex=4;
            rb5.Text="Çok Zor";
            rb5.UseVisualStyleBackColor=true;
            // 
            // rb4
            // 
            rb4.AutoSize=true;
            rb4.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb4.Location=new Point(49, 174);
            rb4.Name="rb4";
            rb4.Size=new Size(72, 36);
            rb4.TabIndex=3;
            rb4.Text="Zor";
            rb4.UseVisualStyleBackColor=true;
            // 
            // rb3
            // 
            rb3.AutoSize=true;
            rb3.Checked=true;
            rb3.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb3.Location=new Point(49, 132);
            rb3.Name="rb3";
            rb3.Size=new Size(83, 36);
            rb3.TabIndex=2;
            rb3.TabStop=true;
            rb3.Text="Orta";
            rb3.UseVisualStyleBackColor=true;
            // 
            // rb2
            // 
            rb2.AutoSize=true;
            rb2.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb2.Location=new Point(49, 90);
            rb2.Name="rb2";
            rb2.Size=new Size(96, 36);
            rb2.TabIndex=1;
            rb2.Text="Kolay";
            rb2.UseVisualStyleBackColor=true;
            // 
            // rb1
            // 
            rb1.AutoSize=true;
            rb1.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rb1.Location=new Point(49, 48);
            rb1.Name="rb1";
            rb1.Size=new Size(146, 36);
            rb1.TabIndex=0;
            rb1.Text="Çok Kolay";
            rb1.UseVisualStyleBackColor=true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(643, 24);
            menuStrip1.TabIndex=1;
            menuStrip1.Text="menuStrip1";
            // 
            // yeniOyunToolStripMenuItem
            // 
            yeniOyunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniOyunToolStripMenuItem1 });
            yeniOyunToolStripMenuItem.Name="yeniOyunToolStripMenuItem";
            yeniOyunToolStripMenuItem.ShortcutKeys=Keys.F2;
            yeniOyunToolStripMenuItem.Size=new Size(48, 20);
            yeniOyunToolStripMenuItem.Text="Oyun";
            // 
            // yeniOyunToolStripMenuItem1
            // 
            yeniOyunToolStripMenuItem1.Name="yeniOyunToolStripMenuItem1";
            yeniOyunToolStripMenuItem1.ShortcutKeys=Keys.F2;
            yeniOyunToolStripMenuItem1.Size=new Size(147, 22);
            yeniOyunToolStripMenuItem1.Text="Yeni Oyun";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.WhiteSmoke;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout=ImageLayout.Zoom;
            ClientSize=new Size(643, 654);
            Controls.Add(gboYeniOyun);
            Controls.Add(pnlKartlar);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Name="Form1";
            Text="Eşini Bul Oyunu";
            gboYeniOyun.ResumeLayout(false);
            gboYeniOyun.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlKartlar;
        private Button btnOyunuBaslat;
        private GroupBox gboYeniOyun;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem yeniOyunToolStripMenuItem;
        private ToolStripMenuItem yeniOyunToolStripMenuItem1;
    }
}