using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class CustomList<T>
    {
        T[] myList;
        public CustomList()
        {

        }

        public void Add(T item)
        {
           T Counter;
            while(myList != null)
            {
                Counter++;
            }
            while(myList = Counter)
            {
                myList+= 1;
            }
            

            }
        }
        public void GetCounter()
        {
            int Counter;
            while(myList != null)
            {
                Counter++;
            }
        }
         public override string ToString()
        {
            // declare empty string
            
                        
            string answerString = "";
            foreach (T item in myList)
            {
                answerString += item;
            }
            return answerString;
            // pull index out of list
            // add piece from list to empty string
                //loop this process
            // return final string
        }


        //public class CustomList<T> : IEnumerable
    }//list<int i - new list<int>();
    //i.add(16);
    //i.add(20);
    //custom list<int>list new customlist<int>();
    //customList<lemon> Lemon = new CustomerList<lemons>();
}
