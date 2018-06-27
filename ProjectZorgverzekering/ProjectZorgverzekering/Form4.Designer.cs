namespace ProjectZorgverzekering
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.NaamBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BeschrijvingBox = new System.Windows.Forms.TextBox();
            this.BijwerkingBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // NaamBox
            // 
            this.NaamBox.Location = new System.Drawing.Point(83, 28);
            this.NaamBox.Name = "NaamBox";
            this.NaamBox.Size = new System.Drawing.Size(149, 20);
            this.NaamBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beschrijving";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "bijwerkingen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 76);
            this.button1.TabIndex = 6;
            this.button1.Text = "Medicatie Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BeschrijvingBox
            // 
            this.BeschrijvingBox.Location = new System.Drawing.Point(83, 71);
            this.BeschrijvingBox.Multiline = true;
            this.BeschrijvingBox.Name = "BeschrijvingBox";
            this.BeschrijvingBox.Size = new System.Drawing.Size(149, 89);
            this.BeschrijvingBox.TabIndex = 3;
            // 
            // BijwerkingBox
            // 
            this.BijwerkingBox.Location = new System.Drawing.Point(83, 166);
            this.BijwerkingBox.Multiline = true;
            this.BijwerkingBox.Name = "BijwerkingBox";
            this.BijwerkingBox.Size = new System.Drawing.Size(149, 105);
            this.BijwerkingBox.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BijwerkingBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BeschrijvingBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NaamBox);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NaamBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox BeschrijvingBox;
        private System.Windows.Forms.TextBox BijwerkingBox;
    }
}