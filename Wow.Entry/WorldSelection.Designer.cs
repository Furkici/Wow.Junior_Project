namespace Wow.Entry
{
    partial class WorldSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldSelection));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterAlliance = new System.Windows.Forms.Button();
            this.btnEnterHorde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(164, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "ALLİANCE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(676, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 71);
            this.label2.TabIndex = 5;
            this.label2.Text = "HORDE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEnterAlliance
            // 
            this.btnEnterAlliance.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterAlliance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterAlliance.BackgroundImage")));
            this.btnEnterAlliance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterAlliance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterAlliance.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnEnterAlliance.Location = new System.Drawing.Point(240, 374);
            this.btnEnterAlliance.Name = "btnEnterAlliance";
            this.btnEnterAlliance.Size = new System.Drawing.Size(233, 76);
            this.btnEnterAlliance.TabIndex = 8;
            this.btnEnterAlliance.Text = "ENTER";
            this.btnEnterAlliance.UseVisualStyleBackColor = false;
            this.btnEnterAlliance.Click += new System.EventHandler(this.btnEnterAlliance_Click);
            // 
            // btnEnterHorde
            // 
            this.btnEnterHorde.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterHorde.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnterHorde.BackgroundImage")));
            this.btnEnterHorde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterHorde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterHorde.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnEnterHorde.Location = new System.Drawing.Point(711, 374);
            this.btnEnterHorde.Name = "btnEnterHorde";
            this.btnEnterHorde.Size = new System.Drawing.Size(233, 76);
            this.btnEnterHorde.TabIndex = 7;
            this.btnEnterHorde.Text = "ENTER";
            this.btnEnterHorde.UseVisualStyleBackColor = false;
            this.btnEnterHorde.Click += new System.EventHandler(this.btnEnterHorde_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label3.Location = new System.Drawing.Point(715, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 72);
            this.label3.TabIndex = 10;
            this.label3.Text = "Toprakları istila et klan üyelerini arttır";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label4.Location = new System.Drawing.Point(241, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 72);
            this.label4.TabIndex = 9;
            this.label4.Text = "Halkını koru ve onurun için savaş";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // WorldSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 593);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnterHorde);
            this.Controls.Add(this.btnEnterAlliance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WorldSelection";
            this.Text = "WorldSelection";
            this.Load += new System.EventHandler(this.WorldSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnterAlliance;
        private System.Windows.Forms.Button btnEnterHorde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}