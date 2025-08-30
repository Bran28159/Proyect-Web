namespace ProyectoVistas.Models;
    public class Parrot
    {
        public int Id { get; set; }

        // Nombre común del loro
        public string? Name { get; set; }

        // Nombre científico
        public string? ScientificName { get; set; }

        // Familia a la que pertenece
        public string? Family { get; set; }

        // Estado de conservación (LC, EN, VU, etc.)
        public string? ConservationStatus { get; set; }

        // Esperanza de vida
        public string? Lifespan { get; set; }

        // Tamaño promedio
        public string? Size { get; set; }

        // Peso promedio
        public string? Weight { get; set; }

        // Hábitat
        public string? Habitat { get; set; }

        // Distribución geográfica
        public string? Distribution { get; set; }

        // Dieta
        public string? Diet { get; set; }

        // Descripción general
        public string? Description { get; set; }

        // Lenguaje o capacidad de imitación
        public string? Language { get; set; }

        // País o región principal
        public string? Country { get; set; }

        // Imagen principal
        public string? Poster { get; set; }

        // Lista de imágenes (en JSON podrías poner más)
        public List<string>? Images { get; set; }
    }

