using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEntidad
{
    public interface IEntidad<T>
    {
        public int ID { get; set; }
    }
}
