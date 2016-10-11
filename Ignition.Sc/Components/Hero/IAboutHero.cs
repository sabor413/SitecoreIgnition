﻿using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Ignition.Foundation.Data.Fields;

namespace Ignition.Project.IgnitionDemo.Sc.Components.Hero
{
    [SitecoreType(TemplateId = "{6538AB6D-3016-4708-8800-0735967EA67F}", AutoMap = true)]
    public interface IAboutHero : IHeading, IImage, ICopy1
    {
        [SitecoreField(FieldId = "{07DF7C11-7EA7-4739-8FE5-9A3DA7067163}", Setting = SitecoreFieldSettings.InferType)]
        IEnumerable<ILinkedImage> LogoImages { get; set; }
    }
}