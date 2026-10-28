namespace SistemaBarbearia.Models;

public class Cronometro
{
    public Cronometro(string nome)
    {
        Nome = nome;
        Segundos = 0;
        Pausado = false;
    }

    public string Nome { get; set; } = string.Empty;

    public int Segundos { get; set; } 

    public bool Pausado { get; set; }

    public void PassarUmSegundo()
    {
        if (Pausado)
            return;

        Segundos++;
    }

    public void PausarOuContinuar()
    {
        if (Pausado)
        {
            Pausado = false;
            return;
        }

        Pausado = true;
    }

    public override string ToString()
    {
        return TimeSpan.FromSeconds(Segundos).ToString(@"hh\:mm\:ss");
    }
}
