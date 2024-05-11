using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.DirectX.Common.DirectWrite;

namespace CarreraCarritos
{

    public partial class Form1 : Form
    {
        Graphics Carrito1, Carrito2, Carrito3;
        SolidBrush lapisAzul = new SolidBrush(Color.Blue);
        SolidBrush lapisRojo = new SolidBrush(Color.Red);
        SolidBrush lapisNegro = new SolidBrush(Color.Black);
        SolidBrush lapisVerde = new SolidBrush(Color.Green);
        SolidBrush lapisVerde2 = new SolidBrush(Color.Green);
        SolidBrush lapisVerde3 = new SolidBrush(Color.Green);

        Random random = new Random();
        static CancellationTokenSource cts = new CancellationTokenSource();




        Thread HiloRojo;
        Thread HiloAzul;
        Thread HiloNegro;

        public Form1()
        {
            InitializeComponent();
            
        }

        // Método para actualizar el label desde otro hilo
        private void ActualizarLabel(string texto)
        {
            // Verificamos si es necesario llamar al hilo principal
            if (lblPrimerLugar.InvokeRequired)
            {
                // Invocamos al hilo principal y llamamos nuevamente al método ActualizarLabel
                lblPrimerLugar.Invoke(new Action<string>(ActualizarLabel), texto);
            }
            else
            {
                // Actualizamos el texto del label en el hilo principal
                lblPrimerLugar.Text = texto;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Carrito1 = this.CreateGraphics();
            Carrito2 = this.CreateGraphics();
            Carrito3 = this.CreateGraphics();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            // Crear un nuevo CancellationTokenSource para los hilos
            cts = new CancellationTokenSource();
            HiloAzul = new Thread(() => DibujarCuadradosAzul(cts.Token));
            HiloRojo = new Thread(() => DibujarCuadradosRojo(cts.Token));
            HiloNegro = new Thread(() => DibujarCuadradosNegro(cts.Token));
            HiloAzul.Start();
            HiloRojo.Start();
            HiloNegro.Start();

            
            //Manera normal, sin  btn reiniciar
            //HiloAzul = new Thread(DibujarCuadradosAzul);
            //HiloRojo = new Thread(DibujarCuadradosRojo);
            //HiloNegro = new Thread(DibujarCuadradosNegro);


            //DibujarCuadradosAzul();
            //DibujarCuadradosRojo();

        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cts.Cancel();

            // Establecer las posiciones de los carritos a cero
            corX = 30;
            corX2 = 30;
            corX3 = 30;

            // Limpiar el canvas
            Carrito1.Clear(Color.White);
            Carrito2.Clear(Color.White);
            Carrito3.Clear(Color.White);

            // Reiniciar la carrera desde el principio
            btnComenzar_Click(sender, e);


        }

        int corX = 30;
        int corX2 = 30;
        int corX3 = 30;
        void DibujarCuadradosAzul(CancellationToken token)
        {
            while (!token.IsCancellationRequested && corX < 980)
            {
                Carrito1.FillRectangle(lapisAzul, corX, 30, 90, 40);
                Carrito1.FillEllipse(lapisVerde, corX + 5, 60, 20, 20);
                Carrito1.FillEllipse(lapisVerde, corX + 60, 60, 20, 20);
                corX = corX + random.Next(6);
                Thread.Sleep(5);
                Carrito1.Clear(Color.White);
                //Gana azul
                if (corX > corX2 && corX > corX3)
                {
                    ActualizarLabel("Primer lugar: carrito AZUL");
                }
                if (corX2 > corX && corX2 > corX3)
                {
                    ActualizarLabel("Primer lugar: carrito ROJO");
                }
                if (corX3 > corX && corX3 > corX2)
                {
                    ActualizarLabel("Primer lugar: carrito NEGRO");
                }
               
                if (corX > 885 && corX > corX2 && corX > corX3)
                {
                    if (corX2 > 885 && corX2 > corX3)
                    {
                        MessageBox.Show("Primer lugar: AZUL, " +
                                        "Segundo lugar: ROJO, " +
                                        "Tercer lugar: NEGRO");
                        HiloAzul.Abort();
                        HiloRojo.Abort();
                        HiloNegro.Abort();
                        break;
                    }
                    if (corX3 > 885 && corX3 > corX2)
                    {
                        MessageBox.Show("Primer lugar: AZUL, " +
                                        "Segundo lugar: NEGRO, " +
                                        "Tercer lugar: ROJO");
                        HiloAzul.Abort();
                        HiloRojo.Abort();
                        HiloNegro.Abort();
                        break;
                    }


                }
                //Gana rojo
                if (corX2 > 885 && corX2 > corX && corX2 > corX3)
                {
                    if (corX > 885 && corX > corX3)
                    {
                        MessageBox.Show("Primer lugar: ROJO, " +
                                        "Segundo lugar: AZUL, " +
                                        "Tercer lugar: NEGRO");
                        HiloAzul.Abort();
                        HiloRojo.Abort();
                        HiloNegro.Abort();
                        break;
                    }
                    if (corX3 > 885 && corX3 > corX)
                    {
                        MessageBox.Show("Primer lugar: ROJO, " +
                                        "Segundo lugar: NEGRO, " +
                                        "Tercer lugar: AZUL");
                        HiloAzul.Abort();
                        HiloRojo.Abort();
                        HiloNegro.Abort();
                        break;
                    }


                }
                if (corX3 > 885 && corX3 > corX && corX3 > corX2)
                {
                    if (corX > 885 && corX > corX2)
                    {
                        MessageBox.Show("Primer lugar: NEGRO, " +
                                        "Segundo lugar: AZUL, " +
                                        "Tercer lugar: ROJO");
                        HiloAzul.Abort();
                        HiloRojo.Abort();
                        HiloNegro.Abort();
                        break;
                    }
                    if (corX2 > 885 && corX2 > corX)
                    {
                        MessageBox.Show("Primer lugar: NEGRO, " +
                                        "Segundo lugar: ROJO, " +
                                        "Tercer lugar: AZUL");
                        HiloAzul.Abort();
                        HiloRojo.Abort();
                        HiloNegro.Abort();
                        break;
                    }


                }


              

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            HiloAzul.Abort();
            HiloRojo.Abort();
            HiloNegro.Abort();
        }



        void DibujarCuadradosRojo(CancellationToken token)
        {
            while (!token.IsCancellationRequested && corX < 980)
            {

                Carrito2.FillRectangle(lapisRojo, corX2, 90, 90, 40);
                Carrito2.FillEllipse(lapisVerde2, corX2 + 5, 120, 20, 20);
                Carrito2.FillEllipse(lapisVerde2, corX2 + 60, 120, 20, 20);
                corX2 = corX2 + random.Next(6);
                Thread.Sleep(5);
                Carrito2.Clear(Color.White);
                
            }
           
        }

       
        void DibujarCuadradosNegro(CancellationToken token)
        {
            while (!token.IsCancellationRequested && corX < 980)
            {

                Carrito3.FillRectangle(lapisNegro, corX3, 150, 90, 40);
                Carrito3.FillEllipse(lapisVerde3, corX3 + 5, 180, 20, 20);
                Carrito3.FillEllipse(lapisVerde3, corX3 + 60, 180, 20, 20);
                corX3 = corX3 + random.Next(6);
                Thread.Sleep(5);
                Carrito3.Clear(Color.White);
                

            }

        }

       









    }



}
