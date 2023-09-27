namespace Unidad1_Act1.Models.ViewModels
{
    public class MiPerfilViewModel
    {
        public class MiPerfil
        {
            public int IdFoto { get; set; }
            public string Nombre { get; set; } = null!;
            public string Apellido { get; set; } = null!;
            public string Direccion { get; set; } = null!;
            public string Telefono { get; set; } = null!;
            public string Email { get; set; } = null!;
            public string FechaNacimiento { get; set; } = null!;
            public string Genero { get; set; } = null!;
            public string Nacionalidad { get; set; } = null!;
            public string Carrera { get; set; } = null!;
            public string Semestre { get; set; } =null!;    
            public string NumeroCtrl { get; set; } = null!;
        }
    }
}
