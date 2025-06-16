using Tareas;
List<Tarea> TareasPendientes = new List<Tarea>();

int N;
string n;
Console.WriteLine("Ingrese N:");
n = Console.ReadLine();
int.TryParse(n,out N);
int id = 0;
for (int i = 0; i < N; i++)
{
    id++;
    Console.WriteLine("Ingrese descripcion:");
    string descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese la duracion:");
    string duracion = Console.ReadLine();
    TareasPendientes.add(new Tarea(id, descripcion, int.Parse(duracion)));
}