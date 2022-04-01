
namespace tp_gene
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
            this.dgvpersonne = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpersonne
            // 
            this.dgvpersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.Columnnom,
            this.Columprenom});
            this.dgvpersonne.Location = new System.Drawing.Point(304, 246);
            this.dgvpersonne.Name = "dgvpersonne";
            this.dgvpersonne.RowTemplate.Height = 25;
            this.dgvpersonne.Size = new System.Drawing.Size(348, 150);
            this.dgvpersonne.TabIndex = 0;
            // 
            // columnId
            // 
            this.columnId.HeaderText = "id";
            this.columnId.Name = "columnId";
            // 
            // Columnnom
            // 
            this.Columnnom.HeaderText = "Nom";
            this.Columnnom.Name = "Columnnom";
            // 
            // Columprenom
            // 
            this.Columprenom.HeaderText = "Prenom";
            this.Columprenom.Name = "Columprenom";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvpersonne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columprenom;
    }
}

