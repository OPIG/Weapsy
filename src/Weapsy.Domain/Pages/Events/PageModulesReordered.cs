﻿using System;
using System.Collections.Generic;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Pages.Events
{
    public class PageModulesReordered : Event
    {
        public Guid SiteId { get; set; }
        public IList<PageModule> PageModules { get; set; }

        public class PageModule
        {
            public Guid ModuleId { get; set; }
            public string Zone { get; set; }
            public int SortOrder { get; set; }
        }
    }
}
