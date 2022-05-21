using Microsoft.AspNetCore.Mvc.Rendering;

using System.Collections.Generic;


namespace MvcMovie.Models

{
    /*Adición de búsqueda por género*/
    public class MovieGenreViewModel

    {

        public List<Movie> Movies { get; set; }

        public SelectList Genres { get; set; }

        public string MovieGenre { get; set; }

        public string SearchString { get; set; }

    }

}
