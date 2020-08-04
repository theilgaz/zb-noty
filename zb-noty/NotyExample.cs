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
    public partial class NotyExample : Form
    {
        public NotyExample()
        {
            InitializeComponent();
        }

        public void Alert(string caption, string message, AlertKind alertKind)
        {
            Noty n = new Noty();
            n.Alert(caption, message, alertKind);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alert("İşlem başarılı","Kayıt işlemi başarılı bir şekilde tamamlandı.", AlertKind.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alert("Hay aksi!","Bir hata oluştu.", AlertKind.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Alert("Uyarı", "Tüm verilerden emin olun.", AlertKind.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alert("Bilgi", "Bilgi mesajı", AlertKind.Info);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alert("Bilgi","Birincil arkaplan değeri testidir.", AlertKind.Primary);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Alert("Bilgi","İkincil arkaplan değeri testidir.", AlertKind.Secondary);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Alert("Bilgi","İpucu değeri testidir.", AlertKind.Reminder);
        }
    }
}
