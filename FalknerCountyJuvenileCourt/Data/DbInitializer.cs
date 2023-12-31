using FalknerCountyJuvenileCourt.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FalknerCountyJuvenileCourt.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CourtContext context)
        {
            // Look for any students.
            if (context.Juveniles.Any()) {
                return;   // DB has been seeded
            }

            var j0 = new Juvenile {
               ID = 1,
               FaulknerCountyIdentification = "12d",
               RiskID = 1,
               RaceID = 1,
               GenderID = 2,
               Repeat = false,
               Age = 13
            };

            var j1 = new Juvenile {
               ID = 2,
               FaulknerCountyIdentification = "122d",
               RiskID = 4,
               RaceID = 3,
               GenderID = 1,
               Repeat = false,
               Age = 16
            };

            var j2 = new Juvenile {
               ID = 3,
               FaulknerCountyIdentification = "12221d",
               RiskID = 2,
               RaceID = 1,
               GenderID = 2,
               Repeat = true,
               Age = 14
            };

            var j3 = new Juvenile {
               ID = 4,
               FaulknerCountyIdentification = "12dddd",
               RiskID = 3,
               RaceID = 2,
               GenderID = 1,
               Repeat = false,
               Age = 11
            };

            var j4 = new Juvenile {
               ID = 5,
               FaulknerCountyIdentification = "1dd2d",
               RiskID = 1,
               RaceID = 4,
               GenderID = 2,
               Repeat = false,
               Age = 18
            };

            var j5 = new Juvenile {
               ID = 6,
               FaulknerCountyIdentification = "12sasdd",
               RiskID = 2,
               RaceID = 1,
               GenderID = 1,
               Repeat = true,
               Age = 13
            };

            var j6 = new Juvenile {
               ID = 7,
               FaulknerCountyIdentification = "12werd",
               RiskID = 4,
               RaceID = 1,
               GenderID = 2,
               Repeat = false,
               Age = 11
            };

            var j7 = new Juvenile {
               ID = 8,
               FaulknerCountyIdentification = "12999d",
               RiskID = 1,
               RaceID = 2,
               GenderID = 2,
               Repeat = false,
               Age = 16
            };

            var j8 = new Juvenile {
               ID = 9,
               FaulknerCountyIdentification = "12dkkkkk",
               RiskID = 2,
               RaceID = 3,
               GenderID = 2,
               Repeat = false,
               Age = 17
            };

            var j9 = new Juvenile {
               ID = 10,
               FaulknerCountyIdentification = "12d86532",
               RiskID = 4,
               RaceID = 1,
               GenderID = 1,
               Repeat = false,
               Age = 11
            };

            var j10 = new Juvenile {
               ID = 11,
               FaulknerCountyIdentification = "ooi12d",
               RiskID = 4,
               RaceID = 1,
               GenderID = 1,
               Repeat = true,
               Age = 17
            };

            var juveniles = new Juvenile[] {
               j0,
               j1,
               j2,
               j3,
               j4,
               j5,
               j6,
               j7,
               j8,
               j9,
               j10
            };

            context.AddRange(juveniles);

            var s1 = new School {
               ID = 1,
               Name = "Conway High School"
            };

            var s2 = new School {
               ID = 2,
               Name = "Conway Junior High"
            };

            var schools = new School[] {
               s1,
               s2
            };

            context.AddRange(schools);

            var risks = new Risk[] {
               new Risk {
                  ID = 1,
                  Name = REnum.Unknown
               },
               new Risk {
                  ID = 2,
                  Name = REnum.Low
               },
               new Risk {
                  ID = 3,
                  Name = REnum.Medium
               },
               new Risk {
                  ID = 4,
                  Name = REnum.High 
               },
            };

            context.AddRange(risks);

            var races = new Race[] {
               new Race {
                  ID = 1,
                  Name = "Caucasian"
               },
               new Race {
                  ID = 2,
                  Name = "African American"
               },
               new Race {
                  ID = 3,
                  Name = "Asian"
               },
               new Race {
                  ID = 4,
                  Name = "American Indian and Alaska Native"
               },
               new Race {
                  ID = 5,
                  Name = "Native Hawaiian and Other Pacific Islander"
               },
               new Race {
                  ID = 6,
                  Name = "Two or more races"
               },
            };

            context.AddRange(races);

            var intakeDecisions = new IntakeDecision[] {
               new IntakeDecision {
                  ID = 1,
                  Name = "Cite and Release"
               },
               new IntakeDecision {
                  ID = 2,
                  Name = "Detention Alternative"
               },
               new IntakeDecision {
                  ID = 3,
                  Name = "Detention"
               },
            };

            context.AddRange(intakeDecisions);

            var genders = new Gender[] {
               new Gender {
                  ID = 1,
                  Name = "Male"
               },
               new Gender {
                  ID = 2,
                  Name = "Female"
               },
            };

            context.AddRange(genders);

            var filingDecisions = new FilingDecision[] {
               new FilingDecision {
                  ID = 1,
                  Name = "Delinquency Petition Filed"
               },
               new FilingDecision {
                  ID = 2,
                  Name = "Case Diverted"
               },
               new FilingDecision {
                  ID = 3,
                  Name = "Nothing Further"
               },
            };

            context.AddRange(filingDecisions);

            var offenses = new Offense[] {
               new Offense {
                  ID = 1,
                  Name = "Fleeing"
               },
               new Offense {
                  ID = 2,
                  Name = "Battery 3rd"
               },
               new Offense {
                  ID = 3,
                  Name = "Disorderly Conduct"
               },
            };

            context.AddRange(offenses);

            var c0 = new Crime {
               ID = 1,
               JuvenileID = 1,
               OffenseID = 3,
               FilingDecisionID = 1,
               IntakeDecisionID = 2,
               SchoolID = 1,
               DrugOffense = false,
               DrugCourt = false,
               Date = DateTime.Parse("2000-01-01")
            };

            var c1 = new Crime {
               ID = 2,
               JuvenileID = 3,
               OffenseID = 2,
               FilingDecisionID = 3,
               IntakeDecisionID = 3,
               SchoolID = 2,
               DrugOffense = false,
               DrugCourt = false,
               Date = DateTime.Parse("1940-01-01")
            };

            var c2 = new Crime {
               ID = 3,
               JuvenileID = 3,
               OffenseID = 2,
               FilingDecisionID = 3,
               IntakeDecisionID = 3,
               SchoolID = 2,
               DrugOffense = false,
               DrugCourt = false,
               Date = DateTime.Parse("2023-11-08")
            };

            var crimes = new Crime[] {
               c0,
               c1,
               c2
            };

            context.AddRange(crimes);
            context.SaveChanges();
        }
    }
}