using System;
using System.Collections ;

namespace arraylist
{
    class Program
    {
        static void Main ( string[] args)
        {
            //System.Collections namespace

            ArrayList _list= new ArrayList () ;

            _list.Add("sam") ;
            _list.Add(2) ;
            _list.Add(true) ;
            _list.Add('A') ;

            //icerisinde veriler erisim
            Console.WriteLine(_list[1]) ;

            foreach (var item in _list) 
            {
                Console.WriteLine(item) ;
            }
            //AddRange
            Console.WriteLine("**** Add Range *****") ;
            string[] colors = {"red", "yellow", "blue"} ;
            List<int> numbers = new List<int>(){1,3,7,3,5,6,94} ;
            _list.AddRange(colors);
            _list.AddRange(numbers);

            foreach(var item in _list)
                Console.WriteLine(item) ;

            //Sort
            Console.WriteLine("****Sort ***");
            //_list.Sort();

            foreach (var item in _list)
                Console.WriteLine(item) ;
            
            //Binary Search
            Console.WriteLine("**** Binary search****") ;
            Console.WriteLine(_list.BinarySearch(9)) ;

            //Reverse

            Console.WriteLine("**** Reverse *****") ;
            _list.Reverse() ;
        
            foreach(var item in _list) 
                Console.WriteLine(item) ;
            
            // Clear
            Console.WriteLine("**** Clear *****") ;
                _list.Clear() ;

            foreach (var item in _list)
                Console.WriteLine (item) ; 
            
        }

    }
}