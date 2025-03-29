﻿using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DAL.EntityFramework
{
	public class EfAboutDal : GenericRepository<About>, IAboutDal
	{
		public EfAboutDal(SignalRContext context) : base(context)
		{
		}
	}
}
