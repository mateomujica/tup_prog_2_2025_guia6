using System.Configuration;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormDatos formDatos = new FormDatos();
            formDatos.ShowDialog();
            bool cerrar = false;
            while (formDatos.DialogResult == DialogResult.OK && cerrar == false)
            {
                string nombre = formDatos.textBox1.Text;


                Persona p = null;

                if (formDatos.radioButton1.Checked)
                {
                    p = new Persona(nombre);
                }
                else if (formDatos.radioButton2.Checked)
                {
                    string cuit = formDatos.textBox2.Text;
                    p = new PersonaJuridica(nombre, cuit);
                }

                if (p != null)
                {
                    personas.Add(p);
                    Actualizar();
                    cerrar = true;
                   
                }
                else
                {
                    MessageBox.Show("Debe elegir un tipo");
                    formDatos.ShowDialog();

                }

            }

        }


        protected void Actualizar()
        {
            listBox1.Items.Clear();

            foreach (Persona p in personas)
            {
                listBox1.Items.Add(p.Describir());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }

}
