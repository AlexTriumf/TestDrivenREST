using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelLib.Model;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using TestDrivenREST.Controllers;
using TestDrivenREST.Managers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public MovieController MC;
        public ManageFilms MF;
        public Film film;

        [TestInitialize]
        public void BeforeHand()
        {
            MC = new MovieController();
            MF = new ManageFilms();
        }

        [TestMethod]
        public void GetAll()
        {
            List<Film> movieList = ManageFilms.Data;
            List<Film> restList = new List<Film>();
            restList = MC.Get().ToList();

            CollectionAssert.AreEqual(movieList, restList);

        }
        [TestMethod]
        public void GetByDate()
        {
            //alle fil på en dato
            List<Film> movieList = ManageFilms.Data;
            Film program = MC.GetProgram("Adams æbler");
            Assert.AreEqual(movieList.Find(d => d.Title == "Adams æbler"), program);
        }
        [TestMethod]
        public void EnFilmGetByDate()
        {
            //alle afspilningstider til en film
        }
        [TestMethod]
        public void Create()
        {
            //oprette film
        }
        [TestMethod]
        public void Delete()
        {
            //slet film
        }
        [TestMethod]
        public void Update()
        {
            //update film via datetime
        }

    }
}
