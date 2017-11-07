namespace Shopping.Models
{
    public class Usuario
    {

        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string Descripcion { get; set; }
        public bool Flag { get; set; }
        public int IdRol { get; set; }


    }
}