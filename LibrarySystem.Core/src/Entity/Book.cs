namespace LibrarySystem.Core.src.Entity
{
    public class Book
    {
        private static int _id = 0;
        private double _price;

        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { 
            get => _price;
            set
            {
                if(value < 0)
                {
                    throw new InvalidDataException();
                }
                else
                {
                    _price = value;
                }
         } }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
            Id = _id;
            _id++;
        }
        public void UpdateBook(string? title, double? price) //Domain-Driven Design
        {
            if(title != null)
            {
                Title = title;
            }
            if(price != null)
            {
                _price = (double)price;
            }
        }
    }
}
