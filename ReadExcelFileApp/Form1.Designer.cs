using System.Windows.Forms;

namespace ReadExcelFileApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGrdView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Aqua;
            this.btnChoose.Location = new System.Drawing.Point(10, 18);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(207, 27);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose and Read File";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Aqua;
            this.btnCancel.Location = new System.Drawing.Point(222, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGrdView
            // 
            this.dataGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdView.Location = new System.Drawing.Point(10, 59);
            this.dataGrdView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrdView.Name = "dataGrdView";
            this.dataGrdView.RowHeadersWidth = 62;
            this.dataGrdView.RowTemplate.Height = 33;
            this.dataGrdView.Size = new System.Drawing.Size(1650, 545);
            this.dataGrdView.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(10, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate Pdf Files";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGrdView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Read Excel File";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChoose;
        private Button btnCancel;
        private DataGridView dataGrdView;
        private Button button1;
    }
}