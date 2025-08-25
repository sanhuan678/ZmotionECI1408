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
        /// 测试连接Zmotion网络控制器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            // 调用连接控制器的方法
            int result = Zmcaux.ZAux_OpenEth("192.168.0.110", out IntPtr handle);
            if (result == 0) 
            {
                MessageBox.Show("连接控制器成功");
            }
            else 
            {
                MessageBox.Show("连接控制器失败");
            }
        }


        
    }
}