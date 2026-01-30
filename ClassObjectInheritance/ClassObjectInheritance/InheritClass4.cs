namespace ClassObjectInheritance
{
    internal class InheritClass4 : InheritClass5
    {
        public int class3 = 5;
        public int class1;

        public InheritClass4(int class2)
        {
            this.class1 = class2;
        }

        public InheritClass3 class0 = new InheritClass3();
        public void Manipulation()
        {
            class0.value = this.class3;
            this.class3 = 10;
        }

        public int GetNum()
        {
            return class0.value + base.class4 - this.class1;
        }
    }
}
