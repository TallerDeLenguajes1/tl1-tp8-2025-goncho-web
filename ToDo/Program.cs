using Tareas;
using System;
using System.IO;
List<Tarea> tareasPendientes = new List<Tarea>(); //Me permite usar el método Add() para agregar tareas a la lista
List<Tarea> tareasRealizadas = new List<Tarea>();


int id = 1;
int opcion;
do
{
    menu();
    int.TryParse(Console.ReadLine(), out opcion);
    switch(opcion){
            case 1:
                crearTareas(tareasPendientes, id);
                break;
            case 2:
                moverTareas(tareasPendientes, tareasRealizadas);
                break;
            case 3:
                 buscarTarea(tareasPendientes);
                break;    
            case 4:
                Console.WriteLine("Lista de Tareas Pendientes");
                mostrarLista(tareasPendientes);
                break;
            case 5:
                Console.WriteLine("Lista de Tareas Realizadas");
                mostrarLista(tareasRealizadas);
                break;  
            default:
                Console.WriteLine("Saliendo");
                break;
        }

} while (opcion != 0);

void crearTareas(List<Tarea> tareas, int id ){
    Random r = new Random(); //genera numeros aleatorios
    int numero = r.Next(3,6); //genera un numero entre 3 y 6
    int duracion;
    string descripcion;
    for(int i = 0; i<numero; i++){
        Console.WriteLine("Ingrese la duracion de la tarea:");
        int.TryParse(Console.ReadLine(),out duracion);
        if(duracion > 100 || duracion < 10){
           do{
                Console.WriteLine("La duracion de la tarea tiene que estar entre 100 y 10");
                Console.WriteLine("Ingrese nuevamente la duracion de la tarea:");
                int.TryParse(Console.ReadLine(),out duracion);
           }while(duracion > 100 || duracion < 10);
        }
       
        Console.WriteLine($"Ingrese la descripcion de la tarea{i+1}:");
        descripcion = Console.ReadLine();

        var cargarTarea = new Tarea(id,descripcion,duracion);
        tareas.Add(cargarTarea); //cargo las tareas en la lista
        id++;
    }
}

void moverTareas(List<Tarea> pendiente, List<Tarea> realizada){
    Console.WriteLine("Que tarea desea marcar como realizada(ingresar ID):");
    int id = 0;
    int.TryParse(Console.ReadLine(),out id);

    for(int i = pendiente.Count() - 1; i >= 0; i--){ //recorro la lista de tareas pendientes 
       if(pendiente[i].tareaId == id){
        var item = pendiente[i];
        realizada.Add(item); //agrega a realizadas
        pendiente.Remove(item); //elimina de pendientes
        Console.WriteLine("Su tarea ha sido marcada como realizada");
       }
    }
}



void buscarTarea(List<Tarea> pendiente){
    Console.WriteLine("Ingrese la descripcion de la tarea que busca:");
    string descripcion = Console.ReadLine();
    foreach(var item in pendiente){ //recorro la lista de tareas pendientes
        if(item.descri == descripcion){
            Console.WriteLine($"La tarea {descripcion} tiene una duracion de {item.dura} y su id es {item.tareaId}");
        }
    }
}
void mostrarLista(List<Tarea> listaTarea){
    foreach (var lista in listaTarea)
    {
        Console.WriteLine($"Tarea: {lista.tareaId}");
        Console.WriteLine($"Descripcion:{lista.descri}");
        Console.WriteLine($"Duracion:{lista.dura}");
        Console.WriteLine("---------");
    }
}
void menu()
{
    Console.WriteLine("--- Menu Principal ---");
    Console.WriteLine("1- Cargar Nuevas tareas");
    Console.WriteLine("2- Marcar como Realizada");
    Console.WriteLine("3- Buscar Tarea");
    Console.WriteLine("4- Mostrar Lista de tareas Pendientes");
    Console.WriteLine("5- Mostrar Lista de tareas Realizadas");
    Console.WriteLine("0- Salir");
}