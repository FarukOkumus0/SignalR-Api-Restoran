﻿using AutoMapper;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;
using System.CodeDom;

namespace SignalRApi.Mapping
{
	public class SliderMapping : Profile
	{
		public SliderMapping()
		{
			CreateMap<Slider, ResultSliderDto>().ReverseMap();
		}
	}
}
