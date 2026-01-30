namespace ClassObjectInheritance
{
    internal class InheritClass1
    {
        public int value;
        public int num;
        public int input;
        public InheritClass1(int value, int num = 5, int input = 7) 
        {
            this.value = value;
            this.num = num + inherit.input;
            this.input = input;
        }

        public InheritClass3 inherit = new InheritClass2();

        public void Manipulation(int parameter)
        {
            inherit.value = this.value - parameter;
            this.input += inherit.input;
            this.value -= parameter;
        }

        public int GetValue()
        {
            return this.num + this.value - inherit.value;
        }
    }
}
