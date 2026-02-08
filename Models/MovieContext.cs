using Microsoft.EntityFrameworkCore;

namespace HW3.Models
{
    public class MovieContext : DbContext 
    {
        public DbSet<Movie> Movies { get; set; }
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                Movies?.Add(new Movie { Title = "2001: A Space Odyssey", Director = "Stanley Kubrick", Genre = "Adventure, Sci-Fi", Year = 1968, Poster = "~/img/2001_space_odyssey.jpg", Description = "When a mysterious artifact is uncovered on the Moon, a spacecraft manned by two humans and one supercomputer is sent to Jupiter to find its origins." });
                Movies?.Add(new Movie { Title = "Donnie Darko", Director = "Richard Kelly", Genre = "Drama, Mystery, Sci-Fi, Thriller", Year = 2001, Poster = "~/img/donnie_darko.jpg", Description = "After narrowly escaping a bizarre accident, a troubled teenager is plagued by visions of a man in a large rabbit suit who manipulates him to commit a series of crimes." });
                Movies?.Add(new Movie { Title = "Drive", Director = "Nicolas Winding Refn", Genre = "Action, Drama", Year = 2011, Poster = "~/img/drive.jpg", Description = "A mysterious Hollywood action film stuntman gets in trouble with gangsters when he tries to help his neighbor's husband rob a pawn shop while serving as his getaway driver." });
                Movies?.Add(new Movie { Title = "Fight Club", Director = "David Fincher", Genre = "Crime, Drama, Thriller", Year = 1999, Poster = "~/img/fight_club.jpg", Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into much more." });
                Movies?.Add(new Movie { Title = "Harakiri", Director = "Masaki Kobayashi", Genre = "Drama, Mystery", Year = 1962, Poster = "~/img/harakiri.jpg", Description = "When a ronin requesting seppuku at a feudal lord's palace is told of the brutal suicide of another ronin who previously visited, he reveals how their pasts are intertwined - and in doing so challenges the clan's integrity." });
                Movies?.Add(new Movie { Title = "Kill Bill: Vol. 1", Director = "Quentin Tarantino", Genre = "Action, Crime, Thriller", Year = 2003, Poster = "~/img/kill_bill_vol1.jpg", Description = "After waking from a four-year coma, a former assassin wreaks vengeance on the team of assassins who betrayed her." });
                Movies?.Add(new Movie { Title = "Pulp Fiction", Director = "Quentin Tarantino", Genre = "Crime, Drama", Year = 1994, Poster = "~/img/pulp_fiction.jpg", Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption." });
                Movies?.Add(new Movie { Title = "Requiem for a Dream", Director = "Darren Aronofsky", Genre = "Drama", Year = 2000, Poster = "~/img/requiem_for_a_dream.jpg", Description = "The drug-induced utopias of four Coney Island people are shattered when their addictions run deep." });
                Movies?.Add(new Movie { Title = "The Matrix", Director = "Lana Wachowski, Lilly Wachowski", Genre = "Action, Sci-Fi", Year = 1999, Poster = "~/img/the_matrix.jpg", Description = "When a beautiful stranger leads computer hacker Neo to a forbidding underworld, he discovers the shocking truth--the life he knows is the elaborate deception of an evil cyber-intelligence." });
                Movies?.Add(new Movie { Title = "Whiplash", Director = "Damien Chazelle", Genre = "Drama, Music", Year = 2014, Poster = "~/img/whiplash.jpg", Description = "A promising young drummer enrolls at a cut-throat music conservatory where his dreams of greatness are mentored by an instructor who will stop at nothing to realize a student's potential." });
                SaveChanges();
            }
        }
    }
}