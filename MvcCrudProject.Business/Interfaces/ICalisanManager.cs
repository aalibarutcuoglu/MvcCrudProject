using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCrudProje.Models;

namespace MvcCrudProject.Business.Interfaces
{
    public interface ICalisanManager
    {
        List<Calisan> HepsiniGetir();
        Calisan IdyeGoreGetir(int id);
        //void Ekle(Calisan calisan);
        //void Guncelle(Calisan calisan);
        void Kaydet(Calisan calisan);
        void Sil(int id);
    }
}
