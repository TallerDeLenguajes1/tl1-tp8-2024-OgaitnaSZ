using EspacioTarea;

Tarea tarea;
var tareasPendientes = new List<Tarea>();
var tareasRealizadas = new List<Tarea>();

int bandera = 0;
int estado;
int idTarea;
string descripcionTarea;
int opcion;

//generar tareas aleatorias
for(int i=0 ; i<10 ; i++){
    generarTareas();
}

Console.WriteLine("--- SISTEMA DE TAREAS ---");
do{
    Console.WriteLine("0: Agregar Tarea\n1:Ver Tareas Pendientes\n2:Ver Tareas Realizadas\n3:Mover Tareas\n4:Buscar Tareas\n5:Salir");
    opcion = int.Parse(Console.ReadLine());
    switch(opcion){
        case 0:
            agregarTarea();
            break;
        case 1:
            verTareasPendientes();
            break;
        case 2:
            verTareasRealizadas();
            break;
        case 3:
            moverTareas();
            break;
        case 4:
            buscarTarea();
            break;
        case 5:
            bandera = 1;
            break;
        default:
            Console.WriteLine("Ingrese una opcion valida: ");
            break;
    }
}while(bandera == 0);

void agregarTarea(){
    string descripcion;
    int duracion;
    Console.WriteLine("Ingrese la descripcion: ");
    descripcion = Console.ReadLine();
    Console.WriteLine("Ingrese la duracion: ");
    duracion = int.Parse(Console.ReadLine());
    tarea = new Tarea(descripcion, duracion);
    Console.WriteLine("Como se encuentra la tarea?\n0:Pendiente\n1:Realizada");
    estado = int.Parse(Console.ReadLine());
    if(estado == 0){
        tareasPendientes.Add(tarea);
    }else if(estado == 1){
        tareasRealizadas.Add(tarea);
    }else{
        Console.WriteLine("Ingrese una opcion valida");
    }
}
void verTareasPendientes(){
    Console.WriteLine("Tareas Pendientes: " + tareasPendientes.Count);
    if(tareasPendientes.Count>0){
        for(int i=0 ; i<tareasPendientes.Count ; i++){
            mostrarTarea(tareasPendientes[i]);
        }
    }else{
        Console.WriteLine("No hay tareas");
    }
    
}
void verTareasRealizadas(){
    Console.WriteLine("Tareas Realizadas: " + tareasRealizadas.Count);
    if(tareasRealizadas.Count>0){
        for(int i=0 ; i<tareasRealizadas.Count ; i++){
            mostrarTarea(tareasRealizadas[i]);
        }
    }else{
        Console.WriteLine("No hay tareas");
    }
}
void moverTareas(){
    int bandera = 0;
    verTareasPendientes();
    Console.WriteLine("Elija el ID de la tarea a mover: ");
    idTarea = int.Parse(Console.ReadLine());
    for(int i=0 ; i<tareasPendientes.Count ; i++){
        if(tareasPendientes[i].Id == idTarea){
            tarea = tareasPendientes[idTarea];
            tareasRealizadas.Add(tarea);
            tareasPendientes.Remove(tarea);
            break;
        }
    }
    if(bandera == 1){
        Console.WriteLine("Tarea movida con exito");
    }else{
        Console.WriteLine("No se encontro tarea con ese ID");
    }
}
void buscarTarea(){
    Console.WriteLine("Escriba la descripcion de la tarea: "); 
    descripcionTarea = Console.ReadLine();

    for(int i=0 ; i<tareasPendientes.Count ; i++){
        if(tareasPendientes[i].Descripcion.Contains(descripcionTarea)){
            mostrarTarea(tareasPendientes[i]);
        }else{
            Console.WriteLine("No se encontro la tarea");
        }
    }
}
void mostrarTarea(Tarea tarea){
    Console.WriteLine("ID: " + tarea.Id);
    Console.WriteLine("Descrripcion: " + tarea.Descripcion);
    Console.WriteLine("Duracion: " + tarea.Duracion);
}
void generarTareas(){
    Random rand = new Random();
    int duracion;
    duracion = rand.Next(0, 30 + 1);
    tarea = new Tarea("", duracion);
    tareasPendientes.Add(tarea);
}