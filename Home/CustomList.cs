using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    public class CustomList<T>
    {
        public T[] myList;
        private int count;
        public T this[int i]
        {
            get { return myList[i]; }
            set { myList[i] = value; }
        }
        
        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            count = 0;
            myList = new T[count];


        }

       
          public void Add(T positive)
        { 
            count++;
            T[] placeholder = new T[count];
            for(int i = 0; i < count -1; i++)
            {
                placeholder[i] = myList[i];
            }
            myList = placeholder;
            myList[count - 1] = positive;
        }
    public void Remove(T item)
    {
        T Counter;
        while()
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
