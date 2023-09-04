namespace ventana3_lab3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtAdi = new TextBox();
            txtPremio = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 77);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 122);
            label2.Name = "label2";
            label2.Size = new Size(222, 50);
            label2.TabIndex = 1;
            label2.Text = "Cantidad de adivinanzas:\r\n(max.5)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 186);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 2;
            label3.Text = "Premio (en soles):";
            // 
            // txtName
            // 
            txtName.Location = new Point(473, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(473, 136);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(100, 23);
            txtAdi.TabIndex = 4;
            // 
            // txtPremio
            // 
            txtPremio.Location = new Point(473, 186);
            txtPremio.Name = "txtPremio";
            txtPremio.Size = new Size(100, 23);
            txtPremio.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(354, 242);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtPremio);
            Controls.Add(txtAdi);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtAdi;
        private TextBox txtPremio;
        private Button button1;
    }
}