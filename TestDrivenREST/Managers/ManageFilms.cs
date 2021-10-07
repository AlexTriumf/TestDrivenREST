using ModelLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TestDrivenREST.Managers
{
    public class ManageFilms : IManageFilm
    {
        private static List<Film> _data = new List<Film>()
        {
            new Film(1, "Adams Æbler", 2, new List<DateTime>(){new DateTime(2016,1,1,3,15,0), new DateTime(2016, 1, 1, 5, 15,0)}),
            new Film(2, "Blinkende Lygter", 3, new List<DateTime>(){new DateTime(2016, 01,01,3,15,0), new DateTime(2016, 02, 03, 3, 20, 0)}),
            new Film(3, "Abernes planet", 4, new List<DateTime>() {new DateTime(2016, 01, 01, 05, 20,0), new DateTime(2016, 1, 1, 3, 30,0)})

        };

        public static List<Film> Data
        {
            get => _data;
            set => _data = value;
        }

        public Film GetProgram(string title)
        {
            return _data.Find(d => d.Title == title);
        }

        public bool Create(Film film)
        {
            _data.Add(film);
            return true;
        }

        public Film Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> Get()
        {
            return new List<Film>(_data);
        }

        public Film Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Film> GetDateTime(string DateTime)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, Film film)
        {
            throw new NotImplementedException();
        }
    }
}
