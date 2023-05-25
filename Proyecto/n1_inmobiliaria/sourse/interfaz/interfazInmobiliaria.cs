using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using n1_inmobiliaria.source.mundo;
using n1_inmobiliaria.sourse.interfaz;
using n1_inmobiliaria.sourse.mundo;

namespace n1_inmobiliaria.sourse.interfaz
{
    public partial class interfazInmobiliaria : Form
    {
        Inmobiliaria unainmobiliaria;
        public interfazInmobiliaria()
        {
            InitializeComponent();
            inicializar();
        }

        private void interfazInmobiliaria_Load(object sender, EventArgs e)
        {

        }
        public void inicializar()
        {
            unainmobiliaria = new Inmobiliaria();
            unainmobiliaria.inicializar();
            asignarInformacionMansion1();
            asignarInformacionMansion2();
            asignarInformacionMansion3();
            asignarCostoAbministrativo();
            asignarCostoPromedio(); 
        }
        //Metodo pára asignar la informasion de la mansion 1
        public void asignarInformacionMansion1()
        {
            Mansion mansion1 = unainmobiliaria.darMancion1();
            txtCostoLimpiezaMancion1.Text = mansion1.calcularCostoLimpieza().ToString();
            txtCostoSeguridadMansion1.Text = mansion1.calcularCostoServicios().ToString();
            txtCostoServicioMansion1.Text = mansion1.calcularCostoSeguridad().ToString();
        }
        //Metodo pára asignar la informasion de la mansion 2
        public void asignarInformacionMansion2()
        {
            Mansion mansion2 = unainmobiliaria.darMancion2();
            txtCostoLimpiezaMancion2.Text = mansion2.calcularCostoLimpieza().ToString();
            txtCostoSeguridadMansion2.Text = mansion2.calcularCostoServicios().ToString();
            txtCostoServicioMansion2.Text = mansion2.calcularCostoSeguridad().ToString();
        }
        //Metodo pára asignar la informasion de la mansion 1
        public void asignarInformacionMansion3()
        {
            Mansion mansion3 = unainmobiliaria.darMancion3();
            txtCostoLimpiezaMancion3.Text = mansion3.calcularCostoLimpieza().ToString();
            txtCostoSeguridadMansion3.Text = mansion3.calcularCostoServicios().ToString();
            txtCostoServicioMansion3.Text = mansion3.calcularCostoSeguridad().ToString();
        }
        //Metodo para asignar costo acministrativo
        public void asignarCostoAbministrativo()
        {
            txtCostoAbministrativo.Text = unainmobiliaria.calcularCostoAdministrativo().ToString();
        }
        //Metodo para asignar costo promedio
        public void asignarCostoPromedio()
        {
            txtCostoPromedioServicios.Text = unainmobiliaria.calcularCostoPromedioServicios().ToString();
        }


        void modificarDatosMansion1()
        {
            Form1 f1 = new Form1();
           DialogResult dr = f1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                unainmobiliaria.actualizarDatosMancion1(int.Parse(f1.txtHabitantes.Text), int.Parse(f1.txtParqueaderos.Text), int.Parse(f1.txtEmpleados.Text), int.Parse(f1.txtPrecio.Text), int.Parse(f1.txtTamanio.Text));
                asignarInformacionMansion1();
                asignarCostoAbministrativo();
                asignarCostoPromedio();
            }
        }
        void modificarDatosMansion2()
        {
            Form1 f1 = new Form1();
            DialogResult dr = f1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                unainmobiliaria.actualizarDatosMancion2(int.Parse(f1.txtHabitantes.Text), int.Parse(f1.txtParqueaderos.Text), int.Parse(f1.txtEmpleados.Text), int.Parse(f1.txtPrecio.Text), int.Parse(f1.txtTamanio.Text));
                asignarInformacionMansion2();
                asignarCostoAbministrativo();
                asignarCostoPromedio();
            }
        }
        void modificarDatosMansion3()
        {
            Form1 f1 = new Form1();
            DialogResult dr = f1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                unainmobiliaria.actualizarDatosMancion3(int.Parse(f1.txtHabitantes.Text), int.Parse(f1.txtParqueaderos.Text), int.Parse(f1.txtEmpleados.Text), int.Parse(f1.txtPrecio.Text), int.Parse(f1.txtTamanio.Text));
                asignarInformacionMansion3();
                asignarCostoAbministrativo();
                asignarCostoPromedio();
            }
        }
        private void botonActualizarMansion1_Click(object sender, EventArgs e)
        {
            modificarDatosMansion1();
        }

        private void botonActualizarMansion2_Click(object sender, EventArgs e)
        {
            modificarDatosMansion2();
        }

        private void botonActualizarMansion3_Click(object sender, EventArgs e)
        {
            modificarDatosMansion3();
        }
    }
}
