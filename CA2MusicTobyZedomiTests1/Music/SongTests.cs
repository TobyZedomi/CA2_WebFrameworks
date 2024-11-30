using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA2MusicTobyZedomi.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Intrinsics.X86;

namespace CA2MusicTobyZedomi.Music.Tests
{
    [TestClass()]
    public class SongTests
    {
       

        [TestMethod()]
        public void CompareToTestToTestSongName1OverSongName2InAlphabaetList()
        {
            Console.WriteLine("Test for compareTo method for songName1 over songName2 in the Alphabet list");

            Song song1 = new Song("Euphoria", "Whitney Houston", "Fiona");
            Song song2 = new Song("ABC", "Michael Jackson", "Fiona");

            Assert.AreEqual(1,  song1.CompareTo(song2));   

   
        }

        


        [TestMethod()]
        public void CompareToTestWhenSongName1IsNotOverSongName2InTheAlphabetList()
        {
            Console.WriteLine("Test for compareTo method for songname1 is not over songname2 in the alphabet list");

            Song song1 = new Song("Billie Jean", "Michael Jackson", "Fiona");
            Song song2 = new Song("History", "MJ", "Fiona");

            Assert.AreEqual(-1, song1.CompareTo(song2));

        }


        [TestMethod()]
        public void CompareToTestToTestWhenBothSongNamesAreTheSame()
        {
            Console.WriteLine("Test for compareTo method when both SongNames are the same");

            Song song1 = new Song("History", "Michael Jackson", "Fiona");
            Song song2 = new Song("History", "MJ", "Fiona");

            Assert.AreEqual(0, song1.CompareTo(song2));

        }

        [TestMethod()]
        public void EqualsTestWhenSongsAreEqual()
        {
            Console.WriteLine("Test for if two songs are equal");

            string song = "kanye";
            string artist = "kanye";
         

            Song song1 = new Song(song, artist, "fiona");


            Song song2 = new Song("kanye", "kanye", "toby");

            Assert.AreEqual(true, song1.Equals(song2));


        }

        [TestMethod()]
        public void EqualsTestWhenSongsAreNotEqual()
        {
            Console.WriteLine("Test for if two songs are not");

            string song = "kanye";
            string artist = "kanye";

            Song song1 = new Song(song, artist, "fiona");

            Song song2 = new Song("All Of The Lights", "Kanye", "toby");

            Assert.AreEqual(false, song1.Equals(song2));


        }


    }
}