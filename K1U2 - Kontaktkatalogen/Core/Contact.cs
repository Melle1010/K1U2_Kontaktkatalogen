using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.Core
{
    internal class Contact
    {
        public String Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Tags { get; set; }

        public Contact(String id, string name, string email, List<string> tags)
        {
            Id = id;
            Name = name;
            Email = email;
            Tags = tags;
        }

        public override string ToString()
        {
            string tags = "";
            foreach (string tag in Tags) { 
                tags += tag+", ";
            }
            return $"({Id}) {Name}, {Email}, Tags: {tags} ";
        }
    }
}
