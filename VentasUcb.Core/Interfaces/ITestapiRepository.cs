using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VentasUcb.Core.Entities;

namespace VentasUcb.Core.Interfaces
{
    public interface ITestapiRepository
    {
        Task<IEnumerable<TestApi>> GetTestapi();
    }
}