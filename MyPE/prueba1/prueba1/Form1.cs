using prueba1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Obtener el texto del TextBox y dividirlo en nombres (por líneas)
            string[] nombres = txtNombres.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Limpiar la lista de resultados antes de mostrar los nuevos
            lstResultados.Items.Clear();

            // Asegurarse de que se han ingresado al menos 25 nombres
            if (nombres.Length < 25)
            {
                MessageBox.Show("Por favor, ingrese al menos 25 nombres.");
                return;
            }

            // Procesar cada nombre y verificar su longitud usando la clase Estudiante
            for (int i = 0; i < nombres.Length; i++)
            {
                Estudiante estudiante = new Estudiante(nombres[i]);
                if (estudiante.EsNombreLargo())
                {
                    lstResultados.Items.Add(estudiante.NombreCompleto);
                }
            }
        }
    }
}
