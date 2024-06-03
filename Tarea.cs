namespace EspacioTarea{
public class Tarea{
    private int id;
    public int Id{get => id;}
    public static int contador{get;set;}

    private string descripcion;
    public string Descripcion{get => descripcion ; set => descripcion = value;}

    private int duracion;
    public int Duracion{get => duracion ; set => duracion = value;}

    public Tarea(string descripcion1, int duracion1){
        id = contador;
        descripcion = descripcion1;
        duracion = duracion1;
        contador++;
    }

    public void mostrarContador(){
        Console.WriteLine(contador);
    }
}
}