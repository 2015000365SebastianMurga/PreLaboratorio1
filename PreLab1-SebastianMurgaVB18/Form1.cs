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
            {                   //lo escrito sea la contrase�a correcta
                MessageBox.Show("La contrase�a es correcta, Bienvenido"
                , "PreLaboratorio");//Una ventana que dice que est� correcta la contrase�a
                CRUD no = new CRUD();
                no.ShowDialog();//Abre la ventana del crud, y no permite editar esta 
            }else
            {
                MessageBox.Show("La contrase�a es incorrecta, Intentalo de Nuevo",
                    "PreLaboratorio");//Una ventana que dice que no es correcta la contrase�a
                txt1.Text = "";//Vac�a la caja de texto para intentarlo otra vez
            }
        }
    }
}
