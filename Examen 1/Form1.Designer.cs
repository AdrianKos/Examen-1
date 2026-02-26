namespace Examen_1
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
            btn_Calcular = new Button();
            TB_Sueldo = new TextBox();
            label1 = new Label();
            LBL_SueldoNeto = new Label();
            LBL_ISR = new Label();
            SuspendLayout();
            // 
            // btn_Calcular
            // 
            btn_Calcular.Location = new Point(193, 41);
            btn_Calcular.Name = "btn_Calcular";
            btn_Calcular.Size = new Size(75, 23);
            btn_Calcular.TabIndex = 0;
            btn_Calcular.Text = "Calcular ISR";
            btn_Calcular.UseVisualStyleBackColor = true;
            btn_Calcular.Click += btn_Calcular_Click;
            // 
            // TB_Sueldo
            // 
            TB_Sueldo.Location = new Point(12, 41);
            TB_Sueldo.Name = "TB_Sueldo";
            TB_Sueldo.Size = new Size(175, 23);
            TB_Sueldo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Sueldo";
            // 
            // LBL_SueldoNeto
            // 
            LBL_SueldoNeto.AutoSize = true;
            LBL_SueldoNeto.Location = new Point(12, 96);
            LBL_SueldoNeto.Name = "LBL_SueldoNeto";
            LBL_SueldoNeto.Size = new Size(75, 15);
            LBL_SueldoNeto.TabIndex = 3;
            LBL_SueldoNeto.Text = "Sueldo Neto:";
            // 
            // LBL_ISR
            // 
            LBL_ISR.AutoSize = true;
            LBL_ISR.Location = new Point(12, 130);
            LBL_ISR.Name = "LBL_ISR";
            LBL_ISR.Size = new Size(29, 15);
            LBL_ISR.TabIndex = 4;
            LBL_ISR.Text = "ISR: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(285, 213);
            Controls.Add(LBL_ISR);
            Controls.Add(LBL_SueldoNeto);
            Controls.Add(label1);
            Controls.Add(TB_Sueldo);
            Controls.Add(btn_Calcular);
            Name = "Form1";
            Text = "Calculo de ISR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Calcular;
        private TextBox TB_Sueldo;
        private Label label1;
        private Label LBL_SueldoNeto;
        private Label LBL_ISR;
    }
}
