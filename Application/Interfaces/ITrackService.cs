using Application.Models;

namespace Application.Interfaces;

public interface ITrackService
{
    Task AddTrackAsync(TrackModel trackModel);
}
