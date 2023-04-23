using OrleansCodeGen.Orleans.Serialization.Codecs;

namespace OrleansWebAPI7AppDemo.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Animal
    {
        // 名前
        private String _name = String.Empty;
        public string Name 
        { 
            get
            {
                return _name;
            } 
            set 
            { 
                _name = value;
            } 
        }


        // 年齢
        private Int32 _age = 0;
        public Int32 Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
    }
}
