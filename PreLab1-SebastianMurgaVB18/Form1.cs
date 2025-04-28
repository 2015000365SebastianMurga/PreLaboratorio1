namespace PreLab1_SebastianMurgaVB18
{
    public partial class Form1 : Form
    {
        public Form1()
        {//Constructor
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (txt1.Text=="999")//Condicional IF que comprueba que                               
            {                   //lo escrito sea la contraseña correcta
                MessageBox.Show("La contraseña es correcta, Bienvenido"
                , "PreLaboratorio");//Una ventana que dice que está correcta la contraseña
                CRUD no = new CRUD();
                no.ShowDialog();//Abre la ventana del crud, y no permite editar esta 
            }else
            {
                MessageBox.Show("La contraseña es incorrecta, Intentalo de Nuevo",
                    "PreLaboratorio");//Una ventana que dice que no es correcta la contraseña
                txt1.Text = "";//Vacía la caja de texto para intentarlo otra vez
            }
        }
    }
}
