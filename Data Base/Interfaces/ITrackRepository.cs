﻿using Application.Models;

namespace Data_Base.Interfaces;

internal interface ITrackRepository
{
    Task AddTrackAsync(TrackModel trackModel);
}
