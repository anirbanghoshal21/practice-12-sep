using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomAttributes_practice
{
    [StereoDisc(Songname = "Faded" , Language = "English" , Lyrics = " So lost I'm faded") ]
    public class Song
    {
        [StereoDisc(Songname = "Blackbird", Language = "English", Lyrics = "Take these broken wings")]
        public string Name { get; set; }
        [StereoDisc(Songname = "Thinking out loud", Language = "English", Lyrics = "Take me into your arms")]
        public string Description { get; set; }

        [StereoDisc(Songname = "How soon is now", Language = "English", Lyrics = "I am the son")]
        public Song()
        {

        }
       
    }
}
