﻿using System;
using System.Collections.Generic;

namespace MovieSearch.Data
{
    public class MovieData
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public DateTime Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Poster { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        public int Metascore { get; set; }
        public float ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string ImdbID { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public bool Response { get; set; }
        public string Error { get; set; }
    }
}
