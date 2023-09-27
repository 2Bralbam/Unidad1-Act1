namespace Unidad1_Act1.Models.ViewModels
{
    public class IndexViewModel
    {
        public class  Perfil
        {
            public string Nombre { get; set; } = null!;
			public string Carrera { get; set; } = null!;

			public string Periodo { get; set; } = null!;
			public string Semestre { get; set; } = null!;
			public int IdFoto { get; set; }
        }
    }
}
