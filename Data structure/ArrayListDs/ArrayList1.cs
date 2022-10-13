namespace ArrayListDs
{
    public partial class ArrayList
    {

        public void Insert(int index , object data)
        {
            _capacity=_capacity*2;
            object[] temp=new object[_capacity];
            for (var i = 0; i <=_count; i++)
            {
              
                if(i<index)
                {
                    temp[i]=Array[i];
                }
                else if(i==index)
                {
                    temp[i]=data;
                }
                else if(i>index)
                {
                    temp[i]=Array[i-1];
                } 
            }
            Array=temp;
        }

         public void RemoveAt(int index)
        {
            for (var i = 0; i < _count; i++)
            {
    
              if(i>=index)
                {
                    Array[i]=Array[i+1];
                }     
            
            }

        _count--;
        }
    
        public void Remove(object data)
        {
            for (var i = 0; i <_count ; i++)
            {
                if(data.Equals(Array[i]))
                {
                   object temp=Array[i];
                   for (var j = i; j < _count; j++)
                   {
                     Array[j]=Array[j+1];
                   }
                }
            }
            _count--;
        } 

    }
}