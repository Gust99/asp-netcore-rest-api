using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentasUcb.Core.Entities;
using VentasUcb.Core.Interfaces;

namespace VentasUcb.Infraestructure.Repositories
{
    public class TestapiRepository : ITestapiRepository
    {
        public async Task<IEnumerable<TestApi>> GetTestapi()
        {
            var result = Enumerable.Range(1, 10).Select(x => new TestApi
            {
                TestapiId = x,
                Descripcion = $"Descripcion {x}",
                Fecha = DateTime.Now,
                Imagen = $"https://misapis.com/{x}",
                UserId = x * 5
            });
            await Task.Delay(10);
            return result;
        }
    }
}
