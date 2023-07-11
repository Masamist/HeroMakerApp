using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMaker
{
    public class Hero : IComparable
    {
        public Hero() 
        {
        }

        public Hero(string name, bool[] specialAbilities, List<string> officeLocation, string preferredTransport, int speed, int stamina, int strength, DateTime birthday, DateTime superPowerDiscoveryDate, DateTime fatefulDay, decimal yearsExperience, string capeColor, int darkSidePropensity, string portraitPhoto)
        {
            Name = name;
            SpecialAbilities = specialAbilities;
            OfficeLocation = officeLocation;
            PreferredTransport = preferredTransport;
            Speed = speed;
            Stamina = stamina;
            Strength = strength;
            Birthday = birthday;
            SuperPowerDiscoveryDate = superPowerDiscoveryDate;
            FatefulDay = fatefulDay;
            YearsExperience = yearsExperience;
            CapeColor = capeColor;
            DarkSidePropensity = darkSidePropensity;
            PortraitPhoto = portraitPhoto;
        }

        public string Name { get; set; }
        public bool [] SpecialAbilities { get; set; }
        public List<String> OfficeLocation { get; set; }
        public string PreferredTransport { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SuperPowerDiscoveryDate { get; set; }
        public DateTime FatefulDay { get; set; }
        public decimal YearsExperience { get; set; }
        public string CapeColor { get; set; }
        public int DarkSidePropensity { get; set; }
        public String PortraitPhoto { get; set; }

        public int CompareTo(object obj)
        {
            Hero other = (Hero) obj;
            return Name.CompareTo(other.Name);
        }

        override public string ToString()
        {

            string status_message = "";

            string heroName = "Name: " + this.Name;

            // create a message
            status_message = "\r\n You are selected the following abilities: ";

            // This is testing perpose
            if (SpecialAbilities[0])
                status_message += "Fly,";
            if (SpecialAbilities[1])
                status_message += "xRay vision,";
            if (SpecialAbilities[2])
                status_message += "Invisibility,";
            if (SpecialAbilities[3])
                status_message += "Absorb Energy,";
            if (SpecialAbilities[4])
                status_message += "Extreme Luck,";
            if (SpecialAbilities[5])
                status_message += "Explosive Farts,";
            if (SpecialAbilities[6])
                status_message += "Breath Water,";
            if (SpecialAbilities[7])
                status_message += "Time Control.,";

            status_message += "\nThe hero works in these cities: ";
            foreach (String city in this.OfficeLocation)
            {
                status_message += city + ", ";
            }

            status_message += "\r\nThe hero preferred to travel by " + this.PreferredTransport;

            status_message += "\r\nSpeed: " + this.Speed + ", Stamina:" + this.Stamina + ", Strength: " + this.Strength;

            status_message += "\r\nYour hero was born on " + this.Birthday;
            status_message += "\r\nThe hero discovered the super powers on  " + this.SuperPowerDiscoveryDate;
            status_message += "\r\nThe fateful day for the hero is" + this.FatefulDay;

            status_message += "\r\nYears experience: " + this.YearsExperience + "years.";

            status_message += "\r\nThe cape color for the hero is  " + this.CapeColor.ToString();

            status_message += "\r\nThe dark side probability for the hero is " + this.DarkSidePropensity;

            status_message += "\r\nThe picture of the hero is: " + this.PortraitPhoto;


            return status_message;
        }

    }

}
