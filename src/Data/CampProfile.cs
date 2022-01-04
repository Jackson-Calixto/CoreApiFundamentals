using AutoMapper;
using CoreCodeCamp.Model;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            this.CreateMap<Camp, CampModel>()
                .ForMember(c => c.Venue, o => o.MapFrom(m => m.Location.VenueName));

            this.CreateMap<CampModel, Camp>();
            this.CreateMap<CampModel, LocationModel>();
            this.CreateMap<Location, LocationModel>();
            this.CreateMap<Talk, TalkModel>();
            this.CreateMap<Speaker, SpeakerModel>();
        }
    }
}
