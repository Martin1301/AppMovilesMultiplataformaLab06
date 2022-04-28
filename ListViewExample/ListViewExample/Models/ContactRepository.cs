using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample.Models
{

    public class ContactRepository
    {
        public IList<Contact> GetContacts { get; private set; }

        public ContactRepository()
        {
            GetContacts = new List<Contact> {
                new Contact { Name = "Alex Silveira", Email = "egestas@anequeNullam.co.uk", Fone="9985-5623" },
                new Contact { Name = "Yuri Herrera", Email = "velit@erat.org" , Fone ="9985-5623" },
                new Contact { Name = "Lucas Brown", Email = "magnis@Cumsociis.org" , Fone ="9985-5623" },
                new Contact { Name = "Gilson Reilly", Email = "vel@NullamenimSed.com" , Fone ="9985-5623" },
                new Contact { Name = "Arsenio Suarez", Email = "ridiculus.mus.Aenean@tellusfaucibusleo.co.uk" , Fone ="9985-5623" },
                new Contact { Name = "Igor Mclaughlin", Email = "ut.lacus.Nulla@Aliquamnec.edu" , Fone ="9985-3023" },
                new Contact { Name = "Carla Craft", Email = "Etiam.gravida.molestie@rutrummagna.ca" , Fone ="9985-3023" },
                new Contact { Name = "Benedito Carson", Email = "adipiscing@enimMauris.edu" , Fone ="9985-3023" },
                new Contact { Name = "Roberto Reynolds", Email = "commodo@sapienmolestie.edu" , Fone ="9985-3023" },
                new Contact { Name = "Denis Webb", Email = "sit.amet.consectetuer@Loremipsumdolor.org" , Fone ="9985-2123" },
                new Contact { Name = "Jacob Singleton", Email = "sem.consequat@vehiculaPellentesque.co.uk" , Fone="9985-2123" },
                new Contact { Name = "Carina Tucker", Email = "molestie@erosturpis.ca" , Fone ="9985-2123" },
                new Contact { Name = "Felix Holder", Email = "sollicitudin.a@Curae.co.uk" , Fone ="9985-1123" },
                new Contact { Name = "Mateus Reid", Email = "Etiam.bibendum@Donecat.edu" , Fone ="9985-1123" },
                new Contact { Name = "Anabel Noel", Email = "rhoncus.Donec@vel.edu" , Fone ="9985-4123" },
                new Contact { Name = "Karina Dunlap", Email = "lectus@risusQuisque.co.uk" , Fone ="9985-3123" },
                new Contact { Name = "Silvio Ewing", Email = "cubilia@afeugiattellus.ca" , Fone ="9985-5123" },
                new Contact { Name = "Lucas Reed", Email = "id.risus@Aliquam.edu" , Fone ="9985-4423" },
                new Contact { Name = "Geraldo Huff", Email = "non.arcu.Vivamus@fames.edu" , Fone ="9985-0923" },
                new Contact { Name = "Fernando Carroll", Email = "ut.nisi.a@elit.edu" , Fone ="9985-0923" },
                new Contact { Name = "Leonardo Hamilton", Email = "vitae@penatibusetmagnis.net" , Fone ="9985-0923" },
                new Contact { Name = "Myles Knowles", Email = "vitae.aliquam@magna.org" , Fone ="9985-0923" },
                new Contact { Name = "Cristina Schmidt", Email = "imperdiet.dictum.magna@vitaeerat.org" , Fone ="9985-0923" },
                new Contact { Name = "Thais Ball", Email = "Cras.eu@ataugue.net" , Fone ="9985-0923" },
                new Contact { Name = "Renato Mclean", Email = "leo@vitaenibh.net" , Fone ="9985-2323" },
                new Contact { Name = "Celio Rogers", Email = "eros.turpis.non@ettristique.co.uk" , Fone ="9985-1023" },
                new Contact { Name = "Otavio Estes", Email = "vel@ac.edu" , Fone ="9985-7723"},
                new Contact { Name = "Martin Romani", Email = "martin@ac.edu" , Fone ="9654-3321"},
            };
        }
    }

}
