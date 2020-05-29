﻿using CineMagic.Facade.Models.Projection;
using System.Collections.Generic;
using System.Threading.Tasks;
using CineMagic.Facade.Models.PlayingNow;

namespace CineMagic.Facade.Repositories
{
    public interface IProjectionsRespository
    {
        Task<IList<ProjectionGetDetailsRes>> GetProjectionsForMovieAsync(ProjectionGetDetailsReq req);
        Task<IList<ProjectionGetDetailsRes>> GetAllProjectionsAsync();
        Task<PlayingNowGetDetailsRes> GetAllProjectionsByDaysAsync();
    }
}
