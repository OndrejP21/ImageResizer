using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    internal class Picture
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Image Image { get; set; }

        public Picture(string name, string location)
        {
            Name = name;
            Location = location;
            Image = Image.FromFile(location);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
