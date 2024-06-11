using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeOnTap2
{
    public interface INhanVien
    {
        string MaSo {  get; }
        int NamSinh { get; }
        string Ten { get; set; }
    }
}
