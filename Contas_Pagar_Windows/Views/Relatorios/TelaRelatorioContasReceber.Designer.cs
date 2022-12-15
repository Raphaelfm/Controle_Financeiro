namespace Contas_Pagar_Windows.Views
{
    partial class TelaRelatorioContasReceber
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
            this.dataGridContasReceber = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContasReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridContasReceber
            // 
            this.dataGridContasReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridContasReceber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridContasReceber.Location = new System.Drawing.Point(0, 1);
            this.dataGridContasReceber.Name = "dataGridContasReceber";
            this.dataGridContasReceber.RowTemplate.Height = 25;
            this.dataGridContasReceber.Size = new System.Drawing.Size(799, 437);
            this.dataGridContasReceber.TabIndex = 0;
            // 
            // TelaRelatorioContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridContasReceber);
            this.Name = "TelaRelatorioContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridContasReceber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridContasReceber;
    }
}