namespace _5._2_abstract_members_code_along
{
    public abstract class Shape
    {
        public int Widht { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shape into clipboard.");

        }

        public void Select()
        {
            System.Console.WriteLine("Select the shape.");
        }
    }
}
