namespace HelloWorld
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
            this.btnGFY1 = new System.Windows.Forms.Button();
            this.btnGFY2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGFY1
            // 
            this.btnGFY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGFY1.Location = new System.Drawing.Point(475, 91);
            this.btnGFY1.Name = "btnGFY1";
            this.btnGFY1.Size = new System.Drawing.Size(75, 62);
            this.btnGFY1.TabIndex = 0;
            this.btnGFY1.Text = "gfy 1";
            this.btnGFY1.UseVisualStyleBackColor = true;
            this.btnGFY1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGFY2
            // 
            this.btnGFY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGFY2.Location = new System.Drawing.Point(330, 165);
            this.btnGFY2.Name = "btnGFY2";
            this.btnGFY2.Size = new System.Drawing.Size(75, 62);
            this.btnGFY2.TabIndex = 1;
            this.btnGFY2.Text = "gfy 2";
            this.btnGFY2.UseVisualStyleBackColor = true;
            this.btnGFY2.Click += new System.EventHandler(this.btnGFY2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 393);
            this.Controls.Add(this.btnGFY2);
            this.Controls.Add(this.btnGFY1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGFY1;
        private System.Windows.Forms.Button btnGFY2;
    }
}

