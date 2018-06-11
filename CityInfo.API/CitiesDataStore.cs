using CityInfo.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The Big Apple",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "Most visited urban park in the US."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Skyscraper in Midtown Manhattan."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Chicago",
                    Description = "The Windy City",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Millenium Park",
                            Description = "Has a bean."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Willis Tower",
                            Description = "Skyscraper in The Loop."
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Seattle",
                    Description = "The Emerald City",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Space Needle",
                            Description = "Built for the 1962 World Fair, it is 605 feet tall."
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Pike Place Market",
                            Description = "Iconic fish market with the iconic original Starbucks and over 255 local artisans selling wares daily."
                        }
                    }
                }
            };
        }
        
    }
}
