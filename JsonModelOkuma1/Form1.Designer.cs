namespace JsonModelOkuma1
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "tarih"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "test sayısı"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "vaka"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "iyileşen"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("vefat");
            this.Listele = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.tmrguncelle = new System.Windows.Forms.Timer(this.components);
            this.baslik = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.testsayisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vaka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iyilesen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vefat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Listele)).BeginInit();
            this.SuspendLayout();
            // 
            // Listele
            // 
            this.Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Listele.Location = new System.Drawing.Point(12, 27);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(887, 391);
            this.Listele.TabIndex = 0;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(642, 424);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 1;
            this.btnguncelle.Text = "Guncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // baslik
            // 
            this.baslik.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik.Location = new System.Drawing.Point(38, 43);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(793, 38);
            this.baslik.TabIndex = 2;
            this.baslik.Text = "CORONA BASLIK";
            this.baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tarih,
            this.testsayisi,
            this.vaka,
            this.iyilesen,
            this.vefat});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(42, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(836, 276);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // testsayisi
            // 
            this.testsayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vaka
            // 
            this.vaka.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iyilesen
            // 
            this.iyilesen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.baslik);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.Listele);
            this.Name = "Form1";
            this.Text = "Json Data Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Listele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Listele;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Timer tmrguncelle;
        private System.Windows.Forms.Label baslik;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader testsayisi;
        private System.Windows.Forms.ColumnHeader vaka;
        private System.Windows.Forms.ColumnHeader iyilesen;
        private System.Windows.Forms.ColumnHeader vefat;
    }
}

