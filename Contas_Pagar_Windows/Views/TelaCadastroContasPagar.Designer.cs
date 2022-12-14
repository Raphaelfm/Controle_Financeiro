namespace Contas_Pagar_Windows.Views
{
    partial class TelaCadastroContasPagar
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
            this.textBoxRecebedor = new System.Windows.Forms.TextBox();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.labelObservaco = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.dataPickerContPagar = new System.Windows.Forms.DateTimePicker();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recebedor";
            // 
            // textBoxRecebedor
            // 
            this.textBoxRecebedor.Location = new System.Drawing.Point(12, 53);
            this.textBoxRecebedor.Name = "textBoxRecebedor";
            this.textBoxRecebedor.Size = new System.Drawing.Size(328, 23);
            this.textBoxRecebedor.TabIndex = 1;
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Location = new System.Drawing.Point(12, 119);
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(328, 23);
            this.textBoxObservacao.TabIndex = 3;
            // 
            // labelObservaco
            // 
            this.labelObservaco.AutoSize = true;
            this.labelObservaco.Location = new System.Drawing.Point(12, 101);
            this.labelObservaco.Name = "labelObservaco";
            this.labelObservaco.Size = new System.Drawing.Size(69, 15);
            this.labelObservaco.TabIndex = 2;
            this.labelObservaco.Text = "Observação";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(12, 171);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(33, 15);
            this.labelValor.TabIndex = 4;
            this.labelValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(12, 189);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(110, 23);
            this.textBoxValor.TabIndex = 5;
            // 
            // dataPickerContPagar
            // 
            this.dataPickerContPagar.Location = new System.Drawing.Point(14, 238);
            this.dataPickerContPagar.Name = "dataPickerContPagar";
            this.dataPickerContPagar.Size = new System.Drawing.Size(200, 23);
            this.dataPickerContPagar.TabIndex = 6;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(10, 288);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(417, 23);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // TelaCadastroContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 314);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataPickerContPagar);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(this.labelObservaco);
            this.Controls.Add(this.textBoxRecebedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaCadastroContasPagar";
            this.Text = "Cadastro de Contas a Pagar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxRecebedor;
        private TextBox textBoxObservacao;
        private Label labelObservaco;
        private Label labelValor;
        private TextBox textBoxValor;
        private DateTimePicker dataPickerContPagar;
        private Button buttonCadastrar;
    }
}