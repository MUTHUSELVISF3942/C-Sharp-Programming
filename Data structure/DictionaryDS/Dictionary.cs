namespace DictionaryDs
{
    public class  KeyValue<Tkey,Tvalue>
    {
        public Tkey  Key{ get; set;}
        public Tvalue Value {get;set;}
   
    }
    public partial class Dictionary<Tkey,Tvalue>
    {
        private int  _count;
        private int _capacity;
        
        public KeyValue<Tkey,Tvalue>[] Array {get; set;} 
            
        public int Count {get{return _count;}}

        public int Capacity { get {return _capacity;} }
        public Dictionary()
        {
            _count=0;
            _capacity=4;
            Array=new KeyValue<Tkey,Tvalue>[_capacity];
        }
        public Dictionary(int Size)
        {
            _count=0;
            _capacity=4;
            Array=new KeyValue<Tkey,Tvalue>[Size];
        }
        public void Add(Tkey key,Tvalue value)
        {
            if(_count == _capacity)
            {
                GrowSize();
            }
            bool temp=LinearSearch(key,out int index);
            if(temp==true)
            {
                System.Console.WriteLine("<<<<----- Duplicate Key ------>>>> ");
            }
            else
            {
	            KeyValue<Tkey,Tvalue>dictionary=new KeyValue<Tkey, Tvalue>();
	            dictionary.Key=key;
	            dictionary.Value=value;
	            Array[_count]=dictionary;
                _count++;
            }
             

        }
        public void GrowSize()
        {
            _capacity=_capacity*2;
            KeyValue<Tkey,Tvalue>[] temp=new KeyValue<Tkey, Tvalue>[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i]=Array[i];
                
            }
            Array=temp;
        }
        public bool LinearSearch(Tkey key,out int index)
        {
        //If Array Contains Key the Then Return True
            KeyValue<Tkey,Tvalue>dictionary=new KeyValue<Tkey, Tvalue>();
            bool value=false;
            index=0;
            for (int i = 0; i < _count ; i++)
            {
                if(key.Equals(Array[i]))
                {
                index=i;
                value= true;
                break;
                }
            }
            return value;
        }
        public Tvalue this [Tkey Key] //indexer
        {
           
            get
            {   int index;
                Tvalue output=default(Tvalue);
                bool temp=LinearSearch(Key,out index);
                if(temp)
                {
                    output=Array[index].Value;
                }
                else
                {
                    System.Console.WriteLine("Invalid Key");
                }
                return output;
            }
            set
            {
                int postion=0;
                bool temp=LinearSearch(Key,out postion);
                if(temp)
                {
                    Array[postion].Value=value;
                }
                else
                System.Console.WriteLine("Invalid Key...");

            }



        }








        }
       
}