namespace ClassObjectInheritance
{
    internal class InheritClass2 : InheritClass3
    {
        public int num;
        public new int input;
        public InheritClass2(int num = 9, int input = 1)
        {
            this.value = num;
            this.input = input;
        }

        public override void Manipulation()
        {
            base.value = this.value; this.num += 2 * this.num;
        }

        public int GetNum()
        {
            return this.value + this.input;
        }
    }
}
