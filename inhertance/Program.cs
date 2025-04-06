namespace inhertance
{
    class Program
    {

       static void Main(string[] args)
        {
            // Creating an instance of child class
            FictionBook fb = new FictionBook("Harry Potter", "JK Rowling", 250, "Fantasy", 
                                              "Most super noval in the histroy");
            fb.DisplaInfo();
            fb.PrintDescription();
        }
    }
}

