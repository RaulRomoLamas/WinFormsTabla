namespace WinFormsTabla
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
            panelPrincipal = new Panel();
            NOMBRE = new Label();
            richTextResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            LabelTitulo = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.GradientActiveCaption;
            panelPrincipal.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_11_14_at_18_22_50_4d9d4342;
            panelPrincipal.Controls.Add(NOMBRE);
            panelPrincipal.Controls.Add(richTextResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(LabelTitulo);
            panelPrincipal.Cursor = Cursors.Hand;
            panelPrincipal.ForeColor = Color.Black;
            panelPrincipal.Location = new Point(13, 9);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(615, 442);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // NOMBRE
            // 
            NOMBRE.AutoSize = true;
            NOMBRE.BackColor = Color.DarkGreen;
            NOMBRE.Font = new Font("Segoe Print", 12F, FontStyle.Italic, GraphicsUnit.Point);
            NOMBRE.ForeColor = Color.White;
            NOMBRE.Location = new Point(42, 381);
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Size = new Size(298, 35);
            NOMBRE.TabIndex = 5;
            NOMBRE.Text = "Raul Romo Lamas 426723";
            // 
            // richTextResultados
            // 
            richTextResultados.BackColor = Color.DarkGreen;
            richTextResultados.Cursor = Cursors.Hand;
            richTextResultados.Font = new Font("Segoe Script", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            richTextResultados.ForeColor = Color.White;
            richTextResultados.Location = new Point(301, 77);
            richTextResultados.Name = "richTextResultados";
            richTextResultados.Size = new Size(226, 290);
            richTextResultados.TabIndex = 4;
            richTextResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = Color.Chocolate;
            buttonVer.Font = new Font("Segoe Print", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            buttonVer.ForeColor = Color.White;
            buttonVer.Location = new Point(81, 189);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(125, 42);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.BackColor = Color.Green;
            textBoxNum.Font = new Font("Segoe Print", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxNum.ForeColor = Color.White;
            textBoxNum.Location = new Point(81, 143);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(125, 39);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = Color.DarkGreen;
            labelNumero.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumero.ForeColor = Color.White;
            labelNumero.Location = new Point(76, 101);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(175, 30);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "Cual tabla quieres?";
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.BackColor = Color.DarkGreen;
            LabelTitulo.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitulo.ForeColor = Color.White;
            LabelTitulo.Location = new Point(73, 46);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(218, 35);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "Tabla de Multiplicar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = "Form1";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label labelNumero;
        private Label LabelTitulo;
        private Button buttonVer;
        private TextBox textBoxNum;
        private RichTextBox richTextResultados;
        private Label NOMBRE;
    }
}
