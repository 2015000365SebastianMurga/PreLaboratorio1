namespace PreLab1_SebastianMurgaVB18
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
            txt1 = new TextBox();
            b1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arista Pro Alternate Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 46);
            label1.Name = "label1";
            label1.Size = new Size(320, 27);
            label1.TabIndex = 0;
            label1.Text = "Login - CRUD - PreLaboratorio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 145);
            label2.Name = "label2";
            label2.Size = new Size(240, 21);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la contraseña correcta";
            // 
            // txt1
            // 
            txt1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt1.Location = new Point(89, 216);
            txt1.Name = "txt1";
            txt1.PasswordChar = '*';
            txt1.Size = new Size(320, 23);
            txt1.TabIndex = 2;
            // 
            // b1
            // 
            b1.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b1.Location = new Point(173, 277);
            b1.Name = "b1";
            b1.Size = new Size(139, 34);
            b1.TabIndex = 3;
            b1.Text = "INGRESAR";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(491, 375);
            Controls.Add(b1);
            Controls.Add(txt1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "LOGIN";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt1;
        private Button b1;
    }
}
