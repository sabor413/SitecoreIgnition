﻿using Glass.Mapper.Sc.Maps;
using Ignition.Foundation.Core.Factories;
using Ignition.Foundation.Core.Models.BaseModels;
using Ignition.Foundation.Core.Models.Page;

namespace Ignition.Foundation.Core.Models.Mappers
{
	public class PageMapper : SitecoreGlassMap<IPage>, IGlassSettingsConsumer
	{
		public override void Configure()
		{
			Map(x =>
			{
				ImportMap<IMetadata>();
				ImportMap<INavigation>();
				ImportMap<ITaxonomy>();
				ImportMap<INeedsChildren>();
				ImportMap<INeedsParent>();
				ImportMap<IModelBaseWithMetadata>();
				x.AutoMap().Cachable();
				x.TemplateId(SettingsFactory.GetAppSetting("Ignition.Map.Id.Page"));
			});
		}
		public ISitecoreSettingsFactory SettingsFactory { get; set; }
	}
}