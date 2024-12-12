namespace WEB.Models
{
    /// <summary>
    /// Модель для изменения параметров Читателя
    /// </summary>
    public class EditReadersModel
    {
        public int Id { get; set; }

        public List<string> Readers { get; set; }   
    }
}
