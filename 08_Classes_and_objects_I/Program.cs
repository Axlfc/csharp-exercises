Puerta door = new Puerta(150, 200, 0x000000);

door.MostrarEstado();

Persona alumno = new Persona();
alumno.Nombre = "Jose";
alumno.FechaNacimiento = Convert.ToDateTime("10/10/1996");
alumno.registrar();

class Puerta {
    int ancho;
    int alto;
    int color;
    bool abierta;

    // constructor
    public Puerta (int ancho=100, int largo=200, int color=0xFFFFFF, bool abierta=false) {
        this.ancho = ancho;
        this.alto = largo;
        this.color = color;
        this.abierta = abierta;
    }

    public void MostrarEstado() {
        Console.WriteLine($"Ancho: " + ancho);
        Console.WriteLine($"Alto: " + alto);
        Console.WriteLine($"Color: " + color);
        Console.WriteLine($"Abierta: " + abierta);
    }

    // Destructor
    ~Puerta() {
        Console.WriteLine("La puerta se ha destruido.");
    }
}

/*
public class Persona {
    // Attributes
    public string nombre;
    public DateTime fechaNacimiento;
    private int edad;

    */

    public class Persona() {
        private string _nombre;
        private DateTime _fechaNacimiento;
        private int _edad;

        // Propiedades
        public int Edad {
            get { return _edad; }
            private set { _edad = value; }

        }

        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime FechaNacimiento {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public void registrar() {
        calcularEdad(fechaNacimiento);
        Console.WriteLine(nombre + " con " + edad + " años de edad, ha sido registrado correctamente");
        }

        private void calcularEdad(DateTime fechaNacimientoPersona) {
            DateTime fechaActual = DateTime.Now;
            edad = fechaActual.Year - fechaNacimientoPersona.Year;
        }
    }   
}