using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zb_noty.Properties;

namespace zb_noty
{
    public enum AlertKind
    {
        Primary,
        Secondary,
        Success,
        Info,
        Warning,
        Error,
        Reminder
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
        void SetBackColor(int red, int green, int blue);
        void SetBorderColor(int red, int green, int blue);
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

            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string instance;

            for (int i = 1; i < 10; i++)
            {
                instance = "alert" + i.ToString();
                Noty f = (Noty)Application.OpenForms[instance];

                if (f == null)
                {
                    this.Name = instance;
                    _x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    _y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    Location = new Point(_x, _y);
                    break;
                }

            }

            _x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            Caption.Text = message;

            switch (alertKind)
            {
                case AlertKind.Primary:
                    Icon.Image = Resources.info;
                    SetBackColor(93, 156, 236); // blue jeans
                    SetBorderColor(74, 137, 220); // hover
                    break;
                case AlertKind.Secondary:
                    Icon.Image = Resources.info;
                    SetBackColor(101, 109, 120); // dark gray
                    SetBorderColor(67, 74, 84); // hover
                    break;
                case AlertKind.Success:
                    Icon.Image = Resources.success;
                    SetBackColor(160, 212, 104); // grass
                    SetBorderColor(140, 193, 82); // hover
                    break;
                case AlertKind.Info:
                    Icon.Image = Resources.info;
                    SetBackColor(79, 193, 233); // aqua
                    SetBorderColor(59, 175, 218); // hover
                    break;
                case AlertKind.Warning:
                    Icon.Image = Resources.warning;
                    SetBackColor(255, 206, 84); // sunflower
                    SetBorderColor(252, 187, 66); // hover
                    break;
                case AlertKind.Error:
                    Icon.Image = Resources.error;
                    SetBackColor(237, 85, 101); // grapefruit
                    SetBorderColor(218, 68, 83); // hover
                    break;
                default:
                    Icon.Image = Resources.info;
                    SetBackColor(93, 156, 236); // blue jeans
                    SetBorderColor(74, 137, 220); // hover
                    break;
            }
            
            Show();
            _action = ActionKind.Start;
            this.Timer1.Interval = 1;
            this.Timer1.Start();
        }

        public void SetBackColor(int red, int green, int blue)
        {
            BackColor = Color.FromArgb(red, green, blue);
        }

        public void SetBorderColor(int red, int green, int blue)
        {
            BorderLeft.BackColor = Color.FromArgb(red, green, blue);
            BorderTop.BackColor = Color.FromArgb(red, green, blue);
            BorderRight.BackColor = Color.FromArgb(red, green, blue);
            BorderBottom.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
