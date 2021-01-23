﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvcCrudProje.Models;

namespace MvcCrudProject.Business.Interfaces
{
    public interface IDepartmanManager
    {
        List<Departman> HepsiniGetir();
        Departman IdyeGoreGetir(int id);
        void Kaydet(Departman departman);
        void Sil(int id);

    }
}
