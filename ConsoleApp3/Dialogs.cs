using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Dialogs
    {
        Scene death = new Scene("ghost", "ŚMIERĆ", ConsoleColor.Red);
        Scene superdeath = new Scene("ghost", "SUPERŚMIERĆ", ConsoleColor.Red);
        Scene fox = new Scene("fox", "YORK", ConsoleColor.DarkRed);
        Scene captain = new Scene("captain", "KAPITAN", ConsoleColor.DarkCyan);
        Scene ibis = new Scene("ibis", "ZŁA WIEDŹMA FAUSTYNA", ConsoleColor.Green);
        Scene minotaur = new Scene("minotaur", "MINOTAUR", ConsoleColor.Red);
        Scene minotaur2 = new Scene("minohappy", "MINOTAUR", ConsoleColor.Red);
        Scene raven = new Scene("raven", "KEANU REEVES", ConsoleColor.Yellow);
        Scene skeleton = new Scene("skeleton", "SZKIELET PERKUSISTA", ConsoleColor.Red);
        Scene faust = new Scene("faust", "FAUST", ConsoleColor.Cyan);
        Scene guard = new Scene("guard", "STRAŻNIK", ConsoleColor.Red);
        Scene nothing = new Scene("nothing", "???", ConsoleColor.Red);
        Scene castle = new Scene("castle", "");
        Scene amulet = new Scene("amulet", "");
        Scene title = new Scene("title", "");
        Scene empty = new Scene();

        Animations animations = new Animations();
        Audio audio = new Audio();
        Scenario scenario = new Scenario("superdeath");

        public void EnterKey(bool x = true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true);
            }
            if (x)
            {
                Console.Clear();
            }
        }
        public void Enter()
        {
            EnterKey();
        }
        public void DialogDeaths()
        {
            int i = 1;
            empty.DisplayScene("Droga do barku", " Przechodzisz ostrożnie pod barek.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "Witam panią barman, nazywam się FRANCIS YORK MORGAN, \n ale wszyscy mówią na mnie YORK.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", scenario.TakeDialog(i), ConsoleColor.White);
            Enter();
            ibis.DisplayScene("Przy barku", "Ja jestem ZŁA WIEDŹMA FAUSTYNA.", ConsoleColor.White);
            Enter();
            ibis.DisplayScene("Przy barku", "I pierwsze słyszę. Ale mam dla pana dobrą wiadomość, \n dostaje pan drinka na koszt firmy.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "ZACH, nie powinniśmy się upijać.", ConsoleColor.White);
            Enter();
            death.DisplayScene("Przy barku", "Ale bym się czegoś napiła. Sztywno tu jak w grobie.", ConsoleColor.White);
            Enter();
            skeleton.DisplayScene("Przy barku", "BA DUM-TSSS", ConsoleColor.White);
            audio.PlayAudio("badumtss.wav");
            Enter();
            fox.DisplayScene("Przy barku", "Proszę bardzo, mogę oddać ci swojego drinka, \n którego dostałem właśnie na koszt firmy od \n ZŁEJ WIEDŹMY FAUSTYNY. Przysięgam, że nawet kropelki nie wypiłem.", ConsoleColor.White);
            Enter();
            death.DisplayScene("Przy barku", "Świetnie! [gul, gul, gul]", ConsoleColor.White);
            Enter();
            death.DisplayScene("Przy barku", "Trochę dziwnie się czuję...", ConsoleColor.White);
            Enter();
            superdeath.DisplayScene("Przy barku", "Drink był zatruty, nie żyjesz, przyszłam po twoją \n duszę.", ConsoleColor.Red);
            Enter();
            death.DisplayScene("Przy barku", scenario.TakeDialog(i+1), ConsoleColor.White);
            Enter();
            superdeath.DisplayScene("Przy barku", scenario.TakeDialog(i+2), ConsoleColor.Red);
            Enter();
            raven.DisplayScene("Przy barku", "Kraa :(", ConsoleColor.White);
            audio.PlayAudio("raven.wav");
            Enter();
            audio.StopAudio();
            castle.DisplayScene("Przy barku", "[smutny zamek, bo fajna grafika]", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "Wiem!", ConsoleColor.White);
            audio.PlayAudio("alert.wav");
            Enter();
            fox.DisplayScene("Przy barku", "ZŁA WIEDŹMA FAUSTYNA próbowała mnie otruć!", ConsoleColor.White);
            Enter();
            ibis.DisplayScene("Przy barku", "Hahaha! Jesteś niczym wobec mojej mocy!", ConsoleColor.White);
            audio.PlayAudio("powerup.wav");
            Enter();  
        }
        public void TitleScreen()
        {
            int i = 1;
            Console.WriteLine("Naciśnij 'ENTER' aby rozpocząć grę...");
            Enter();
            Console.WriteLine("STEROWANIE: STRZAŁKI oraz cyfry do wybierania poleceń \n'ENTER' kontynuuje przebieg rozgrywki");
            Enter();
            Console.WriteLine("EPIC GAMES 2000 proudly presents...");
            Enter();
            title.DisplayScene("", scenario.TakeDialog(0), ConsoleColor.White);
            Enter();
        }
        public void Intro()
        {
            int i = 1;
            audio.PlayAudio("ocean.wav");
            animations.Display("", "intro", 165, false, "");
            Console.Clear();
            animations.Display("", "loopintro", 165, true, "");
            audio.PlayAudio("codec.wav");
            animations.Display("Plaża", "loopamulet", 300, true, " Dostrzegasz, że ktoś do ciebie dzwoni...");
        }
        public void Captain1()
        {
            int i = 1;
            captain.DisplayScene("Plaża", "YORK? Słyszysz mnie? Gdzie jesteś?", ConsoleColor.White);
            audio.PlayAudio("codecstart.wav");
            Enter();
            fox.DisplayScene("Plaża", "Głośno i wyraźnie. Jestem na wyspie.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Plaża", "Widzę w oddali, że całkiem dużo ludzi przyszło na imprezę.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Plaża", "I muzyka jest dosyć głośna.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Plaża", "Czyli dokładnie tak jak przewidziała mi poranna kawa.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Fantastycznie, będziesz mógł łatwo wtopić się w tłum.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Powtórzę plan, żeby wszystko było jasne. \n Zgodnie z naszymi informacjami na wydarzeniu pojawi się osobnik \n znany jako ZŁY CZARNOKSIĘŻNIK FAUST.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Jest on w posiadaniu spisu członków tak zwanych PROGRAMISTÓW, \n tajnej organizacji, żyjącej z siania terroru i chaosu. \n Twoje zadanie jest proste: znaleźć FAUSTA \n i odebrać ten spis za wszelką cenę.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Pamiętaj, że jesteś tam incognito. \n Pod żadnym pozorem nie możesz dać się rozpoznać. \n Jeżeli Faust dowie się o tobie może zniszczyć spis, \n a wtedy stracimy ostatnią szansę by rozpracować organizację.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Plaża", "Słyszałeś, ZACH, przewiduję, że ta misja będzie tak łatwa, \n że w skali od 1 do 10, gdzie 1 to skucie zmutowanego \n policjanta na dachu komisariatu, a 10 to wygranie \n mistrzostw świata w łowieniu ryb daję jej zero.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Wspaniale. YORK, jeszcze jedno... kim jest ZACH?", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Plaża", "Powiedzmy, że to mój dobry przyjaciel (wink wink), \n który pomaga mi w rozwiązywaniu spraw.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Rozumiem, bez odbioru.", ConsoleColor.White);
            Enter();
            audio.PlayAudio("codecstop.wav");
        }
        public void Empty1()
        {
            int i = 1;
            empty.DisplayScene("Brukowana ścieżka", " Przechodzisz ostrożnie na marmurowy taras \n z widokiem na jezioro i wtapiasz się w tłum \n bawiących się osób", ConsoleColor.White);
            Enter();
        }
        public void Minotaur1()
        {
            int i = 1;
            minotaur.DisplayScene("Taras przy plaży", "Siemanko!", ConsoleColor.White);
            Enter();
            minotaur2.DisplayScene("Taras przy plaży", "Co słychać?", ConsoleColor.White);
            Enter();
            minotaur.DisplayScene("Taras przy plaży", "Jestem PRZEMEK! A ty jak masz na imię?", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Taras przy plaży", "FRANCIS YORK MORGAN, ale wszyscy mówią na mnie YORK. \n Szukam tu jednego starego 'znajomego' razem \n z moim kolegą ZACHIEM.", ConsoleColor.White);
            Enter();
            minotaur2.DisplayScene("Taras przy plaży", "Ooo! Jak Super! Ej a lubisz łamigłówki?", ConsoleColor.White);
            Enter();
            minotaur.DisplayScene("Taras przy plaży", "Bo ja uwielbiam! Zagadki to moja generalnie \n najbardziej ulubiona rzecz na świecie!", ConsoleColor.White);
            Enter();
            minotaur2.DisplayScene("Taras przy plaży", "Chcesz jedną? Dodawali do mojej ulubionej gazetki \n - 1001 sposobów na Lasagnę dla Krytycznych Umysłów.", ConsoleColor.White);
            Enter();
            int a;
            Console.WriteLine("Czy chcesz rozwiązać łamigłówkę? Wybierz odpowiedź:");
            Console.WriteLine("1. Tak");
            Console.WriteLine("2. Nie");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Clear();
            while (a != 1 && a != 2)
            {
                Console.WriteLine("Czy chcesz rozwiązać łamigłówkę? Wybierz odpowiedź:");
                Console.WriteLine("1. Tak");
                Console.WriteLine("2. Nie");
                Int32.TryParse(Console.ReadLine(), out a);
                Console.Clear();
            }
            if(a==1)
            {
                fox.DisplayScene("Taras przy plaży", "Dlaczego by nie, ZACH również bardzo lubi łamigłówki.", ConsoleColor.White);
                Enter();
            }
            else
            {
                fox.DisplayScene("Taras przy plaży", "Ja nieszczególnie, ale za to ZACH bardzo lubi \n łamigłówki.", ConsoleColor.White);
                Enter();
            }
            Console.WriteLine(" ZACH,");
            Console.Write(" aby otworzyć przejście musisz doprowadzić Pionki (");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("P");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") do punktu ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("X");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" \n w tym samym czasie omijając poruszające się Koniki (");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("K");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("). \n Wieże (");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("W");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(") blokują drogę pionkowi. \n");
            Enter();
        }
        public void Minotaur2()
        {
            int i = 1;
            minotaur.DisplayScene("Taras przy plaży", "Wowie! Jesteś w to naprawdę dobry! \n Chyba też jesteś fanem trudnych zagadek. \n Chciałbyś zostać moim przyjacielem? \n Pomógłbym ci szukać twojego znajomego.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Taras przy plaży", "Czytałem kiedyś, że krowy mają kąt widzenia prawie 360 stopni, \n możesz się naprawdę przydać.", ConsoleColor.White);
            Enter();
            minotaur2.DisplayScene("Taras przy plaży", "JEJ TO DZIAŁA! MAM PRZYJACIELA!", ConsoleColor.White);
            Enter();
            minotaur.DisplayScene("Taras przy plaży", "Więc jednak terapeuta się mylił co do moich łamigłówek.", ConsoleColor.White);
            Enter();
        }
        public void Faust()
        {
            int i = 1;
            ibis.DisplayScene("Przy barku", "O NIE!!! Moja moc słabnie, jak ktoś taki jak ty \n mógł mnie pokonać? Przecież jestem wszechpotężna!", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "Wszystko ci się pomyliło. Jesteś morderczynią pierwszego stopnia, \n a ja jestem detektywem jego królewskiej mości, to chyba \n oczywiste, że przegrasz.", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "Coś mi tu nie gra, zaraz się przekonamy kto był pod tą maską \n przez ten cały czas!", ConsoleColor.White);
            Enter();
            faust.DisplayScene("Przy barku", "Jak ci się to udało? Co dało ci taką moc, żeby mnie \n zdemaskować?", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "To było oczywiste. Poranna kawa nigdy się nie myli. \n A teraz poproszę o spis.", ConsoleColor.White);
            Enter();
            faust.DisplayScene("Przy barku", "Niech to, wszystko by mi się udało, gdyby nie \n ten wścibski dzieciak i jego minotaur!", ConsoleColor.White);
            Enter();
            minotaur2.DisplayScene("Przy barku", "Minotaur? Gdzie?", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Przy barku", "Teraz sobie posiedzisz za kratkami.", ConsoleColor.White);
            Enter();
        }
        public void Captain2()
        {
            int i = 1;
            empty.DisplayScene("Brukowana ścieżka", " Wracasz na plażę.", ConsoleColor.White);
            Enter();
            audio.PlayAudio("codec.wav");
            animations.Display("Plaża", "loopamulet", 300, true, " Dostrzegasz, że ktoś do ciebie dzwoni...");
            audio.PlayAudio("codecstart.wav");
            captain.DisplayScene("Plaża", "YORK? Słyszysz mnie? Udało ci się?", ConsoleColor.White);
            Enter();
            fox.DisplayScene("Plaża", "Jak mówiłem, w skali trudności zero na 10. \n Spis jest bezpieczny u mnie.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("Plaża", "Gratulacje. Stukrotne gratulacje! \n Wracaj do kwatery głównej, sam król chce ci \n nadać odznaczenie za specjalne zasługi!", ConsoleColor.White);
            Enter();
            audio.PlayAudio("codecstop.wav");
            Console.WriteLine("Gratulacje...");
            Enter();
            Console.WriteLine("...ZACH. (wink wink)");
            Enter();
            audio.PlayAudio("applause.wav");
            Console.WriteLine("Mam nadzieję, że bawiłeś się z grą \nrównie dobrze, jak ja przy jej tworzeniu:");
            Console.WriteLine("Autor: Mateusz Bąk");
            Enter();
            audio.StopAudio();
        }
        public void Epilog()
        {
            int i = 1;
            nothing.DisplayScene("???", "Jak sytuacja?", ConsoleColor.White);
            Enter();
            captain.DisplayScene("???", "Spis odzyskany.", ConsoleColor.White);
            Enter();
            nothing.DisplayScene("???", "A Faust?", ConsoleColor.White);
            Enter();
            captain.DisplayScene("???", "Zdrajca zneutralizowany.", ConsoleColor.White);
            Enter();
            nothing.DisplayScene("???", "Bardzo dobrze. Ktoś coś podejrzewa?", ConsoleColor.White);
            Enter();
            captain.DisplayScene("???", "Nikt, heh, absolutnie nikt...", ConsoleColor.White);
            Enter();
            captain.DisplayScene("???", "Nikt się nie domyślił, że przez ten cały czas \n pracowałem dla PROGRAMISTÓW.", ConsoleColor.White);
            Enter();
            nothing.DisplayScene("???", "Bardzo się nam przysłużyłeś. Jesteśmy ci wielce wdzięczni.", ConsoleColor.White);
            Enter();
            captain.DisplayScene("???", "Dziękuję...", ConsoleColor.White);
            Enter();
            captain.DisplayScene("???", "...szefie.", ConsoleColor.White);
            audio.PlayAudio("snake.wav");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Koniec...");
            Enter();
        }
    }
}
