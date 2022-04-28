using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            //ObservableCollection allows to be added after ItemsSource
            //is set and the UI will react to changes
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { DisplayName = "Rob Finnerty" });
            employees.Add(new Employee { DisplayName = "Emanuel Delgado" });
            employees.Add(new Employee { DisplayName = "Pedro Quintana" });
            employees.Add(new Employee { DisplayName = "Anderson Palomino" });
            employees.Add(new Employee { DisplayName = "Kevin Layne" });
            employees.Add(new Employee { DisplayName = "Roberto Mendoza" });
        }
    }
}