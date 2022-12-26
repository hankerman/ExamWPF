using ExamWPF.Set;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWPF.Model
{
    public class Movie_DB : NotifyClass
    {
        private static Movie_DB _context;
        public static Movie_DB Context => _context ?? (_context = new Movie_DB());
        public Movie_DB()
        {
            MoviesNode = new List<MovieNode>();
            MovieNodeInit();
        }
        public List<Movie> Movies { get; set; } = new List<Movie> ()
        {
            new Movie(){Name = "Зеленая миля", Teg= new List<string>(){}, YearOfRelease = 1999, Description = "В тюрьме для смертников появляется заключенный с божественным даром.\n Мистическая драма по роману Стивена Кинга",
                CountryOfIssue = "США", FilmCompany = "Castle Rock Entertainment"},
            new Movie(){Name = "Назад в будущее", Teg= new List<string>(){}, YearOfRelease = 1985, Description = "Безумный ученый и 17-летний оболтус тестируют машину времени, наводя шороху в 1950-х.\n Классика кинофантастики",
                CountryOfIssue = "США", FilmCompany = "Юниверсал Пикчерс"},
            new Movie(){Name = "Иван Васильевич меняет профессию ", Teg= new List<string>(){}, YearOfRelease = 1973, Description = "Иван Грозный отвечает на телефон, пока его тезка-пенсионер сидит на троне.\n Советский хит о липовом государе",
                CountryOfIssue = "СССР", FilmCompany = "Мосфильм"},
            
        };
        public List<MovieNode> MoviesNode { get; set; }
        private void MovieNodeInit()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                MovieNode m = new MovieNode(Movies[i]);
                MoviesNode.Add(m);
            }
        }
    }
}
