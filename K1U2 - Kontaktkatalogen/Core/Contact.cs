using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1U2___Kontaktkatalogen.Core
{
    internal class Contact
    {
        public string Id;
        public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Tags { get; set; }

        public Contact(string id, string name, string email, string tags)
        {
            Name = name;
            Email = email;
            Id = id;
            Tags = tags.Split(",").Select(t => t.Trim()).ToList();

        }

        public override string ToString()
        {
            return $"{Name} | {Email} | {String.Join(", ", Tags)}";
        }
    }
}
