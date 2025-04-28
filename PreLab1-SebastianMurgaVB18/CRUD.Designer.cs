namespace PreLab1_SebastianMurgaVB18
{
    partial class CRUD
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
            label1 = new Label();
            DATAGRID = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            grado = new DataGridViewTextBoxColumn();
            seccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            ciclo = new DataGridViewTextBoxColumn();
            maestro = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            añoentrada = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcodigo = new TextBox();
            txtgrado = new TextBox();
            txtseccion = new TextBox();
            txttelefono = new TextBox();
            label11 = new Label();
            txtmaestro = new TextBox();
            txtciclo = new TextBox();
            txtmatricula = new TextBox();
            txtprimer = new TextBox();
            txtedad = new TextBox();
            btnEliminar = new Button();
            button1 = new Button();
            btnRegistro = new Button();
            btnlimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)DATAGRID).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(627, 12);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // DATAGRID
            // 
            DATAGRID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DATAGRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DATAGRID.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, codigo, grado, seccion, telefono, matricula, ciclo, maestro, edad, añoentrada });
            DATAGRID.GridColor = Color.Snow;
            DATAGRID.Location = new Point(12, 12);
            DATAGRID.Name = "DATAGRID";
            DATAGRID.Size = new Size(597, 250);
            DATAGRID.TabIndex = 1;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            // 
            // grado
            // 
            grado.HeaderText = "Grado";
            grado.Name = "grado";
            // 
            // seccion
            // 
            seccion.HeaderText = "Sección";
            seccion.Name = "seccion";
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            // 
            // matricula
            // 
            matricula.HeaderText = "Matrícula";
            matricula.Name = "matricula";
            // 
            // ciclo
            // 
            ciclo.HeaderText = "Ciclo Académico";
            ciclo.Name = "ciclo";
            // 
            // maestro
            // 
            maestro.HeaderText = "Maestro";
            maestro.Name = "maestro";
            // 
            // edad
            // 
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            // 
            // añoentrada
            // 
            añoentrada.HeaderText = "Primer Año";
            añoentrada.Name = "añoentrada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(627, 41);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(633, 289);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 259);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Maestro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(615, 226);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Ciclo Acad.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(621, 194);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 5;
            label6.Text = "Matrícula";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(627, 165);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 6;
            label7.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(627, 131);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 7;
            label8.Text = "Sección";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(627, 99);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 8;
            label9.Text = "Grado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(627, 73);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 9;
            label10.Text = "Código";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(684, 12);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(164, 23);
            txtnombre.TabIndex = 10;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(684, 41);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(164, 23);
            txtapellido.TabIndex = 11;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(684, 70);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(164, 23);
            txtcodigo.TabIndex = 12;
            // 
            // txtgrado
            // 
            txtgrado.Location = new Point(684, 99);
            txtgrado.Name = "txtgrado";
            txtgrado.Size = new Size(164, 23);
            txtgrado.TabIndex = 13;
            // 
            // txtseccion
            // 
            txtseccion.Location = new Point(684, 128);
            txtseccion.Name = "txtseccion";
            txtseccion.Size = new Size(164, 23);
            txtseccion.TabIndex = 14;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(684, 157);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(164, 23);
            txttelefono.TabIndex = 15;
            txttelefono.TextChanged += textBox6_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(611, 321);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 2;
            label11.Text = "Primer Año";
            // 
            // txtmaestro
            // 
            txtmaestro.Location = new Point(684, 252);
            txtmaestro.Name = "txtmaestro";
            txtmaestro.Size = new Size(164, 23);
            txtmaestro.TabIndex = 18;
            // 
            // txtciclo
            // 
            txtciclo.Location = new Point(684, 223);
            txtciclo.Name = "txtciclo";
            txtciclo.Size = new Size(164, 23);
            txtciclo.TabIndex = 17;
            // 
            // txtmatricula
            // 
            txtmatricula.Location = new Point(684, 194);
            txtmatricula.Name = "txtmatricula";
            txtmatricula.Size = new Size(164, 23);
            txtmatricula.TabIndex = 16;
            // 
            // txtprimer
            // 
            txtprimer.Location = new Point(684, 318);
            txtprimer.Name = "txtprimer";
            txtprimer.Size = new Size(164, 23);
            txtprimer.TabIndex = 20;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(684, 289);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(164, 23);
            txtedad.TabIndex = 19;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(254, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Location = new Point(36, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "CRÉDITOS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(150, 299);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(75, 23);
            btnRegistro.TabIndex = 21;
            btnRegistro.Text = "REGISTRAR";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(356, 299);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(75, 23);
            btnlimpiar.TabIndex = 22;
            btnlimpiar.Text = "LIMPIAR";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(860, 363);
            Controls.Add(btnlimpiar);
            Controls.Add(button1);
            Controls.Add(btnRegistro);
            Controls.Add(btnEliminar);
            Controls.Add(txtprimer);
            Controls.Add(txtedad);
            Controls.Add(txtmaestro);
            Controls.Add(txtciclo);
            Controls.Add(txtmatricula);
            Controls.Add(txttelefono);
            Controls.Add(txtseccion);
            Controls.Add(txtgrado);
            Controls.Add(txtcodigo);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(DATAGRID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CRUD";
            Text = "CRUD";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)DATAGRID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DATAGRID;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcodigo;
        private TextBox txtgrado;
        private TextBox txtseccion;
        private TextBox txttelefono;
        private Label label11;
        private TextBox txtmaestro;
        private TextBox txtciclo;
        private TextBox txtmatricula;
        private TextBox txtprimer;
        private TextBox txtedad;
        private Button btnEliminar;
        private Button button1;
        private Button btnRegistro;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn grado;
        private DataGridViewTextBoxColumn seccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn ciclo;
        private DataGridViewTextBoxColumn maestro;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn añoentrada;
        private Button btnlimpiar;
    }
}