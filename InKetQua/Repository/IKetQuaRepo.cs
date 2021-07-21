using InKetQua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InKetQua.Repository
{
    public interface IKetQuaRepo
    {
        Task<IList<KetQuaVm>> GetListKetQuaChuaIn(string tuNgay, string denNgay);
        Task<IList<KetQuaVm>> GetListKetQuaDaIn(string tuNgay, string denNgay, string Query);

        Task<IList<KetQuaXnImport>> GetListKetQuaImport(string tuNgay, string denNgay, string textFile);

        Task<KetQuaVm> GetKetQuaById(int id, string tuNgay, string denNgay);
        Task<int> UpdateDaIn(int id);
    }
}
