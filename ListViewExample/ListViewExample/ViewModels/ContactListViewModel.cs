using ListViewExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListViewExample.ViewModels
{

    public class ContactListViewModel
    {

        public IList<Contact> Items { get; private set; }
        public List<ObservableGroupCollection<string, Contact>> GroupedData { get; set; }

        public int ItemsCount { get; private set; }
        public string MyNumber { get; set; } = "+51 9874-5431";

        public ContactListViewModel()
        {
            var repo = new ContactRepository();
            Items = repo.GetContacts.OrderBy(c => c.Name).ToList();

            GroupedData = Items.OrderBy(p => p.Name)
               .GroupBy(p => p.Name[0].ToString())
               .Select(p => new ObservableGroupCollection<string, Contact>(p)).ToList();

            ItemsCount = repo.GetContacts.Count;
        }

    }

}
