using Application.Interfaces;
using Application.Models;
using Data_Base.Interfaces;

namespace Application.Services;

public class TrackService : ITrackService
{
    private readonly ITrackRepository _trackRepository;

    public TrackService(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository ?? throw new ArgumentNullException(nameof(trackRepository));
    }

    public async Task AddTrackAsync(TrackModel trackModel) => await _trackRepository.AddTrackAsync(trackModel);
}