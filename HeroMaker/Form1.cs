using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace HeroMaker
{
    public partial class Form1 : Form
    {
        string picture_of_hero = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            // Hero name
            string heroName = txt_name.Text;

            bool[] abilities = { false, false, false, false, false, false, false, false };
            abilities[0] = chk_fly.Checked;
            abilities[1] = chk_xray.Checked;
            abilities[2] = chk_invisibility.Checked;
            abilities[3] = chk_energy.Checked;
            abilities[4] = chk_luck.Checked;
            abilities[5] = chk_fart.Checked;
            abilities[6] = chk_water_breathing.Checked;
            abilities[7] = chk_timecontrol.Checked;

            // cities

            // array or list
            List<String> cities = new List<string>();

            // add the selected items to cities
            foreach (String s in lst_cities.SelectedItems)
            {
                cities.Add(s);
            }

            // Preferred transport
            // use a single string since only one mode can be the preferred transport.

            string preferred_transport = "";

            if (rdo_jetpack.Checked)
            {
                preferred_transport = "Jet Pack";
            }
            if (rdo_landspeeder.Checked)
            {
                preferred_transport = "Land Speeder";
            }
            if (rdo_teleport.Checked)
            {
                preferred_transport = "Teleport";
            }
            if (rdo_batmobile.Checked)
            {
                preferred_transport = "Batmobile";
            }

            int speed = scroll_speed.Value;
            int stamina = scroll_stamina.Value;
            int strength = scroll_strength.Value;
            if (speed + stamina + strength > 100)
            {
                MessageBox.Show("You cannot have more than 100 total points for speed and stamina");
            }


            // dates
            DateTime birthday = date_birthday.Value;
            DateTime superPowerDiscovery = date_power_discovery.Value;
            DateTime fatafulday = date_fatefulday.Value;

            // years experience
            decimal years_experience = num_year_experience.Value;

            // dark side
            int dark_side = 0;
            dark_side = trk_dark_side.Value;

            // picture of hero






            // create a message
            string status_message = "Your new hiro name is " + heroName + ". You are selected the following abilities: ";

            // This is testing perpose
            if (abilities[0])
                status_message += "Fly,";
            if (abilities[1])
                status_message += "xRay vision,";
            if (abilities[2])
                status_message += "Invisibility,";
            if (abilities[3])
                status_message += "Absorb Energy,";
            if (abilities[4])
                status_message += "Extreme Luck,";
            if (abilities[5])
                status_message += "Explosive Farts,";
            if (abilities[6])
                status_message += "Breath Water,";
            if (abilities[7])
                status_message += "Time Control.,";

            status_message += "\nThe hero works in these cities: ";
            foreach (String city in cities)
            {
                status_message += city + ", ";
            }

            status_message += "\nThe hero preferred to travel by " + preferred_transport;

            status_message += "\nSpeed: " + speed + ", Stamina:" + stamina + ", Strength: " + strength;

            status_message += "\nYour hero was born on " + birthday;
            status_message += "\nThe hero discovered the super powers on  " + superPowerDiscovery;
            status_message += "\nThe fateful day for the hero is" + fatafulday;

            status_message += "\nYears experience: " + years_experience + "years.";

            status_message += "\nThe cape color for the hero is  " + pic_cape_color.BackColor.ToString();

            status_message += "\nThe dark side probability for the hero is " + dark_side;

            status_message += "\n The picture of the hero is: " + picture_of_hero;

            Hero hero = new Hero(heroName, abilities, cities, preferred_transport, speed, stamina, strength, birthday, superPowerDiscovery, fatafulday, years_experience, pic_cape_color.BackColor.ToString(), dark_side, picture_of_hero);

            HeroList.hallOfFame.Add(hero);

            MessageBox.Show(status_message);
            MessageBox.Show("\nYou have made " + HeroList.hallOfFame.Count() + "different heroes.");
            Form2 f2 = new Form2();
            f2.Show();


        }

        private void scroll_speed_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_speed.Text = scroll_speed.Value.ToString();
        }

        private void scroll_stamina_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_stamina.Text = scroll_stamina.Value.ToString();
        }

        private void scroll_strength_Scroll(object sender, ScrollEventArgs e)
        {
            lbl_strength.Text = scroll_strength.Value.ToString();
        }

        private void pic_cape_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                pic_cape_color.BackColor = colorPicker.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_dark_side.Text = trk_dark_side.Value.ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog portraitPicker = new OpenFileDialog();
            if (portraitPicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(portraitPicker.FileName);

                picture_of_hero = portraitPicker.FileName;
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.StartPosition = FormStartPosition.Manual;
            NewForm.Location = this.Location;

            NewForm.Show();
            this.Dispose(false);
        }
    }
}