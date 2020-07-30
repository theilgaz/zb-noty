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
        Primary,
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

    interface INoty
    {
        void Alert(string message, AlertKind alertKind = AlertKind.Primary);
    }

    public partial class Noty : Form, INoty
    {
        private int _x, _y;
        private ActionKind _action;
        public Noty()
        {
            InitializeComponent();
        }

        public void Alert(string message, AlertKind alertKind = AlertKind.Primary)
        {
            throw new NotImplementedException();
        }
    }
}
