using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2MusicTobyZedomi.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2MusicTobyZedomi.Music.Tests
{
    [TestClass()]
    public class AlbumTests
    {

        [TestMethod()]
        public void CompareToTestWhenAlbumName1IsOverAlbumName2InAlphabetList()
        {
            Console.WriteLine("CompareTo test when albumName1 is over albumName2 in the alphabet list");

            Album album1 = new Album("Off The Wall", "Michael Jackson");
            Album album2 = new Album("ABC", "Janet Jackson");

            Assert.AreEqual(1, album1.CompareTo(album2));
        }


        [TestMethod()]
        public void CompareToTestWhenAlbumName1IsNotOverAlbumName2InAlphabetList()
        {
            Console.WriteLine("CompareTo test when albumName1 is NOT over albumName2 in the alphabet list");

            Album album1 = new Album("Thriller", "Michael Jackson");
            Album album2 = new Album("Ziggy Stardust", "David Bowie");

            Assert.AreEqual(-1, album1.CompareTo(album2));
        }



        [TestMethod()]
        public void CompareToTestWhenAlbumNameIsTheExactSame()
        {
            Console.WriteLine("CompareTo test when artistName1 is the same as artistName2 in the alphabet list");

            Album album1 = new Album("Off The Wall", "Michael Jackson");
            Album album2 = new Album("Off The Wall", "MJ");

            Assert.AreEqual(0, album1.CompareTo(album2));
        }


        [TestMethod()]
        public void EqualsTestWhenBothAlbumsAreTheSame()
        {
            Console.WriteLine("Test for when both albums are the same");


            Album album1 = new Album("Electric Ladyland", "Jimi Hendrix");
            Album album2 = new Album("Electric Ladyland", "Jimi Hendrix");


            Assert.AreEqual(true, album1.Equals(album2));

        }



        [TestMethod()]
        public void EqualsTestWhenBothAlbumsAreNotTheSame()
        {
            Console.WriteLine("Test for when both albums are not the same");


            Album album1 = new Album("Electric Ladyland", "Jimi Hendrix");
            Album album2 = new Album("Prince Self titled", "Prince");

            Assert.AreEqual(false, album1.Equals(album2));

        }
    }
}