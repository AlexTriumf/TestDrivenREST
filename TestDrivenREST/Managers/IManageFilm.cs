using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;

namespace TestDrivenREST.Managers
{
    public interface IManageFilm
    {
        IEnumerable<Film> Get();

        Film GetProgram(string title);

        Film Get(int id);

        IEnumerable<Film> GetDateTime(string DateTime);

        bool Create(Film film);

        bool Update(int id, Film film);
        Film Delete(int id);


    }
}
