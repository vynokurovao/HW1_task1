using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TypesRangesForm : Form
    {
        private static readonly string _messagePattern = "Valid values: {0} - {1}";
        
        private static void ShowMessageBoxWithTypeRange(decimal minValue, decimal maxValue)
        {
            MessageBox.Show(String.Format(_messagePattern, minValue, maxValue));
        }
        
        public TypesRangesForm()
        {
            InitializeComponent();
        }

        private void byte_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(byte.MinValue, byte.MaxValue);
        }

        private void sbyte_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(sbyte.MinValue, sbyte.MaxValue);
        }

        private void short_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(short.MinValue, short.MaxValue);
        }

        private void ushort_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(ushort.MinValue, ushort.MaxValue);
        }

        private void int_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(int.MinValue, int.MaxValue);
        }

        private void uint_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(uint.MinValue, uint.MaxValue);
        }

        private void long_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(long.MinValue, long.MaxValue);
        }

        private void ulong_Click(object sender, EventArgs e)
        {
            ShowMessageBoxWithTypeRange(ulong.MinValue, ulong.MaxValue);
        }
    }
}
