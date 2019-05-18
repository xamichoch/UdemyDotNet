namespace CorsoDotnet.Models.ViewModels
{
    public class CourseViewModel
    {
        private string _titolo;
        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _imagePath;
        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        private Money _fullPrice;
        public Money FullPrice
        {
            get { return _fullPrice; }
            set { _fullPrice = value; }
        }

        private Money _currentPrice;
        public Money CurrentPrice
        {
            get { return _currentPrice; }
            set { _currentPrice = value; }
        }


    }
}