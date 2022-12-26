using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWPF.Model
{
    public class MovieNode : INode
    {
        public MovieNode(Movie m)
        {
            Movie = m;
        }
        public string Name { get => Movie.Name; }
        public Movie Movie { get; private set; }

    }
}
