using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Teoria10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewDemo : ContentPage
    {
        public ListViewDemo()
        {
            InitializeComponent();
            //En este caso A es un ListView
            //En este caso B es una lista
            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = "Hugo", LastName = "Torrico",Age=34 });
            people.Add(new Person { FirstName = "Guissela", LastName = "Gamarra",Age=20 });
            people.Add(new Person { FirstName = "Sebastián", LastName = "Márquez", Age = 25 });

            foreach (var item in people)
            {
                item.Color = Color.Green;
                if (item.Age > 30)
                    item.Color = Color.Red;
            }

            this.lvPeople.ItemsSource = people;

        }
    }
}