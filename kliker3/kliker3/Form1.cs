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

            MessageBox.Show("�������");
            Thread myThread = new Thread(func); //������� ����� ������ ������ (Thread)
            Thread myThread1 = new Thread(func1);
            //��������� �����

            myThread.Start();
            myThread.Interrupt();
            myThread1.Start();
            myThread1.Interrupt();
            for (int i = 0; i < 10; i++)
            {
               // myThread.Resume();
                
               // Thread.Sleep(2000);
                
            }

            Console.Read(); //������������ �������� �����
        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        static void func()
        {
            string k ="������";
                
            for (int i = 0; i < 10; i++)
            {
                // myThread.Resume();
                MessageBox.Show(k);
                // Thread.Sleep(2000);

            }




        }

        static void func1()
        {
            string k = "������";

            for (int i = 0; i < 10; i++)
            {
                // myThread.Resume();
                MessageBox.Show(k);
                // Thread.Sleep(2000);

            }




        }
    }
}