using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_P.I
{
    public partial class FormListagemReservas: Form
    {
        public FormListagemReservas()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvReservas.Rows.Add("Ana Clara", "01/05/2025", "19:00", "Mesa 3", "Vegetariana");
        }
    }
}
