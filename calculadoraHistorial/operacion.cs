public class Operacion{ 
    private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
    private double nuevoValor; //El valor con el que se opera sobre el 
    resultadoAnterior; 

    private TipoOperacion operacion;// El tipo de operación realizada 

    public double Resultado{ 
    /* Lógica para calcular o devolver el resultado */ 
    } 
    // Propiedad pública para acceder al nuevo valor utilizado en la operación 
    public double NuevoValor{ 
        get {...} 
    } 
    // Constructor u otros métodos necesarios para inicializar y gestionar la operación 
    // ... 
    public enum TipoOperacion{ 
        Suma, 
        Resta, 
        Multiplicacion, 
        Division, 
        Limpiar  // Representa la acción de borrar el resultado actual o el historial 
    } 
} 