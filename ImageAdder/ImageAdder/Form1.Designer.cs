namespace ImageAdder
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
            this.tbAfbeeldingID = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblAfbeeldingID = new System.Windows.Forms.Label();
            this.lblCategorieID = new System.Windows.Forms.Label();
            this.tbCategorieID = new System.Windows.Forms.TextBox();
            this.lblFormaat = new System.Windows.Forms.Label();
            this.tbFormaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAfbeeldingID
            // 
            this.tbAfbeeldingID.Location = new System.Drawing.Point(79, 27);
            this.tbAfbeeldingID.Name = "tbAfbeeldingID";
            this.tbAfbeeldingID.Size = new System.Drawing.Size(25, 22);
            this.tbAfbeeldingID.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(30, 92);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(179, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblAfbeeldingID
            // 
            this.lblAfbeeldingID.AutoSize = true;
            this.lblAfbeeldingID.Location = new System.Drawing.Point(27, 30);
            this.lblAfbeeldingID.Name = "lblAfbeeldingID";
            this.lblAfbeeldingID.Size = new System.Drawing.Size(21, 17);
            this.lblAfbeeldingID.TabIndex = 2;
            this.lblAfbeeldingID.Text = "ID";
            // 
            // lblCategorieID
            // 
            this.lblCategorieID.AutoSize = true;
            this.lblCategorieID.Location = new System.Drawing.Point(131, 30);
            this.lblCategorieID.Name = "lblCategorieID";
            this.lblCategorieID.Size = new System.Drawing.Size(42, 17);
            this.lblCategorieID.TabIndex = 4;
            this.lblCategorieID.Text = "CatID";
            // 
            // tbCategorieID
            // 
            this.tbCategorieID.Location = new System.Drawing.Point(183, 27);
            this.tbCategorieID.Name = "tbCategorieID";
            this.tbCategorieID.Size = new System.Drawing.Size(25, 22);
            this.tbCategorieID.TabIndex = 3;
            // 
            // lblFormaat
            // 
            this.lblFormaat.AutoSize = true;
            this.lblFormaat.Location = new System.Drawing.Point(27, 63);
            this.lblFormaat.Name = "lblFormaat";
            this.lblFormaat.Size = new System.Drawing.Size(60, 17);
            this.lblFormaat.TabIndex = 6;
            this.lblFormaat.Text = "Formaat";
            // 
            // tbFormaat
            // 
            this.tbFormaat.Location = new System.Drawing.Point(93, 60);
            this.tbFormaat.Name = "tbFormaat";
            this.tbFormaat.Size = new System.Drawing.Size(116, 22);
            this.tbFormaat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 141);
            this.Controls.Add(this.lblFormaat);
            this.Controls.Add(this.tbFormaat);
            this.Controls.Add(this.lblCategorieID);
            this.Controls.Add(this.tbCategorieID);
            this.Controls.Add(this.lblAfbeeldingID);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbAfbeeldingID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAfbeeldingID;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblAfbeeldingID;
        private System.Windows.Forms.Label lblCategorieID;
        private System.Windows.Forms.TextBox tbCategorieID;
        private System.Windows.Forms.Label lblFormaat;
        private System.Windows.Forms.TextBox tbFormaat;
    }
}

