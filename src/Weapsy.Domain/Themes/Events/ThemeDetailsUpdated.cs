﻿using Weapsy.Infrastructure.Domain;

namespace Weapsy.Domain.Themes.Events
{
    public class ThemeDetailsUpdated : Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Folder { get; set; }
    }
}
