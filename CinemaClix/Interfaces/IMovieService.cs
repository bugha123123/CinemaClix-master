﻿using CinemaClix.Models;

namespace CinemaClix.Interfaces
{
    public interface IMovieService
    {

        List<Movie> GetMovieList();
        List<Movie> GetMoviesByCategory(string category);
        Movie GetMovieById(int id);
        IEnumerable<Movie> GetPopularMoviesByGenre(string genre, int rating);
        Task AddToWatchlist(WatchListedMovie watchListedMovie, int id);

        Task<List<WatchListedMovie>> GetAllWatchlist();

        Task RemoveWatchListById(string MovieTitle);

        Task LikeMovie(int id);

        Task<List<Likes>> GetAllLikes();

        Task<bool> IsAlreadyLiked(int id);

        Task DeleteLike(int MovieId);

        List<Movie> GetAll(string MovieTitle);

        Task<List<Movie>> Get10MoviesForSlider();
    }
}
