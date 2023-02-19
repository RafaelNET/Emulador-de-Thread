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

namespace EmuladorThread
{
    public partial class Form1 : Form
    {
        //List<Thread> listaThreads = new List<Thread>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovaThred_Click(object sender, EventArgs e)
        {

            //listaThreads.Clear();

            this.Enabled = false;
            for (var index = 1; index <= 5000; index++)
            {
                ParameterizedThreadStart start = new ParameterizedThreadStart(minhaFuncao);
                var novaThread = new Thread(start);
                //listaThreads.Add(novaThread);
                // novaThread.IsBackground = True
                novaThread.Priority = ThreadPriority.Highest;
                novaThread.Start(index);
                Application.DoEvents();
                txtNrThreads.Text = (System.Convert.ToInt32(txtNrThreads.Text) + 1).ToString();
                txtNrThreads.Refresh();
            }
            this.Enabled = true;
        }

        private delegate void minhaFuncaoDelegate(object obj);

        private void minhaFuncao(object obj)
        {
            Thread.Sleep(new Random().Next(2000, 10000));
            ThreadFinalizada(obj);
        }

        private delegate void ThreadFinalizadaDelegate(object obj);
        private void ThreadFinalizada(object obj)
        {
            if (this.txtNrThreadsFinalizadas.InvokeRequired)
            {
                this.Invoke(new ThreadFinalizadaDelegate(this.ThreadFinalizada), new object[] { obj });
                return;
            }

            txtNrThreadsFinalizadas.Text = (System.Convert.ToInt32(txtNrThreadsFinalizadas.Text) + 1).ToString() ;
            txtNrThreadsFinalizadas.Refresh();
        }
    }
}
