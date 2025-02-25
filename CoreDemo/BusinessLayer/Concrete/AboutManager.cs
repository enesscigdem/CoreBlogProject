﻿using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }
        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }
        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}

