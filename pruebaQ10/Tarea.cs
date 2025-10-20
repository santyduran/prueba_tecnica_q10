//definimos las propiedades 
public class Tarea
{
    public string Descripcion { get; set; }
    public DateTime? FechaLimite { get; set; }
    public bool Completada { get; set; } = false;

    public Tarea(string descripcion, DateTime? fechaLimite = null)
    {
        Descripcion = descripcion;
        FechaLimite = fechaLimite;
    }
    
}