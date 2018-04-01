using System;
using System.Collections.Generic;

namespace Jasarsoft.Launcher.SAMP
{
    internal sealed class RolePlayBS
    {
        private readonly List<RoleRule> roleRules;

        public RolePlayBS()
        {
            roleRules = new List<RoleRule>();   
            roleRules.Add(new RoleRule("IC",    "In Character",             "In Character se koristi u svim chat-ovima u igri osim /o, /b i /report, služi za komunikaciju za drugim igračima i u njega se piše SAMO ono što ima veze sa Vašim virtualnim karakterom. U IC chatu ne pišemo smajlije i sva ostala komunikativna sredstva koja nisu realna i nisu vezana za radnju Vašeg virtualnog lika."));
            roleRules.Add(new RoleRule("OCC",   "Out Of Character",         "Out Of Character koristi se SAMO u /o /b i /report chat-ovima. Služi za priču o svemu što nema veze sa trenutnom situacijom u igri. U OOC chatu razgovarate o stvarima vezanim za stvarni život, npr. o sportskim dešavanjima. Takodje smijete zatražiti pomoc oko određenih komandi i sličnih stvari u /report chatu."));
            roleRules.Add(new RoleRule("MG",    "MetaGaming",               "MetaGaming (MG) je korištenje OOC formata u IC korist. Primjer: Idete do nekog lika a neznate ga IC i zovete ga imenom, to spada pod MG. Jasnije malo, npr. vi hodate u RL i vidite nekog čovjeka i priđete mu i zovete ga imenom, normalno ne znate mu ime jer se niste ni upoznali, tako i u SAMP-u."));
            roleRules.Add(new RoleRule("PG",    "PowerGaming",              "PowerGaming (PG) je radnja koja nije izvodiva u RL ili u nekom datom trenutnku.\nPrimjer: /me dize zgradu , naravno u RL ne možemo dignuti zgradu to je PG.\n/me jede zgradu, također je i ovo PG, jer u RL ne možemo jesti kuću."));
            roleRules.Add(new RoleRule("LTA",   "Leave to Avoid",           "Leave to Avoid (LTA) je napuštanje servera da bi se nešto izbjeglo.\nPrimjer: Policija vas treba uhapsiti vi napustite server."));
            roleRules.Add(new RoleRule("BH",    "Bunny Hopping",            "Bunny Hopping (BH) je učestalo skakanje prilikom trčanja s ciljem bržeg trčanja i sl.\nPrimjer: Ganja Vas policajac, trči za Vama a Vi lagano počnete skakati prema npr. autu da bi prije stigli i pobjegli mu."));
            roleRules.Add(new RoleRule("DM",    "Deatmatch",                "Deatmatch (DM) je ubijanje naokolo bez dovoljno RP razloga.\nPrimjer: Kupite oruzje u Gun Shop-u i sada do svakog lika odete i ubijete ga."));
            roleRules.Add(new RoleRule("SK",    "Spawn Kill",               "Spawn Kill (SK) je učestalo ubijanje igrača na Spawn-u.\nPrimjer: Vi odete do nečije kuće od nekog lika vidite ga i ubijete ga pa čekate opet da se spawna i opet ubijete ga."));
            roleRules.Add(new RoleRule("NJ",    "Ninja Jack",               "Ninja Jack (NJ) je NON RP krađa vozila.\nPrimjer: Neko vozi auto i uspori malo a Vi stisnete enter i ukradete mu auto te pobjegnete."));
            roleRules.Add(new RoleRule("DB",    "Drive By",                 "Drive By (DB) je pucanje i gaženje s mjesta vozača, i ubijanje elisom helikoptera.\nPrimjer: Vozite se gradom (bandit ste) i policajac Vam govori da stanete i dođe Vam s boka a Vi imate MP5 i počnete pucati na njega, ili imate helikopter i vidite ispred Burga neko okupljanje i zaletite se i elisom ih pobijete."));
            roleRules.Add(new RoleRule("RK",    "Revenge Kill",             "Revenge Kill (RK) je ubijanje iz osvete igrača. Primjer: Neki Hitman ima Vas kao metu, i on Vas ubije a Vi mu zapamtite ime i dođete nakon 5-minuta sa M4 i kažete eh ti si mene ubio evo ti sad.\nRevenge kill je takodje dio Metagaminga, jer koristite OOC informacije da rješite IC probleme."));
            roleRules.Add(new RoleRule("RPS",   "RP Supermen",              "RP Supermen je ponašanje igrača da je on kao najjači i da mu niko ništa ne može, ne boji se ničega, nije mu bitno hoće li poginuti."));
            roleRules.Add(new RoleRule("GFA",   "Gun From ASS",             "Gun From ASS (GFA) je vađenje oružja bez korištenja /me i /do komande. Primjer: Idete gradom i vidite nekog lika koji Vam je smetao u životu i izvadite oružje na brzinu bez korištenja /me i /do komande.\nKako je pravilno izvaditi oružje?\n/me vadi pištolj sa desnog pasa\n/do u ruci mi je."));
            roleRules.Add(new RoleRule("DFA",   "Drug From ASS",            "Drug From ASS (DFA) je nonRP korišćenje droge, bez /me i /do komande. Kako je pravilno koristiti drogu?\n/me vadi vrećiću (droge ,brasna) iz dzepa\n/do izvadio\n/me istresa (drogu ,brasno) na sto\n/do smrce drogu sa stola."));
            roleRules.Add(new RoleRule("PVP",   "Player vs Player",         "Player vs Player (PVP) je napadanje nedužnog civila bez razloga, iživljavanje na njemu."));
            roleRules.Add(new RoleRule("CK",    "Carachter Kill",           "Carachter Kill (CK) je tjeranje igrača da promjeni ime ili da napravi novi account.\nPrimjer: Stalno ga CK-ate i mučite."));
            roleRules.Add(new RoleRule("RPW",   "RP2WIN",                   "RP2WIN ponavljano korišćenje neke komande ili ponavljano mjenjanje IC priče kako bi izašli kao pobjednik iz RP-anja.\nPrimjer: Dođe vam policajac pretresa Vas pregleda dozvole sve ok. Kaže otvorite gepek a Vi u gepeku imate Silenced Pistol i ostala oružja. Vi otvorite on pretrese.\n/do Da li vidim Silenced Pistol u gepeku?\n/do Ne, ne vidiš ga zato što je ispao u gepekovi šupljinu."));
            roleRules.Add(new RoleRule("AA",    "Admin Abusing",            "Admin Abusing (AA) je iskorištavanje Admin komandi u svoju korist.\nPrimjer: Igrate WAR ili VS s nekim i on Vam do pola skine health(zdravlje) a Vi sebi nadopunite (/sethp ID 100)."));
            roleRules.Add(new RoleRule("EX",    "Exploiting",               "Exploiting je korištenje bilo kakvih poznatih/nepoznatih bug-ova/propusta u igri ili skripti. U to se ubraja i skupljanje spawnova novaca, uzimanje CJ skina i sl.\nPrimjer: Namjerno uzmete CJ skin kako bi brže trčali ili razvalite banderu za naplatu parkinga te pokupite pare."));
            roleRules.Add(new RoleRule("QS",    "QuickSwapping",            "QuickSwapping (QS) je brzo mjenjanje oružje na Q i E bez korištenja /me i /do komande."));
            roleRules.Add(new RoleRule("ERC",   "Exploiting the red circle","Iskorištavanje crvenih check point-a u burgu, cluckin bellu i drugim prodavnicama, kad stanete na crveni marker server vas zaledi i izađe vam meni da izaberete sta želite kupiti, za to vrijeme niko ne može da vas ubije."));
            roleRules.Add(new RoleRule("KOS",   "Kill on Sight",            "Kill on Sight (KOS) je ubijanje igrača po viđenju, bez upozorenja, korištenja chata..."));
            roleRules.Add(new RoleRule("CS",    "CrackShoting",             "CrackShoting (CS) je iskorištavanje bugova sa oružjem, deagle i combat shotgun pucaju većom brzinom iz vozila."));
            roleRules.Add(new RoleRule("PvE",   "Player vs Enviroment",     "Player vs Enviroment (PvE) je divljanje i pucanje po okolini i ugrožavanje nečije imovine."));
            roleRules.Add(new RoleRule("CR",    "ChickenRunning",           "ChickenRunning (CR) je trčanje cik-cak kako bi izbegli metke i preživeli."));
            roleRules.Add(new RoleRule("SPAM",  "Spamming",                 "Spamming - Pisanje iste riječi ili rečenice dva ili više puta za redom. Jedino opravdanje vašeg Spam-anja može biti lag ili nešto slično. Ili slanje poruke poslije svake napisanje riječi...\n\nPrimjer:\nPetar_Petrovic: E\nPetar_Petrovic: ajde\nPetar_Petrovic: mi\nPetar_Petrovic: daj\nPetar_Petrovic: admina..."));
        }

        public int Lenght
        {
            get { return roleRules.Count; }
        }

        public RoleRule this[int index]
        {
            get { return roleRules[index] ; }
            //set { roleRules = value; }
        }
    }
}
