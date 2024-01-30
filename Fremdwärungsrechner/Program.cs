namespace Fremdwärungsrechner
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Dictionary<string, double> meinDictionary = new Dictionary<string, double>();
            {
                meinDictionary.Add("Euro", 1.04);
                meinDictionary.Add("Dollar", 1.11);
                meinDictionary.Add("Yuan", 8.11);
                meinDictionary.Add("Lira", 31.34);
                meinDictionary.Add("Rubel", 101.88);
                meinDictionary.Add("Pfund", 0.9);
                meinDictionary.Add("Dirham", 4.07);
                meinDictionary.Add("Schekel", 4.47);
                meinDictionary.Add("Real", 5.60);
                meinDictionary.Add("Rupie", 92.33);

            }
            double Euro = meinDictionary["Euro"];
            double Dollar = meinDictionary["Dollar"];
            double Yuan = meinDictionary["Yuan"];
            double Lira = meinDictionary["Lira"];
            double Rubel = meinDictionary["Rubel"];
            double Pfund = meinDictionary["Pfund"];
            double Dirham = meinDictionary["Dirham"];
            double Schekel = meinDictionary["Schekel"];
            double Real = meinDictionary["Real"];
            double Rupie = meinDictionary["Rupie"];


            Console.WriteLine("Welche Fremdwährung willst du in welche umwandeln?");
            Console.WriteLine("Gib eine Anzahl an Schweizer Franken");
            string userinput1 = Console.ReadLine();
            Console.WriteLine("Gib deine Fremdwährung ein, in die du umrechnen willst");
           string userinput2 = Console.ReadLine();    

            double Nummereins = Convert.ToDouble(userinput1);

            switch (userinput2) {
                case "Euro":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Euro));
                    break;
                case "Dollar":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Dollar));
                    break;
                case "Yuan":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Yuan));
                    break;
                case "Lira":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Lira));
                    break;
                case "Rubel":
                    Console.WriteLine("Dein Ergebniss ist  " + (Nummereins * Rubel));
                    break;
                case "Dirham":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Dirham));
                    break;
                case "Schekel":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Schekel));
                    break;
                case "Real":
                    Console.WriteLine("Dein Ergebniss ist  " + (Nummereins * Real));
                    break;
                case "Rupie":
                    Console.WriteLine("Dein Ergebniss ist " + (Nummereins * Rupie));
                    break;


            }     
        } 
    }
}