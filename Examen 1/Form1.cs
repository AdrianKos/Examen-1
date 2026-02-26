namespace Examen_1
{
    public partial class Examen1 : Form
    {
        public Examen1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            //Oscar Adrian Campos Gonzalez C23130706

            //ISR = Cuota fija + (Sueldo − Límite inferior) × Porcentaje
            /* ISR
            Limite inferior    Límite superior	Cuota fija	Porcentaje
            0.01	    746.04	    0.00	    1.92%
            746.05	    6,332.05	14.32	    6.40%
            6,332.06	11,128.01	371.83	    10.88%
            11,128.02	12,935.82	893.63	    16.00%
            12,935.83	15,487.71	1,318.26	17.92%
            15,487.72	31,236.49	1,972.12	21.36%
            31,236.50	49,233.00	5,850.76	23.52%
            49,233.01	93,993.90	10,837.02	30.00%
            93,993.91	125,325.20	26,177.04	32.00%
            125,325.21	375,975.61	38,243.68	34.00%
            375,975.62	En adelante	142,119.38	35.00%*/


            try
            {
                double sueldo = Convert.ToDouble(TB_Sueldo.Text);
                double isr = 0;
                double sueldoNeto = 0;


                //Por si el sueldo es menor a 0
                if (sueldo <= 0)
                {
                    MessageBox.Show("Ingresa un numero mayor que cero");
                }
                else
                {   
                    //Calculo del ISR y el sueldo neto
                    if (sueldo > 0 && sueldo < 746.05)
                    {
                        isr = 0 + (sueldo - 0.01) * 0.0192;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 746.04 && sueldo < 6332.06)
                    {
                        isr = 14.32 + (sueldo - 746.05) * 0.064;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 6332.05 && sueldo < 11128.02)
                    {
                        isr = 371.83 + (sueldo - 6332.06) * 0.1088;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 11128.01 && sueldo < 12935.83)
                    {
                        isr = 893.63 + (sueldo - 11128.02) * 0.16;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 12935.82 && sueldo < 15487.72)
                    {
                        isr = 1318.26 + (sueldo - 12935.83) * 0.1792;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 15487.71 && sueldo < 31236.50)
                    {
                        isr = 1972.12 + (sueldo - 15487.72) * 0.2136;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 31236.49 && sueldo < 49233.01)
                    {
                        isr = 5850.76 + (sueldo - 31236.50) * 0.2352;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 49233 && sueldo < 93993.91)
                    {
                        isr = 10837.02 + (sueldo - 49233.01) * 0.3;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 93993.90 && sueldo < 125325.21)
                    {
                        isr = 26177.04 + (sueldo - 93993.91) * 0.32;
                        sueldoNeto = sueldo - isr;
                    }
                    else if (sueldo > 125325.20 && sueldo < 375975.62)
                    {
                        isr = 38243.68 + (sueldo - 125325.21) * 0.34;
                        sueldoNeto = sueldo - isr;
                    }
                    else
                    {
                        isr = 142119.38 + (sueldo - 375975.62) * 0.35;
                        sueldoNeto = sueldo - isr;
                    }


                    //mostrar los resultados en los label

                    LBL_ISR.Text = "ISR: " + isr.ToString("#####.###");
                    LBL_SueldoNeto.Text = "Sueldo Neto: " + sueldoNeto.ToString("########.###");
                }
            }
            catch (Exception ex)
            {
                //Por si el valor que se ingresa no es un numero se muestra lo siguiente:
                MessageBox.Show("El Valor de sueldo ingresado no es valido: " + ex.Message);
            }
        }
    }
}
