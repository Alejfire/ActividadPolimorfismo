//Polimorfismo por abstraccion


class Program
{
    static void Main(string[] args)
    {
        EstudianteInteligente _EstudianteInteligente1 = new EstudianteInteligente();
        
        EstudianteVago _EstudianteVago1 = new EstudianteVago();
        
        EstudianteGenio _EstudianteGenio1 = new EstudianteGenio();
        
        Estudiante[] _Escuela = { _EstudianteInteligente1,
        _EstudianteVago1, _EstudianteGenio1 };

        foreach (Estudiante item in _Escuela)
        {
            Console.WriteLine(item.irAClases());
            Console.WriteLine(item.estudiar());
        }
    }
}

public abstract class Estudiante
{
    public virtual string irAClases()
    {
        return "Estudiante esta yendo a clases.";
    }

    public abstract string estudiar();
}

public class EstudianteInteligente : Estudiante
{
    public override string irAClases()
    {
        return "Estudiante inteligente esta yendo a clases";
    }
    public override string estudiar()
    {
        return "El estudiante inteligente estudia mucho.";
    }

}

public class EstudianteVago : Estudiante
{
    public override string irAClases()
    {
        return "El estudiante vago va a clases";
    }

    public override string estudiar()
    {
        return "El estudiante vago no estudia";
    }
}

public class EstudianteGenio : Estudiante
{
    public override string irAClases()
    {
        return "El estudiante genio va a clases";
    }

    public override string estudiar()
    {
        return "El estudiante genio no necesita estudiar";
    }
}


//Polimorfismo por interface

/*
class Program
{
    static void Main(string[] args)
    {
        EstudianteInteligente _EstudianteInteligente1 = new EstudianteInteligente();
        
        EstudianteVago _EstudianteVago1 = new EstudianteVago();
        
        EstudianteGenio _EstudianteGenio1 = new EstudianteGenio();
        
        IEstudiante[] _Escuela = { _EstudianteInteligente1,
        _EstudianteVago1, _EstudianteGenio1 };

        foreach (IEstudiante item in _Escuela)
        {
            Console.WriteLine(item.irAClases());
            Console.WriteLine(item.estudiar());
        }
    }
}

public interface IEstudiante
{
    string irAClases();
    string estudiar();
}

public class EstudianteInteligente : IEstudiante
{
    public string irAClases()
    {
        return "Estudiante inteligente esta yendo a clases";
    }
    public string estudiar()
    {
        return "El estudiante inteligente estudia mucho.";
    }

}

public class EstudianteVago : IEstudiante
{
    public string irAClases()
    {
        return "El estudiante vago va a clases";
    }

    public string estudiar()
    {
        return "El estudiante vago no estudia";
    }
}

public class EstudianteGenio : IEstudiante
{
    public string irAClases()
    {
        return "El estudiante genio va a clases";
    }

    public string estudiar()
    {
        return "El estudiante genio no necesita estudiar";
    }
}
*/