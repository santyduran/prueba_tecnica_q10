using System.Globalization;

public static class Program{    
    public static void Main(string[] args)
    {
        TodoList todoList = new TodoList();
        var cerrar = false;
        //menu para interaccion del cliente 
        do
        {
            Console.WriteLine("Menu tareas");
            Console.WriteLine("1. Agregar tareas");
            Console.WriteLine("2. Ver lista de tareas");
            Console.WriteLine("3. Marcar tareas como compeltadas");
            Console.WriteLine("4. Eliminar tareas");
            Console.WriteLine("5. Salir");
            var opcion = Console.ReadLine();



            switch (opcion)
            {
                case "1":
                    {
                        Console.WriteLine("ingrese la descripcion");
                        var descripcion = Console.ReadLine();
                        Console.WriteLine("ingrese la fecha(yyyy-MM-dd) o enter si no es necesaria.");
                        var fechaLimite = Console.ReadLine();

                        if (fechaLimite == "")
                            todoList.AgregarTarea(descripcion);
                        else
                        {

                            if (DateTime.TryParseExact(fechaLimite, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
                            {
                                todoList.AgregarTarea(descripcion, fecha);
                            }
                            else
                            {
                                Console.WriteLine("el formato es incorrecto");
                            }
                        }
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("listando tareas");
                        todoList.MostrarTarea();
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("ingrese la descripcion");
                        var descripcion = Console.ReadLine();
                        todoList.TareaCompletada(descripcion);
                        Console.WriteLine("tarea completada");

                    }
                    break;
                case "4":
                    {
                        Console.WriteLine("ingrese la descripcion");
                        var descripcion = Console.ReadLine();
                        todoList.ElimitarTarea(descripcion);
                        Console.WriteLine("tarea eliminada");

                    }
                    break;
                case "5":
                    {
                        Console.WriteLine("saliendo del menu");
                        cerrar = true;
                    }
                    break;

                default: {

                        Console.WriteLine("Opcion no valida");
                    }
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }
        while (cerrar == false);


        //1. agregar tarea
        //2. mostrar listas de tareas
        //3. marcar tareas completadas
        //4. eliminar tareas
        //5. salir 

       



    }
}
