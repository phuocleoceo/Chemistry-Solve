namespace WindowsFormsApp1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btndang1 = new System.Windows.Forms.Button();
            this.btndang2 = new System.Windows.Forms.Button();
            this.btndang3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndang1
            // 
            this.btndang1.BackColor = System.Drawing.Color.GreenYellow;
            this.btndang1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndang1.Location = new System.Drawing.Point(118, 33);
            this.btndang1.Name = "btndang1";
            this.btndang1.Size = new System.Drawing.Size(211, 42);
            this.btndang1.TabIndex = 0;
            this.btndang1.Text = "Dạng 1";
            this.btndang1.UseVisualStyleBackColor = false;
            this.btndang1.Click += new System.EventHandler(this.btndang1_Click);
            // 
            // btndang2
            // 
            this.btndang2.BackColor = System.Drawing.Color.Aqua;
            this.btndang2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndang2.Location = new System.Drawing.Point(118, 106);
            this.btndang2.Name = "btndang2";
            this.btndang2.Size = new System.Drawing.Size(211, 42);
            this.btndang2.TabIndex = 0;
            this.btndang2.Text = "Dạng 2";
            this.btndang2.UseVisualStyleBackColor = false;
            this.btndang2.Click += new System.EventHandler(this.btndang2_Click);
            // 
            // btndang3
            // 
            this.btndang3.BackColor = System.Drawing.Color.LightSalmon;
            this.btndang3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndang3.Location = new System.Drawing.Point(118, 178);
            this.btndang3.Name = "btndang3";
            this.btndang3.Size = new System.Drawing.Size(211, 42);
            this.btndang3.TabIndex = 0;
            this.btndang3.Text = "Dạng 3";
            this.btndang3.UseVisualStyleBackColor = false;
            this.btndang3.Click += new System.EventHandler(this.btndang3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(448, 248);
            this.Controls.Add(this.btndang3);
            this.Controls.Add(this.btndang2);
            this.Controls.Add(this.btndang1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndang1;
        private System.Windows.Forms.Button btndang2;
        private System.Windows.Forms.Button btndang3;
    }
}