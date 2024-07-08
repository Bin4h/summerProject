using Application.Models;

namespace Data_Base.Interfaces;

public interface ITrackRepository
{
    Task AddTrackAsync(TrackModel trackModel);
}
