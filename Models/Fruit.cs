namespace FruitsTask.Models
{
    abstract class Fruit
    {
        public decimal _price;
        public string _sort;

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0) 
                {
                    _price= value;
                }
            }
        }

        public string Sort { get;set; }

        public abstract void Taste();  
    }
}
