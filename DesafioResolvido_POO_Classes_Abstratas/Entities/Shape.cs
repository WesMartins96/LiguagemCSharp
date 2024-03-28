using DesafioResolvido_POO_Classes_Abstratas.Entities.Enums;


namespace DesafioResolvido_POO_Classes_Abstratas.Entities
{
    //classe abstrata para que o método tambpem possa ser abstrato
    abstract class Shape
    {
        public Color Color { get; set; }


        public Shape(Color color)
        {
            Color = color;
        }


        //Para o metodo ser abstrato, a classe também precisa ser abstrata, pode-se dizer que esse metodo é um prototipo
        public abstract double Area();

    }
}
