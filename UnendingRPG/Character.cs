using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnendingRPG
{

    public class Character
    {

        // Member variables
        private string name;

        private int hp, mp, level;

        private CClass c_Class;

        private Race cRace;

        private Gender cGender;

        private Armor helmet, chest, greaves, gloves, boots, cape;

        private Weapon main_hand, off_hand;

        private Accessory neck, ring1, ring2;

        // Getter/Setter methods
        public string Name
        {
            get
            {

                return this.name;

            }
            set
            {

                this.name = value;

            }
        }

        public int Hp
        {

            get
            {

                return this.hp;

            }

            set
            {

                this.hp = value;

            }

        }

        public int Mp
        {

            get
            {

                return this.mp;

            }

            set
            {

                this.mp = value;

            }

        }

        public int Level
        {

            get
            {

                return this.level;

            }

            set
            {

                this.level = value;

            }

        }

        public CClass C_Class
        {

            get
            {

                return this.c_Class;

            }

            set
            {

                this.c_Class = new CClass(value);

            }

        }

        public Race CRace
        {

            get
            {

                return this.cRace;

            }

            set
            {

                this.cRace = new Race(value);

            }

        }

        public Gender CGender
        {

            get
            {

                return this.cGender;

            }

            set
            {

                this.cGender = new Gender(value);

            }

        }

        public Armor Helmet
        {

            get
            {

                return this.helmet;

            }

            set
            {

                this.helmet = new Armor(value);

            }

        }

        public Armor Chest
        {

            get
            {

                return this.chest;

            }

            set
            {

                this.chest = new Armor(value);

            }

        }

        public Armor Greaves
        {

            get
            {

                return this.greaves;

            }

            set
            {

                this.greaves = new Armor(value);

            }

        }

        public Armor Gloves
        {

            get
            {

                return this.gloves;

            }

            set
            {

                this.gloves = new Armor(value);

            }

        }

        public Armor Boots
        {

            get
            {

                return this.boots;

            }

            set
            {

                this.boots = new Armor(value);

            }

        }

        public Armor Cape
        {

            get
            {

                return this.cape;

            }

            set
            {

                this.cape = new Armor(value);

            }

        }

        public Weapon Main_Hand
        {

            get
            {

                return this.main_hand;

            }

            set
            {

                this.main_hand = new Weapon(value);

            }

        }

        public Weapon Off_Hand
        {

            get
            {

                return this.off_hand;

            }

            set
            {

                this.off_hand = new Weapon(value);

            }

        }

        public Accessory Neck
        {

            get
            {

                return this.Neck;

            }

            set
            {

                this.Neck = new Accessory(value);

            }

        }

        public Accessory Ring1
        {

            get
            {

                return this.ring1;

            }

            set
            {

                this.ring1 = new Accessory(value);

            }

        }

        public Accessory Ring2
        {

            get
            {

                return this.ring2;

            }

            set
            {

                this.ring2 = new Accessory(value);

            }

        }

        // Constructors
        public Character()
        {

            Name = "";

            Hp = 0;
            Mp = 0;
            Level = 0;

            C_Class = new CClass();

            CRace = new Race();

            CGender = new Gender();

            Helmet = new Armor();
            Chest = new Armor();
            Greaves = new Armor();
            Gloves = new Armor();
            Boots = new Armor();
            Cape = new Armor();

            Main_Hand = new Weapon();
            Off_Hand = new Weapon();

            Neck = new Accessory();
            Ring1 = new Accessory();
            Ring2 = new Accessory();

        }

        public Character(string name = null, int hp = 0, int mp = 0, int level = 0, CClass cclass = null, Race race = null, Gender gender = null, Armor helmet = null, Armor chest = null, Armor greaves = null, 
            Armor gloves = null, Armor boots = null, Armor cape = null, Weapon mHand = null, Weapon oHand = null, Accessory neck = null, Accessory ring1 = null, Accessory ring2 = null)
        {

            Name = name;

            Hp = hp;
            Mp = mp;
            Level = level;

            C_Class = cclass;

            CRace = race;

            CGender = gender;

            Helmet = helmet;
            Chest = chest;
            Greaves = greaves;
            Gloves = gloves;
            Boots = boots;
            Cape = cape;

            Main_Hand = mHand;
            Off_Hand = oHand;

            Neck = neck;
            Ring1 = ring1;
            Ring2 = ring2;

        }

        public Character(Character chara)
        {

            Name = chara.Name;

            Hp = chara.Hp;
            Mp = chara.Mp;
            Level = chara.Level;

            C_Class = chara.C_Class;

            CRace = chara.CRace;

            CGender = chara.CGender;

            Helmet = chara.Helmet;
            Chest = chara.Chest;
            Greaves = chara.Greaves;
            Gloves = chara.Gloves;
            Boots = chara.Boots;
            Cape = chara.Cape;

            Main_Hand = chara.Main_Hand;
            Off_Hand = chara.Off_Hand;

            Neck = chara.Neck;
            Ring1 = chara.Ring1;
            Ring2 = chara.Ring2;

        }

    }

}
