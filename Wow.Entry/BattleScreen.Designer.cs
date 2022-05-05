namespace Wow.Entry
{
    partial class BattleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUltraAtack2 = new System.Windows.Forms.Button();
            this.btnUltraAttack = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbBattle = new System.Windows.Forms.PictureBox();
            this.btnSaldırı2 = new System.Windows.Forms.Button();
            this.btnSaldırı = new System.Windows.Forms.Button();
            this.lblBattle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 627);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(147, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Health:500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(731, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Health:500";
            // 
            // btnUltraAtack2
            // 
            this.btnUltraAtack2.BackColor = System.Drawing.Color.DarkRed;
            this.btnUltraAtack2.Location = new System.Drawing.Point(799, 398);
            this.btnUltraAtack2.Name = "btnUltraAtack2";
            this.btnUltraAtack2.Size = new System.Drawing.Size(39, 39);
            this.btnUltraAtack2.TabIndex = 8;
            this.btnUltraAtack2.UseVisualStyleBackColor = false;
            // 
            // btnUltraAttack
            // 
            this.btnUltraAttack.BackColor = System.Drawing.Color.DarkRed;
            this.btnUltraAttack.Location = new System.Drawing.Point(152, 398);
            this.btnUltraAttack.Name = "btnUltraAttack";
            this.btnUltraAttack.Size = new System.Drawing.Size(39, 39);
            this.btnUltraAttack.TabIndex = 7;
            this.btnUltraAttack.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(857, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 104);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pbBattle
            // 
            this.pbBattle.Location = new System.Drawing.Point(10, 219);
            this.pbBattle.Name = "pbBattle";
            this.pbBattle.Size = new System.Drawing.Size(121, 114);
            this.pbBattle.TabIndex = 5;
            this.pbBattle.TabStop = false;
            // 
            // btnSaldırı2
            // 
            this.btnSaldırı2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaldırı2.Location = new System.Drawing.Point(735, 347);
            this.btnSaldırı2.Name = "btnSaldırı2";
            this.btnSaldırı2.Size = new System.Drawing.Size(103, 23);
            this.btnSaldırı2.TabIndex = 11;
            this.btnSaldırı2.Text = "Hızlı Saldırı";
            this.btnSaldırı2.UseVisualStyleBackColor = true;
            this.btnSaldırı2.Click += new System.EventHandler(this.btnSaldırı2_Click);
            // 
            // btnSaldırı
            // 
            this.btnSaldırı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaldırı.Location = new System.Drawing.Point(152, 347);
            this.btnSaldırı.Name = "btnSaldırı";
            this.btnSaldırı.Size = new System.Drawing.Size(99, 23);
            this.btnSaldırı.TabIndex = 12;
            this.btnSaldırı.Text = "Hızlı Saldırı";
            this.btnSaldırı.UseVisualStyleBackColor = true;
            this.btnSaldırı.Click += new System.EventHandler(this.btnSaldırı_Click);
            // 
            // lblBattle
            // 
            this.lblBattle.BackColor = System.Drawing.Color.Transparent;
            this.lblBattle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBattle.Font = new System.Drawing.Font("Poor Richard", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattle.ForeColor = System.Drawing.Color.DarkKhaki;
            this.lblBattle.Location = new System.Drawing.Point(387, 207);
            this.lblBattle.Name = "lblBattle";
            this.lblBattle.Size = new System.Drawing.Size(244, 151);
            this.lblBattle.TabIndex = 13;
            this.lblBattle.Text = "savaş alanı";
            this.lblBattle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 627);
            this.Controls.Add(this.lblBattle);
            this.Controls.Add(this.btnSaldırı);
            this.Controls.Add(this.btnSaldırı2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUltraAtack2);
            this.Controls.Add(this.btnUltraAttack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbBattle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BattleScreen";
            this.Load += new System.EventHandler(this.BattleScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUltraAtack2;
        private System.Windows.Forms.Button btnUltraAttack;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pbBattle;
        private System.Windows.Forms.Button btnSaldırı2;
        private System.Windows.Forms.Button btnSaldırı;
        private System.Windows.Forms.Label lblBattle;
    }
}