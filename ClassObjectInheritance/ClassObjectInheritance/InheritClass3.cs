namespace ClassObjectInheritance
{
    internal class InheritClass3
    {
        public int value;
        public int input;

        public InheritClass3(int input =10, int value=5)
        {
            this.value = input;
            this.input = value;
        }
        public virtual void Manipulation()
        {
            this.value += this.value;
        }

    }
}
