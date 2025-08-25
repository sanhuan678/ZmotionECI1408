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
        /// ͨ��ɨ���ȡ��ǰ���������п�����������IP������ӵ������б����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ScanIP_Click(object sender, EventArgs e)
        {
            // ����洢ɨ���IP����ַ����������
            // 192.168.0.112 192.168.0.123 
            var buffer = new StringBuilder();
            // ������ǰ�����¿������� IP
            int res = ZAux_SearchEthlist(buffer, 1024, 1000);
            if (res != 0) 
            {
                MessageBox.Show("ɨ��IP��ַʧ��");
                return;
            }
            // ���ݿո�ָ��IP��ַ��ɵ�����
            var ips = buffer.ToString().Split(" ");
            // ��ӷ��滷��IP��ַ�������б����
            cmbIps.Items.Add("127.0.0.1");
            // ѭ���ѻ�ȡ��IP�б���ӵ������б����
            for (int i = 0; i < ips.Length-1; i++)
            {
                cmbIps.Items.Add(ips[i]);
            }
            // Ĭ��ѡ�������б���е�һ����
            cmbIps.SelectedIndex = 0;

        }
        /// <summary>
        /// ������Ͽ��������Ĺ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            // ��ȡ��ť������
            var btnContent = Btn_Connect.Text;
            // �ж��ǶϿ���������
            if (object.Equals(btnContent, "����"))
            {
                // ��ȡ���ӵ�IP��ַ
                var ip = cmbIps.Text;
                // ���÷������ӿ�����
                int res = ZAux_OpenEth(ip, out handle);
                // �ж��Ƿ����ӳɹ�
                if (res != 0)
                {
                    MessageBox.Show("����ʧ�ܣ�����IP��ַ�Ƿ���ȷ");
                    return;
                }
                // �޸İ�ť����ʾ�ַ���
                Btn_Connect.Text = "�Ͽ�";
                // �޸�LED����ɫ
                LED.BackColor= Color.LimeGreen;
            }
            else // ִ�жϿ����ӵĲ���
            {
                // �ж����Ӿ���Ƿ�Ϊ��
                if (handle != IntPtr.Zero) 
                {
                    // �رտ���������
                    int res = ZAux_Close(handle);
                    if (res == 0) 
                    {
                        // �޸İ�ť����ʾ�ַ���
                        Btn_Connect.Text = "����";
                        // �޸�LED����ɫ
                        LED.BackColor = Color.Gray;
                    }
                }
            }
        }
        /// <summary>
        /// ��ʼ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Init_Click(object sender, EventArgs e)
        {
            // ��ȡ�滮�����
            var axis = GetPrfAxis();
            // ��������λӳ���IO��
            ZAux_Direct_SetFwdIn(handle, axis, 2);
            // ���ø���λӳ���IO��
            ZAux_Direct_SetRevIn(handle, axis, 0);
            // ����ԭ��λӳ���IO��
            ZAux_Direct_SetDatumIn(handle, axis, 1);
        }

        /// <summary>
        /// ��ȡ�����˶��滮���
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
            // ��ȡ�滮�����
            var axis = GetPrfAxis();
            // ����������
            ZAux_Direct_SetAtype(handle, axis, 1);
            // �����˶�����,��ʼ�ٶȡ������ٶȣ����ٶȣ����ٶȣ�s���ߣ����嵱��
            ZAux_Direct_SetLspeed(handle, axis, Convert.ToSingle(txt_Lspeed.Text));
            ZAux_Direct_SetSpeed(handle, axis, Convert.ToSingle(txtSpeed.Text));
            ZAux_Direct_SetAccel(handle, axis, Convert.ToSingle(txtAccel.Text));
            ZAux_Direct_SetDecel(handle, axis, Convert.ToSingle(txtDeccl.Text));
            ZAux_Direct_SetSramp(handle, axis, Convert.ToSingle(txt_Sramp.Text));
            ZAux_Direct_SetUnits(handle, axis, Convert.ToSingle(txtUnits.Text));
            // ���������˶�
            ZAux_Direct_Single_Vmove(handle, axis, -1);
        }

        private void Btn_Right_MouseDown(object sender, MouseEventArgs e)
        {
            // ��ȡ�滮�����
            var axis = GetPrfAxis();
            // ����������
            ZAux_Direct_SetAtype(handle, axis, 1);
            // �����˶�����,��ʼ�ٶȡ������ٶȣ����ٶȣ����ٶȣ�s���ߣ����嵱��
            ZAux_Direct_SetLspeed(handle, axis, Convert.ToSingle(txt_Lspeed.Text));
            ZAux_Direct_SetSpeed(handle, axis, Convert.ToSingle(txtSpeed.Text));
            ZAux_Direct_SetAccel(handle, axis, Convert.ToSingle(txtAccel.Text));
            ZAux_Direct_SetDecel(handle, axis, Convert.ToSingle(txtDeccl.Text));
            ZAux_Direct_SetSramp(handle, axis, Convert.ToSingle(txt_Sramp.Text));
            ZAux_Direct_SetUnits(handle, axis, Convert.ToSingle(txtUnits.Text));
            // ���ÿ��ټ����ٶ�
            ZAux_Direct_SetFastDec(handle, axis, 3000);
            // ���������˶�
            ZAux_Direct_Single_Vmove(handle, axis, 1);
        }

        private void Btn_Left_MouseUp(object sender, MouseEventArgs e)
        {
            // ��ȡ�滮�����
            var axis = GetPrfAxis();
            // ֹͣ�滮���Ӧ�˶�
            if (handle != IntPtr.Zero)
            {
                int res = ZAux_Direct_Single_Cancel(handle, axis, 2);
            }
        }
    }
}