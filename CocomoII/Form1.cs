using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CocomoII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private Conexion obDatos;
        private Validacion validar = new Validacion();
        private Procesos procesar = new Procesos();
        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection();
            cn.ConnectionString = "SERVER=localhost;DATABASE=cocomo;UID=root;PASSWORD=;";
            try
            {
                cn.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            cargar_lenguajes();
            cargar_jv();
            cargar_fa();
            seleccionar_combo();
            //procesar.Procesar("hola", "hello", 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1);
        }
        //Cargando los lenguajes al comboBox
        void cargar_lenguajes()
        {
            obDatos = new Conexion();
            this.comboLenguajes.DataSource = obDatos.consultar2("pf_lenguaje");
            this.comboLenguajes.DisplayMember = "nombre";
            this.comboLenguajes.ValueMember = "valor";
            this.comboLenguajes.Refresh();
        }
        //Cargar Valores de las 14 preguntas
        private void cargar_jv()
        {
            obDatos = new Conexion();
            this.jv1.DataSource = obDatos.consultar2("valores14");
            this.jv1.DisplayMember = "significado";
            this.jv1.ValueMember = "valor";
            this.jv1.Refresh();
            this.jv2.DataSource = obDatos.consultar2("valores14");
            this.jv2.DisplayMember = "significado";
            this.jv2.ValueMember = "valor";
            this.jv2.Refresh();
            this.jv3.DataSource = obDatos.consultar2("valores14");
            this.jv3.DisplayMember = "significado";
            this.jv3.ValueMember = "valor";
            this.jv3.Refresh();
            this.jv4.DataSource = obDatos.consultar2("valores14");
            this.jv4.DisplayMember = "significado";
            this.jv4.ValueMember = "valor";
            this.jv4.Refresh();
            this.jv5.DataSource = obDatos.consultar2("valores14");
            this.jv5.DisplayMember = "significado";
            this.jv5.ValueMember = "valor";
            this.jv5.Refresh();
            this.jv6.DataSource = obDatos.consultar2("valores14");
            this.jv6.DisplayMember = "significado";
            this.jv6.ValueMember = "valor";
            this.jv6.Refresh();
            this.jv7.DataSource = obDatos.consultar2("valores14");
            this.jv7.DisplayMember = "significado";
            this.jv7.ValueMember = "valor";
            this.jv7.Refresh();
            this.jv8.DataSource = obDatos.consultar2("valores14");
            this.jv8.DisplayMember = "significado";
            this.jv8.ValueMember = "valor";
            this.jv8.Refresh();
            this.jv9.DataSource = obDatos.consultar2("valores14");
            this.jv9.DisplayMember = "significado";
            this.jv9.ValueMember = "valor";
            this.jv9.Refresh();
            this.jv10.DataSource = obDatos.consultar2("valores14");
            this.jv10.DisplayMember = "significado";
            this.jv10.ValueMember = "valor";
            this.jv10.Refresh();
            this.jv11.DataSource = obDatos.consultar2("valores14");
            this.jv11.DisplayMember = "significado";
            this.jv11.ValueMember = "valor";
            this.jv11.Refresh();
            this.jv12.DataSource = obDatos.consultar2("valores14");
            this.jv12.DisplayMember = "significado";
            this.jv12.ValueMember = "valor";
            this.jv12.Refresh();
            this.jv13.DataSource = obDatos.consultar2("valores14");
            this.jv13.DisplayMember = "significado";
            this.jv13.ValueMember = "valor";
            this.jv13.Refresh();
            this.jv14.DataSource = obDatos.consultar2("valores14");
            this.jv14.DisplayMember = "significado";
            this.jv14.ValueMember = "valor";
            this.jv14.Refresh();
        }
        private void cargar_fa()
        {
            this.fa1.DataSource = obDatos.consultar2("fa where f=0 or f=1");
            this.fa1.DisplayMember = "nombre";
            this.fa1.ValueMember = "valor";
            this.fa1.Refresh();
            this.fa2.DataSource = obDatos.consultar2("fa where f=0 or f=2");
            this.fa2.DisplayMember = "nombre";
            this.fa2.ValueMember = "valor";
            this.fa2.Refresh();
            this.fa3.DataSource = obDatos.consultar2("fa where f=0 or f=3");
            this.fa3.DisplayMember = "nombre";
            this.fa3.ValueMember = "valor";
            this.fa3.Refresh();
            this.fa4.DataSource = obDatos.consultar2("fa where f=0 or f=4");
            this.fa4.DisplayMember = "nombre";
            this.fa4.ValueMember = "valor";
            this.fa4.Refresh();
            this.fa5.DataSource = obDatos.consultar2("fa where f=0 or f=5");
            this.fa5.DisplayMember = "nombre";
            this.fa5.ValueMember = "valor";
            this.fa5.Refresh();
            this.fa6.DataSource = obDatos.consultar2("fa where f=0 or f=6");
            this.fa6.DisplayMember = "nombre";
            this.fa6.ValueMember = "valor";
            this.fa6.Refresh();
            this.fa7.DataSource = obDatos.consultar2("fa where f=0 or f=7");
            this.fa7.DisplayMember = "nombre";
            this.fa7.ValueMember = "valor";
            this.fa7.Refresh();
            this.fa8.DataSource = obDatos.consultar2("fa where f=0 or f=8");
            this.fa8.DisplayMember = "nombre";
            this.fa8.ValueMember = "valor";
            this.fa8.Refresh();
            this.fa9.DataSource = obDatos.consultar2("fa where f=0 or f=9");
            this.fa9.DisplayMember = "nombre";
            this.fa9.ValueMember = "valor";
            this.fa9.Refresh();
            this.fa10.DataSource = obDatos.consultar2("fa where f=0 or f=10");
            this.fa10.DisplayMember = "nombre";
            this.fa10.ValueMember = "valor";
            this.fa10.Refresh();
            this.fa11.DataSource = obDatos.consultar2("fa where f=0 or f=11");
            this.fa11.DisplayMember = "nombre";
            this.fa11.ValueMember = "valor";
            this.fa11.Refresh();
            this.fa12.DataSource = obDatos.consultar2("fa where f=0 or f=12");
            this.fa12.DisplayMember = "nombre";
            this.fa12.ValueMember = "valor";
            this.fa12.Refresh();
            this.fa13.DataSource = obDatos.consultar2("fa where f=0 or f=13");
            this.fa13.DisplayMember = "nombre";
            this.fa13.ValueMember = "valor";
            this.fa13.Refresh();
            this.fa14.DataSource = obDatos.consultar2("fa where f=0 or f=14");
            this.fa14.DisplayMember = "nombre";
            this.fa14.ValueMember = "valor";
            this.fa14.Refresh();
            this.fa15.DataSource = obDatos.consultar2("fa where f=0 or f=15");
            this.fa15.DisplayMember = "nombre";
            this.fa15.ValueMember = "valor";
            this.fa15.Refresh();
        }
        //Seleccionar combo
        void seleccionar_combo()
        {
            comboLenguajes.Text = "C";
            comboLenguajes.Text = "Seleccionar";
        }
        private void comboLenguajes_TextChanged(object sender, EventArgs e)
        {
            PFL.Text = comboLenguajes.SelectedValue.ToString();
        }
        //Calculando valores parciales de la tabla puntos de funcion
        private void PFL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Nentradas.Text = Convert.ToString(procesar.puntos_parciales(Convert.ToInt32(es1.Text), Convert.ToInt32(em1.Text), Convert.ToInt32(ec1.Text), "entradas"));
            }
            catch (Exception)
            {
            }
        }

        private void sc1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Nsalidas.Text = Convert.ToString(procesar.puntos_parciales(Convert.ToInt32(ss1.Text), Convert.ToInt32(sm1.Text), Convert.ToInt32(sc1.Text), "salidas"));
            }
            catch (Exception)
            {
            }
        }

        private void cc1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Nconsultas.Text = Convert.ToString(procesar.puntos_parciales(Convert.ToInt32(cs1.Text), Convert.ToInt32(cm1.Text), Convert.ToInt32(cc1.Text), "consultas"));
            }
            catch (Exception)
            {
            }
        }

        private void ac1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Narchivos.Text = Convert.ToString(procesar.puntos_parciales(Convert.ToInt32(as1.Text), Convert.ToInt32(am1.Text), Convert.ToInt32(ac1.Text), "archivos"));
            }
            catch (Exception)
            {
            }
        }

        private void ic1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Ninterfaces.Text = Convert.ToString(procesar.puntos_parciales(Convert.ToInt32(is1.Text), Convert.ToInt32(im1.Text), Convert.ToInt32(ic1.Text), "interfaces"));
            }
            catch (Exception)
            {
            }
        }
        void inicializar()
        {
            if (es1.Text == "") { es1.Text = "0"; }
            if (em1.Text == "") { em1.Text = "0"; }
            if (ec1.Text == "") { ec1.Text = "0"; }
            if (ss1.Text == "") { ss1.Text = "0"; }
            if (sm1.Text == "") { sm1.Text = "0"; }
            if (sc1.Text == "") { sc1.Text = "0"; }
            if (cs1.Text == "") { cs1.Text = "0"; }
            if (cm1.Text == "") { cm1.Text = "0"; }
            if (cc1.Text == "") { cc1.Text = "0"; }
            if (as1.Text == "") { as1.Text = "0"; }
            if (am1.Text == "") { am1.Text = "0"; }
            if (ac1.Text == "") { ac1.Text = "0"; }
            if (is1.Text == "") { is1.Text = "0"; }
            if (im1.Text == "") { im1.Text = "0"; }
            if (ic1.Text == "") { ic1.Text = "0"; }
        }
        private void Ninterfaces_TextChanged(object sender, EventArgs e)
        {
            totalPFNA.Text=Convert.ToString(procesar.calcular_pfna());
            PFNA.Text = Convert.ToString(procesar.calcular_pfna());
        }

        private void jv14_TextChanged(object sender, EventArgs e)
        {
            Calcular_valor14();
        }
        //Colculo a las 14 prguntas
        private void Calcular_valor14()
        {
            try
            {
                int p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14;
                p1 = Convert.ToInt32(jv1.SelectedValue.ToString());
                p2 = Convert.ToInt32(jv2.SelectedValue.ToString());
                p3 = Convert.ToInt32(jv3.SelectedValue.ToString());
                p4 = Convert.ToInt32(jv4.SelectedValue.ToString());
                p5 = Convert.ToInt32(jv5.SelectedValue.ToString());
                p6 = Convert.ToInt32(jv6.SelectedValue.ToString());
                p7 = Convert.ToInt32(jv7.SelectedValue.ToString());
                p8 = Convert.ToInt32(jv8.SelectedValue.ToString());
                p9 = Convert.ToInt32(jv9.SelectedValue.ToString());
                p10 = Convert.ToInt32(jv10.SelectedValue.ToString());
                p11 = Convert.ToInt32(jv11.SelectedValue.ToString());
                p12 = Convert.ToInt32(jv12.SelectedValue.ToString());
                p13 = Convert.ToInt32(jv13.SelectedValue.ToString());
                p14 = Convert.ToInt32(jv14.SelectedValue.ToString());
                Valor14.Text = Convert.ToString(procesar.calcular_14(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14));
            }
            catch (Exception)
            {

            }
        }
        //Validar solo numeroes en la tabla de puntos de funcion
        private void ic1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.SoloNumeros(e);
        }

        private void Valor14_TextChanged(object sender, EventArgs e)
        {
            calcular_pfa();
            try
            {
                calculo_parcial();
            }
            catch (Exception) { }
        }

        private void calcular_pfa()
        {
            PFA.Text = Convert.ToString(procesar.calcular_pfa());
            try
            {
                calculo_parcial();
            }
            catch (Exception) { }
        }

        private void PFA_TextChanged(object sender, EventArgs e)
        {
            calcular_kloc();
            try
            {
                calculo_parcial();
            }
            catch (Exception) { }
        }
        //Funcion de calculo de KLOC LOC
        private void calcular_kloc()
        {
            KLOC.Text=Convert.ToString(procesar.calcular_kloc(Convert.ToInt32(comboLenguajes.SelectedValue.ToString())));
            LOC.Text = Convert.ToString(procesar.calcular_loc());
            try
            {
                calculo_parcial();
            }
            catch (Exception) { }
        }

        private void KLOC_TextChanged(object sender, EventArgs e)
        {
            asignar_tipo();
            try
            {
                calculo_parcial();
            }
            catch (Exception) { }
        }
        //Asignar tipo de proyecto
        private void asignar_tipo()
        {
            if (nombreP.Text == "")
            {
                MessageBox.Show("Dale nombre a tu proyecto por favor");
            }
            else 
            { 
            }
            type_project.Text = procesar.verificar_tipo();
        }
        //Funcion calcular total
        private void enviar_principales()
        {
                string name = nombreP.Text;
                string lengua = comboLenguajes.Text;
                int puntos_lenguaje = Convert.ToInt32(comboLenguajes.SelectedValue.ToString());
                int entradaS = Convert.ToInt32(es1.Text);
                int entradaM = Convert.ToInt32(em1.Text);
                int entradaC = Convert.ToInt32(ec1.Text);
                int salidaS = Convert.ToInt32(ss1.Text);
                int salidaM = Convert.ToInt32(sm1.Text);
                int salidaC = Convert.ToInt32(sc1.Text);
                int consultaS = Convert.ToInt32(cs1.Text);
                int consultaM = Convert.ToInt32(cm1.Text);
                int consultaC = Convert.ToInt32(cc1.Text);
                int archivoS = Convert.ToInt32(as1.Text);
                int archivoM = Convert.ToInt32(am1.Text);
                int archivoC = Convert.ToInt32(ac1.Text);
                int interfaceS = Convert.ToInt32(is1.Text);
                int interfaceM = Convert.ToInt32(im1.Text);
                int interfaceC = Convert.ToInt32(ic1.Text);
                int pr1 = Convert.ToInt32(jv1.SelectedValue.ToString());
                int pr2 = Convert.ToInt32(jv2.SelectedValue.ToString());
                int pr3 = Convert.ToInt32(jv3.SelectedValue.ToString());
                int pr4 = Convert.ToInt32(jv4.SelectedValue.ToString());
                int pr5 = Convert.ToInt32(jv5.SelectedValue.ToString());
                int pr6 = Convert.ToInt32(jv6.SelectedValue.ToString());
                int pr7 = Convert.ToInt32(jv7.SelectedValue.ToString());
                int pr8 = Convert.ToInt32(jv8.SelectedValue.ToString());
                int pr9 = Convert.ToInt32(jv9.SelectedValue.ToString());
                int pr10 = Convert.ToInt32(jv10.SelectedValue.ToString());
                int pr11 = Convert.ToInt32(jv11.SelectedValue.ToString());
                int pr12 = Convert.ToInt32(jv12.SelectedValue.ToString());
                int pr13 = Convert.ToInt32(jv13.SelectedValue.ToString());
                int pr14 = Convert.ToInt32(jv14.SelectedValue.ToString());
                procesar.evaluar(name, lengua, puntos_lenguaje, entradaS, entradaM, entradaC, salidaS, salidaM, salidaC, consultaS, consultaM, consultaC, archivoS, archivoM, archivoC, interfaceS, interfaceM, interfaceC, pr1, pr2, pr3, pr4, pr5, pr6, pr7, pr8, pr9, pr10, pr11, pr12, pr13, pr14);
        }
        //calcular
        private void calculo_parcial()
        {
            enviar_principales();
            int pr1=Convert.ToInt32(jv1.SelectedValue.ToString());
            int pr2=Convert.ToInt32(jv2.SelectedValue.ToString());
            int pr3=Convert.ToInt32(jv3.SelectedValue.ToString());
            int pr4=Convert.ToInt32(jv4.SelectedValue.ToString());
            int pr5=Convert.ToInt32(jv5.SelectedValue.ToString());
            int pr6=Convert.ToInt32(jv6.SelectedValue.ToString());
            int pr7=Convert.ToInt32(jv7.SelectedValue.ToString());
            int pr8=Convert.ToInt32(jv8.SelectedValue.ToString());
            int pr9=Convert.ToInt32(jv9.SelectedValue.ToString());
            int pr10=Convert.ToInt32(jv10.SelectedValue.ToString());
            int pr11=Convert.ToInt32(jv11.SelectedValue.ToString());
            int pr12=Convert.ToInt32(jv12.SelectedValue.ToString());
            int pr13=Convert.ToInt32(jv13.SelectedValue.ToString());
            int pr14=Convert.ToInt32(jv14.SelectedValue.ToString());
            totalPFNA.Text = Convert.ToString(procesar.calcular_pfna());
            PFNA.Text = Convert.ToString(procesar.calcular_pfna());
            Valor14.Text = Convert.ToString(procesar.calcular_14(pr1,pr2,pr3,pr4,pr5,pr6,pr7,pr8,pr9,pr10,pr11,pr12,pr13,pr14));
            PFA.Text = Convert.ToString(procesar.calcular_pfa());
            KLOC.Text = Convert.ToString(procesar.calcular_kloc(Convert.ToInt32(comboLenguajes.SelectedValue.ToString())));
            LOC.Text = Convert.ToString(procesar.calcular_loc());
            type_project.Text = procesar.verificar_tipo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PFL.Text == "0" && nombreP.Text == "")
            {
                if (PFL.Text == "0")
                {
                    MessageBox.Show("Seleccione un lenguaje para calcular cocomo");
                }
                if (nombreP.Text == "")
                {
                    MessageBox.Show("ingrese un nombre para este proyecto");
                }
            }
            else
            {
                inicializar();
                calculo_parcial();
                BasicoE.Text = procesar.Esfuerzo_basico();
                BasicoT.Text = procesar.Tiempo_basico();
                BasicoProb.Text = procesar.Prob_basico();
                BasicoP.Text = procesar.Personas_basico();
                //Calculando cocomo modelo intermedio
                send_fa();
                FA.Text = Convert.ToString(procesar.factor_ajuste());
                IntermedioE.Text = procesar.Esfuerzo_intermedio();
                IntermedioT.Text = procesar.Tiempo_intermedio();
                IntermedioProb.Text = procesar.Prob_intermedio();
                IntermedioP.Text = procesar.Personas_intermedio();
                //Mostrando modelo avanzado
                E_req.Text = procesar.E_requerimiento();
                E_dis_prod.Text = procesar.E_diseño_producto();
                E_prog.Text = procesar.E_programacion();
                E_dis_det.Text = procesar.E_diseño_detallado();
                E_cod_tes.Text = procesar.E_codificacion_testeo();
                E_int_tes.Text = procesar.E_integracion_testeo();
            }
        }
        private void send_fa()
        {
            double q1 = Convert.ToDouble(fa1.SelectedValue.ToString());
            double q2 = Convert.ToDouble(fa2.SelectedValue.ToString());
            double q3 = Convert.ToDouble(fa3.SelectedValue.ToString());
            double q4 = Convert.ToDouble(fa4.SelectedValue.ToString());
            double q5 = Convert.ToDouble(fa5.SelectedValue.ToString());
            double q6 = Convert.ToDouble(fa6.SelectedValue.ToString());
            double q7 = Convert.ToDouble(fa7.SelectedValue.ToString());
            double q8 = Convert.ToDouble(fa8.SelectedValue.ToString());
            double q9 = Convert.ToDouble(fa9.SelectedValue.ToString());
            double q10 = Convert.ToDouble(fa10.SelectedValue.ToString());
            double q11 = Convert.ToDouble(fa11.SelectedValue.ToString());
            double q12 = Convert.ToDouble(fa12.SelectedValue.ToString());
            double q13 = Convert.ToDouble(fa13.SelectedValue.ToString());
            double q14 = Convert.ToDouble(fa14.SelectedValue.ToString());
            double q15 = Convert.ToDouble(fa15.SelectedValue.ToString());
            procesar.calcular_fa(q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15);
        }
        private MessageBoxButtons aceptar;
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (KLOC.Text != "0")
            {
                aceptar = MessageBoxButtons.OKCancel;
                DialogResult result =
                MessageBox.Show("Los progresos que hiciste de tu estimacion se borraran desea seguir con el procedimiento?...", "Advertencia", aceptar);
                switch (result)
                {
                    case DialogResult.OK:
                        Application.Restart();
                        break;
                }
            }
            else
            {
                Application.Restart();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
                aceptar = MessageBoxButtons.OKCancel;
                DialogResult result =
                MessageBox.Show("Desea salir de la aplicacion?...", "Advertencia", aceptar);
                switch (result)
                {
                    case DialogResult.OK:
                        this.Close();
                        break;
                }
        }

        private void ic1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ic1_TabStopChanged(object sender, EventArgs e)
        {
            inicializar();
        }

  

    }
}
