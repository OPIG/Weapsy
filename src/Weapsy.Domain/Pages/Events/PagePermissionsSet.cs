﻿using System;
using System.Collections.Generic;
using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Pages.Events
{
    public class PagePermissionsSet : Event
    {
        public Guid SiteId { get; set; }
        public IList<PagePermission> PagePermissions { get; set; }
    }
}
