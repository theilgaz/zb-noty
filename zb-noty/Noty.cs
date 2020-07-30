using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zb_noty
{
    public enum AlertKind
    {
        Success,
        Info,
        Warning,
        Error
    }

    public enum ActionKind
    {
        Wait,
        Start,
        Close
    }

    public partial class Noty : Form
    {
        public Noty()
        {
            InitializeComponent();
        }
    }
}
