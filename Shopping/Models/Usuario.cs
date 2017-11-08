namespace Shopping.Models
{
    public class Usuario
    {
        public string Id_user { get; set; }
        public string Username { get; set; }
        public string Contraseña { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public int Id_rol { get; set; }

    }


}