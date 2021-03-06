﻿using System.Collections.Generic;

namespace MovieSearch.Data
{
    public class MovieSearchResult
    {
        public IEnumerable<MovieShortData> Search { get; set; }
        public int TotalResults { get; set; }
        public bool Response { get; set; }
        public string Error { get; set; }
    }
}
