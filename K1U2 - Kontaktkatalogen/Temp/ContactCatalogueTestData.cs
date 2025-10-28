using K1U2___Kontaktkatalogen.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.Temp
{
    internal class ContactCatalogueTestData
    {

        public void Run(ContactCatalog cc)
        {
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Ava Harper", "ava.harper@example.com", "friend, coworker"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Ben Carter", "ben.carter@example.com", "family"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Clara Nguyen", "clara.nguyen@example.org", "work"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Diego Morales", "diego.morales@gmail.com", "gym, friend"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Eva Thompson", "eva.thompson@outlook.com", "neighbor"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Frank Liu", "frank.liu@company.com", "work, manager"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Grace Lee", "grace.lee@gmail.com", "friend, school"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Hector Ramirez", "hector.ramirez@mail.com", "guitar, band"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Iris Patel", "iris.patel@domain.com", "friend, colleague"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Jon Smith", "jon.smith@example.com", "school"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Kira Johnson", "kira.johnson@pobox.com", "friend"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Liam O'Connor", "liam.oconnor@example.com", "young"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Mona Rossi", "mona.rossi@art.com", "artist"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Noah Brown", "noah.brown@home.com", "family"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Olivia Martin", "olivia.martin@example.com", "work, lead"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Pablo Suarez", "pablo.suarez@studio.com", "photography"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Quinn Blake", "quinn.blake@example.com", "gym"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Rita Gomez", "rita.gomez@mail.com", "friend, cooking"));
            cc.AddContact(new Contact(cc.MakeUniqueID(), "Sam Walker", "sam.walker@tech.io", "dev, coworker"));
        }
    }
}
