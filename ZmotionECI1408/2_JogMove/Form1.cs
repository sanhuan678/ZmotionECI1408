using System.Text;
using static cszmcaux.Zmcaux;
namespace _2_JogMove
{
    public partial class Form1 : Form
    {
        private IntPtr handle;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 通过扫描获取当前网段下所有控制器的网络IP，并添加到下拉列表框中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ScanIP_Click(object sender, EventArgs e)
        {
            // 定义存储扫描的IP组成字符串缓存对象
            // 192.168.0.112 192.168.0.123 
            var buffer = new StringBuilder();
            // 搜索当前网段下控制器的 IP
            int res = ZAux_SearchEthlist(buffer, 1024, 1000);
            if (res != 0) 
            {
                MessageBox.Show("扫描IP地址失败");
                return;
            }
            // 根据空格分割出IP地址组成的数组
            var ips = buffer.ToString().Split(" ");
            // 添加仿真环境IP地址到下拉列表框中
            cmbIps.Items.Add("127.0.0.1");
            // 循环把获取的IP列表添加到下拉列表框中
            for (int i = 0; i < ips.Length-1; i++)
            {
                cmbIps.Items.Add(ips[i]);
            }
            // 默认选择下拉列表框中第一个项
            cmbIps.SelectedIndex = 0;

        }
        /// <summary>
        /// 连接与断开控制器的功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            // 获取按钮的名称
            var btnContent = Btn_Connect.Text;
            // 判断是断开还是连接
            if (object.Equals(btnContent, "连接"))
            {
                // 获取连接的IP地址
                var ip = cmbIps.Text;
                // 调用方法连接控制器
                int res = ZAux_OpenEth(ip, out handle);
                // 判断是否连接成功
                if (res != 0)
                {
                    MessageBox.Show("连接失败，请检查IP地址是否正确");
                    return;
                }
                // 修改按钮的显示字符串
                Btn_Connect.Text = "断开";
                // 修改LED灯颜色
                LED.BackColor= Color.LimeGreen;
            }
            else // 执行断开连接的操作
            {
                // 判断连接句柄是否为空
                if (handle != IntPtr.Zero) 
                {
                    // 关闭控制器连接
                    int res = ZAux_Close(handle);
                    if (res == 0) 
                    {
                        // 修改按钮的显示字符串
                        Btn_Connect.Text = "连接";
                        // 修改LED灯颜色
                        LED.BackColor = Color.Gray;
                    }
                }
            }
        }
        /// <summary>
        /// 初始化控制器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Init_Click(object sender, EventArgs e)
        {
            // 获取规划的轴号
            var axis = GetPrfAxis();
            // 设置正限位映射的IO口
            ZAux_Direct_SetFwdIn(handle, axis, 2);
            // 设置负限位映射的IO口
            ZAux_Direct_SetRevIn(handle, axis, 0);
            // 设置原点位映射的IO口
            ZAux_Direct_SetDatumIn(handle, axis, 1);
        }

        /// <summary>
        /// 获取单轴运动规划轴号
        /// </summary>
        /// <returns></returns>
        private int GetPrfAxis()
        {
            int result = -1;
            if (rad_X.Checked)
            {
                result = 0;
            }

            if (rad_Y.Checked)
            {
                result = 1;
            }

            if (rad_Z.Checked)
            {
                result = 2;
            }

            if (rad_U.Checked)
            {
                result = 3;
            }

            return result;
        }

        private void Btn_Left_MouseDown(object sender, MouseEventArgs e)
        {
            // 获取规划的轴号
            var axis = GetPrfAxis();
            // 设置轴类型
            ZAux_Direct_SetAtype(handle, axis, 1);
            // 设置运动曲线,起始速度、运行速度，加速度，减速度，s曲线，脉冲当量
            ZAux_Direct_SetLspeed(handle, axis, Convert.ToSingle(txt_Lspeed.Text));
            ZAux_Direct_SetSpeed(handle, axis, Convert.ToSingle(txtSpeed.Text));
            ZAux_Direct_SetAccel(handle, axis, Convert.ToSingle(txtAccel.Text));
            ZAux_Direct_SetDecel(handle, axis, Convert.ToSingle(txtDeccl.Text));
            ZAux_Direct_SetSramp(handle, axis, Convert.ToSingle(txt_Sramp.Text));
            ZAux_Direct_SetUnits(handle, axis, Convert.ToSingle(txtUnits.Text));
            // 启动连续运动
            ZAux_Direct_Single_Vmove(handle, axis, -1);
        }

        private void Btn_Right_MouseDown(object sender, MouseEventArgs e)
        {
            // 获取规划的轴号
            var axis = GetPrfAxis();
            // 设置轴类型
            ZAux_Direct_SetAtype(handle, axis, 1);
            // 设置运动曲线,起始速度、运行速度，加速度，减速度，s曲线，脉冲当量
            ZAux_Direct_SetLspeed(handle, axis, Convert.ToSingle(txt_Lspeed.Text));
            ZAux_Direct_SetSpeed(handle, axis, Convert.ToSingle(txtSpeed.Text));
            ZAux_Direct_SetAccel(handle, axis, Convert.ToSingle(txtAccel.Text));
            ZAux_Direct_SetDecel(handle, axis, Convert.ToSingle(txtDeccl.Text));
            ZAux_Direct_SetSramp(handle, axis, Convert.ToSingle(txt_Sramp.Text));
            ZAux_Direct_SetUnits(handle, axis, Convert.ToSingle(txtUnits.Text));
            // 设置快速减速速度
            ZAux_Direct_SetFastDec(handle, axis, 3000);
            // 启动连续运动
            ZAux_Direct_Single_Vmove(handle, axis, 1);
        }

        private void Btn_Left_MouseUp(object sender, MouseEventArgs e)
        {
            // 获取规划的轴号
            var axis = GetPrfAxis();
            // 停止规划轴对应运动
            if (handle != IntPtr.Zero)
            {
                int res = ZAux_Direct_Single_Cancel(handle, axis, 2);
            }
        }
    }
}