namespace Contas_Pagar_Windows.Views
{
    partial class TelaRelatorioContasPagar
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
            this.dataGridContasPagar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridContasPagar
            // 
            this.dataGridContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContasPagar.Location = new System.Drawing.Point(0, 0);
            this.dataGridContasPagar.Name = "dataGridContasPagar";
            this.dataGridContasPagar.RowTemplate.Height = 25;
            this.dataGridContasPagar.Size = new System.Drawing.Size(799, 438);
            this.dataGridContasPagar.TabIndex = 0;
            // 
            // TelaRelatorioContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridContasPagar);
            this.Name = "TelaRelatorioContasPagar";
            this.Text = "Contas a Pagar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContasPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridContasPagar;
    }
}