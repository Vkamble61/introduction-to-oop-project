namespace introduction_to_oop
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Spin();
            pippa.DoTheCaterpiller();
            pippa.Jump();

            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();
            pingu.Spin();
            pingu.DoTheCaterpiller();
            pingu.Jump();


            Parrot par = new Parrot("Pari", "Green");
            par.Speak();
            par.Fly();
            par.DoTheCaterpiller();
        }
    }
}
