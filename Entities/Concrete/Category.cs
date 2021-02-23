using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category1:IEntity
    {
        //Çıplak Class Kalmasın
        public int CategoryId { get; set; }
        public string CatgeoryName { get; set; }
    }
}
