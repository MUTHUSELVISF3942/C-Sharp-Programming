using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QueueDS
{
    public partial class Queue<Type>
    {
        private Type[] Array{get;set;}
        private int count;
        private int capacity;
        private int tail;
        private int head;
        public int Count{get{return count;}}
        public Queue()
        {
            count=0;
            capacity=4;
            tail=0;
            head=0;
            Array=new Type[capacity];
        }
        public Queue(int size)
        {
            count=0;
            capacity=size;
            tail=0;
            head=0;
            Array=new Type[capacity];
        }
        public void Enqueue(Type data)
        {
            if(tail==capacity)
            {
                GrowSize();
            }
            Array[tail]=data;
            tail++;
            count++;
        }
         public void GrowSize()
        {
            capacity=capacity*2;
            Type[] Array1=new Type[capacity];
            for(int i=0;i<tail;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }
        public Type Dequeue()
        {
            Type value=default(Type);
            if(head>=tail)
            {
                System.Console.WriteLine("Empty queue");
            }
            else 
            {
                value=Array[head];
                head++;
                count--;
            }
            return value;

        }
        public Type Peak()
        {
            Type value=default(Type);
            if(head>=tail)
            {
                System.Console.WriteLine("Empty queue");
            }
            else 
            {
                value=Array[head];
                
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
    }
}