using SacramentPlanner.Models;
using System;
using System.Linq;

namespace SacramentPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }

            var meetings = new Meeting[]
            {
            new Meeting{MeetingDate=DateTime.Parse("2005-09-01"),ConductingLeader="Mathew Bahling",OpeningSong="301 I am a Child of God", SacramentSong="172 In Humility, Our Savior", ClosingSong="2 Spirit of God", IntermediateSong="", OpeningPrayer="Bekah Howe", ClosingPrayer = "Kent Roper"}
            };

            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var speakers = new Speaker[]
            {
                new Speaker{MeetingID=1, SpeakerName="Bro Blazzard", Subject=".Net and the Gospel"}
            };
            foreach (Speaker s in speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();

            
        }
    }
}
