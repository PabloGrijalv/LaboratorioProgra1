using System;

class VideoJuego
{
    public string Titulo { get; set; }
    public string Desarrolladora { get; set; }
    public int Calificacion { get; set; }
    public int AnioLanzamiento { get; set; }

    public static void MostrarInformacion(VideoJuego juego)
    {
        Console.WriteLine($"Título: {juego.Titulo}, Desarrolladora: {juego.Desarrolladora}, Calificación: {juego.Calificacion}, Año de lanzamiento: {juego.AnioLanzamiento}");
    }
}

class JuegoAccion : VideoJuego
{
    public string TipoAccion { get; set; }
    public int NivelDificultad { get; set; }

    public void JugarAccion()
    {
        Console.WriteLine($"Jugando a {Titulo} - ¡Prepárate para la acción!");
    }
}

class JuegoAventura : VideoJuego
{
    public string TipoAventura { get; set; }
    public bool MundoAbierto { get; set; }

    public void Explorar()
    {
        Console.WriteLine($"Explorando en {Titulo} - ¡Adéntrate en esta emocionante aventura!");
    }
}

class JuegoEstrategia : VideoJuego
{
    public string TipoEstrategia { get; set; }
    public bool Multijugador { get; set; }

    public void PlanificarEstrategia()
    {
        Console.WriteLine($"Planificando estrategia en {Titulo} - ¡La victoria depende de tus decisiones!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        JuegoAccion juegoAccion = new JuegoAccion()
        {
            Titulo = "Call of Duty",
            Desarrolladora = "Activision",
            Calificacion = 90,
            AnioLanzamiento = 2020,
            TipoAccion = "Disparos en primera persona",
            NivelDificultad = 3
        };
        juegoAccion.JugarAccion();
        VideoJuego.MostrarInformacion(juegoAccion);

        JuegoAventura juegoAventura = new JuegoAventura()
        {
            Titulo = "Uncharted 4: A Thief's End",
            Desarrolladora = "Naughty Dog",
            Calificacion = 94,
            AnioLanzamiento = 2016,
            TipoAventura = "Aventura de acción",
            MundoAbierto = true
        };
        juegoAventura.Explorar();
        VideoJuego.MostrarInformacion(juegoAventura);

        JuegoEstrategia juegoEstrategia = new JuegoEstrategia()
        {
            Titulo = "Age of Empires II",
            Desarrolladora = "Microsoft",
            Calificacion = 88,
            AnioLanzamiento = 1999,
            TipoEstrategia = "Estrategia en tiempo real",
            Multijugador = true
        };
        juegoEstrategia.PlanificarEstrategia();
        VideoJuego.MostrarInformacion(juegoEstrategia);
    }
}