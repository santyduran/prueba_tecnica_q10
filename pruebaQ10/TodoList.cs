//es la clase principal con la logica, agregar, eliminar, completar y listar 
public class TodoList 
{
    private List <Tarea> listaTareas = new List<Tarea>();

    public void AgregarTarea(string descripcion, DateTime? fechaLimite =null)
    {
        listaTareas.Add(new Tarea(descripcion, fechaLimite));
    }

    public void ElimitarTarea(string descripcion)
    {
        //buscar la tarea a por descripcion para eliminar
        var tarea = listaTareas.Where(t => t.Descripcion.Equals(descripcion, StringComparison.OrdinalIgnoreCase))
                               .FirstOrDefault();

        //eliminar
        if (tarea != null)
        {
            listaTareas.Remove(tarea);
        }
        
    }

    public void TareaCompletada(string descripcion)
    {   //1.buscar la tarea por descriocion para completarla 
        var tarea = listaTareas.Where(t => t.Descripcion.Equals(descripcion, StringComparison.OrdinalIgnoreCase))
                               .FirstOrDefault();
        //2 marcar como completada
        if (tarea != null)
        {
            tarea.Completada = true;
        }
    }

    //se busca en la lista de tareas si estan agregadas o no y que contiene
    public void MostrarTarea()
    {
        if (listaTareas.Count == 0)
        {
            Console.WriteLine("no hay tareas registradas");
        }
        else
        {
           
            foreach (var tarea in listaTareas)
            {
                Console.WriteLine($"{tarea.Descripcion} - {(tarea.FechaLimite.HasValue ? tarea.FechaLimite.Value.ToString("yyyy-MM-dd"):"")} - {(tarea.Completada ? "Completada" : "Pendiente")} ");
                
            }
        }
    }
}
