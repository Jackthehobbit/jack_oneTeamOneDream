using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jack_oneTeamOneDreamEntities
{
    public class ProductImage
    {
        public ProductImage()
        {

        }
        public int Id { get; private set; }

        public byte[] Image { get; set; }
    }
}
