﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void AddContentBusinessLayer(Content content)
        {
            _contentDal.Add(content);
        }

        public void ContentDelete(Content content)
        {
           _contentDal.Delete(content); 
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);    
        }

        public Content GetContentById(int id)
        {
            return _contentDal.Get(x=>x.ContentId==id);
        }

        public List<Content> GetList()
        {
           return _contentDal.List();
        }

        public List<Content> GetListByHeadingId(int id)
        {
            return _contentDal.List(x => x.HeadingId == id);
        }
    }
}
