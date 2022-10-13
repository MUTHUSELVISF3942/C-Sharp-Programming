
namespace ListDs
{
    

    public partial class List<Type>
    {
        private Type[] Array { get; set; }
        private int _count;
        private int _capacity;

        public Type this[int index]
        {
            get { return Array[index];}
            set { Array[index]=value; }
        }

        public int Count { get{return _count;}}
        public int Capacity { get{return _capacity;}}
        public List()
        {
            _count = 0;
            _capacity=4;
            Array =new Type[_capacity];

        }
        public List(int size)
        {
            _count=0;
            _capacity=size;
            Array =new Type[_capacity];
        }

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
            Type[] Array1= new Type[_capacity*2];
            for(int i=0;i<_count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1; 
        }
        
    }
}