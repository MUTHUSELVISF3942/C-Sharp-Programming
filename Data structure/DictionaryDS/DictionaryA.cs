namespace DictionaryDs
{
    public partial class Dictionary<Tkey,Tvalue>
    {
        
        public bool Containskey(Tkey Key)
        {
            int index=0;
            bool result=LinearSearch(Key,out index);
            return result;
        }
        public bool ContainsValue(Tvalue Value)
        {
            bool result=false;

            for (var i = 0; i < _count; i++)
            {
                if(Value.Equals(Array[i]))
                {
                 result=true;
                 break;
                }
            }
            return result;
        }
        public bool Remove(Tkey Key)
        {
            bool result=false;
            int flag=0;
            for (var i = 0; i < _count; i++)
            {
                if(Key.Equals(Array[i].Key))
                {
                    
                    result=true;
                    Array[i]=Array[i+1];
                    flag++;
                }
                else if(flag==1)
                {
                 Array[i]=Array[i+1];
                }
            }
            return result;
        }
        public KeyValue<Tkey,Tvalue> ElementAt(int index)
        {
             KeyValue<Tkey,Tvalue>output=null;
            for (var i = 0; i < _count; i++)
            {
                if(index.Equals(i))
                {
                 output=Array[i];
                 break;
                }
            }
            return output;
        }
        }
    }
