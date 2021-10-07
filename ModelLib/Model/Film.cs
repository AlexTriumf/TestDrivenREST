using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Model
{
    public class Film
    {
        private int _id;
        private string _title;
        private int _sal;
        private List<DateTime> _program;

        public Film()
        { }

        public Film(int id, string title, int sal, List<DateTime> program)
        {
            _id = id;
            _title = title;
            _sal = sal;
            List<DateTime> _program = program;
        }

        public List<DateTime> Program
        {
            get => _program;
            set => _program = value;
        }


        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public int Sal
        {
            get => _sal;
            set => _sal = value;
        }


        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public override string ToString()
        {
            return $"{nameof(Program)}: {Program}, {nameof(Title)}: {Title}, {nameof(Sal)}: {Sal}, {nameof(Id)}: {Id}";
        }
    }
}
