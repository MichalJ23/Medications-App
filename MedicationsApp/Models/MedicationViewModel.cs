namespace MedicationsApp.Models
{
    public class MedicationViewModel
    {
        public static int IdCounter = 0;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Portion { get; set; }

        public decimal Price { get; set; }
    }
}
