namespace CorsoDotnet.Models.ViewModels
{
    public class CourseDetailViewModel : CourseViewModel
    {
        private string _descrizione;
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }


    }
}