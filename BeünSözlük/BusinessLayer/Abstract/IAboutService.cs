﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();
        void AddAboutBusinessLayer(About about);
        About GetAboutById(int id);
        void AboutDelete(About about);
        void AboutUpdate(About about);
    }
}
