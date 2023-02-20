namespace Otoslotto
{
    partial class OtosSorsolo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtosSorsolo));
            this.lottoszamokpan = new System.Windows.Forms.Panel();
            this.sorsolobutton = new System.Windows.Forms.Button();
            this.nyeroszamoklab = new System.Windows.Forms.Label();
            this.megjatszottlab = new System.Windows.Forms.Label();
            this.talalatlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lottoszamokpan
            // 
            this.lottoszamokpan.Location = new System.Drawing.Point(28, 21);
            this.lottoszamokpan.Name = "lottoszamokpan";
            this.lottoszamokpan.Size = new System.Drawing.Size(1148, 379);
            this.lottoszamokpan.TabIndex = 0;
            // 
            // sorsolobutton
            // 
            this.sorsolobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sorsolobutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sorsolobutton.Image = global::Otoslotto.Properties.Resources.shamrock_lucky_icon;
            this.sorsolobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sorsolobutton.Location = new System.Drawing.Point(213, 526);
            this.sorsolobutton.Name = "sorsolobutton";
            this.sorsolobutton.Size = new System.Drawing.Size(128, 53);
            this.sorsolobutton.TabIndex = 1;
            this.sorsolobutton.Text = "Sorsolás";
            this.sorsolobutton.UseVisualStyleBackColor = true;
            this.sorsolobutton.Click += new System.EventHandler(this.sorsolobutton_Click);
            // 
            // nyeroszamoklab
            // 
            this.nyeroszamoklab.AutoSize = true;
            this.nyeroszamoklab.ForeColor = System.Drawing.Color.DarkGreen;
            this.nyeroszamoklab.Location = new System.Drawing.Point(455, 476);
            this.nyeroszamoklab.Name = "nyeroszamoklab";
            this.nyeroszamoklab.Size = new System.Drawing.Size(109, 19);
            this.nyeroszamoklab.TabIndex = 2;
            this.nyeroszamoklab.Text = "Nyerőszámok->";
            // 
            // megjatszottlab
            // 
            this.megjatszottlab.AutoSize = true;
            this.megjatszottlab.ForeColor = System.Drawing.Color.Black;
            this.megjatszottlab.Location = new System.Drawing.Point(455, 526);
            this.megjatszottlab.Name = "megjatszottlab";
            this.megjatszottlab.Size = new System.Drawing.Size(95, 19);
            this.megjatszottlab.TabIndex = 3;
            this.megjatszottlab.Text = "Megjátszott->";
            // 
            // talalatlab
            // 
            this.talalatlab.AutoSize = true;
            this.talalatlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.talalatlab.Location = new System.Drawing.Point(455, 577);
            this.talalatlab.Name = "talalatlab";
            this.talalatlab.Size = new System.Drawing.Size(63, 19);
            this.talalatlab.TabIndex = 4;
            this.talalatlab.Text = "Találat->";
            // 
            // OtosSorsolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.talalatlab);
            this.Controls.Add(this.megjatszottlab);
            this.Controls.Add(this.nyeroszamoklab);
            this.Controls.Add(this.sorsolobutton);
            this.Controls.Add(this.lottoszamokpan);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OtosSorsolo";
            this.Text = "Ötös Lottó";
            this.Load += new System.EventHandler(this.OtosSorsolo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lottoszamokpan;
        private System.Windows.Forms.Button sorsolobutton;
        private System.Windows.Forms.Label nyeroszamoklab;
        private System.Windows.Forms.Label megjatszottlab;
        private System.Windows.Forms.Label talalatlab;
    }
}

