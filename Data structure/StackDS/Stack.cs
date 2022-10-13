using System;
namespace StackDS
{
    public class Stack<Type>
    {
        private Type[] Array{get;set;}
        private int count;
        private int capacity;
        public int Count{get{return count;}}
        public Stack()
        {
            count=0;
            capacity=4;
            Array=new Type[capacity];
        }
        public Stack(int size)
        {
            count=0;
            capacity=size;
            Array=new Type[capacity];

        }
        public void Push(Type data)
        {
            if(count==capacity)
            {
                GrowSize();
            }
            Array[count]=data;
            count++;
        }
        public void GrowSize()
        {
            capacity=capacity*2;
            Type[] array=new Type[capacity];
            for(int i=0;i<count;i++)
            {
                Array[i]=array[i];
            }
            array=Array;
        }
        public Type Pop()
        {
            Type value=default(Type);
            if(count<0)
            {
                System.Console.WriteLine("Empty stack");
            }
            else if(count>=0)
            {
                value=Array[count];
                count--;
            }
            return value;

        }
        public bool Contains(Type data)
        {
            bool value=false;
            for(int i=0;i<count;i++)
            {
                if(Array[i].Equals(data))
                {
                    return value;
                }
                
            }
            return value;
        }
        public Type Peak()
        {
            Type value=default(Type);
            if(count<0)
            {
                System.Console.WriteLine("Empty stack");
            }
            else if(count>=0)
            {
                value=Array[count];
                
            }
            return value;

        }

    }
}