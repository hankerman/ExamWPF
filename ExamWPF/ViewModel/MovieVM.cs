using ExamWPF.Model;
using ExamWPF.Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ExamWPF.ViewModel
{
    public class MovieVM : NotifyClass
    {
        public MovieVM()
        {
            Orders = Movie_DB.Context.Movies.ToList();
        }
        public List<Movie> Orders { get; set; }
        public List<Movie> SelectedOrders { get; set; }
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }
        //public void UpdateListOrders()
        //{
        //    Orders = Movie_DB.Context.Movies.Where(x => _searchText == String.Empty || _searchText == null);
        //    OnPropertyChanged("Orders");
        //    //OnPropertyChanged();
        //}
        public void DeleteOrders()
        {
            foreach (var r in SelectedOrders)
            {
                Movie_DB.Context.Movies.Remove(r);
            }
            //Orders.RemoveAll(x=>SelectedOrders.Contains(x));
            Orders = Movie_DB.Context.Movies.ToList();
            SelectedOrders.Clear();
            //перерисовка можно использовать nameoff(Orders)
            OnPropertyChanged("Orders");
        }
    }
}
