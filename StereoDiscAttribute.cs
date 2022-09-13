using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes_practice
{
    
        [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        sealed class StereoDiscAttribute : Attribute
        {

        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        //readonly string positionalString;

        // This is a positional argument
        public StereoDiscAttribute(string sname, string lang, string lyr)
        {
            this.Songname = sname;
            this.Language = lang;
            this.Lyrics = lyr;
        }
        // TODO: Implement code here

        //throw new NotImplementedException();







        //public string PositionalString
        //{
        //    get { return positionalString; }
        //}

        // This is a named argument

        public string Songname { get; set; }
        public string Language { get; set; }
            public string Lyrics { get; set; }    

        }
    }

