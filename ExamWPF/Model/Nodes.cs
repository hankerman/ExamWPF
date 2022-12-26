using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWPF.Model
{
    public class Nodes : INode
    {
        public string Name { get; set; }
        public List<INode> MovieNodes { get; set; }
    }
}
