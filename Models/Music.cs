using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Box.Models
{
    internal class Music
    {
       
        string name;
        string artistname;
       public  int Time { get; set; }
        public int Id { get; set; }
        public string Name
        {
            get
            { return name; }
            set
            {
                if(value.Trim().Length> 0 && value.Trim().Length<30)
                {
                    name = value.Trim();
                }
            }
        }
        public string Artistname
        {
            get { return artistname; }
            set 
            { 
                if(value.Trim().Length > 4 && value.Trim().Length<50)
                { artistname = value.Trim(); }
            }
        }
        //public Music(string Name ,string stname , int id)
        //{
        //    name= Name;
        //    artistname = stname;
        //    Id = id;
            
        //}
       
    }
}
