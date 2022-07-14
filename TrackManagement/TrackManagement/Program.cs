using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrackManagement
{
    public class Program
    {
        public static List<Track> tracks = new List<Track>()
        {
            new Track { TrackId=1 ,TrackName="track1",TrackDuration=DateTime.Now,TrackLead ="Track Lead 1",NumberOfCampusMinds=2 },
            new Track { TrackId=2 ,TrackName="track2",TrackDuration=DateTime.Now,TrackLead = "Track Lead 2",NumberOfCampusMinds=4 }
        };

        public static void Main()
        {
            Console.WriteLine("--------------------Track Management Application--------------------");
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\tA - Add New Trak");
            Console.WriteLine("\tU - Update a Track");
            Console.WriteLine("\tL - Get All Tracks");
            Console.WriteLine("\tI - Get Track By Id");
            Console.WriteLine("\tD - Delete Track");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "A":
                    for (int i = 1; i < 6; i++)
                    {
                        Console.Write("TrackId: ");
                        int Id = int.Parse(Console.ReadLine());

                        Console.Write("TrackName: ");
                        string name = Console.ReadLine();

                        Console.Write("TrackDuration: ");
                        DateTime duration = DateTime.Parse(Console.ReadLine());

                        Console.Write("TrackLead: ");
                        string lead = Console.ReadLine();

                        Console.Write("NumberOfCampusMinds: ");
                        int count = int.Parse(Console.ReadLine());
                        Track _track = new Track(Id, name, duration, lead, count);
                        AddTrack(_track);
                    }
                    break;

                case "U":
                    for (int i = 1; i < 6; i++)
                    {
                        Console.Write("TrackId: ");
                        int Id = int.Parse(Console.ReadLine());

                        Console.Write("TrackName: ");
                        string name = Console.ReadLine();

                        Console.Write("TrackDuration: ");
                        DateTime duration = DateTime.Parse(Console.ReadLine());

                        Console.Write("TrackLead: ");
                        string lead = Console.ReadLine();

                        Console.Write("NumberOfCampusMinds: ");
                        int count = int.Parse(Console.ReadLine());
                        Track _track = new Track(Id, name, duration, lead, count);
                        UpdateTrack(_track);
                    }
                    break;

                case "L":
                    ShowAllTracks();
                    break;

                case "I":
                    Console.WriteLine("Enter Track Id:");
                    int id = int.Parse(Console.ReadLine());
                    GetTrackById(id);
                    break;

                case "D":
                    Console.WriteLine("Enter Track Id:");
                    int trackid = int.Parse(Console.ReadLine());
                    RemoveTrackById(trackid);
                    break;
            }
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }

        /// <summary>
        /// Add a track
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        public static IEnumerable<Object> AddTrack(Track track)
        {
            tracks.Add(track);
            List<Object> result = new List<Object>();
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    foreach (PropertyInfo prop in tracks[i].GetType().GetProperties())
                    {
                        result.Add(prop.GetValue(tracks[i], null));
                    }
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(result[j]);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        /// <summary>
        /// Update a track
        /// </summary>
        /// <param name="track"></param>
        /// <returns></returns>
        public static IEnumerable<Object> UpdateTrack(Track track)
        {
            List<Object> result = new List<Object>();
            try
            {
                    if (tracks[0].TrackId == track.TrackId)
                    {
                    tracks[0].TrackName = track.TrackName;
                    tracks[0].TrackDuration = track.TrackDuration;
                    tracks[0].TrackLead = track.TrackLead;
                    tracks[0].NumberOfCampusMinds = track.NumberOfCampusMinds;
                        result.Add(tracks[0]);
                    }
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        /// <summary>
        /// Show all tracks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Object> ShowAllTracks()
        {
            List<Object> result = new List<Object>();
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    foreach (PropertyInfo prop in tracks[i].GetType().GetProperties())
                    {
                        result.Add(prop.GetValue(tracks[i], null));
                    }
                    for (int j = 0; j < 5; j++)
                    {
                        Console.WriteLine(result[j]);
                    }
                }
            }          
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        /// <summary>
        /// Get track by id
        /// </summary>
        /// <param name="TrackId"></param>
        /// <returns></returns>
        public static IEnumerable<Object> GetTrackById(int TrackId)
        {
            List<Object> result = new List<Object>();
            try
            {
                for (int i = 0; i < 1; i++)
                {
                    foreach (PropertyInfo prop in tracks[i].GetType().GetProperties())
                    {
                        if (tracks[i].TrackId == TrackId)
                        {
                            result.Add(prop.GetValue(tracks[i], null));
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return result;
        }

        /// <summary>
        /// Delete track from list
        /// </summary>
        /// <param name="TrackId"></param>
        /// <returns></returns>
        public static IEnumerable<Track> RemoveTrackById(int TrackId)
        {
            try
            {
                if (tracks[0].TrackId == TrackId)
                {
                    tracks.RemoveAt(0);
                }
            }           
            catch (Exception)
            {
                return null;
            }
            return tracks;
        }
    }
}

