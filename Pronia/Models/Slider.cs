﻿using Pronia.Models.Base;

namespace Pronia.Models
{
    public class Slider : BaseEntity
    {

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
        public DateTime CreatedAt { get; internal set; }
    }
}
