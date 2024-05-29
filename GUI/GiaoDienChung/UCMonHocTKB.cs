using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UCMonHocTKB : UserControl
    {
        public string UCTenMonHoc
        {
            get => lblTenMonHoc.Text;
            set => lblTenMonHoc.Text = value;
        }
        public string UCGioHoc
        { 
            get => lblGioHoc.Text;
            set => lblGioHoc.Text = value;
        }

        public string UCPhongHoc
        {
            get => lblPhongHoc.Text;
            set => lblPhongHoc.Text = value;
        }
        public UCMonHocTKB()
        {
            InitializeComponent();
        }

    }
}
