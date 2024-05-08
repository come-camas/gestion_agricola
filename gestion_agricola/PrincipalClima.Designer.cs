namespace gestion_agricola
{
    partial class PrincipalClima
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
            lbBienvenida = new Label();
            btnAH = new Button();
            btnAM = new Button();
            btnInforme = new Button();
            SuspendLayout();
            // 
            // lbBienvenida
            // 
            lbBienvenida.AutoSize = true;
            lbBienvenida.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbBienvenida.Location = new Point(163, 9);
            lbBienvenida.Name = "lbBienvenida";
            lbBienvenida.Size = new Size(241, 27);
            lbBienvenida.TabIndex = 0;
            lbBienvenida.Text = "ANALISIS DEL CLIMA ";
            lbBienvenida.Click += lbBienvenida_Click;
            // 
            // btnAH
            // 
            btnAH.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAH.Location = new Point(12, 83);
            btnAH.Name = "btnAH";
            btnAH.Size = new Size(138, 37);
            btnAH.TabIndex = 1;
            btnAH.Text = "Analisis Hoy";
            btnAH.UseVisualStyleBackColor = true;
            // 
            // btnAM
            // 
            btnAM.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAM.Location = new Point(178, 83);
            btnAM.Name = "btnAM";
            btnAM.Size = new Size(226, 37);
            btnAM.TabIndex = 2;
            btnAM.Text = "Analisis Periodo 15-30 dias";
            btnAM.UseVisualStyleBackColor = true;
            // 
            // btnInforme
            // 
            btnInforme.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInforme.Location = new Point(410, 83);
            btnInforme.Name = "btnInforme";
            btnInforme.Size = new Size(156, 37);
            btnInforme.TabIndex = 3;
            btnInforme.Text = "Informe Analisis";
            btnInforme.UseVisualStyleBackColor = true;
            // 
            // PrincipalClima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 309);
            Controls.Add(btnInforme);
            Controls.Add(btnAM);
            Controls.Add(btnAH);
            Controls.Add(lbBienvenida);
            Name = "PrincipalClima";
            Text = "PrincipalClima";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBienvenida;
        private Button btnAH;
        private Button btnAM;
        private Button btnInforme;
    }
}