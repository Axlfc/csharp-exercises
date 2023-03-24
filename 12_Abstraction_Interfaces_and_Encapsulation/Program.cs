// DateTime, TimeOnly y DateOnly
/*
var now = DateTime.Now;
Console.WriteLine(now);

var hour = now.ToShortTimeString();
Console.WriteLine(hour);

var date = now.ToShortDateString();
Console.WriteLine(date);

TimeOnly onlyHour = new TimeOnly(9, 30);
Console.WriteLine(onlyHour);

DateOnly onlyDate = new DateOnly(2023, 3, 24);
Console.WriteLine(onlyDate);
*/

// Interfaces

var person = new Persona();
person.AskName();
Console.WriteLine(person.Name);

public class Persona : IPersonas {
    public String Name { get; set; }
    public string Surname { get; set; }

    public int Age  { get; set; }

    public int Height { get; set; }

    public DateOnly BirthDate { get; set; }

    public Persona(string name) {
        //Name = name;
        AskName();
    }

    public void AskName() {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        if (name == null) {
            Console.WriteLine("You must enter your name!");
        } else {
            Name = name;
        }
        Console.WriteLine("¿Cuál es tu fecha de nacimiento? (aaa/mm/dd)");

        var fecha = Console.ReadLine();
        BirthDate = DateOnly.Parse(fecha);
    }

    public void WriteData() {
        Console.WriteLine($"Nombre: {Name}, Fecha de Nacimiento: {BirthDate} ");
    }
}

public interface IPersonas {
    public string Name { get; set; }
    public string Surname { get; set; }

    public int Age { get; set; }

    public int Height { get; set; }

    public DateOnly BirthDate { get; set; }

    public void AskData();
    public void WriteData();
}