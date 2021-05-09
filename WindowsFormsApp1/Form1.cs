using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UIntPtr hProcess;

        private int GetHangarAddr(ref ulong addr, ulong slot)
        {
            ulong a;
            int ret;
            UIntPtr returnd = (UIntPtr)0;
            byte[] data = new byte[8];

            Process[] ps = Process.GetProcessesByName("RTypeFinal2-Win64-Shipping");
            if (ps.Length == 0)
            {
                return 0;
            }

            hProcess = OpenProcess(0x0038, false, (uint)ps[0].Id);
            if (hProcess == null)
            {
                return 0;
            }

            //class base ptr
            a = (ulong)ps[0].MainModule.BaseAddress;
            a += 0x4FEB568;

            ret = ReadProcessMemory(hProcess, (UIntPtr)a, data, 8, returnd);
            if (ret == 0)
            {
                CloseHandle(hProcess);
                return 0;
            }

            //sub class
            a = BitConverter.ToUInt64(data, 0);

            ret = ReadProcessMemory(hProcess, (UIntPtr)a, data, 8, returnd);
            if (ret == 0)
            {
                CloseHandle(hProcess);
                return 0;
            }

            //sub class
            a = BitConverter.ToUInt64(data, 0);
            a += 0xA9260;

            ret = ReadProcessMemory(hProcess, (UIntPtr)a, data, 8, returnd);
            if (ret == 0)
            {
                CloseHandle(hProcess);
                return 0;
            }

            // sub class
            a = BitConverter.ToUInt64(data, 0);
            a += 0x60;

            ret = ReadProcessMemory(hProcess, (UIntPtr)a, data, 8, returnd);
            if (ret == 0)
            {
                CloseHandle(hProcess);
                return 0;
            }

            //hangar address
            addr = BitConverter.ToUInt64(data, 0);
            addr += slot * 0x30;

            return 1;
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            ulong addr = 0;
            int ret;
            UIntPtr returnd = (UIntPtr)0;
            byte[] data = new byte[48];

            ret = GetHangarAddr(ref addr, (ulong)comboBox_hangar.SelectedIndex);
            if(ret == 0)
            {
                MessageBox.Show("R-TYPE FINAL2にアクセス出来ません。", "R-TYPE FINAL2 Ship mod",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //機体データ取得
            ret = ReadProcessMemory(hProcess, (UIntPtr)addr, data, 0x30, returnd);
            if (ret == 0)
            {
                MessageBox.Show("R-TYPE FINAL2にアクセス出来ません。", "R-TYPE FINAL2 Ship mod",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseHandle(hProcess);
                return;
            }

            comboBox_ship.SelectedIndex = (int)data[1];
            comboBox_missile.SelectedIndex = (int)data[2];
            comboBox_bit.SelectedIndex = (int)data[3];
            comboBox_force.SelectedIndex = (int)data[4];
            comboBox_cannon.SelectedIndex = (int)data[5];
            comboBox_dose.SelectedIndex = (int)data[6];

            CloseHandle(hProcess);

        }

        private void button_write_Click(object sender, EventArgs e)
        {
            ulong addr = 0;
            int ret;
            UIntPtr returnd = (UIntPtr)0;
            byte[] data = new byte[48];

            Array.Clear(data, 0, 48);

            ret = GetHangarAddr(ref addr, (ulong)comboBox_hangar.SelectedIndex);
            if (ret == 0)
            {
                MessageBox.Show("R-TYPE FINAL2にアクセス出来ません。", "R-TYPE FINAL2 Ship mod",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data[0] = 1;
            data[1] = (byte)comboBox_ship.SelectedIndex;
            data[2] = (byte)comboBox_missile.SelectedIndex;
            data[3] = (byte)comboBox_bit.SelectedIndex;
            data[4] = (byte)comboBox_force.SelectedIndex;
            data[5] = (byte)comboBox_cannon.SelectedIndex;
            data[6] = (byte)comboBox_dose.SelectedIndex;

            ret = WriteProcessMemory(hProcess, (UIntPtr)addr, data, 0x30, returnd);
            if (ret == 0)
            {
                MessageBox.Show("R-TYPE FINAL2にアクセス出来ません。", "R-TYPE FINAL2 Ship mod",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseHandle(hProcess);
                
                return;
            }

            CloseHandle(hProcess);

            MessageBox.Show("機体データ書き込み成功。", "R-TYPE FINAL2 Ship mod",
                    MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_hangar.SelectedIndex = 0;
            comboBox_ship.SelectedIndex = 0;
            comboBox_missile.SelectedIndex = 0;
            comboBox_bit.SelectedIndex = 0;
            comboBox_force.SelectedIndex = 0;
            comboBox_cannon.SelectedIndex = 0;
            comboBox_dose.SelectedIndex = 0;

            hProcess = (UIntPtr)null;
        }
    }
}
