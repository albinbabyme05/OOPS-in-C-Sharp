using delegates_examples;

namespace delegates_examples
{
    public class ScrapYardManager
    {
        // searching for engien if found retruna engine name
        public Engine SearchEngine(string engine_model)
        {
            return new Engine();
        }
    }

    public class Engine
    {

    }

    public delegate Engine SearchDelegate(string condition);
    public class Mechanic
    {
        public SearchDelegate searchDel { get; set; }
        public void ReplaceEngine(string engine_brand)
        {
            //1 get the engine
            //normal way 
            //ScrapYardManager manager = new ScrapYardManager();
            //manager.SearchEngine(engine_brand);

            // delegate method 
            searchDel(engine_brand);

            //2 replace the engine

            Console.WriteLine($"Searching for {engine_brand} ");
            //3 Done work

            Console.WriteLine($"Yes fixed car with {engine_brand} model");

        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Mechanic mech = new Mechanic();

            ScrapYardManager man1 = new ScrapYardManager();
            mech.searchDel = man1.SearchEngine;// referencing to SearchEngine method

            mech.ReplaceEngine("BMW engine");
        }
    }

}
