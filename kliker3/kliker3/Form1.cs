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

            myThread.Start(); //��������� �����

            for (int i = 0; i < 10; i++)
            {
                
                Thread.Sleep(0);
            }

            Console.Read(); //������������ �������� �����
        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        static void func()
        {
           
                MessageBox.Show(k);
                Thread.Sleep(0);

            
           
        }
    }
}