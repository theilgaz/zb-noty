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
        void Alert(string caption, string message, AlertKind alertKind = AlertKind.Primary);
        void SetBackColor(int red, int green, int blue);
        void SetBorderColor(int red, int green, int blue);
        void SetCaptionColor(int red, int green, int blue);
    }

    public partial class Noty : Form, INoty
    {
        private int _x, _y;
        private ActionKind _action;
        public Noty()
        {
            InitializeComponent();
        }

        public void Alert(string caption, string message = "", AlertKind alertKind = AlertKind.Primary)
        {

            Opacity = 0.0;
            StartPosition = FormStartPosition.Manual;
            string instance;

            for (int i = 1; i < 10; i++)
            {
                instance = "noty" + i.ToString();
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

            Caption.Text = caption;
            Message.Text = message;

            switch (alertKind)
            {
                case AlertKind.Primary:
                    Icon.Image = Resources.info;
                    SetBackColor(93, 156, 236); // blue jeans
                    SetBorderColor(74, 137, 220); // hover
                    SetCaptionColor(21, 61, 115);
                    break;
                case AlertKind.Secondary:
                    Icon.Image = Resources.info;
                    SetBackColor(101, 109, 120); // dark gray
                    SetBorderColor(67, 74, 84); // hover
                    SetCaptionColor(27, 30, 36); 
                    break;
                case AlertKind.Success:
                    Icon.Image = Resources.success;
                    SetBackColor(160, 212, 104); // grass
                    SetBorderColor(140, 193, 82); // hover
                    SetCaptionColor(49, 89, 5); 
                    break;
                case AlertKind.Info:
                    Icon.Image = Resources.info;
                    SetBackColor(79, 193, 233); // aqua
                    SetBorderColor(59, 175, 218); // hover
                    SetCaptionColor(12, 98, 130); 
                    break;
                case AlertKind.Warning:
                    Icon.Image = Resources.warning;
                    SetBackColor(255, 206, 84); // sunflower
                    SetBorderColor(252, 187, 66); // hover
                    SetCaptionColor(194, 129, 10); 
                    break;
                case AlertKind.Error:
                    Icon.Image = Resources.error;
                    SetBackColor(237, 85, 101); // grapefruit
                    SetBorderColor(218, 68, 83); // hover
                    SetCaptionColor(110, 21, 30); 
                    break;
                case AlertKind.Reminder:
                    Icon.Image = Resources.warning;
                    SetBackColor(252, 110, 81); // grapefruit
                    SetBorderColor(233, 87, 63); // hover
                    SetCaptionColor(135, 31, 14); 
                    break;
                default:
                    Icon.Image = Resources.info;
                    SetBackColor(93, 156, 236); // blue jeans
                    SetBorderColor(74, 137, 220); // hover
                    SetCaptionColor(32, 77, 138); 
                    break;
            }

            Show();
            _action = ActionKind.Start;
            timer.Interval = 1;
            timer.Start();
        }

        public void SetBackColor(int red, int green, int blue)
        {
            BackColor = Color.FromArgb(red, green, blue);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            _action = ActionKind.Close;
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            switch (_action)
            {
                case ActionKind.Wait:
                    timer.Interval = 5000;
                    _action = ActionKind.Close;
                    break;
                case ActionKind.Start:
                    timer.Interval = 1;
                    Opacity += 0.1;
                    if (_x < Location.X)
                    {
                        Left--;
                    }
                    else
                    {
                        if (Opacity == 1.0)
                        {
                            _action = ActionKind.Wait;
                        }
                    }
                    break;
                case ActionKind.Close:
                    timer.Interval = 1;
                    Opacity -= 0.1;

                    Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
                default:
                    break;
            }
        }

        public void SetBorderColor(int red, int green, int blue)
        {
            BorderLeft.BackColor = Color.FromArgb(red, green, blue);
            BorderTop.BackColor = Color.FromArgb(red, green, blue);
            BorderRight.BackColor = Color.FromArgb(red, green, blue);
            BorderBottom.BackColor = Color.FromArgb(red, green, blue);
        }

        public void SetCaptionColor(int red, int green, int blue)
        {
            Caption.ForeColor = Color.FromArgb(red, green, blue);
            Message.ForeColor = Color.FromArgb(red, green, blue);
        }
         
    }
}
