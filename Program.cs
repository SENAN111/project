using Music_Box.Models;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Music_Box
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Music> Playlist = new List<Music>();
            Playlist.Add(new Music { Name = "sen ogrusan", Artistname = "mahirAYbrat", Id = 444, Time = 300 });
        yeni:
            Console.WriteLine("Emelyyati secin");
            Console.WriteLine("1) Mahni yarat");
            Console.WriteLine("2) Playlistdəki mahnılara bax.");
            Console.WriteLine("3)  Playlistə mahnı əlavə et");
            Console.WriteLine("4) Mahnı qoş");
            string emeliyyat = Console.ReadLine();
            switch (emeliyyat)
            {
                case "1":



                    Playlist.Add(new Music { Name = Console.ReadLine(), Artistname = Console.ReadLine(), Id = Convert.ToInt32(Console.ReadLine()), Time = Convert.ToInt32(Console.ReadLine()) });
                    foreach (Music music in Playlist)
                    {
                        Console.WriteLine(music.Name + music.Artistname + music.Id + music.Time);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        //static string play()
                        //{
                        //    foreach (Music music in Playlist)
                        //    {
                        //        string musicname = Console.ReadLine();
                        //        if (music.Name == musicname)
                        //        {
                        //            Console.WriteLine(musicname);
                        //        }
                        //    }



                    }
                    goto yeni;
                    break;

                case "2":
                    foreach (Music music in Playlist)
                    {
                        Console.WriteLine(music.Name + " " + music.Artistname + " " + music.Id + " " + music.Time + "");
                        Console.WriteLine("---------------------------------------------------------------------");
                    }
                    break;
                case "3":
                    break;
                    case "4":
                    break; 
                default: Console.WriteLine("dogru emeliyyat secin");
                    goto yeni;

                    
            }
        }
           
    }
        
 }
