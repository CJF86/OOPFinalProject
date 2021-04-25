using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_iteration1
{
    class GOT
    {
        private string Entered_Date;
        private string Entered_Age;
        private string Entered_Series;

        public GOT(string entered_Date, string entered_Age, string entered_Series)//creates constructor for private variables
        {
            Entered_Date = entered_Date;
            Entered_Age = entered_Age;
            Entered_Series = entered_Series; //exists here for inheritance purposes. May be useless IDK
        }
        public string User_Date { get => Entered_Date; set => Entered_Date = value; }//allows use of user input values

        public string User_Series { get => Entered_Series; set => Entered_Series = value; }//allows use of user input values

        public string User_Age { get => Entered_Age; set => Entered_Age = value; }//allows use of user input values

        public void DawnAge_Method(string entered_Date, string entered_Age)//Method used to handle first age calendar
        {
            int j;
            bool DawnAge_Switch = false;
            bool Iteration_Switch = false;
            string[] DawnAge_Array = new string[] { "12000", "A human ethnic group, the First Men, invades Westeros across the Arm of Dorne from Essos. The Wars of the First Men and the Children of the Forest last for generations. The Children destroy the Arm of Dorne.", "10000", "After years of warfare, the two sides agree to a truce: the Children could not win, but the First Men feared the massive cost in lives if they continued to fight the Children to extinction.", "8000", "The Long Night: A great winter that lasts a generation descends on the world, followed by a night that goes for years. Under the cover of darkness, the White Walkers invade Westeros from the uttermost north, causing immense suffering and destruction. In the War for the Dawn, the Children and the First Men unite to defeat the Walkers, eventually throwing them back into the north.", "7500", "Bran the Builder may have ruled the North from Winterfell as some sort of high-king, but this unity falls apart after the threat of the Long Night ends, and the North fragments into various petty kingdoms, like the rest of Westeros.", "7000", "Garth Gardener builds Highgarden and settles the fertile fields of the Reach. His dynasty continues as House Gardener, though Garth's numerous descendants also found many other vassal houses throughout the Reach.", "6500", "Lann the Clever swindles House Casterly out of Casterly Rock and its rich gold mines using nothing but his wits, and becomes the founder of House Lannister.", "6000", "Durran Godsgrief builds the impregnable fortress Storm's End, founding House Durrandon (ancestors of House Baratheon).", "5500", "The Grey King unites the Iron Islands, and according to legend kills Nagga the sea-dragon. His sons begin the tradition of the Kingsmoot, raising up non-hereditary high kings of the isles by holding an election among their own lords." };

            while (DawnAge_Switch == false)
            {
                for (j = 0; j < DawnAge_Array.Length; j++)
                {
                    if (j == DawnAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == DawnAge_Array[j])
                    {
                        Console.WriteLine(DawnAge_Array[j + 1]);
                        DawnAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != DawnAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        DawnAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void AndalAge_Method(string entered_Date, string entered_Age)//Method used to handle second age calendar
        {
            int k;
            bool AndalAge_Switch = false;
            bool Iteration_Switch = false;
            string[] AndalAge_Array = new string[] { "8000", "On the eastern continent of Essos, the ancient Ghiscari Empire flourishes on the eastern coast of Slaver's Bay, one of the oldest - if not the oldest - great civilizations in the world. The Ghiscari Empire is built on large-scale slavery of conquered peoples, who toil away to build the great pyramids of Old Ghis and its colonies.", "6000", "On the western side of Slaver's Bay, a race of peaceful shepherds find Dragons lairing in the Fourteen Fires, an immense chain of volcanoes extending across the neck of the Valyrian Peninsula. The Valyrians tame the dragons with magic and begin expanding their influence into the rest of Essos.", "7000", "The Ghiscari Wars begin, span for 1000 years. Inevitably, the expanding Valyrian Freehold comes into conflict with the Ghiscari Empire over which superpower will dominate the continent. They fight a series of five great wars, ending with the Valyrians throwing down the Ghiscari in defeat.", "6001", "A race of men from Essos, the Andals, crossed the Narrow Sea in numerous ships and made landfall in the Vale of Arryn. Under the banner of the Faith of the Seven, riding horses and wielding weapons made of iron, they overran and conquered all of Westeros south of the Neck.", "5500", "Their overland migration waves only reached the western side of the continent generations later, and by that point they were clearly inevitable. Therefore, the rulers of the Westerlands and the Reach peacefully intermarried with chosen Andal groups, inviting them in and uniting with them to fight off the other Andal kingdoms in eastern Westeros.", "4000", "The Andals finally conquer the Iron Islands, much later than the mainland of Westeros due to their isolated location. However, the few Andals who invaded the Iron Islands essentially 'went native' and acculturated to the distinct ironborn culture, even abandoning the Faith of the Seven to convert to worship of the Drowned God.", "700", "The Rhoynish Wars begin. The Valyrian Freehold begins settling the region of the modern Free Cities. Their expansion brings them into conflict with the native inhabitants of the region surrounding the River Rhoyne. Nymeria, the warrior-queen of the Rhoynar, realizes that they cannot stand against dragons and they flee to Dorne, in southern Westeros.", "500", "Revolting slaves take over the Valyrian fleet they were being transported in, and use the ships to flee from the Valyrian-controlled areas of central Essos to the northwestern corner of the continent. There they find a secretive lagoon protected by mountains and narrow access channels, where they found the Secret City of Braavos.", "200", "The Valyrians annex Dragonstone, an island in the Narrow Sea just off the eastern coast of Westeros. The Targaryen family takes control of the island, which is used as a trading post with the Seven Kingdoms. According to legend, Aenar Targaryen had a vision of impending catastrophe and arranged to have his family removed from the Freehold.", "100", "Doom of Valyria: The Fourteen Fires erupt in a titanic explosion that obliterates the heartland of the Valyrian Freehold. Most of the Valyrian dragons, who lair in the volcanoes when not needed, are killed outright. The City of Valyria is partially buried under vast amounts of ash. The Valyrian Peninsula fractures and breaks apart. A large part of it is torn away from the mainland, low-lying areas are flooded and many offshore islands are formed. The waters around Valyria remain poisonous until the present day.", "2", "The Century of Blood. In the aftermath of the Doom, Valyria's outlying colony-cities began breaking away and asserting their independence, becoming the nine Free Cities." };
            while (AndalAge_Switch == false)
            {
                for (k = 0; k < AndalAge_Array.Length; k++)
                {
                    if (k == AndalAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }
                    if (entered_Date == AndalAge_Array[k])
                    {
                        Console.WriteLine(AndalAge_Array[k + 1]);
                        AndalAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != AndalAge_Array[k])
                    {
                        Console.WriteLine("That date is unknown");
                        AndalAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void HundredAge_Method(string entered_Date, string entered_Age)//Method used to handle third age calendar
        {
            int k;
            bool HundredAge_Switch = false;
            bool Iteration_Switch = false;
            string[] HundredAge_Array = new string[] { "700", "Over the centuries following the Andal Invasion, hundreds of petty kingdoms form across Westeros, eventually aggregating into several larger powerful realms, and ultimately, seven large kingdoms.", "701", "The Rhoynar migrate to Dorne, after being driven from the Rhoyne River network in Essos by the Valyrians. House Martell intermarries with the Rhoynar led by Princess Nymeria and with their extra numbers conquers the rest of Dorne, unifying the entire region for the first time.", "400", "House Bolton rises again in rebellion against House Stark, but is subdued once more. Due to his actions in suppressing the Bolton rebellion the younger son of the King in the North, Karlon Stark, is awarded lands confiscated from the north of the Boltons' former possessions, founding a cadet branch of House Stark. Over the generations, 'Karl's Hold' becomes known as 'Karhold', and the 'Karl's Hold Starks' become known as House Karstark.", "300", "The newly-ennobled House Frey begins construction of a massive bridge and castle complex across the Green Fork of the Trident, which when completed is known as the Twins.", "200", "House Targaryen, one of the aristocratic families of the Valyrian Freehold, settles on Dragonstone island in Blackwater Bay, to establish a Valyrian trading outpost.", "100", "The Targaryens relocate their entire family and household to Dragonstone island (just off the east coast of Westeros in Blackwater Bay), convinced by a prophecy that the destruction of Valyria is imminent. This proves true, as the Doom of Valyria follows only a few years later - leaving the Targaryens on Dragonstone with the world's only surviving dragons.", "60", "Some three generations before Aegon's Landing, the Iron Islands enter into their second great era of expansion, conquering the territory of the Riverlands from the Stormlands."};


            while (HundredAge_Switch == false)
            {
                for (k = 0; k < HundredAge_Array.Length; k++)
                {
                    if (k == HundredAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }
                    if (entered_Date == HundredAge_Array[k])
                    {
                        Console.WriteLine(HundredAge_Array[k + 1]);
                        HundredAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != HundredAge_Array[k])
                    {
                        Console.WriteLine("That date is unknown");
                        HundredAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void ConquestAge_Method(string entered_Date, string entered_Age)//Method used to handle fourth age calendar
        {
            int k;
            bool ConquestAge_Switch = false;
            bool Iteration_Switch = false;
            string[] ConquestAge_Array = new string[] { "1", "Despite pleas to intervene in the Free Cities, Aegon the Conqueror, the ruler of House Targaryen, decides to invade Westeros, along with his sister-wives Rhaenys and Visenya.", "4", "After Aegon conquers most of Westeros, he begins a war with the final unconquered kingdom, Dorne.", "7", "Aegon's son Aenys I is born from Rhaenys.", "10", "Rhaenys dies after a Dornish scorpion bolt strikes her dragon and she falls to her death.", "12", "Aegon's second son Maegor I is born from Visenya.", "13", "The Dornish War ends; Dorne falls under Aegon's rule, but its monarch is allowed to keep the title of 'Prince' or 'Princess'.", "37", "Aegon the Conqueror dies from a stroke at the age of 64. His first son Aenys becomes king.", "42", "Aenys dies under questionable circumstances. His brother Maegor assumes the Iron Throne, skipping over Aenys' children.", "48", "Maegor is defeated. His nephew Jaeherys becomes King.", "103", "Jaeherys dies after a long rule. His grandson Viserys I takes the throne.", "129", "Viserys I dies. Despite choosing his daughter Rhaenyra as his sucessor, his son Aegon II takes the throne, beginning a Targaryen Civil War that ends with many dead dragons and a new monarch.", "131", "After the war, Aegon III takes the throne. The last dragon in the world dies during his reign, branding him 'Aegon Dragonsbane'.", "157", "Aegon Dragonsbane dies. His son Daeron the Young Dragon takes the throne at the age of 14. Starts the Conquest of Dorne, resulting in a short-lasting conquest of Dorne, followed by a Dornish rebellion.", "161", "Daeron the Young Dragon dies. His brother Baelor I takes the throne.", "171", "Baelor I accidentally fasts to death. His uncle Viserys II, brother to Aegon III, takes the throne.", "172", "Viserys II dies. His son, Aegon IV, assumes the throne.", "184", "Aegon IV, deemed Aegon the Unworthy, dies after fathering countless bastard children. He legitimizes all of them upon his death. His trueborn son Daeron II assumes the throne.", "196", "Daemon Blackfyre, one of Aegon the Unworthy's legitimized bastards, starts an unsucessful rebellion against his brother. It ends in the same year with his death and defeat.", "209", "Daeron II dies of an illness. His son Aerys I takes the throne.", "221", "Aerys I dies. His brother Maekar I takes the throne.", "233", "Maeker I dies. His fifth son Aegon takes the throne, becoming Aegon V, the 'Unlikely'.", "259", "Aegon V, among many other Kinsgaurd and Servants, dies in the mysterious Tragedy of Summerhall. His son Jaeherys II takes the throne.", "262", "Jaeherys II dies. His son Aerys II, dubbed 'The Mad King', assumes the throne." };

            while (ConquestAge_Switch == false)
            {
                for (k = 0; k < ConquestAge_Array.Length; k++)
                {
                    if (k == ConquestAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }
                    if (entered_Date == ConquestAge_Array[k])
                    {
                        Console.WriteLine(ConquestAge_Array[k + 1]);
                        ConquestAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != ConquestAge_Array[k])
                    {
                        Console.WriteLine("That date is unknown");
                        ConquestAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void PostAge_Method(string entered_Date, string entered_Age)//Method used to handle fourth age calendar
        {
            int k;
            bool PostAge_Switch = false;
            bool Iteration_Switch = false;
            string[] PostAge_Array = new string[] { "279", "Robert's Rebellion against the Mad King begins after his bride, Lyanna Stark, is kidnapped by Prince Rhaegar. Ends in victory two years later. Robert I Baratheon takes the throne.", "280", "Robb Stark, Eddard Stark's first trueborn son, is born. Jon Snow, Eddard Stark's bastard son, is born.", "281", "Having fled after the defeat of her husband, the Mad King, Queen Rhaella dies giving birth to her daughter, Daenerys Targaryen.", "298", "Daenerys Targaryen marries Khal Drogo. Robert Baratheon dies. His son, Joffrey I Baratheon, executes Robert's friend and Hand, Eddard Stark. This starts the War of the Five Kings. Daenerys hatches three dragons, the first dragons seen since Aegon Dragonsbane's Reign.", "300", "The War of the Five Kings ends with Robb I Stark is murdered at his uncles wedding. Jon Snow is murdered at the Wall."};
            while (PostAge_Switch == false)
            {
                for (k = 0; k < PostAge_Array.Length; k++)
                {
                    if (k == PostAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }
                    if (entered_Date == PostAge_Array[k])
                    {
                        Console.WriteLine(PostAge_Array[k + 1]);
                        PostAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != PostAge_Array[k])
                    {
                        Console.WriteLine("That date is unknown");
                        PostAge_Switch = true;
                        break;
                    }
                }
            }
        }

    }
}
