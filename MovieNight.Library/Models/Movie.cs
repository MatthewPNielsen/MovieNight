using MovieNight.Library.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieNight.Library.Models
{
    public class Movie : AModel
    {
        public List<Actor> Actors
        {
            get;
            set;
        }

        public List<Voter> Votes
        {
            get;
            set;
        }

        public Movie()
        {
            Actors = new List<Actor>()
            {
                new Actor()
            };
            Votes = new List<Voter>()
            {
                new Voter()
            };
        }
    }
}
