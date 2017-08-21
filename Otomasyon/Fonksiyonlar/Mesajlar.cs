using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayıt Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Secili olan kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyor musunuz?","Silme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili kayıdı kalıcı olarak silinecektir\n Silme işlemini onaylar mısınız?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt Güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
