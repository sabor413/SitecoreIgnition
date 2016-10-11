﻿using Glass.Mapper.Sc.Configuration.Attributes;
using Ignition.Foundation.Data.Fields;

namespace Ignition.Project.IgnitionDemo.Sc.Components.Hero
{
	[SitecoreType(TemplateId= "{43798756-1389-421B-AAC8-0A6AC99273FA}")]
	public interface ICarouselSlide : IHeading, ICopy1, IBackgroundImage
	{
	}
}
