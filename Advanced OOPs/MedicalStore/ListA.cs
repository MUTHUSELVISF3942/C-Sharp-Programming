using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public partial class List<Type>
    {
        public void Insert(int index,Type data)
        { 
            _capacity++;
            Type[] insert=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                if(index==i)
                {
                    insert[i]=data;
                }
                else if(i<index)
                {
                    insert[i]=Array[i];     
                     
                }
                else
                {
                    insert[i]=Array[i-1];
                    
                }
                
               
            }
            insert=Array;
            _count++;
        }
        public void RemoveAt(int index)
        {
            for(int i=0;i<_count;i++)
            {
                if(i<index)
                {
                    Array[i]=Array[i];
                }
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                }
                _count--;
            }
        }
        public void Remove(int data)
        {
            for(int i=0;i<_count;i++)
            {
                if(i==data)
                {
                    Array[i]=Array[i+1];
                }
            }
            _count--;
        }
    }
}