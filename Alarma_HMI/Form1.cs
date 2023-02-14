using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Alarma_HMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int indice = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Datos.Rows.Add();

            Datos.Rows[n].Cells[0].Value = ComboBoxHora.Text;
            Datos.Rows[n].Cells[1].Value = ComboBoxMinuto.Text;
            Datos.Rows[n].Cells[2].Value = ComboBoxSirena.Text;
            ComboBoxHora.SelectedIndex = 0;
            ComboBoxMinuto.SelectedIndex = 0;
            ComboBoxSirena.SelectedIndex = 0;

            string Ubicacion = TextoUbicacion.Text;
            TextWriter writer = new StreamWriter($@"{Ubicacion}");

            for (int i = 0; i < Datos.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Datos.Columns.Count; j++)
                {
                    if (j == Datos.Columns.Count - 1)
                    {
                        writer.Write(Datos.Rows[i].Cells[j].Value.ToString() + "\n");
                    }
                    else
                    {
                        writer.Write(Datos.Rows[i].Cells[j].Value.ToString() + ",");
                    }
                }
            }
            writer.Close();

            EnviarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos.Rows.RemoveAt(indice);

            string Ubicacion = TextoUbicacion.Text;
            TextWriter writer = new StreamWriter($@"{Ubicacion}");

            for (int i = 0; i < Datos.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Datos.Columns.Count; j++)
                {
                    if (j == Datos.Columns.Count - 1)
                    {
                        writer.Write(Datos.Rows[i].Cells[j].Value.ToString() + "\n");
                    }
                    else
                    {
                        writer.Write(Datos.Rows[i].Cells[j].Value.ToString() + ",");
                    }
                }
            }
            writer.Close();

            EnviarDatos();
        }

        private void Datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.BaudRate = 9600;
                serialPort1.PortName = ComboPuertos.Text;
                serialPort1.Open();
            }

            String Ubicacion = TextoUbicacion.Text;

            string[] lineas = File.ReadAllLines($@"{Ubicacion}");
            string[] data;

            for (int i = 0; i < lineas.Length; i++)
            {
                Datos.Rows.Add();
                data = lineas[i].ToString().Split(',');

                for (int j = 0; j < data.Length; j++)
                {
                    Datos.Rows[i].Cells[j].Value = data[j];
                }
            }

            EnviarDatos();
        }
        async void EnviarDatos()
        {
            BotonAñadir.Enabled = false;
            BotonBorrar.Enabled = false;
            panel1.Enabled = false;

            LabelInfo.Text = "ENVIANDO DATOS...";

            string DatoEnviar1 = "ISSSSSSSF";
            LabelAux.Text = "Borrando Alarmas";
            string v1 = DatoEnviar1;
            serialPort1.WriteLine(text: v1);
            serialPort1.DiscardOutBuffer();
            await Task.Delay(2000);

            try
            {
                for (int i = 0; i < Datos.RowCount-1; i++)
                {

                    string Ind = "0";

                    if (i < 10)
                    {
                        Ind = "0" + i.ToString();
                    }
                    else
                    {
                        Ind = i.ToString();
                    }

                    string DatoUnido = "I" + Ind + Datos.Rows[i].Cells[0].Value.ToString() + Datos.Rows[i].Cells[1].Value.ToString() + Datos.Rows[i].Cells[2].Value.ToString() + "F";
                    LabelAux.Text = "Alarma "+(i+1).ToString();

                    string DatoEnviar = $"{DatoUnido}";
                    string v = DatoEnviar;
                    serialPort1.WriteLine(text: v);
                    serialPort1.DiscardOutBuffer();
                    await Task.Delay(2000);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


            BotonAbrir.Visible = false;
            label6.Visible = false;
            TextoUbicacion.Visible = false;
            BotonBorrar.Enabled = true;
            BotonAñadir.Enabled = true;
            panel1.Visible = false;
            LabelAlarmas.Visible = true;
            BotonAñadir.Enabled = true;
            BotonBorrar.Enabled = true;

            LabelInfo.Text = "";
            LabelAux.Text = "";

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            BotonAñadir.Enabled = false;
            BotonBorrar.Enabled = false;

            string[] ports = null;
            ports = SerialPort.GetPortNames();
            ComboPuertos.DataSource = ports;
            LabelAlarmas.Visible = false;

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialPort1.IsOpen && serialPort1.BytesToRead > 0)
                {
                    string MensajeRecibido = serialPort1.ReadLine();
                    string MensajeAceptado = "";

                    CheckForIllegalCrossThreadCalls = false;

                    int Longitud = MensajeRecibido.Length;

                    string Inicio = MensajeRecibido.Substring(0, 1);
                    string Fin = MensajeRecibido.Substring(Longitud - 2, 1);

                    if (Inicio.Equals("I") && Fin.Equals("F"))
                    {
                        MensajeAceptado = MensajeRecibido.Substring(1, Longitud - 3);
                        LabelReloj.Text = MensajeAceptado;
                    }

                    serialPort1.DiscardInBuffer();
                    MensajeRecibido = "";
                    Longitud = 0;
                    Inicio = "";
                    Fin = "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

