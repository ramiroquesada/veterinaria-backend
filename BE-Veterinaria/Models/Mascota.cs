namespace BE_Veterinaria.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public string Duenio { get; set; }
        public string Tipo { get; set;}
        public DateTime FechaCreacion { get; set; }
    }
}
