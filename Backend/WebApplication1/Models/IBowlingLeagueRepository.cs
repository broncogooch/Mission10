using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public interface IBowlingLeagueRepository
    {
        IEnumerable<Bowler> Bowlers { get; }
        IEnumerable<Team> Teams { get; }
    }
}