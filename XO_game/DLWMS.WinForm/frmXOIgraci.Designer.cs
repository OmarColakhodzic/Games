namespace DLWMS.WinForm
{
    partial class frmXOIgraci
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
            this.txtIgrac1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIgrac2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIgrac1
            // 
            this.txtIgrac1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIgrac1.Location = new System.Drawing.Point(12, 45);
            this.txtIgrac1.Name = "txtIgrac1";
            this.txtIgrac1.Size = new System.Drawing.Size(364, 47);
            this.txtIgrac1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime prvog igrača:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime drugog igrača:";
            // 
            // txtIgrac2
            // 
            this.txtIgrac2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIgrac2.Location = new System.Drawing.Point(12, 123);
            this.txtIgrac2.Name = "txtIgrac2";
            this.txtIgrac2.Size = new System.Drawing.Size(364, 47);
            this.txtIgrac2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmXOIgraci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIgrac2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIgrac1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXOIgraci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igraci";
            this.Load += new System.EventHandler(this.frmXOIgraci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIgrac1;
        private Label label1;
        private Label label2;
        private TextBox txtIgrac2;
        private Button button1;
    }
}