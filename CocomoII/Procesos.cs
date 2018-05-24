using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CocomoII
{
    class Procesos
    {
        public MySqlConnection cn;
        string nombre;
        string lenguaje;
        int valLenguaje;
        //Variables de cantidad de puntos de funcion
        int entradaSimple;
        int entradaMedia;
        int entradaCompleja;
        int salidaSimple;
        int salidaMedia;
        int salidaCompleja;
        int consultaSimple;
        int consultaMedia;
        int consultaCompleja;
        int archivoSimple;
        int archivoMedia;
        int archivoCompleja;
        int interfaceSimple;
        int interfaceMedia;
        int interfaceCompleja;
        //Valores de puntos de funcion
        int EPS=3;
        int EPM=4;
        int EPC=6;
        int SPS=4;
        int SPM=5;
        int SPC=7;
        int CPS=3;
        int CPM=4;
        int CPC=6;
        int APS=7;
        int APM=10;
        int APC=15;
        int IPS=5;
        int IPM=7;
        int IPC=10;
        //Valores de las 14 preguntas
        int p1;
        int p2;
        int p3;
        int p4;
        int p5;
        int p6;
        int p7;
        int p8;
        int p9;
        int p10;
        int p11;
        int p12;
        int p13;
        int p14;
        int val14;
        //Valores de las variables dependientes
        int pfna;
        double pfa;
        double kloc;
        double loc;
        string tipo_proyecto;
        //Valor de variables modelo basico
        double a;
        double b;
        double c;
        double d;
        double esfuerzo_basico;
        double tiempo_basico;
        double probabilidad_basico;
        double personas_basico;
        //Modelo intermedio
        double fa;
        double ai;
        double bi;
        double ci;
        double di;
        double esfuerzo_intermedio;
        double tiempo_intermedio;
        double probabilidad_intermedio;
        double personas_intermedio;
        //modelo avanzado
        double e_requerimientos;
        double e_diseño_producto;
        double e_programacion;
        double e_diseño_detallado;
        double e_codificacion_testeo;
        double e_integracion_testeo;

        public Procesos(string name, string lengua, int entradaS, int entradaM, int entradaC, int salidaS, int salidaM, int salidaC, int consultaS, int consultaM, int consultaC, int archivoS,int archivoM, int archivoC, int interfaceS, int interfaceM, int interfaceC,int pr1,int pr2,int pr3,int pr4,int pr5,int pr6,int pr7,int pr8,int pr9,int pr10,int pr11,int pr12,int pr13,int pr14)
        {
            nombre = name;
            lenguaje = lengua;
            entradaSimple = entradaS;
            entradaMedia = entradaM;
            entradaCompleja = entradaC;
            salidaSimple = salidaS;
            salidaMedia = salidaM;
            salidaCompleja = salidaC;
            consultaSimple = consultaS;
            consultaMedia = consultaM;
            consultaCompleja = consultaC;
            archivoSimple = archivoS;
            archivoMedia = archivoM;
            archivoCompleja = archivoC;
            interfaceSimple = interfaceS;
            interfaceMedia = interfaceM;
            interfaceCompleja = interfaceC;
            p1 = pr1;
            p2 = pr2;
            p3 = pr3;
            p4 = pr4;
            p5 = pr5;
            p6 = pr6;
            p7 = pr7;
            p8 = pr8;
            p9 = pr9;
            p10 = pr10;
            p11 = pr11;
            p12 = pr12;
            p13 = pr13;
            p14 = pr14;
        }

        public Procesos()
        {
            // TODO: Complete member initialization
        }
        public void evaluar(string name, string lengua,int puntos_lenguaje, int entradaS, int entradaM, int entradaC, int salidaS, int salidaM, int salidaC, int consultaS, int consultaM, int consultaC, int archivoS, int archivoM, int archivoC, int interfaceS, int interfaceM, int interfaceC, int pr1, int pr2, int pr3, int pr4, int pr5, int pr6, int pr7, int pr8, int pr9, int pr10, int pr11, int pr12, int pr13, int pr14)
        {
            nombre = name;
            lenguaje = lengua;
            valLenguaje = puntos_lenguaje;
            entradaSimple = entradaS;
            entradaMedia = entradaM;
            entradaCompleja = entradaC;
            salidaSimple = salidaS;
            salidaMedia = salidaM;
            salidaCompleja = salidaC;
            consultaSimple = consultaS;
            consultaMedia = consultaM;
            consultaCompleja = consultaC;
            archivoSimple = archivoS;
            archivoMedia = archivoM;
            archivoCompleja = archivoC;
            interfaceSimple = interfaceS;
            interfaceMedia = interfaceM;
            interfaceCompleja = interfaceC;
            p1 = pr1;
            p2 = pr2;
            p3 = pr3;
            p4 = pr4;
            p5 = pr5;
            p6 = pr6;
            p7 = pr7;
            p8 = pr8;
            p9 = pr9;
            p10 = pr10;
            p11 = pr11;
            p12 = pr12;
            p13 = pr13;
            p14 = pr14;
        }
        //Calculo de entradas parciales
        public Int32 puntos_parciales(int cantidadSimples, int cantidadMedias, int cantidadComplejas,string parametro)
        {
            switch (parametro)
            {
                case "entradas":
                    entradaSimple = cantidadSimples;
                    entradaMedia = cantidadMedias;
                    entradaCompleja = cantidadComplejas;
                    return cantidadSimples * EPS + cantidadMedias * EPM + cantidadComplejas * EPC;
                case "salidas":
                    salidaSimple = cantidadSimples;
                    salidaMedia = cantidadMedias;
                    salidaCompleja = cantidadComplejas;
                    return cantidadSimples * SPS + cantidadMedias * SPM + cantidadComplejas * SPC;
                case "consultas":
                    consultaSimple = cantidadSimples;
                    consultaMedia = cantidadMedias;
                    consultaCompleja = cantidadComplejas;
                    return cantidadSimples * CPS + cantidadMedias * CPM + cantidadComplejas * CPC;
                case "archivos":
                    archivoSimple = cantidadSimples;
                    archivoMedia = cantidadMedias;
                    archivoCompleja = cantidadComplejas;
                    return cantidadSimples * APS + cantidadMedias * APM + cantidadComplejas * APC;
                case "interfaces":
                    interfaceSimple = cantidadSimples;
                    interfaceMedia = cantidadMedias;
                    interfaceCompleja = cantidadComplejas;
                    return cantidadSimples * IPS + cantidadMedias * IPM + cantidadComplejas * IPC;
                default:
                    return 0;
            }
        }
        //Funcion de calculo de puntos de funcion
        public Int32 calcular_pfna()
        {
            int e = entradaSimple * EPS + entradaMedia * EPM + entradaCompleja * EPC;
            int s = salidaSimple * SPS + salidaMedia * SPM + salidaCompleja * SPC;
            int c = consultaSimple * CPS + consultaMedia * CPM + consultaCompleja * CPC;
            int a = archivoSimple * APS + archivoMedia * APM + archivoCompleja * APC;
            int i = interfaceSimple * IPS + interfaceMedia * IPM + interfaceCompleja * IPC;
            pfna = e + s + c + a + i;
            return pfna;
        }
        //Funcion de calculo a las 14 preguntas
        public Int32 calcular_14(int r1,int r2,int r3,int r4,int r5,int r6,int r7,int r8,int r9,int r10,int r11,int r12,int r13,int r14)
        {
            p1 = r1;
            p2 = r2;
            p3 = r3;
            p4 = r4;
            p5 = r5;
            p6 = r6;
            p7 = r7;
            p8 = r8;
            p9 = r9;
            p10 = r10;
            p11 = r11;
            p12 = r12;
            p13 = r13;
            p14 = r14;
            val14 = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10 + p11 + p12 + p13 + p14;
            return val14;
        }
        //Funcion calcular puntos de funcion ajustados
        public Double calcular_pfa()
        {
            pfa = pfna * (0.65 + 0.01 * val14);
            pfa = Math.Round(pfa, 2);
            return pfa;
        }
        //Funcion calcular KLOC
        public Double calcular_kloc(int puntosLenguaje)
        {
            valLenguaje = puntosLenguaje;
            kloc = (pfa * puntosLenguaje) / 1000;
            kloc = Math.Round(kloc, 2);
            return kloc;
        }
        //Funcion calcular loc
        public Double calcular_loc()
        {
            calcular_kloc(valLenguaje);
            loc = kloc * 1000;
            loc = Math.Round(loc, 2);
            return loc;
        }
        //Funcion asignar tipo de proyecto
        public String verificar_tipo()
        {
            if (kloc < 50)
            {
                tipo_proyecto = "Organico";
            }
            else
            {
                if (kloc < 300)
                {
                   tipo_proyecto = "Semi-acoplado";
                }
                else
                {
                    tipo_proyecto = "Empotrado";
                }
            }
            return tipo_proyecto;
        }
        //////////////////////////////////////////////////////////////////
        /////////CALCULOS DE COCOMO///////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        
        //Calculoas de modelo basico
        public void m_basico()
        {
            try
            {
                double e = 0;
                double t = 0;
                double pn = 0;
                double p = 0;
                cn = new MySqlConnection();
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                }
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select nombre,a,b,c,d from val_coeficientes where nombre='" + tipo_proyecto + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    a = Convert.ToDouble(reader[1].ToString());
                    b = Convert.ToDouble(reader[2].ToString());
                    c = Convert.ToDouble(reader[3].ToString());
                    d = Convert.ToDouble(reader[4].ToString());
                }
                else
                {

                }
                reader.Close();
                e = a * Math.Pow(kloc, b);
                e = Math.Round(e, 2);
                t = c * Math.Pow(e, d);
                t = Math.Round(t, 2);
                pn = loc / e;
                pn = Math.Round(pn, 2);
                p = e / t;
                p = Math.Round(p, 0);
                esfuerzo_basico = e;
                tiempo_basico = t;
                probabilidad_basico = pn;
                personas_basico = p;

            }
            catch (Exception)
            {
            }
        }
        public void m_intermedio()
        {
            try
            {
                double e = 0;
                double t = 0;
                double pn = 0;
                double p = 0;
                cn = new MySqlConnection();
                try
                {
                    cn.Open();
                }
                catch (Exception)
                {
                }
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select nombre,a,b,c,d from coeficientes_intermedio where nombre='" + tipo_proyecto + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    ai = Convert.ToDouble(reader[1].ToString());
                    bi = Convert.ToDouble(reader[2].ToString());
                    ci = Convert.ToDouble(reader[3].ToString());
                    di = Convert.ToDouble(reader[4].ToString());
                }
                else
                {

                }
                reader.Close();
                e = ai * Math.Pow(kloc, bi)*fa;
                e = Math.Round(e, 2);
                t = ci * Math.Pow(e, di);
                t = Math.Round(t, 2);
                pn = loc / e;
                pn = Math.Round(pn, 2);
                p = e / t;
                p = Math.Round(p, 0);
                esfuerzo_intermedio = e;
                tiempo_intermedio = t;
                probabilidad_intermedio = pn;
                personas_intermedio = p;

            }
            catch (Exception)
            {
            }
        }
        public String Esfuerzo_basico()
        {
            m_basico();
            return Convert.ToString(esfuerzo_basico) + " personas/mes";
        }
        public String Tiempo_basico()
        {
            m_basico();
            return Convert.ToString(tiempo_basico) + " meses";
        }
        public String Prob_basico()
        {
            m_basico();
            return Convert.ToString(probabilidad_basico) + " LOC/personas/mes";
        }
        public String Personas_basico()
        {
            m_basico();
            return Convert.ToString(personas_basico) + " Personas";
        }
        public String Esfuerzo_intermedio()
        {
            m_intermedio();
            return Convert.ToString(esfuerzo_intermedio) + " personas/mes";
        }
        public String Tiempo_intermedio()
        {
            m_intermedio();
            return Convert.ToString(tiempo_intermedio) + " meses";
        }
        public String Prob_intermedio()
        {
            m_intermedio();
            return Convert.ToString(probabilidad_intermedio) + " LOC/personas mes";
        }
        public String Personas_intermedio()
        {
            m_intermedio();
            return Convert.ToString(personas_intermedio) + " Personas";
        }
        public void calcular_fa(double fa1, double fa2, double fa3, double fa4, double fa5, double fa6, double fa7, double fa8, double fa9, double fa10, double fa11, double fa12, double fa13, double fa14, double fa15)
        {
            fa = fa1 * fa2 * fa3 * fa4 * fa5 * fa6 * fa7 * fa8 * fa9 * fa10 * fa11 * fa12 * fa13 * fa14 * fa15;
            fa = Math.Round(fa, 2);
        }
        public Double factor_ajuste()
        {
            return fa;
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////PROGRAMACION DEL MODELO AVANZADO///////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////7/
        public void m_avanzado()
        {
            string a="";
            string b="";
            int y0=0;
            int y1=0;
            if (kloc>2&&kloc<8)
            {
                a = "pequeño";
                b = "intermedio";
                y0 = 2;
                y1 = 8;
            }
            if (kloc > 8 && kloc < 32)
            {
                a = "intermedio";
                b = "medio";
                y0 = 8;
                y1 = 32;
            }
            if(kloc>32&&kloc<128)
            {
                a = "medio";
                b = "grande";
                y0 = 32;
                y1 = 128;
            }
            if(kloc>128&&kloc<512)
            {
                a = "grande";
                b = "muy_grande";
                y0 = 128;
                y1 = 512;
            }
            e_requerimientos = calcular_requerimientos(a, b,y0,y1);
            e_diseño_producto = calcular_diseño_producto(a, b,y0,y1);
            e_programacion = calcular_programacion(a, b,y0,y1);
            e_diseño_detallado = calcular_diseño_detallado(a, b,y0,y1);
            e_codificacion_testeo = calcular_codificacion_testeo(a, b,y0,y1);
            e_integracion_testeo = calcular_integracion_testeo(a, b,y0,y1);
        }

        private double calcular_integracion_testeo(string a, string b,int x0,int x1)
        {
            int y0 = 0;
            int y1 = 0;
            double y;
            cn = new MySqlConnection();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
            }
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select " + a + "," + b + " from distribucion where fase='integracion y testeo' and modo='" + tipo_proyecto + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                y0 = Convert.ToInt32(reader[0].ToString());
                y1 = Convert.ToInt32(reader[1].ToString());
            }
            else
            {

            }
            reader.Close();
            y = y0 + ((kloc - x0) / x1 - x0) * (y1 - y0);
            y = Math.Round(y, 3);
            return esfuerzo_intermedio * (y / 100);
        }

        private double calcular_codificacion_testeo(string a, string b,int x0,int x1)
        {
            int y0 = 0;
            int y1 = 0;
            double y;
            cn = new MySqlConnection();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
            }
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select " + a + "," + b + " from distribucion where fase='codificacion y testeo' and modo='" + tipo_proyecto + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                y0 = Convert.ToInt32(reader[0].ToString());
                y1 = Convert.ToInt32(reader[1].ToString());
            }
            else
            {

            }
            reader.Close();
            y = y0 + ((kloc - x0) / x1 - x0) * (y1 - y0);
            y = Math.Round(y, 3);
            return esfuerzo_intermedio * (y / 100);
        }

        private double calcular_diseño_detallado(string a, string b,int x0,int x1)
        {
            int y0 = 0;
            int y1 = 0;
            double y;
            cn = new MySqlConnection();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
            }
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select " + a + "," + b + " from distribucion where fase='diseño detallado' and modo='" + tipo_proyecto + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                y0 = Convert.ToInt32(reader[0].ToString());
                y1 = Convert.ToInt32(reader[1].ToString());
            }
            else
            {

            }
            reader.Close();
            y = y0 + ((kloc - x0) / x1 - x0) * (y1 - y0);
            y = Math.Round(y, 3);
            return esfuerzo_intermedio * (y / 100);
        }

        private double calcular_programacion(string a, string b,int x0,int x1)
        {
            int y0 = 0;
            int y1 = 0;
            double y;
            cn = new MySqlConnection();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
            }
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select " + a + "," + b + " from distribucion where fase='programacion' and modo='" + tipo_proyecto + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                y0 = Convert.ToInt32(reader[0].ToString());
                y1 = Convert.ToInt32(reader[1].ToString());
            }
            else
            {

            }
            reader.Close();
            y = y0 + ((kloc - x0) / x1 - x0) * (y1 - y0);
            y = Math.Round(y, 3);
            return esfuerzo_intermedio * (y / 100);
        }

        private double calcular_diseño_producto(string a, string b,int x0,int x1)
        {
            int y0 = 0;
            int y1 = 0;
            double y;
            cn = new MySqlConnection();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
            }
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select " + a + "," + b + " from distribucion where fase='diseño del producto' and modo='" + tipo_proyecto + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                y0 = Convert.ToInt32(reader[0].ToString());
                y1 = Convert.ToInt32(reader[1].ToString());
            }
            else
            {

            }
            reader.Close();
            y = y0 + ((kloc - x0) / x1 - x0) * (y1 - y0);
            y = Math.Round(y, 3);
            return esfuerzo_intermedio * (y / 100);
        }

        private double calcular_requerimientos(string a, string b,int x0,int x1)
        {
            int y0=0;
            int y1=0;
            double y;
            cn = new MySqlConnection();
            try
            {
                cn.Open();
            }
            catch (Exception)
            {
            }
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select "+a+","+b+" from distribucion where fase='requerimientos' and modo='"+tipo_proyecto+"'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                y0 = Convert.ToInt32(reader[0].ToString());
                y1 = Convert.ToInt32(reader[1].ToString());
            }
            else
            {

            }
            reader.Close();
            y = y0 + ((kloc - x0) / x1 - x0) * (y1 - y0);
            y = Math.Round(y, 3);
            return esfuerzo_intermedio * (y / 100);
        }
        //retornando valores del modelo avanzado a la pantalla del usuario
        public String E_requerimiento()
        {
            m_avanzado();
            return Convert.ToString(e_requerimientos);
        }
        public String E_diseño_producto()
        {
            m_avanzado();
            return Convert.ToString(e_diseño_producto);
        }
        public String E_programacion()
        {
            m_avanzado();
            return Convert.ToString(e_programacion);
        }
        public String E_diseño_detallado()
        {
            m_avanzado();
            return Convert.ToString(e_diseño_detallado);
        }
        public String E_codificacion_testeo()
        {
            m_avanzado();
           return Convert.ToString(e_codificacion_testeo);
        }
        public String E_integracion_testeo()
        {
            m_avanzado();
            return Convert.ToString(e_integracion_testeo);
        }
    }
}
