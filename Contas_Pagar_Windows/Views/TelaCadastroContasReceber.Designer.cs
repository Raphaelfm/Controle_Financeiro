namespace Contas_Pagar_Windows.Views
{
    partial class TelaCadastroContasReceber
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.dataPickerContPagar = new System.Windows.Forms.DateTimePicker();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.labelObservaco = new System.Windows.Forms.Label();
            this.textBoxOrigem = new System.Windows.Forms.TextBox();
            this.labelOrigem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(10, 271);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(417, 23);
            this.buttonCadastrar.TabIndex = 15;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // dataPickerContPagar
            // 
            this.dataPickerContPagar.Location = new System.Drawing.Point(14, 221);
            this.dataPickerContPagar.Name = "dataPickerContPagar";
            this.dataPickerContPagar.Size = new System.Drawing.Size(200, 23);
            this.dataPickerContPagar.TabIndex = 14;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(12, 172);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(110, 23);
            this.textBoxValor.TabIndex = 13;
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(12, 154);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(33, 15);
            this.labelValor.TabIndex = 12;
            this.labelValor.Text = "Valor";
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Location = new System.Drawing.Point(12, 102);
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(328, 23);
            this.textBoxObservacao.TabIndex = 11;
            // 
            // labelObservaco
            // 
            this.labelObservaco.AutoSize = true;
            this.labelObservaco.Location = new System.Drawing.Point(12, 84);
            this.labelObservaco.Name = "labelObservaco";
            this.labelObservaco.Size = new System.Drawing.Size(69, 15);
            this.labelObservaco.TabIndex = 10;
            this.labelObservaco.Text = "Observação";
            // 
            // textBoxOrigem
            // 
            this.textBoxOrigem.Location = new System.Drawing.Point(12, 36);
            this.textBoxOrigem.Name = "textBoxOrigem";
            this.textBoxOrigem.Size = new System.Drawing.Size(328, 23);
            this.textBoxOrigem.TabIndex = 9;
            // 
            // labelOrigem
            // 
            this.labelOrigem.AutoSize = true;
            this.labelOrigem.Location = new System.Drawing.Point(12, 18);
            this.labelOrigem.Name = "labelOrigem";
            this.labelOrigem.Size = new System.Drawing.Size(47, 15);
            this.labelOrigem.TabIndex = 8;
            this.labelOrigem.Text = "Origem";
            // 
            // TelaCadastroContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 301);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataPickerContPagar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(this.labelObservaco);
            this.Controls.Add(this.textBoxOrigem);
            this.Controls.Add(this.labelOrigem);
            this.Name = "TelaCadastroContasReceber";
            this.Text = "Cadastro de Contas a Receber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCadastrar;
        private DateTimePicker dataPickerContPagar;
        private TextBox textBoxValor;
        private Label labelValor;
        private TextBox textBoxObservacao;
        private Label labelObservaco;
        private TextBox textBoxOrigem;
        private Label labelOrigem;
    }
}