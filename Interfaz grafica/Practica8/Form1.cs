/*
 * Fecha: 23/03/2019	Hack For Good 2019
 *
 * Emergency 4.0	Interfaz centralita	Prototipo V0.0
 * Autores: Samuel Dominguez Cid, Juan Jose Jimenez Rama, Manuel Delgado Lara, Jose Angel Blanco Genil, Pablo Lopez Cortes
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Practica8
{
    public partial class Form1 : Form
    {
        byte[] buffer=new byte[5];
        byte[] buffer_2 = new byte[5];
        byte[] buffer_out = new byte[5];
        byte[] buffer_out1 = new byte[5];
        int[] vector ={0x01,0x02,0x04,0x08};
        int[] estado = new int[4];
        int[] control=new int[4];
        public Form1()
        {
            InitializeComponent();
            buffer_out[3]=0x00;
            try
            {
                serialPort1.Open();
                serialPort2.Open();
                serialPort1.DiscardInBuffer();
                serialPort2.DiscardInBuffer();
                timer1.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Error abriendo el puerto serie");
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            buffer[0] = buffer[1];
            buffer[1] = buffer[2];
            buffer[2] = buffer[3];
            buffer[3] = buffer[4];
            serialPort1.Read(buffer,4,1);

            if(buffer[4]==0xE0) //Condicion de que han llegado los datos correctos, es el ACK
            {
                switch (buffer[0])
                {
                    case 0X30: // Recibe la señal de feedback de las señales
                        switch (buffer[1])
                        {
                            case 0:
                                estado[0] = buffer[3];
                                break;
                            case 1:
                                estado[1] =buffer[3];
                                break;
                            case 2:
                                estado[2] =buffer[3];
                                break;
                            case 3:
                                estado[3]=buffer[3];
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            serialPort1.DiscardInBuffer();
        }
        private void timer1_Tick(object sender, EventArgs e) //Refresco de la pantalla segun timer
        {

            Flecha1_I.Visible = Convert.ToBoolean(estado[0]);//Convert.ToBoolean(sign_id & 0x01);
            Flecha1_D.Visible = Convert.ToBoolean(estado[0] ^ 1);//Convert.ToBoolean((sign_id & 0x01) ^ 1);
            Flecha2_Arr.Visible = Convert.ToBoolean(estado[1] ^ 1);
            Flecha2_Abj.Visible = Convert.ToBoolean(estado[1]);
            Flecha3_Abj.Visible = Convert.ToBoolean(estado[3]);
            Flecha3_Arr.Visible = Convert.ToBoolean(estado[3] ^ 1);
            Flecha4_I.Visible = Convert.ToBoolean(estado[2]);
            Flecha4_D.Visible = Convert.ToBoolean(estado[2] ^ 1);
            if (Convert.ToBoolean(control[0])) lbLed2.State =LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            else lbLed2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            if (Convert.ToBoolean(control[1])) lbLed3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            else lbLed3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            if (Convert.ToBoolean(control[2])) lbLed4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            else lbLed4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            if (Convert.ToBoolean(control[3])) lbLed5.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.On;
            else lbLed5.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;



            int i = 0;
            buffer_out1[0] = 0x10;
            buffer_out1[2] = 0;
            buffer_out1[4] = 0xE0;
            for (i = 0; i < 4; i++)
            {
                buffer_out1[1] = Convert.ToByte(i);
                buffer_out1[3] = Convert.ToByte(control[i]);

                serialPort1.Write(buffer_out1, 0, 5);
            }

        }
        private void lbButton1_MouseClick(object sender, MouseEventArgs e)
        {
            estado[0] ^= 1;
            //Establecer comunicacion para redirigir el flujo fuera del sector 1
            buffer_out[0] = 0x20;
            buffer_out[1] = 0;//Sector en el que se produce la incidencia
            buffer_out[2] = 0;//Sensor que genera la incidencia
            buffer_out[3] = Convert.ToByte(estado[0]);//Con 1 digo que conmute el estado
            buffer_out[4] = 0xE0;
            serialPort1.Write(buffer_out, 0, 5);
        }

        private void lbButton2_MouseClick(object sender, MouseEventArgs e)
        {
            estado[1] ^= 1;
            //Establecer comunicacion para redirigir el flujo fuera del sector 2
            buffer_out[0] = 0x20;
            buffer_out[1] = 1;//Sector en el que se produce la incidencia
            buffer_out[2] = 0;//Sensor que genera la incidencia
            buffer_out[3] = Convert.ToByte(estado[1]);//Con 1 digo que conmute el estado
            buffer_out[4] = 0xE0;
            serialPort1.Write(buffer_out, 0, 5);
        }

        private void lbButton3_MouseClick(object sender, MouseEventArgs e)
        {
            estado[2] ^= 1;
            //Establecer comunicacion para redirigir el flujo del sector 3
            buffer_out[0] = 0x20;
            buffer_out[1] = 2;//Sector en el que se produce la incidencia
            buffer_out[2] = 0;//Sensor que genera la incidencia
            buffer_out[3] = Convert.ToByte(estado[2]);//Con 1 digo que conmute el estado
            buffer_out[4] = 0xE0;
            serialPort1.Write(buffer_out, 0, 5);
        }

        private void lbButton4_MouseClick(object sender, MouseEventArgs e)
        {
            estado[3] ^= 1;
            //Establecer comunicacion para redirigir el flujo del sector 4
            buffer_out[0] = 0x20;
            buffer_out[1] = 3;//Sector en el que se produce la incidencia
            buffer_out[2] =0 ;//Sensor que genera la incidencia
            buffer_out[3] = Convert.ToByte(estado[3]);//Con 1 digo que conmute el estado
            buffer_out[4] = 0xE0;
            serialPort1.Write(buffer_out, 0, 5);
        }
        private void serialPort2_DataReceived_1(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            buffer_2[0] = buffer_2[1];
            buffer_2[1] = buffer_2[2];
            buffer_2[2] = buffer_2[3];
            buffer_2[3] = buffer_2[4];
            serialPort2.Read(buffer_2, 4, 1);
            if (buffer_2[4] == 0xE0) //Condicion de que han llegado los datos correctos, es el ACK
            {
                switch (buffer_2[0])
                {
                    case 0X50: // Recibe la señal de los sensores de temperatura
                        switch (buffer_2[1])
                        {
                            case 0:
                                if (buffer_2[3] >= 50)
                                {
                                    control[0] =1;
                                }
                                else control[0] = 0;
                                break;
                            case 1:
                                if (buffer_2[3] >= 50)
                                {
                                    control[1]=1;
                                }
                                else control[1] = 0;
                                break;
                            case 2:
                                if (buffer_2[3] >= 50)
                                {
                                    control[2]=1;
                                }
                                else control[2] = 0;
                                break;
                            case 3:
                                if (buffer_2[3] >= 50)
                                {
                                    control[3]=1;
                                }
                                else control[3] = 0;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }
        }

        private void lbButton5_MouseClick(object sender, MouseEventArgs e)
        {
            //Establecer comunicacion para redirigir el flujo del sector 4
            buffer_out[0] = 0xFF;
            buffer_out[1] = 0;//Sector en el que se produce la incidencia
            buffer_out[2] = 0;//Sensor que genera la incidencia
            buffer_out[3] = 0;
            buffer_out[4] = 0xE0;
            serialPort1.Write(buffer_out, 0, 5);
        }
    }
}
