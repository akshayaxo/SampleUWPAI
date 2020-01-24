using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi
{
    public class MockDatatModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public static ObservableCollection<MockDatatModel> BooksList()
        {
            ObservableCollection<MockDatatModel> books = new ObservableCollection<MockDatatModel>()
            {
                new MockDatatModel()
                {
                    Id=1,
                    Name="The Alchemist",
                    Author="Paulo Coelho",
                    Image="Assets/Images/the-alchemist.jpg",
                    Description="The Alchemist tells the story of a young shepherd named Santiago who is able to find a treasure beyond his wildest dreams. Along the way, he learns to listen to his heart and, more importantly, realizes that his dreams, or his Personal Legend, are not just his but part of the Soul of the Universe."
                },
                new MockDatatModel()
                {
                    Id=2,
                    Name="Alice in the Wonderland",
                    Author="Lewis Carroll",
                    Image="Assets/Images/Alice.jpg",
                    Description="Alice in Wonderland Summary. Alice is sitting with her sister outdoors when she spies a White Rabbit with a pocket watch. Fascinated by the sight, she follows the rabbit down the hole. She falls for a long time, and finds herself in a long hallway full of doors."
                },
                new MockDatatModel()
                {
                    Id=3,
                    Name="Arthashastra",
                    Author="Kautilya",
                    Image="Assets/Images/kautilya.jpeg",
                    Description="Nothing vindicates belief better than reality. Two thousand four hundred years ago Kautilya compiled the Arthashastra and with it he proved to be a kingmaker he enabled the inception of the Gupta dynasty. The Arthashastra endured the test of time and it has since withstood the test of credibility"
                },
                new MockDatatModel()
                {
                    Id=4,
                    Name="As you like it",
                    Author="William Shakespeare",
                    Image="Assets/Images/Asyou.png",
                    Description="As You Like It Summary. Rosalind and her cousin escape into the forest and find Orlando, Rosalind's love. Disguised as a boy shepherd, Rosalind has Orlando woo her under the guise of curing him of his love for Rosalind. Rosalind reveals she is a girl and marries Orlando during a group wedding at the end of the play."
                },


                new MockDatatModel()
                {
                    Id=5,
                    Name="I Do What I Do",
                    Author="Dr. Raghuram Rajan",
                    Image="Assets/Images/Whatido.jpg",
                    Description="Raghuram Rajan was chief economic advisor at that time and may have been taken to be with the government, but he acted differently when he became governor of the Reserve Bank of India himself. ... It is the space where a government can exercise its powers through policy changes/formulations."
                },
                new MockDatatModel()
                {
                    Id=6,
                    Name="Hit Refresh",
                    Author="Satya Nadella",
                    Image="Assets/Images/Hit.jpg",
                    Description="Hit Refresh (publisher: Harper Collins) is a book that is the blueprint Nadella has in mind as he tries to change the culture of Microsoft from know-it-all to learn-it-all. The new culture at Microsoft is all about listening, learning more and talking less. The book is a terrific study in changing culture."
                },
                new MockDatatModel()
                {
                    Id=7,
                    Name="Alice in the Wonderland",
                    Author="Lewis Carroll",
                    Image="Assets/Images/Alice.jpg",
                    Description="Alice in Wonderland Summary. Alice is sitting with her sister outdoors when she spies a White Rabbit with a pocket watch. Fascinated by the sight, she follows the rabbit down the hole. She falls for a long time, and finds herself in a long hallway full of doors."
                },
                new MockDatatModel()
                {
                    Id=8,
                    Name="Arthashastra",
                    Author="Kautilya",
                    Image="Assets/Images/kautilya.jpeg",
                    Description="Nothing vindicates belief better than reality. Two thousand four hundred years ago Kautilya compiled the Arthashastra and with it he proved to be a kingmaker he enabled the inception of the Gupta dynasty. The Arthashastra endured the test of time and it has since withstood the test of credibility"
                },
                new MockDatatModel()
                {
                    Id=9,
                    Name="As you like it",
                    Author="William Shakespeare",
                    Image="Assets/Images/Asyou.png",
                    Description="As You Like It Summary. Rosalind and her cousin escape into the forest and find Orlando, Rosalind's love. Disguised as a boy shepherd, Rosalind has Orlando woo her under the guise of curing him of his love for Rosalind. Rosalind reveals she is a girl and marries Orlando during a group wedding at the end of the play."
                },


                new MockDatatModel()
                {
                    Id=10,
                    Name="I Do What I Do",
                    Author="Dr. Raghuram Rajan",
                    Image="Assets/Images/Whatido.jpg",
                    Description="Raghuram Rajan was chief economic advisor at that time and may have been taken to be with the government, but he acted differently when he became governor of the Reserve Bank of India himself. ... It is the space where a government can exercise its powers through policy changes/formulations."
                },
                new MockDatatModel()
                {
                    Id=11,
                    Name="Hit Refresh",
                    Author="Satya Nadella",
                    Image="Assets/Images/Hit.jpg",
                    Description="Hit Refresh (publisher: Harper Collins) is a book that is the blueprint Nadella has in mind as he tries to change the culture of Microsoft from know-it-all to learn-it-all. The new culture at Microsoft is all about listening, learning more and talking less. The book is a terrific study in changing culture."
                },
                new MockDatatModel()
                {
                    Id=12,
                    Name="The Alchemist",
                    Author="Paulo Coelho",
                    Image="Assets/Images/the-alchemist.jpg",
                    Description="The Alchemist tells the story of a young shepherd named Santiago who is able to find a treasure beyond his wildest dreams. Along the way, he learns to listen to his heart and, more importantly, realizes that his dreams, or his Personal Legend, are not just his but part of the Soul of the Universe."
                }
            };
            return books;
        }
    }
}
