using System;


namespace MedicalStore{
    public partial class List<Type> //Include the type
    {
      
        private Type[] Array{get;set;}
        public int _count;
        public int _capacity;

        public int count{get{return _count;}}
        public int capacity{get{return _capacity;}}
        public Type this[int i]
        {
            get{return Array[i];}
            set{Array[i]=value;}
        }
        public List()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }
        //Creating a function that appends an element at the end of the array
        public void AddElement(Type data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            Type[] Array1=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }
       

    }
}