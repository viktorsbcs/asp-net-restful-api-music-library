﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibraryAPI.Model.DTO
{
    public class TrackMinimalDTO
    {
        public long Id { get; set; }

        public string TrackTitle { get; set; }

        public TimeSpan TrackDuration { get; set; }
    }
}
