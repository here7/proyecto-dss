﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InfoCostePrograma
{
    public partial class GestionarClientes : Form
    {
        public GestionarClientes()
        {
            InitializeComponent();
        }

        private void GestionarClientes_Load(object sender, EventArgs e)
        {
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN ccen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN> listaClientes = ccen.LeerTodos(0, 100);

            dataGridView_GestionarClientes.Rows.Clear();
            foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN c in listaClientes)
            {
                bool empresa = false;
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
                try {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEmpresaEN ceEN = ceCEN.LeerPorOID(c.Id);
                    if(ceEN != null)
                        empresa = true; 
                }
                catch (Exception ex) { }
                dataGridView_GestionarClientes.Rows.Add(c.Id, c.NombreCompleto, c.Direccion, c.Telefono, c.Email, empresa);
            }

           
        }

        private void dataGridView_GestionarClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente nc = new NuevoCliente();
            nc.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ver_presupuestos vp = new Ver_presupuestos();
            vp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ver_reservas vr = new ver_reservas();
            vr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow current = dataGridView_GestionarClientes.CurrentRow;

            NuevoCliente c = new NuevoCliente(current.Cells[0].Value.ToString());
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro desea eliminar este cliente?", "Clientes", MessageBoxButtons.OKCancel);

            DataGridViewRow current = dataGridView_GestionarClientes.CurrentRow;

            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN ccen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
            ccen.Borrar(current.Cells[0].Value.ToString());


            GestionarClientes_Load(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nombre del trabajador?");
            InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN ccen = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteCEN();
            IList<InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN> lc =  ccen.LeerPorNombre(input);

            dataGridView_GestionarClientes.Rows.Clear();
            foreach (InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEN c in lc)
            {
                bool empresa = false;
                InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN ceCEN = new InfoCosteProgramaGenNHibernate.CEN.InfoCoste.ClienteEmpresaCEN();
                try
                {
                    InfoCosteProgramaGenNHibernate.EN.InfoCoste.ClienteEmpresaEN ceEN = ceCEN.LeerPorOID(c.Id);
                    if (ceEN != null)
                        empresa = true;
                }
                catch (Exception ex) { }
                dataGridView_GestionarClientes.Rows.Add(c.Id, c.NombreCompleto, c.Direccion, c.Telefono, c.Email, empresa);
            }
        }
    }
}
