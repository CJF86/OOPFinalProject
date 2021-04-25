using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project_iteration1
{
    class Dune
    {
        private string Entered_Date;
        private string Entered_Age;
        private string Entered_Series;

        public Dune(string entered_Date, string entered_Age, string entered_Series)//creates constructor for private variables
        {
            Entered_Date = entered_Date;
            Entered_Age = entered_Age;
            Entered_Series = entered_Series;//exists here soley for inheritance purposes. May not need to exist here at all
        }

        public string User_Date { get => Entered_Date; set => Entered_Date = value; }//allows use of user input values

        public string User_Series { get => Entered_Series; set => Entered_Series = value; }//allows use of user input values

        public string User_Age { get => Entered_Age; set => Entered_Age = value; }//allows use of user input values

        public void TitanAge_Method(string entered_Date, string entered_Age)
        {
            int j;
            bool TitanAge_Switch = false;
            bool Iteration_Switch = false;
            string[] TitanAge_Array = new string[] { "2200", "Arn Eklo, Kwyna, Vidad and others become Cogitors. Some follow Vidad to Hessra to contemplate the universe or become hermit philosophers on inhabited worlds.", "1381", "The Zensunni break away from the religion of Maometh.", "1287", "Tlaloc fails to bring the Old Empire out of her slumber. 20 people (Titans) set out to conquer the Empire with him. Barbarossa reprograms computers giving them human aggression and hunger for power. With his aid the Old Empire falls. Arrakis is abandoned.", "1280", "Tlaloc dies. Agamemnon and other Titans have themselves transformed to cymeks.", "1192", "The First Hrethgir Rebellion on Walgis. Xerxes trusts keeping the order on his planets completely to the local computer network.", "1183", "Ajax, lord of Walgis crushes the rebellion and exterminates the populace. Outraged by the massacre, his mate Hecate transfers her brain into a deepspace vessel and disappears." };
            while (TitanAge_Switch == false)
            {
                for (j = 0; j < TitanAge_Array.Length; j++)
                {
                    if (j == TitanAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == TitanAge_Array[j])
                    {
                        Console.WriteLine(TitanAge_Array[j + 1]);
                        TitanAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != TitanAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        TitanAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void OmniusAge_Method(string entered_Date, string entered_Age)
        {
            int j;
            bool OmniusAge_Switch = false;
            bool Iteration_Switch = false;
            string[] OmniusAge_Array = new string[] { "1182", "Xerxes' network seizes control over Ix. Omnius, the AI, establishes the Synchronized Worlds over the Titan-worlds. The Titans are made his servants.", "1082", "Barbarossa creates Beowulf.", "603", "Omnius launches an unsuccessful attack against Chusuk.", "400", "The Sorceresses of Rossak begin to keep detailed breeding records, starting the future Kwisatz Haderach program.", "377" , "Discovery of a Muadru runestone on an empty planet.", "358", "Birth of Abdel.", "303", "Last massive assault of the machines for the next 100 years.", "277", "Ginaz soldiers find Chirox in a shipwreck. They reprogram it and begin using it for combat practices.", "225", "Hecate secretly returns to human space and begins to watch the war between Omnius and the League of Nobles.", "224", "Marriage of Manion Butler and Livia. Birth of Camie Boro, descendant of the last Emperor of the Old Empire.", "223", "Birth of Vorian Atreides and Xavier Harkonnen.", "221", "Birth of Serena, Octa, and Fredo Butler.", "210", "Death of Conquee Cenva. Selim is lost in the desert for two days.", "206", "Death of Fredo Butler. Xavier receives the legal entitlement to the original Harkonnen holdings.", "203", "Tio Holtzman invents the Scrambler web which fails to protect the attack of the thinking machines against Salusa Secundus. Selim is exiled from his village by Naib Dhartha, but he discovers how to ride the sandworms of Arrakis. Erasmus is transferred from Corrin to Earth. Omnius conquers Giedi Prime and then he dispatches thousands of deepspace probes into the galaxy to establish machine bases.", "201", "Birth of Roella Harkonnen. Erasmus kills the baby Manion. Revolt breaks out on Earth were Ajax is killed. The First slave revolt of Poritrin is suppressed and Bel Moulay executed.", "200", "The League of Nobles starts the Butlerian Jihad against the thinking machines. Using atomics, the League wipes out the thinking machines of Earth. The nuclear attack renders Earth uninhabitable for centuries.", "199", "Birth of Omilia Harkonnen.", "197", "Corrin-Omnius sends a heavy fleet to Salusa Secundus, but the Army of the Jihad rebuffs them. Vorian Atreides returns to Bela Tegeuse and discovers that the thinking machines have rebuilt it. Jafar joins the exiled Selim. Later many follow his example, making Selim’s outlaw band grow.", "195", "The Army of the Jihad attempts to free the population from the Synchronized World Honru but Omnius uses suicide robot ships that wipe out the whole Jihad fleet. Over 500000 free humans are killed.", "193", "Jihad Police is officially established, lead by Yorek Thurr. In a political marriage, Iblis Ginjo marries Camie Boro.", "164", "Aurelius Venport gives the space-folding technology and the Kolhar shipyards to the Jihad’s disposal. Vidad and his colleagues broker peace between Omnius and the League. The war-weary humans want peace in spite of Serena Butler’s and Iblis Ginjo’s protest.", "108", "Vorian Atreides reveals to Abulurd Butler the true role of Xavier Harkonnen in the Tlulaxa organ scandal. Liberation of Honru. Omnius infects the League Planets with the Omnius Scourge causing the death of billions." };
            while (OmniusAge_Switch == false)
            {
                for (j = 0; j < OmniusAge_Array.Length; j++)
                {
                    if (j == OmniusAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == OmniusAge_Array[j])
                    {
                        Console.WriteLine(OmniusAge_Array[j + 1]);
                        OmniusAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != OmniusAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        OmniusAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void ElroodAge_Method(string entered_Date, string entered_Age)
        {
            int j;
            bool ElroodAge_Switch = false;
            bool Iteration_Switch = false;
            string[] ElroodAge_Array = new string[] { "10018", "Death of Emperor Fondil III. Elrood Corrino IX ascends the throne. During the reign of Elrood IX, Richese is overpowered by Ix in an economic warfare. This leads to the political and economic decline of House Richese.", "10071", "Birth of Habla.", "10092", "Birth of Fafnir Corrino, son of Elrood IX and Alexandra Ecaz. Birth of Wanna Marcus.", "10112", "Wellington Yueh graduates at the Suk School.", "10119", "Habla gives birth to Shaddam, son of Elrood IX and Barbara Mutelli.", "10130", "The Ecazi Revolt. Dominic Vernius and Paulus Atreides fight on Elrood IX’s side against the rebels. The rebellion is suppressed. Birth of the bastard son of Elrood and his concubine Shando Balut. The child is named Tyros Reffa and is adopted by House Taligari.", "10138", "Marriage of Dominic Vernius and Shando Balut. Hasimir and Shaddam kill Fafnir Corrino, the crown prince.", "10140", "Birth of Leto Atreides, son of Paulus Atreides and Helena Richese.", "10146", "Birth of Duncan Idaho.", "10154", "Bene Tleilax takes over control of Ix. The Fremen begin terraforming Arrakis with Pardot Kynes’s guidance. Duncan Idaho becomes a servant of House Atreides. Birth of Liet-Kynes, son of Pardot Kynes. Birth of Jessica, daughter of Gaius Helen Mohiam and Vladimir Harkonnen as a subject of the Kwisatz Haderach project." };
            while (ElroodAge_Switch == false)
            {
                for (j = 0; j < ElroodAge_Array.Length; j++)
                {
                    if (j == ElroodAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == ElroodAge_Array[j])
                    {
                        Console.WriteLine(ElroodAge_Array[j + 1]);
                        ElroodAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != ElroodAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        ElroodAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void ShaddamAge_Method(string entered_Date, string entered_Age)
        {
            int j;
            bool ShaddamAge_Switch = false;
            bool Iteration_Switch = false;
            string[] ShaddamAge_Array = new string[] { "10156", "Death of Elrood IX. Vladimir Harkonnen’s unsuccessful effort to cause warfare between House Atreides and the Bene Tleilax.", "10171", "Leto Atreides gains popularity in the Landsraad by trying to solve the Moritani-Ecaz conflict. The Bene Gesserit 'presents' Jessica to Leto with the secret aim that she would conceive a girl child from him – this girl should give birth to the Kwisatz Haderach.", "10173", "Gurney Halleck escapes from slavery.", "10174", "Birth of Abulurd Harkonnen's second son, Feyd-Rautha.Duncan Idaho is declared swordmaster. Gurney Halleck joins House Atreides. Birth of Chani Kynes, daughter of Liet-Kynes and Faroula.", "10175", "Birth of Paul Atreides.", "10182", "Death of Wensicia Corrino, daughter of Elrood IX.", "10192", "Birth of Marie Fenring, biological daughter of Feyd-Rautha Harkonnen and Lady Margot Fenring, on Caladan." };
            while (ShaddamAge_Switch == false)
            {
                for (j = 0; j < ShaddamAge_Array.Length; j++)
                {
                    if (j == ShaddamAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == ShaddamAge_Array[j])
                    {
                        Console.WriteLine(ShaddamAge_Array[j + 1]);
                        ShaddamAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != ShaddamAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        ShaddamAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void PaulAge_Method(string entered_Date, string entered_Age)
        {
            int j;
            bool PaulAge_Switch = false;
            bool Iteration_Switch = false;
            string[] PaulAge_Array = new string[] { "10193", "Battle of Arrakeen. House Harkonnen is annihilated. Glossu Rabban, Vladimir Harkonnen and Feyd-Rautha died. Paul Atreides officially becomes Padishah Emperor.", "10194", "Paul and Jessica travel back to Caladan. Jessica is installed as Duchess. Alia proclaims that those who are not Muad'Dib's allies, are his enemies.", "10198", "First failed attempt on Paul's life by Swordmaster Whitmore Bludd.", "10199", "Second failed attempt on Paul's life by Marie Fenring and her adopted parents, Hasimir Fenring and Margot Fenring, with him using the Emperor's Blade.", "10209", "Chani dies after giving birth to Leto Atreides II and Ghanima Atreides. Paul goes into the deep desert. Alia assumes regency of the throne for the twins.", "10219", "After a confrontation against her nephew Leto Atreides II, Alia Atreides dies, and he ascends to the throne, becoming the God Emperor/Tyrant, and sets the Universe on his The Golden Path.", "10256", "Jessica Atreides dies." };
            while (PaulAge_Switch == false)
            {
                for (j = 0; j < PaulAge_Array.Length; j++)
                {
                    if (j == PaulAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == PaulAge_Array[j])
                    {
                        Console.WriteLine(PaulAge_Array[j + 1]);
                        PaulAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != PaulAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        PaulAge_Switch = true;
                        break;
                    }
                }
            }
        }
        public void ScatterAge_Method(string entered_Date, string entered_Age)
        {
            int j;
            bool ScatterAge_Switch = false;
            bool Iteration_Switch = false;
            string[] ScatterAge_Array = new string[] {"13728", "Death of Leto II. Siona Atreides and Duncan-13727 gain stewardship of Arrakis. Beginning of the Famine Times and The Scattering.", "15200", "The Lost Ones return from The Scattering.", "15201", "History ends." };
            while (ScatterAge_Switch == false)
            {
                for (j = 0; j < ScatterAge_Array.Length; j++)
                {
                    if (j == ScatterAge_Array.Length - 1)
                    {
                        Iteration_Switch = true;
                    }

                    if (entered_Date == ScatterAge_Array[j])
                    {
                        Console.WriteLine(ScatterAge_Array[j + 1]);
                        ScatterAge_Switch = true;
                        break;
                    }
                    else if (Iteration_Switch == true && entered_Date != ScatterAge_Array[j])
                    {
                        Console.WriteLine("That date is unknown");
                        ScatterAge_Switch = true;
                        break;
                    }
                }
            }
        }

    }
}
