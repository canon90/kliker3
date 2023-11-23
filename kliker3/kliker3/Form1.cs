using System;
using System.Threading;

namespace kliker3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)

        {

            MessageBox.Show("цуцйуцй");
            Thread myThread = new Thread(func); //Создаем новый объект потока (Thread)
            Thread myThread1 = new Thread(func1);
            //запускаем поток

            myThread.Start();
            myThread.Interrupt();
            myThread1.Start();
            myThread1.Interrupt();
            for (int i = 0; i < 10; i++)
            {
               // myThread.Resume();
                
               // Thread.Sleep(2000);
                
            }

            Console.Read(); //Приостановим основной поток
        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        static void func()
        {
            string k ="первый";
                
            for (int i = 0; i < 10; i++)
            {
                // myThread.Resume();
                MessageBox.Show(k);
                // Thread.Sleep(2000);

            }




        }

        static void func1()
        {
            string k = "второй";

            for (int i = 0; i < 10; i++)
            {
                // myThread.Resume();
                MessageBox.Show(k);
                // Thread.Sleep(2000);

            }




        }
    }
}