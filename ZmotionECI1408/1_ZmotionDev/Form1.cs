using cszmcaux;
namespace _1_ZmotionDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ��������Zmotion���������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            // �������ӿ������ķ���
            int result = Zmcaux.ZAux_OpenEth("192.168.0.110", out IntPtr handle);
            if (result == 0) 
            {
                MessageBox.Show("���ӿ������ɹ�");
            }
            else 
            {
                MessageBox.Show("���ӿ�����ʧ��");
            }
        }


        
    }
}