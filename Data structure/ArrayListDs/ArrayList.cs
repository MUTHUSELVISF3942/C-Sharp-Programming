namespace ArrayListDs
{
    public partial class ArrayList
    {
        private dynamic[] Array {get; set;}

        private int _count;
        private int _capacity;

        public dynamic this[int index]
        {
            get { return Array[index];}
            set { Array[index]=value; }
        }

        public int count {get{return _count;}}

        public int Capacity { get {return _capacity;} }

        public ArrayList()
        {
            _count = 0;
            _capacity = 4;
            Array=new object[_capacity];
        }
        public ArrayList(int size)
        {
            _count=0;
            _capacity=size;
            Array =new object[_capacity];
        }
        public void Add(object data)
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
            object[] Array1= new object[_capacity*2];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1; 
        }  
        
    }
}