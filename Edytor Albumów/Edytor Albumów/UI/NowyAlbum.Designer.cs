namespace Edytor_Albumów.UI
{
    partial class NowyAlbum
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
            this.Nazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Opis = new System.Windows.Forms.RichTextBox();
            this.Gotowe = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // Nazwa
            // 
            this.Nazwa.Location = new System.Drawing.Point(13, 30);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(153, 20);
            this.Nazwa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Opis:";
            // 
            // Opis
            // 
            this.Opis.Location = new System.Drawing.Point(13, 74);
            this.Opis.Name = "Opis";
            this.Opis.Size = new System.Drawing.Size(280, 78);
            this.Opis.TabIndex = 3;
            this.Opis.Text = "";
            // 
            // Gotowe
            // 
            this.Gotowe.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Gotowe.Location = new System.Drawing.Point(12, 158);
            this.Gotowe.Name = "Gotowe";
            this.Gotowe.Size = new System.Drawing.Size(75, 23);
            this.Gotowe.TabIndex = 4;
            this.Gotowe.Text = "Gotowe";
            this.Gotowe.UseVisualStyleBackColor = true;
            this.Gotowe.Click += new System.EventHandler(this.Gotowe_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Anuluj.Location = new System.Drawing.Point(91, 158);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 5;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // NowyAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 190);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.Gotowe);
            this.Controls.Add(this.Opis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.label1);
            this.Name = "NowyAlbum";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Gotowe;
        private System.Windows.Forms.Button Anuluj;
        public System.Windows.Forms.TextBox Nazwa;
        public System.Windows.Forms.RichTextBox Opis;
    }
}